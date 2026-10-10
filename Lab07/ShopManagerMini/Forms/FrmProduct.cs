using System.ComponentModel;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmProduct : Form
{
    private BindingList<Product> dsSanPham;
    private BindingSource bsSanPham = new BindingSource();
    private Product sanPhamDangChon = null;

    public FrmProduct(BindingList<Product> ds)
    {
        InitializeComponent();
        dsSanPham = ds;
    }

    private void FrmProduct_Load(object sender, EventArgs e)
    {
        cboLoaiSP.Items.Add("Đồ uống");
        cboLoaiSP.Items.Add("Thực phẩm");
        cboLoaiSP.Items.Add("Văn phòng phẩm");
        cboLoaiSP.Items.Add("Gia dụng");

        dgvProducts.DataSource = bsSanPham;
        HienThiTatCa();
    }

    private void CauHinhCotGrid()
    {
        if (dgvProducts.Columns["MaSP"] == null) return;
        dgvProducts.Columns["MaSP"].HeaderText = "Mã sản phẩm";
        dgvProducts.Columns["TenSP"].HeaderText = "Tên sản phẩm";
        dgvProducts.Columns["LoaiSP"].HeaderText = "Loại sản phẩm";
        dgvProducts.Columns["DonGia"].HeaderText = "Đơn giá";
        dgvProducts.Columns["DonGia"].DefaultCellStyle.Format = "N0";
        dgvProducts.Columns["SoLuong"].HeaderText = "Số lượng";
    }

    private void HienThiTatCa()
    {
        bsSanPham.DataSource = dsSanPham;
        bsSanPham.ResetBindings(false);
        CauHinhCotGrid();
    }

    private bool ValidateInput(bool dangSua)
    {
        if (txtMaSP.Text.Trim() == "")
        {
            MessageBox.Show("Mã sản phẩm không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaSP.Focus();
            return false;
        }

        if (!dangSua && dsSanPham.Any(p => p.MaSP.Equals(txtMaSP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã sản phẩm đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaSP.Focus();
            return false;
        }

        if (txtTenSP.Text.Trim() == "")
        {
            MessageBox.Show("Tên sản phẩm không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenSP.Focus();
            return false;
        }

        if (cboLoaiSP.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboLoaiSP.Focus();
            return false;
        }

        if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
        {
            MessageBox.Show("Đơn giá phải là số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDonGia.Focus();
            return false;
        }

        if (donGia < 0)
        {
            MessageBox.Show("Đơn giá không được âm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDonGia.Focus();
            return false;
        }

        if (!int.TryParse(txtSoLuong.Text, out int soLuong))
        {
            MessageBox.Show("Số lượng phải là số nguyên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoLuong.Focus();
            return false;
        }

        if (soLuong < 0)
        {
            MessageBox.Show("Số lượng không được âm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoLuong.Focus();
            return false;
        }

        return true;
    }

    private void ClearInput()
    {
        txtMaSP.Clear();
        txtTenSP.Clear();
        cboLoaiSP.SelectedIndex = -1;
        txtDonGia.Clear();
        txtSoLuong.Clear();
        txtMaSP.ReadOnly = false;
        sanPhamDangChon = null;
    }

    private void LoadProductToForm(Product sp)
    {
        txtMaSP.Text = sp.MaSP;
        txtTenSP.Text = sp.TenSP;
        cboLoaiSP.SelectedItem = sp.LoaiSP;
        txtDonGia.Text = sp.DonGia.ToString("0");
        txtSoLuong.Text = sp.SoLuong.ToString();
        txtMaSP.ReadOnly = true;
        sanPhamDangChon = sp;
    }

    private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        Product sp = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
        if (sp != null) LoadProductToForm(sp);
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        txtMaSP.ReadOnly = false;
        sanPhamDangChon = null;

        if (!ValidateInput(false)) return;

        Product sp = new Product
        {
            MaSP = txtMaSP.Text.Trim(),
            TenSP = txtTenSP.Text.Trim(),
            LoaiSP = cboLoaiSP.SelectedItem.ToString(),
            DonGia = decimal.Parse(txtDonGia.Text),
            SoLuong = int.Parse(txtSoLuong.Text)
        };

        dsSanPham.Add(sp);
        HienThiTatCa();
        ClearInput();
        MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (sanPhamDangChon == null)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInput(true)) return;

        sanPhamDangChon.TenSP = txtTenSP.Text.Trim();
        sanPhamDangChon.LoaiSP = cboLoaiSP.SelectedItem.ToString();
        sanPhamDangChon.DonGia = decimal.Parse(txtDonGia.Text);
        sanPhamDangChon.SoLuong = int.Parse(txtSoLuong.Text);

        HienThiTatCa();
        ClearInput();
        MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        Product sp = sanPhamDangChon;
        if (sp == null)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + sp.TenSP + "?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq != DialogResult.Yes) return;

        dsSanPham.Remove(sp);
        HienThiTatCa();
        ClearInput();
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ClearInput();
        txtTimKiem.Clear();
        HienThiTatCa();
        txtMaSP.Focus();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        sanPhamDangChon = null;
        txtMaSP.ReadOnly = false;

        string tuKhoa = txtTimKiem.Text.Trim();
        if (tuKhoa == "")
        {
            HienThiTatCa();
            return;
        }

        List<Product> ketQua = dsSanPham.Where(p =>
            p.MaSP.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
            p.TenSP.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)).ToList();

        bsSanPham.DataSource = new BindingList<Product>(ketQua);
        CauHinhCotGrid();

        if (ketQua.Count == 0)
            MessageBox.Show("Không tìm thấy sản phẩm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
