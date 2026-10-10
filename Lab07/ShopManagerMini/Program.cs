using System.ComponentModel;
using ShopManagerMini.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        BindingList<Product> dsSanPham = new BindingList<Product>();
        dsSanPham.Add(new Product { MaSP = "SP001", TenSP = "Nước suối", LoaiSP = "Đồ uống", DonGia = 5000, SoLuong = 100 });
        dsSanPham.Add(new Product { MaSP = "SP002", TenSP = "Mì gói", LoaiSP = "Thực phẩm", DonGia = 4500, SoLuong = 200 });
        dsSanPham.Add(new Product { MaSP = "SP003", TenSP = "Bút bi", LoaiSP = "Văn phòng phẩm", DonGia = 3000, SoLuong = 150 });

        BindingList<Customer> dsKhachHang = new BindingList<Customer>();
        dsKhachHang.Add(new Customer { MaKH = "KH001", HoTen = "Nguyễn Văn A", SoDienThoai = "0901234567", LoaiKhachHang = "Thường" });
        dsKhachHang.Add(new Customer { MaKH = "KH002", HoTen = "Trần Thị B", SoDienThoai = "0912345678", LoaiKhachHang = "VIP" });

        while (true)
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK) break;

            FrmMain frmMain = new FrmMain(frmLogin.NguoiDung, dsSanPham, dsKhachHang);
            Application.Run(frmMain);

            if (!frmMain.DangXuat) break;
        }
    }
}
