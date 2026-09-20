using System;

namespace Lab03_QuanLySinhVienOOP
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

        // Constructor khởi tạo
        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        // Phương thức virtual để lớp con có thể ghi đè (Override)
        public virtual void LayThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen} | Ngày sinh: {NgaySinh:dd/MM/yyyy}");
        }
    }
}