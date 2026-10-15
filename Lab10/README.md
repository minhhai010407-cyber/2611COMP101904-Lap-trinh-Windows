\# BÁO CÁO LAB 10: THIẾT KẾ VÀ CÀI ĐẶT CƠ SỞ DỮ LIỆU EDUMANAGERDB



\- \*\*Học phần:\*\* COMP1019 - Lập trình trên Windows

\- \*\*Giảng viên hướng dẫn:\*\* ThS. Lê Thanh Thoại

\- \*\*Sinh viên thực hiện:\*\* Ngô Minh Hải

\- \*\*Môi trường:\*\* Microsoft SQL Server / SQL Server Management Studio (SSMS)

\- \*\*Tên CSDL:\*\* EduManagerDB



\---



\## 1. Cấu trúc tệp nộp bài



\- `01\_CreateDatabase.sql`: Tạo CSDL `EduManagerDB`, tạo 6 bảng, thiết lập khóa chính, khóa ngoại và ràng buộc `CHECK`.

\- `02\_InsertSampleData.sql`: Nạp dữ liệu mẫu (2 khoa, 3 lớp, 7 sinh viên, 4 môn học, 8 kết quả học tập, 2 tài khoản).

\- `03\_Queries.sql`: Thực hiện 12 câu truy vấn (`SELECT`, `JOIN`, `UPDATE`, `DELETE`, `GROUP BY`, `HAVING`) và kiểm thử ràng buộc.

\- `Images/`: Thư mục chứa 5 ảnh chụp kết quả chạy truy vấn và kiểm thử lỗi.

\- `README.md`: Báo cáo tóm tắt CSDL và kết quả thực nghiệm.



\---



\## 2. Thiết kế bảng và ràng buộc toàn vẹn



| Tên bảng | Khóa chính (PK) | Khóa ngoại (FK) | Ràng buộc kiểm tra (CHECK) |

| :--- | :--- | :--- | :--- |

| `KHOA` | `MaKhoa` | Không | `TenKhoa NOT NULL` |

| `LOP` | `MaLop` | `MaKhoa` $\\rightarrow$ `KHOA(MaKhoa)` | `TenLop NOT NULL` |

| `SINHVIEN` | `MaSV` | `MaLop` $\\rightarrow$ `LOP(MaLop)` | `GioiTinh IN (N'Nam', N'Nữ')` |

| `MONHOC` | `MaMH` | Không | `SoTinChi > 0` |

| `KETQUA` | `(MaSV, MaMH)` | `MaSV` $\\rightarrow$ `SINHVIEN(MaSV)`<br>`MaMH` $\\rightarrow$ `MONHOC(MaMH)` | `Diem >= 0 AND Diem <= 10` |

| `TAIKHOAN` | `TenDangNhap` | Không | `MatKhau, HoTen, VaiTro NOT NULL` |



\---



\## 3. Ảnh chụp minh chứng thực nghiệm



\### 3.1. Truy vấn liên kết bảng (Câu 2 - INNER JOIN)

Liệt kê danh sách sinh viên kèm tên lớp và tên khoa:

!\[Truy vấn JOIN](Images/01\_TruyVan\_JOIN.png)



\### 3.2. Thống kê dữ liệu gom nhóm (Câu 8 - GROUP BY / AVG)

Tính điểm trung bình học tập của từng sinh viên:

!\[Thống kê gom nhóm](Images/02\_ThongKe.png)



\### 3.3. Cập nhật và Xóa dữ liệu (Câu 5 \& Câu 6 - UPDATE / DELETE)

Cập nhật thông tin lớp học và xóa sinh viên chưa có dữ liệu điểm:

!\[Cập nhật hoặc xóa](Images/03\_CapNhat\_Hoac\_Xoa.png)



\### 3.4. Kiểm thử ràng buộc khóa ngoại (Câu 11 - FOREIGN KEY)

Bắt lỗi khi thêm sinh viên vào mã lớp không tồn tại:

!\[Lỗi khóa ngoại](Images/04\_TestLoi\_KhoaNgoai.png)



\### 3.5. Kiểm thử ràng buộc miền giá trị (Câu 12 - CHECK Constraint)

Bắt lỗi khi nhập điểm ngoài khoảng từ 0 đến 10:

!\[Lỗi ràng buộc điểm](Images/05\_TestLoi\_RangBuocDiem.png)



\---



\## 4. Hướng dẫn thực thi



Mở SSMS, mở từng file và thực thi bằng phím \*\*F5\*\* theo đúng thứ tự:

1\. `01\_CreateDatabase.sql`: Khởi tạo CSDL và 6 bảng.

2\. `02\_InsertSampleData.sql`: Nạp toàn bộ dữ liệu mẫu ban đầu.

3\. `03\_Queries.sql`: Chạy và kiểm tra kết quả 12 câu truy vấn.

