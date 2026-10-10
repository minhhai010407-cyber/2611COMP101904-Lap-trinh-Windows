using System.ComponentModel;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmCustomer : Form
{
    private BindingList<Customer> dsKhachHang;
    private BindingSource bsKhachHang = new BindingSource();
    private Customer khachHangDangChon = null;

    public FrmCustomer(BindingList<Customer> ds)
    {
        InitializeComponent();
        dsKhachHang = ds;
    }

    private void FrmCustomer_Load(object sender, EventArgs e)
    {
        cboLoaiKhachHang.Items.Add("Thường");
        cboLoaiKhachHang.Items.Add("Thân thiết");
        cboLoaiKhachHang.Items.Add("VIP");

        dgvCustomers.DataSource = bsKhachHang;
        HienThiTatCa();
    }

    private void CauHinhCotGrid()
    {
        if (dgvCustomers.Columns["MaKH"] == null) return;
        dgvCustomers.Columns["MaKH"].HeaderText = "Mã khách hàng";
        dgvCustomers.Columns["HoTen"].HeaderText = "Họ tên";
        dgvCustomers.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        dgvCustomers.Columns["LoaiKhachHang"].HeaderText = "Loại khách hàng";
    }

    private void HienThiTatCa()
    {
        bsKhachHang.DataSource = dsKhachHang;
        bsKhachHang.ResetBindings(false);
        CauHinhCotGrid();
    }

    private bool ValidateInput(bool dangSua)
    {
        if (txtMaKH.Text.Trim() == "")
        {
            MessageBox.Show("Mã khách hàng không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaKH.Focus();
            return false;
        }

        if (!dangSua && dsKhachHang.Any(k => k.MaKH.Equals(txtMaKH.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã khách hàng đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaKH.Focus();
            return false;
        }

        if (txtHoTen.Text.Trim() == "")
        {
            MessageBox.Show("Họ tên không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return false;
        }

        if (txtSoDienThoai.Text.Trim() == "")
        {
            MessageBox.Show("Số điện thoại không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return false;
        }

        if (!txtSoDienThoai.Text.Trim().All(char.IsDigit))
        {
            MessageBox.Show("Số điện thoại chỉ được chứa chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return false;
        }

        if (cboLoaiKhachHang.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn loại khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboLoaiKhachHang.Focus();
            return false;
        }

        return true;
    }

    private void ClearInput()
    {
        txtMaKH.Clear();
        txtHoTen.Clear();
        txtSoDienThoai.Clear();
        cboLoaiKhachHang.SelectedIndex = -1;
        txtMaKH.ReadOnly = false;
        khachHangDangChon = null;
    }

    private void LoadCustomerToForm(Customer kh)
    {
        txtMaKH.Text = kh.MaKH;
        txtHoTen.Text = kh.HoTen;
        txtSoDienThoai.Text = kh.SoDienThoai;
        cboLoaiKhachHang.SelectedItem = kh.LoaiKhachHang;
        txtMaKH.ReadOnly = true;
        khachHangDangChon = kh;
    }

    private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        Customer kh = dgvCustomers.Rows[e.RowIndex].DataBoundItem as Customer;
        if (kh != null) LoadCustomerToForm(kh);
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        txtMaKH.ReadOnly = false;
        khachHangDangChon = null;

        if (!ValidateInput(false)) return;

        Customer kh = new Customer
        {
            MaKH = txtMaKH.Text.Trim(),
            HoTen = txtHoTen.Text.Trim(),
            SoDienThoai = txtSoDienThoai.Text.Trim(),
            LoaiKhachHang = cboLoaiKhachHang.SelectedItem.ToString()
        };

        dsKhachHang.Add(kh);
        HienThiTatCa();
        ClearInput();
        MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (khachHangDangChon == null)
        {
            MessageBox.Show("Vui lòng chọn một khách hàng trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInput(true)) return;

        khachHangDangChon.HoTen = txtHoTen.Text.Trim();
        khachHangDangChon.SoDienThoai = txtSoDienThoai.Text.Trim();
        khachHangDangChon.LoaiKhachHang = cboLoaiKhachHang.SelectedItem.ToString();

        HienThiTatCa();
        ClearInput();
        MessageBox.Show("Cập nhật khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        Customer kh = khachHangDangChon;
        if (kh == null)
        {
            MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + kh.HoTen + "?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq != DialogResult.Yes) return;

        dsKhachHang.Remove(kh);
        HienThiTatCa();
        ClearInput();
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ClearInput();
        txtTimKiem.Clear();
        HienThiTatCa();
        txtMaKH.Focus();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        khachHangDangChon = null;
        txtMaKH.ReadOnly = false;

        string tuKhoa = txtTimKiem.Text.Trim();
        if (tuKhoa == "")
        {
            HienThiTatCa();
            return;
        }

        List<Customer> ketQua = dsKhachHang.Where(k =>
            k.MaKH.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
            k.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)).ToList();

        bsKhachHang.DataSource = new BindingList<Customer>(ketQua);
        CauHinhCotGrid();

        if (ketQua.Count == 0)
            MessageBox.Show("Không tìm thấy khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
