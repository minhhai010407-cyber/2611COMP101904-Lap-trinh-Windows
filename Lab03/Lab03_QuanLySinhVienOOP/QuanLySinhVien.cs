using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_QuanLySinhVienOOP
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSachSV;

        public QuanLySinhVien()
        {
            danhSachSV = new List<SinhVien>();
        }

        public bool KiemTraTonTai(string maSV)
        {
            return danhSachSV.Any(sv => sv.MaSinhVien.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public void Them(SinhVien sv)
        {
            danhSachSV.Add(sv);
        }

        public List<SinhVien> LayDanhSach()
        {
            return danhSachSV;
        }

        public SinhVien TimTheoMa(string maSV)
        {
            return danhSachSV.FirstOrDefault(sv => sv.MaSinhVien.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            return danhSachSV.Where(sv => sv.HoTen.ToLower().Contains(tuKhoa.ToLower())).ToList();
        }

        public bool SuaDiem(string maSV, double diemMoi)
        {
            var sv = TimTheoMa(maSV);
            if (sv != null)
            {
                sv.DiemTrungBinh = diemMoi;
                return true;
            }
            return false;
        }

        public bool Xoa(string maSV)
        {
            var sv = TimTheoMa(maSV);
            if (sv != null)
            {
                danhSachSV.Remove(sv);
                return true;
            }
            return false;
        }

        public List<SinhVien> SapXepTheoDiemGiamDan()
        {
            return danhSachSV.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
        }

        public List<SinhVien> LocSinhVienDat()
        {
            return danhSachSV.Where(sv => sv.DiemTrungBinh >= 5.0).ToList();
        }
    }
}