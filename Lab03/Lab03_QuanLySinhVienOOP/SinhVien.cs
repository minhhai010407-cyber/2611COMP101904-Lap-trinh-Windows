using System;

namespace Lab03_QuanLySinhVienOOP
{
    public class SinhVien : Nguoi
    {
        public string MaSinhVien { get; set; }
        public string MaLop { get; set; }

        // Encapsulation (Đóng gói) kiểm tra điểm từ 0 đến 10
        private double diemTrungBinh;
        public double DiemTrungBinh
        {
            get { return diemTrungBinh; }
            set
            {
                if (value >= 0 && value <= 10)
                    diemTrungBinh = value;
                else
                    diemTrungBinh = 0; 
            }
        }

        
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string maLop, double diemTB)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSV;
            MaLop = maLop;
            DiemTrungBinh = diemTB;
        }

        
        public string XepLoai()
        {
            if (DiemTrungBinh >= 8.0) return "Giỏi";
            if (DiemTrungBinh >= 6.5) return "Khá";
            if (DiemTrungBinh >= 5.0) return "Đạt"; 
            return "Không đạt";
        }

        
        public override void LayThongTin()
        {
            Console.WriteLine($"Mã SV: {MaSinhVien,-8} | Họ tên: {HoTen,-18} | Lớp: {MaLop,-8} | Ngày sinh: {NgaySinh:dd/MM/yyyy} | Điểm TB: {DiemTrungBinh,-4} | Xếp loại: {XepLoai()}");
        }
    }
}