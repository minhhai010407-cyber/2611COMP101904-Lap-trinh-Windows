using System;

namespace QuanLyNhanVien_16092026
{
    public class NhanVienThoiVu : NhanVien
    {
        public double SoGioLam { get; set; }
        public double LuongTheoGio { get; set; }

        // Nhân viên thời vụ tính lương theo giờ, gán lương cơ bản mặc định là 1 để hợp lệ lớp cha
        public NhanVienThoiVu(string maNV, string hoTen, double soGioLam, double luongTheoGio)
            : base(maNV, hoTen, 1)
        {
            SoGioLam = soGioLam >= 0 ? soGioLam : 0;
            LuongTheoGio = luongTheoGio >= 0 ? luongTheoGio : 0;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[Thời Vụ]    Mã: {MaNV,-5} | Họ tên: {HoTen,-16} | Giờ làm: {SoGioLam,4} | Lương/giờ: {LuongTheoGio,8:N0} | Tổng lương: {TinhLuong(),10:N0}");
        }
    }
}