using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab04_QuanLySanPham
{
    internal class Program
    {
        private static ProductService productService = new ProductService();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Đăng ký Event để nhận thông báo từ Service
            productService.OnProductAdded += (p) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[EVENT] -> Đã thêm thành công sản phẩm: {p.TenSP}");
                Console.ResetColor();
            };

            productService.OnProductRemoved += (id) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n[EVENT] -> Đã xóa thành công sản phẩm mã: {id}");
                Console.ResetColor();
            };

            int luaChon = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("===== PRODUCT MANAGER =====");
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim theo ma");
                Console.WriteLine("4. Tim theo ten");
                Console.WriteLine("5. Loc theo khoang gia");
                Console.WriteLine("6. Xoa san pham");
                Console.WriteLine("7. Tinh tong gia tri kho");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("===========================");
                Console.Write("Chon: ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    InLoi("Lỗi: Vui lòng nhập số hợp lệ!");
                    DungManHinh();
                    continue;
                }

                Console.WriteLine();
                try
                {
                    switch (luaChon)
                    {
                        case 1: ThemSanPham(); break;
                        case 2: XuatDanhSach(productService.GetAll()); break;
                        case 3: TimTheoMa(); break;
                        case 4: TimTheoTen(); break;
                        case 5: LocTheoGia(); break;
                        case 6: XoaSanPham(); break;
                        case 7: TinhTongGiaTri(); break;
                        case 0: Console.WriteLine("Đã thoát chương trình."); break;
                        default: InLoi("Lựa chọn không hợp lệ, vui lòng chọn lại!"); break;
                    }
                }
                // Bắt các lỗi (Exception) ném ra từ ProductService và Product
                catch (DuplicateProductException ex) { InLoi(ex.Message); }
                catch (ProductNotFoundException ex) { InLoi(ex.Message); }
                catch (ArgumentException ex) { InLoi(ex.Message); }
                catch (Exception ex) { InLoi($"Lỗi hệ thống: {ex.Message}"); }

                if (luaChon != 0) DungManHinh();

            } while (luaChon != 0);
        }

        static void ThemSanPham()
        {
            Console.Write("Nhập mã sản phẩm: ");
            string id = Console.ReadLine()?.Trim() ?? "";
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("Mã sản phẩm không được rỗng!");

            Console.Write("Nhập tên sản phẩm: ");
            string ten = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Nhập đơn giá: ");
            if (!double.TryParse(Console.ReadLine(), out double gia)) throw new ArgumentException("Đơn giá phải là số!");

            Console.Write("Nhập số lượng: ");
            if (!int.TryParse(Console.ReadLine(), out int soLuong)) throw new ArgumentException("Số lượng phải là số nguyên!");

            Product p = new Product(id, ten, gia, soLuong);
            productService.AddProduct(p);
        }

        static void XuatDanhSach(List<Product> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }
            foreach (var p in list) Console.WriteLine(p.ToString());
        }

        static void TimTheoMa()
        {
            Console.Write("Nhập mã sản phẩm cần tìm: ");
            string id = Console.ReadLine()?.Trim() ?? "";
            var p = productService.FindById(id);

            if (p != null) Console.WriteLine(p.ToString());
            else Console.WriteLine($"Không tìm thấy sản phẩm nào có mã: {id}");
        }

        static void TimTheoTen()
        {
            Console.Write("Nhập từ khóa tên sản phẩm: ");
            string keyword = Console.ReadLine()?.Trim() ?? "";
            XuatDanhSach(productService.Search(keyword));
        }

        static void LocTheoGia()
        {
            Console.Write("Nhập giá nhỏ nhất: ");
            if (!double.TryParse(Console.ReadLine(), out double min)) throw new ArgumentException("Giá phải là số!");

            Console.Write("Nhập giá lớn nhất: ");
            if (!double.TryParse(Console.ReadLine(), out double max)) throw new ArgumentException("Giá phải là số!");

            XuatDanhSach(productService.Filter(min, max));
        }

        static void XoaSanPham()
        {
            Console.Write("Nhập mã sản phẩm cần xóa: ");
            string id = Console.ReadLine()?.Trim() ?? "";
            productService.RemoveProduct(id);
        }

        static void TinhTongGiaTri()
        {
            double tong = productService.GetAll().Sum(p => p.Price * p.Quantity);
            Console.WriteLine($">> Tổng giá trị kho hàng: {tong:N0}");
        }

        static void InLoi(string thongBao)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(thongBao);
            Console.ResetColor();
        }

        static void DungManHinh()
        {
            Console.Write("\nBấm phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }
    }
}