namespace StudentReportDemo.Models
{
    public class SinhVien
    {
        public const string KetQuaDat = "Đạt";
        public const string KetQuaKhongDat = "Không đạt";

        private const double DiemDat = 5;

        public SinhVien(string maSV, string hoTen, string maLop, string tenLop, double diem)
        {
            MaSV = maSV;
            HoTen = hoTen;
            MaLop = maLop;
            TenLop = tenLop;
            Diem = diem;
        }

        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public double Diem { get; set; }

        public bool Dat => Diem >= DiemDat;
        public string KetQua => Dat ? KetQuaDat : KetQuaKhongDat;
    }
}
