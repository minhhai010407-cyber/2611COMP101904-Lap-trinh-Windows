using System;

namespace QuanLyNhanVien_16092026
{
    public class NhanVienKinhDoanh : NhanVien
    {
        private double doanhSo;
        public double DoanhSo
        {
            get { return doanhSo; }
            set
            {
                // Doanh số phải >= 0
                if (value >= 0) doanhSo = value;
                else doanhSo = 0;
            }
        }

        // Gọi Constructor của lớp cha qua base
        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo)
            : base(maNV, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[Kinh Doanh] Mã: {MaNV,-5} | Họ tên: {HoTen,-16} | Lương CB: {LuongCoBan,10:N0} | Doanh số: {DoanhSo,10:N0} | Tổng lương: {TinhLuong(),10:N0}");
        }
    }
}