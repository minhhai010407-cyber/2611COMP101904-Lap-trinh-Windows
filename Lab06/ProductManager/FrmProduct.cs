using System.ComponentModel;

namespace ProductManager;

public partial class FrmProduct : Form
{
    private BindingList<Product> dsSanPham = new BindingList<Product>();
    private BindingSource bsSanPham = new BindingSource();
    private Product sanPhamDangSua = null;
    private string duongDanAnhDaChon = "";

    public FrmProduct()
    {
        InitializeComponent();
    }

    private void FrmProduct_Load(object sender, EventArgs e)
    {
        cboLoaiSP.Items.Add("Điện tử");
        cboLoaiSP.Items.Add("Văn phòng");
        cboLoaiSP.Items.Add("Gia dụng");
        cboLoaiSP.Items.Add("Thời trang");

        dtpNgayNhap.MaxDate = DateTime.Now;

        dsSanPham.Add(new Product
        {
            MaSP = "SP001",
            TenSP = "Bàn phím cơ",
            LoaiSP = "Điện tử",
            DonGia = 550000,
            SoLuong = 20,
            NgayNhap = DateTime.Now.AddDays(-10),
            ConKinhDoanh = true,
            DuongDanAnh = ""
        });
        dsSanPham.Add(new Product
        {
            MaSP = "SP002",
            TenSP = "Ghế văn phòng",
            LoaiSP = "Văn phòng",
            DonGia = 1200000,
            SoLuong = 10,
            NgayNhap = DateTime.Now.AddDays(-5),
            ConKinhDoanh = true,
            DuongDanAnh = ""
        });
        dsSanPham.Add(new Product
        {
            MaSP = "SP003",
            TenSP = "Nồi cơm điện",
            LoaiSP = "Gia dụng",
            DonGia = 850000,
            SoLuong = 15,
            NgayNhap = DateTime.Now.AddDays(-20),
            ConKinhDoanh = false,
            DuongDanAnh = ""
        });

        dgvProducts.DataSource = bsSanPham;
        HienThiTatCa();
        UpdateStatus("Đã tải dữ liệu sản phẩm");
    }

    private void CauHinhCotGrid()
    {
        if (dgvProducts.Columns["MaSP"] == null) return;
        dgvProducts.Columns["MaSP"].HeaderText = "Mã SP";
        dgvProducts.Columns["TenSP"].HeaderText = "Tên SP";
        dgvProducts.Columns["LoaiSP"].HeaderText = "Loại SP";
        dgvProducts.Columns["DonGia"].HeaderText = "Đơn giá";
        dgvProducts.Columns["DonGia"].DefaultCellStyle.Format = "N0";
        dgvProducts.Columns["SoLuong"].HeaderText = "Số lượng";
        dgvProducts.Columns["NgayNhap"].HeaderText = "Ngày nhập";
        dgvProducts.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvProducts.Columns["ConKinhDoanh"].HeaderText = "Còn kinh doanh";
        dgvProducts.Columns["DuongDanAnh"].Visible = false;
    }

    private void HienThiTatCa()
    {
        bsSanPham.DataSource = dsSanPham;
        CauHinhCotGrid();
    }

    private void UpdateStatus(string noiDung)
    {
        lblStatus.Text = noiDung;
        lblSoLuong.Text = "Số lượng: " + dsSanPham.Count;
    }

    private bool ValidateInput(bool dangSua)
    {
        errProvider.Clear();
        bool hopLe = true;

        if (string.IsNullOrWhiteSpace(txtMaSP.Text))
        {
            errProvider.SetError(txtMaSP, "Mã SP không được để trống");
            hopLe = false;
        }
        else if (!dangSua && dsSanPham.Any(p => p.MaSP.Equals(txtMaSP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            errProvider.SetError(txtMaSP, "Mã SP đã tồn tại");
            hopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtTenSP.Text))
        {
            errProvider.SetError(txtTenSP, "Tên SP không được để trống");
            hopLe = false;
        }

        if (cboLoaiSP.SelectedIndex < 0)
        {
            errProvider.SetError(cboLoaiSP, "Chưa chọn loại sản phẩm");
            hopLe = false;
        }

        if (numDonGia.Value <= 0)
        {
            errProvider.SetError(numDonGia, "Đơn giá phải lớn hơn 0");
            hopLe = false;
        }

        if (dtpNgayNhap.Value.Date > DateTime.Now.Date)
        {
            errProvider.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại");
            hopLe = false;
        }

        return hopLe;
    }

    private void ClearInput()
    {
        txtMaSP.Clear();
        txtTenSP.Clear();
        cboLoaiSP.SelectedIndex = -1;
        numDonGia.Value = 0;
        numSoLuong.Value = 0;
        dtpNgayNhap.Value = DateTime.Today;
        chkConKinhDoanh.Checked = false;
        picAnh.Image = null;
        duongDanAnhDaChon = "";
        errProvider.Clear();
        sanPhamDangSua = null;
        txtMaSP.Enabled = true;
    }

    private void LoadProductToForm(Product sp)
    {
        txtMaSP.Text = sp.MaSP;
        txtTenSP.Text = sp.TenSP;
        cboLoaiSP.SelectedItem = sp.LoaiSP;
        numDonGia.Value = sp.DonGia;
        numSoLuong.Value = sp.SoLuong;
        dtpNgayNhap.Value = sp.NgayNhap;
        chkConKinhDoanh.Checked = sp.ConKinhDoanh;
        duongDanAnhDaChon = sp.DuongDanAnh;

        if (!string.IsNullOrWhiteSpace(sp.DuongDanAnh) && File.Exists(sp.DuongDanAnh))
            picAnh.Image = Image.FromFile(sp.DuongDanAnh);
        else
            picAnh.Image = null;

        sanPhamDangSua = sp;
        txtMaSP.Enabled = false;
        errProvider.Clear();
    }

    private Product LaySanPhamDangChon()
    {
        if (dgvProducts.CurrentRow == null) return null;
        return dgvProducts.CurrentRow.DataBoundItem as Product;
    }

    private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        Product sp = LaySanPhamDangChon();
        if (sp != null) LoadProductToForm(sp);
    }

    private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right) return;
        var hit = dgvProducts.HitTest(e.X, e.Y);
        if (hit.RowIndex < 0) return;
        dgvProducts.ClearSelection();
        dgvProducts.Rows[hit.RowIndex].Selected = true;
        dgvProducts.CurrentCell = dgvProducts.Rows[hit.RowIndex].Cells[0];
    }

    private void tsbThem_Click(object sender, EventArgs e)
    {
        txtMaSP.Enabled = true;
        sanPhamDangSua = null;

        if (!ValidateInput(dangSua: false)) return;

        Product sp = new Product
        {
            MaSP = txtMaSP.Text.Trim(),
            TenSP = txtTenSP.Text.Trim(),
            LoaiSP = cboLoaiSP.SelectedItem.ToString(),
            DonGia = numDonGia.Value,
            SoLuong = (int)numSoLuong.Value,
            NgayNhap = dtpNgayNhap.Value,
            ConKinhDoanh = chkConKinhDoanh.Checked,
            DuongDanAnh = duongDanAnhDaChon
        };

        dsSanPham.Add(sp);
        ClearInput();
        HienThiTatCa();
        UpdateStatus("Đã thêm sản phẩm " + sp.MaSP);
    }

    private void tsbSua_Click(object sender, EventArgs e)
    {
        if (sanPhamDangSua == null)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInput(dangSua: true)) return;

        sanPhamDangSua.TenSP = txtTenSP.Text.Trim();
        sanPhamDangSua.LoaiSP = cboLoaiSP.SelectedItem.ToString();
        sanPhamDangSua.DonGia = numDonGia.Value;
        sanPhamDangSua.SoLuong = (int)numSoLuong.Value;
        sanPhamDangSua.NgayNhap = dtpNgayNhap.Value;
        sanPhamDangSua.ConKinhDoanh = chkConKinhDoanh.Checked;
        sanPhamDangSua.DuongDanAnh = duongDanAnhDaChon;

        string ma = sanPhamDangSua.MaSP;
        ClearInput();
        HienThiTatCa();
        UpdateStatus("Đã cập nhật sản phẩm " + ma);
    }

    private void mnuCtxSua_Click(object sender, EventArgs e)
    {
        Product sp = LaySanPhamDangChon();
        if (sp == null)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        LoadProductToForm(sp);
    }

    private void tsbXoa_Click(object sender, EventArgs e)
    {
        Product sp = LaySanPhamDangChon();
        if (sp == null)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + sp.MaSP + "?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq != DialogResult.Yes) return;

        dsSanPham.Remove(sp);
        ClearInput();
        HienThiTatCa();
        UpdateStatus("Đã xóa sản phẩm " + sp.MaSP);
    }

    private void tsbTimKiem_Click(object sender, EventArgs e)
    {
        string tuKhoa = txtTimKiem.Text.Trim();
        if (string.IsNullOrWhiteSpace(tuKhoa))
        {
            HienThiTatCa();
            UpdateStatus("Hiển thị toàn bộ sản phẩm");
            return;
        }

        List<Product> ketQua = dsSanPham.Where(p =>
            p.MaSP.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
            p.TenSP.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)).ToList();

        bsSanPham.DataSource = new BindingList<Product>(ketQua);
        CauHinhCotGrid();
        UpdateStatus("Tìm thấy " + ketQua.Count + " sản phẩm");
    }

    private void tsbLamMoi_Click(object sender, EventArgs e)
    {
        ClearInput();
        txtTimKiem.Text = "";
        HienThiTatCa();
        UpdateStatus("Đã làm mới");
    }

    private void btnChonAnh_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        duongDanAnhDaChon = openFileDialog1.FileName;
        picAnh.Image = Image.FromFile(duongDanAnhDaChon);
    }

    private void mnuCtxChiTiet_Click(object sender, EventArgs e)
    {
        Product sp = LaySanPhamDangChon();
        if (sp == null)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string noiDung =
            "Mã SP: " + sp.MaSP + "\n" +
            "Tên SP: " + sp.TenSP + "\n" +
            "Loại SP: " + sp.LoaiSP + "\n" +
            "Đơn giá: " + sp.DonGia.ToString("N0") + " VNĐ\n" +
            "Số lượng: " + sp.SoLuong + "\n" +
            "Ngày nhập: " + sp.NgayNhap.ToString("dd/MM/yyyy") + "\n" +
            "Tình trạng: " + (sp.ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh");

        MessageBox.Show(noiDung, "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void mnuGioiThieu_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Ứng dụng quản lý sản phẩm\nLab 05 - COMP1019", "Giới thiệu",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        Close();
    }
}
