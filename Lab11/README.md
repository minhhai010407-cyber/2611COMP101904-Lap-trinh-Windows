# BÁO CÁO LAB 11: ADO.NET VÀ CRUD VỚI SQL SERVER

- **Học phần:** COMP1019 - Lập trình trên Windows
- **Giảng viên hướng dẫn:** ThS. Lê Thanh Thoại
- **Sinh viên thực hiện:** Ngô Minh Hải
- **Công cụ:** Visual Studio, SQL Server, SSMS, `Microsoft.Data.SqlClient`
- **Tên CSDL:** `EduManagerDB`

---

## 1. Cấu trúc tệp nộp

- `EduManagerDB.sql`: Script SQL tạo database `EduManagerDB`, bảng `LOP`, `SINHVIEN` và dữ liệu mẫu.
- `Lab11_QuanLyLopHoc.sln`: Solution ứng dụng Windows Forms quản lý lớp học.
- `Lab11_QuanLyLopHoc/`: Thư mục chứa mã nguồn C# (`FrmQuanLyLop.cs`, `FrmQuanLyLop.Designer.cs`, `Program.cs`).
- `README.md`: Tài liệu mô tả cấu hình kết nối và chức năng.

---

## 2. Chuỗi kết nối (Connection String)

Chuỗi kết nối sử dụng trong `FrmQuanLyLop.cs`:

```csharp
Data Source=localhost\SQLEXPRESS;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True;
```

---

## 3. Chức năng đã thực hiện

- **F1 (Load dữ liệu):** Tự động tải danh sách lớp từ bảng `LOP` lên `dgvLop` khi mở Form.
- **F2 (Chọn dòng):** Khi chọn một dòng trên `dgvLop`, đổ dữ liệu lên `txtMaLop`, `txtTenLop` và khóa `txtMaLop` (`ReadOnly = true`).
- **F3 (Thêm lớp):** Kiểm tra rỗng, kiểm tra trùng mã lớp trong CSDL trước khi thêm mới bằng `SqlParameter`.
- **F4 (Sửa lớp):** Kiểm tra trạng thái đã chọn lớp và cập nhật `TenLop` theo `MaLop`.
- **F5 (Xóa lớp):** Kiểm tra lớp có đang chứa sinh viên trong bảng `SINHVIEN` hay không, hiển thị hộp thoại xác nhận trước khi xóa.
- **F6 (Tìm kiếm):** Tìm kiếm theo `MaLop` hoặc `TenLop` sử dụng toán tử `LIKE` kết hợp `SqlParameter`.
- **F7 (Làm mới):** Xóa trắng các ô nhập liệu, mở khóa `txtMaLop` và tải lại toàn bộ danh sách lớp.
- **F8 (Bảo mật truy vấn):** Toàn bộ câu lệnh SQL nhận dữ liệu từ người dùng đều truyền qua `SqlParameter`.

---

## 4. Hướng dẫn chạy chương trình

1. Mở **SSMS**, chạy file `EduManagerDB.sql` (`F5`) để khởi tạo CSDL và dữ liệu mẫu.
2. Mở file `Lab11_QuanLyLopHoc.sln` bằng **Visual Studio**.
3. Kiểm tra chuỗi kết nối `_connectionString` trong `FrmQuanLyLop.cs` cho khớp với tên SQL Server trên máy.
4. Nhấn `Ctrl + Shift + B` để build và nhấn `F5` để chạy ứng dụng.
