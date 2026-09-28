using System.Globalization;

namespace CourseRegistrationApp;

public partial class frmDangKyKhoaHoc : Form
{
    // Dữ liệu khóa học: tên khóa học -> học phí / tháng (VNĐ)
    private readonly Dictionary<string, int> _dsKhoaHoc = new()
    {
        { "C# WinForms cơ bản", 800000 },
        { "SQL Server cơ bản", 700000 },
        { "Web Frontend cơ bản", 750000 },
        { "Lập trình Python cơ bản", 650000 },
    };

    private static readonly CultureInfo ViVN = new("vi-VN");

    public frmDangKyKhoaHoc()
    {
        InitializeComponent();
    }

    // ===== 5.1. Form Load =====
    private void frmDangKyKhoaHoc_Load(object sender, EventArgs e)
    {
        cboKhoaHoc.Items.Clear();
        foreach (string tenKhoaHoc in _dsKhoaHoc.Keys)
            cboKhoaHoc.Items.Add(tenKhoaHoc);

        cboKhoaHoc.SelectedIndex = 0;      // khóa học đầu tiên
        radOnline.Checked = true;          // mặc định Online
        numSoThang.Minimum = 1;
        numSoThang.Maximum = 12;
        numSoThang.Value = 1;

        CapNhatTrangThaiEmail();
        HienThiHocPhi();
    }

    // ===== Tính và hiển thị học phí =====
    private int LayHocPhiMotThang()
    {
        if (cboKhoaHoc.SelectedItem == null) return 0;
        return _dsKhoaHoc[cboKhoaHoc.SelectedItem.ToString()];
    }

    private long TinhTongHocPhi()
    {
        return (long)LayHocPhiMotThang() * (int)numSoThang.Value;
    }

    private static string DinhDangTien(long soTien)
    {
        return soTien.ToString("N0", ViVN) + " VNĐ";
    }

    private void HienThiHocPhi()
    {
        lblHocPhiThang.Text = DinhDangTien(LayHocPhiMotThang());
        lblTongTien.Text = DinhDangTien(TinhTongHocPhi());
    }

    private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e) => HienThiHocPhi();

    private void numSoThang_ValueChanged(object sender, EventArgs e) => HienThiHocPhi();

    // ===== Các sự kiện phụ =====
    private void txtHoTen_TextChanged(object sender, EventArgs e)
    {
        lblDemKyTu.Text = $"{txtHoTen.Text.Length}/{txtHoTen.MaxLength}";
    }

    private void chkNhanEmail_CheckedChanged(object sender, EventArgs e) => CapNhatTrangThaiEmail();

    private void CapNhatTrangThaiEmail()
    {
        lblTrangThaiEmail.Text = chkNhanEmail.Checked
            ? "Nhận email thông báo"
            : "Không nhận email thông báo";
    }

    // ===== 5.2. Nút Đăng ký =====
    private void btnDangKy_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            MessageBox.Show("Họ tên không được để trống.", "Thiếu thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
        {
            MessageBox.Show("Số điện thoại không được để trống.", "Thiếu thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return;
        }

        if (cboKhoaHoc.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn khóa học.", "Thiếu thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboKhoaHoc.Focus();
            return;
        }

        string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
        string trangThaiEmail = chkNhanEmail.Checked ? "Có nhận email thông báo" : "Không nhận email thông báo";

        string phieu =
            "PHIẾU ĐĂNG KÝ KHÓA HỌC\n" +
            "-----------------------------------\n" +
            $"Họ tên: {txtHoTen.Text.Trim()}\n" +
            $"Số điện thoại: {txtSoDienThoai.Text.Trim()}\n" +
            $"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}\n" +
            $"Khóa học: {cboKhoaHoc.SelectedItem}\n" +
            $"Hình thức học: {hinhThuc}\n" +
            $"Số tháng: {numSoThang.Value}\n" +
            $"Tổng tiền: {DinhDangTien(TinhTongHocPhi())}\n" +
            $"Nhận email: {trangThaiEmail}";

        MessageBox.Show(phieu, "Đăng ký thành công",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ===== 5.3. Nút Làm mới =====
    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtSoDienThoai.Clear();
        dtpNgaySinh.Value = DateTime.Now;
        chkNhanEmail.Checked = false;
        cboKhoaHoc.SelectedIndex = 0;
        radOnline.Checked = true;
        numSoThang.Value = 1;
        HienThiHocPhi();
        txtHoTen.Focus();
    }

    // ===== 5.4. Nút Thoát =====
    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq == DialogResult.Yes)
            Close();
    }
}
