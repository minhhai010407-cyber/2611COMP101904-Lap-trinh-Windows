using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien_16092026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font tiếng Việt cho Console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // 1. Khởi tạo danh sách theo yêu cầu đề bài
            List<NhanVien> danhSach = new List<NhanVien>();

            // Khởi tạo sẵn 5 nhân viên mẫu thuộc các loại (đáp ứng yêu cầu >= 5 nhân viên và Bonus)
            danhSach.Add(new NhanVienVanPhong("VP01", "Nguyen Van An", 7000000, 24));
            danhSach.Add(new NhanVienVanPhong("VP02", "Tran Thi Binh", 8000000, 20));
            danhSach.Add(new NhanVienKinhDoanh("KD01", "Le Van Cuong", 6000000, 150000000));
            danhSach.Add(new NhanVienKinhDoanh("KD02", "Pham Thi Dung", 6500000, 80000000));
            danhSach.Add(new NhanVienThoiVu("TV01", "Hoang Van Em", 120, 50000));

            int luaChon = -1;
            do
            {
                HienThiMenu();
                Console.Write("Nhập lựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine(">> Lỗi: Vui lòng nhập số nguyên hợp lệ!");
                    DungManHinh();
                    continue;
                }

                Console.WriteLine();
                switch (luaChon)
                {
                    case 1:
                        XuatDanhSach(danhSach);
                        break;
                    case 2:
                        TimNhanVienTheoMa(danhSach);
                        break;
                    case 3:
                        TimLuongCaoNhat(danhSach);
                        break;
                    case 4:
                        TinhTongLuong(danhSach);
                        break;
                    case 0:
                        Console.WriteLine(">> Đã thoát chương trình thành công!");
                        break;
                    default:
                        Console.WriteLine(">> Lựa chọn không hợp lệ! Vui lòng chọn từ 0 đến 4.");
                        break;
                }

                if (luaChon != 0) DungManHinh();

            } while (luaChon != 0);
        }

        static void HienThiMenu()
        {
            Console.Clear();
            Console.WriteLine("========== MENU QUẢN LÝ NHÂN VIÊN ==========");
            Console.WriteLine("1. Xuất danh sách nhân viên");
            Console.WriteLine("2. Tìm nhân viên theo mã");
            Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
            Console.WriteLine("4. Tính tổng lương công ty phải trả");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("============================================");
        }

        // Chức năng 1: Áp dụng Đa hình gọi HienThiThongTin()
        static void XuatDanhSach(List<NhanVien> danhSach)
        {
            Console.WriteLine("--- DANH SÁCH NHÂN VIÊN ---");
            foreach (var nv in danhSach)
            {
                nv.HienThiThongTin();
            }
        }

        // Chức năng 2: Tìm kiếm theo mã
        static void TimNhanVienTheoMa(List<NhanVien> danhSach)
        {
            Console.Write("Nhập mã nhân viên cần tìm: ");
            string maCanTim = Console.ReadLine()?.Trim() ?? "";

            bool timThay = false;
            foreach (var nv in danhSach)
            {
                if (nv.MaNV.Equals(maCanTim, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(">> Thông tin nhân viên tìm thấy:");
                    nv.HienThiThongTin();
                    timThay = true;
                    break;
                }
            }

            if (!timThay)
            {
                Console.WriteLine($">> Không tìm thấy nhân viên có mã: {maCanTim}");
            }
        }

        // Chức năng 3: Áp dụng Đa hình qua TinhLuong() để tìm max
        static void TimLuongCaoNhat(List<NhanVien> danhSach)
        {
            if (danhSach.Count == 0) return;

            NhanVien nvMax = danhSach[0];
            foreach (var nv in danhSach)
            {
                if (nv.TinhLuong() > nvMax.TinhLuong())
                {
                    nvMax = nv;
                }
            }

            Console.WriteLine(">> Nhân viên có mức lương cao nhất:");
            nvMax.HienThiThongTin();
        }

        // Chức năng 4: Áp dụng Đa hình qua TinhLuong() để tính tổng
        static void TinhTongLuong(List<NhanVien> danhSach)
        {
            double tongLuong = 0;
            foreach (var nv in danhSach)
            {
                tongLuong += nv.TinhLuong();
            }

            Console.WriteLine($">> Tổng lương toàn bộ công ty phải trả: {tongLuong:N0} VNĐ");
        }

        static void DungManHinh()
        {
            Console.WriteLine("\nBấm phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }
    }
}