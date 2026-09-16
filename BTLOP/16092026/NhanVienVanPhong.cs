using System;

namespace QuanLyNhanVien_16092026
{
    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;
        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set
            {
                // Ràng buộc số ngày làm việc từ 0 đến 31
                if (value >= 0 && value <= 31) soNgayLamViec = value;
                else soNgayLamViec = 0;
            }
        }

        // Gọi Constructor của lớp cha qua base
        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec)
            : base(maNV, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[Văn Phòng] Mã: {MaNV,-6} | Họ tên: {HoTen,-16} | Lương CB: {LuongCoBan,10:N0} | Ngày công: {SoNgayLamViec,2} | Tổng lương: {TinhLuong(),10:N0}");
        }
    }
}