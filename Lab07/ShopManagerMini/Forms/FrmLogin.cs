using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmLogin : Form
{
    private List<User> dsTaiKhoan = new List<User>();

    public User NguoiDung { get; private set; }

    public FrmLogin()
    {
        InitializeComponent();
        dsTaiKhoan.Add(new User { Username = "admin", Password = "123", HoTen = "Quản trị viên", VaiTro = "Admin" });
        dsTaiKhoan.Add(new User { Username = "user", Password = "123", HoTen = "Nhân viên bán hàng", VaiTro = "User" });
    }

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (username == "")
        {
            MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsername.Focus();
            return;
        }

        if (password == "")
        {
            MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword.Focus();
            return;
        }

        foreach (User u in dsTaiKhoan)
        {
            if (u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password)
            {
                NguoiDung = u;
                DialogResult = DialogResult.OK;
                return;
            }
        }

        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtPassword.Clear();
        txtPassword.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq == DialogResult.Yes) DialogResult = DialogResult.Cancel;
    }
}
