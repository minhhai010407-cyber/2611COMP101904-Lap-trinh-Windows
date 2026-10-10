using System.ComponentModel;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmMain : Form
{
    private User nguoiDung;
    private BindingList<Product> dsSanPham;
    private BindingList<Customer> dsKhachHang;

    public bool DangXuat { get; private set; }

    public FrmMain(User user, BindingList<Product> sanPham, BindingList<Customer> khachHang)
    {
        InitializeComponent();
        nguoiDung = user;
        dsSanPham = sanPham;
        dsKhachHang = khachHang;

        lblNguoiDung.Text = "Người dùng: " + nguoiDung.HoTen;
        lblVaiTro.Text = "Vai trò: " + nguoiDung.VaiTro;
        lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }

    private bool DaMoForm(Type loaiForm)
    {
        foreach (Form f in MdiChildren)
        {
            if (f.GetType() == loaiForm)
            {
                if (f.WindowState == FormWindowState.Minimized) f.WindowState = FormWindowState.Normal;
                f.Activate();
                return true;
            }
        }
        return false;
    }

    private void mnuQuanLySanPham_Click(object sender, EventArgs e)
    {
        if (DaMoForm(typeof(FrmProduct))) return;

        FrmProduct frm = new FrmProduct(dsSanPham);
        frm.MdiParent = this;
        frm.Show();
    }

    private void mnuQuanLyKhachHang_Click(object sender, EventArgs e)
    {
        if (DaMoForm(typeof(FrmCustomer))) return;

        FrmCustomer frm = new FrmCustomer(dsKhachHang);
        frm.MdiParent = this;
        frm.Show();
    }

    private void mnuGioiThieu_Click(object sender, EventArgs e)
    {
        if (DaMoForm(typeof(FrmAbout))) return;

        FrmAbout frm = new FrmAbout();
        frm.MdiParent = this;
        frm.Show();
    }

    private void mnuDangXuat_Click(object sender, EventArgs e)
    {
        DialogResult kq = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq != DialogResult.Yes) return;

        DangXuat = true;
        Close();
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (DangXuat) return;

        DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq != DialogResult.Yes) e.Cancel = true;
    }

    private void timerThoiGian_Tick(object sender, EventArgs e)
    {
        lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
