using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03_QuanLySinhVienOOP
{
    internal class Program
    {
        private static QuanLySinhVien ql = new QuanLySinhVien();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int luaChon = -1;
            do
            {
                HienThiMenu();
                Console.Write("Chọn chức năng: ");
                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số!");
                    DungManHinh();
                    continue;
                }

                Console.WriteLine();
                switch (luaChon)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        XuatDanhSach(ql.LayDanhSach());
                        break;
                    case 3:
                        TimTheoMa();
                        break;
                    case 4:
                        TimTheoTen();
                        break;
                    case 5:
                        SuaDiem();
                        break;
                    case 6:
                        XoaSinhVien();
                        break;
                    case 7:
                        XuatDanhSach(ql.SapXepTheoDiemGiamDan());
                        break;
                    case 8:
                        XuatDanhSach(ql.LocSinhVienDat());
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                        break;
                }

                if (luaChon != 0) DungManHinh();

            } while (luaChon != 0);
        }

        static void HienThiMenu()
        {
            Console.Clear();
            Console.WriteLine("===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim sinh vien theo ten");
            Console.WriteLine("5. Sua diem trung binh");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo diem giam dan");
            Console.WriteLine("8. Loc sinh vien dat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("=============================");
        }

        static void ThemSinhVien()
        {
            Console.WriteLine("--- THÊM SINH VIÊN ---");
            Console.Write("Nhập mã sinh viên: ");
            string maSV = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(maSV))
            {
                Console.WriteLine("Mã sinh viên không được để trống!");
                return;
            }

            if (ql.KiemTraTonTai(maSV))
            {
                Console.WriteLine("Lỗi: Mã sinh viên đã tồn tại trong hệ thống!");
                return;
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            DateTime ngaySinh;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
            {
                Console.Write("Định dạng không hợp lệ, nhập lại (dd/MM/yyyy): ");
            }

            Console.Write("Nhập mã lớp: ");
            string maLop = Console.ReadLine()?.Trim() ?? "";

            double diemTB;
            while (true)
            {
                Console.Write("Nhập điểm trung bình (0 - 10): ");
                if (double.TryParse(Console.ReadLine(), out diemTB) && diemTB >= 0 && diemTB <= 10)
                {
                    break;
                }
                Console.WriteLine("Điểm không hợp lệ! Điểm phải từ 0 đến 10.");
            }

            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, maLop, diemTB);
            ql.Them(sv);
            Console.WriteLine($">> Thêm thành công, xếp loại {sv.XepLoai()}");
        }

        static void XuatDanhSach(List<SinhVien> list)
        {
            Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            foreach (var sv in list)
            {
                sv.LayThongTin();
            }
        }

        static void TimTheoMa()
        {
            Console.Write("Nhập mã sinh viên cần tìm: ");
            string maSV = Console.ReadLine()?.Trim() ?? "";

            var sv = ql.TimTheoMa(maSV);
            if (sv != null)
            {
                Console.WriteLine(">> Kết quả tìm kiếm:");
                sv.LayThongTin();
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên có mã: {maSV}");
            }
        }

        static void TimTheoTen()
        {
            Console.Write("Nhập từ khóa họ tên cần tìm: ");
            string tuKhoa = Console.ReadLine()?.Trim() ?? "";

            var ketQua = ql.TimTheoTen(tuKhoa);
            XuatDanhSach(ketQua);
        }

        static void SuaDiem()
        {
            Console.Write("Nhập mã sinh viên cần sửa điểm: ");
            string maSV = Console.ReadLine()?.Trim() ?? "";

            if (!ql.KiemTraTonTai(maSV))
            {
                Console.WriteLine($"Không tìm thấy sinh viên có mã: {maSV}");
                return;
            }

            double diemMoi;
            while (true)
            {
                Console.Write("Nhập điểm mới (0 - 10): ");
                if (double.TryParse(Console.ReadLine(), out diemMoi) && diemMoi >= 0 && diemMoi <= 10)
                {
                    break;
                }
                Console.WriteLine("Điểm không hợp lệ! Nhập lại từ 0 đến 10.");
            }

            if (ql.SuaDiem(maSV, diemMoi))
            {
                Console.WriteLine(">> Cập nhật điểm thành công!");
            }
        }

        static void XoaSinhVien()
        {
            Console.Write("Nhập mã sinh viên cần xóa: ");
            string maSV = Console.ReadLine()?.Trim() ?? "";

            if (ql.Xoa(maSV))
            {
                Console.WriteLine(">> Xóa sinh viên thành công!");
            }
            else
            {
                Console.WriteLine($"Lỗi: Không tìm thấy sinh viên có mã: {maSV}");
            }
        }

        static void DungManHinh()
        {
            Console.WriteLine("\nBấm phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }
    }
}