using System;

namespace Lab02_QuanLyMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] mang = null;
            int luaChon;

            do
            {
                HienThiMenu();
                luaChon = NhapSoNguyen("Chọn chức năng: ");
                Console.WriteLine();

                switch (luaChon)
                {
                    case 1:
                        mang = NhapMang();
                        Console.WriteLine("=> Đã nhập mảng thành công!");
                        break;

                    case 2:
                        if (KiemTraMangRong(mang)) break;
                        Console.Write("Mảng hiện tại: ");
                        XuatMang(mang);
                        break;

                    case 3:
                        if (KiemTraMangRong(mang)) break;
                        Console.WriteLine($"Tổng các phần tử trong mảng: {TinhTong(mang)}");
                        break;

                    case 4:
                        if (KiemTraMangRong(mang)) break;
                        Console.WriteLine($"Giá trị lớn nhất (Max): {TimMax(mang)}");
                        Console.WriteLine($"Giá trị nhỏ nhất (Min): {TimMin(mang)}");
                        break;

                    case 5:
                        if (KiemTraMangRong(mang)) break;
                        Console.WriteLine($"Số lượng phần tử chẵn: {DemChan(mang)}");
                        Console.WriteLine($"Số lượng phần tử lẻ: {DemLe(mang)}");
                        break;

                    case 6:
                        if (KiemTraMangRong(mang)) break;
                        SapXepTangDan(mang);
                        Console.Write("Mảng sau khi sắp xếp tăng dần: ");
                        XuatMang(mang);
                        break;

                    case 7:
                        if (KiemTraMangRong(mang)) break;
                        int x = NhapSoNguyen("Nhập giá trị x cần tìm: ");
                        int viTri = TimKiem(mang, x);
                        if (viTri != -1)
                        {
                            Console.WriteLine($"Đã tìm thấy {x} tại vị trí đầu tiên: {viTri}");
                        }
                        else
                        {
                            Console.WriteLine($"Không tìm thấy giá trị {x} trong mảng.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình!");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn từ 0 đến 7!");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                }

            } while (luaChon != 0);
        }

        static void HienThiMenu()
        {
            Console.Clear();
            Console.Write(
@"===== MENU =====
1. Nhap mang
2. Xuat mang
3. Tinh tong
4. Tim max/min
5. Dem chan/le
6. Sap xep tang dan
7. Tim kiem
0. Thoat
");
        }

        static bool KiemTraMangRong(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Cảnh báo: Bạn chưa nhập mảng! Vui lòng chọn 1 trước.");
                return true;
            }
            return false;
        }

        static int NhapSoNguyen(string message)
        {
            int n;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out n)) return n;
                Console.WriteLine("Lỗi: Dữ liệu nhập phải là số nguyên!");
            }
        }

        static int NhapSoNguyenDuong(string message)
        {
            int n;
            while (true)
            {
                n = NhapSoNguyen(message);
                if (n > 0) return n;
                Console.WriteLine("Lỗi: Số lượng n phải lớn hơn 0!");
            }
        }

        static int[] NhapMang()
        {
            int n = NhapSoNguyenDuong("Nhập số lượng phần tử n: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = NhapSoNguyen($"Nhập a[{i}]: ");
            }
            return a;
        }

        static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        static int TimMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
            }
            return max;
        }

        static int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
            }
            return min;
        }

        static int DemChan(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) dem++;
            }
            return dem;
        }

        static int DemLe(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0) dem++;
            }
            return dem;
        }

        static void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        static int TimKiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
    }
}