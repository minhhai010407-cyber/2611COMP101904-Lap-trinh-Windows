using System;

namespace QuanLyNhanVien_16092026
{
    public class NhanVien
    {
        // Thuộc tính
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        //  kiểm tra Lương cơ bản > 0
        private double luongCoBan;
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                if (value > 0) luongCoBan = value;
                else luongCoBan = 1; // Hoặc gán bằng mức tối thiểu nào đó tránh lỗi
            }
        }

        //  khởi tạo
        public NhanVien(string maNV, string hoTen, double luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        // Đa hình
        public virtual double TinhLuong()
        {
            return 0; // Lớp cha chưa xác định cách tính lương cụ thể
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Mã NV: {MaNV,-5} | Họ tên: {HoTen,-15} | Lương CB: {LuongCoBan:N0}");
        }
    }
}