# BÁO CÁO LAB 09: THIẾT KẾ VÀ IN THẺ SINH VIÊN BẰNG WINFORMS

- **Môn học:** COMP1019 - Lập trình trên Windows
- **Giảng viên:** ThS. Lê Thanh Thoại
- **Sinh viên thực hiện:** Ngô Minh Hải
- **Công nghệ:** C# Windows Forms (.NET), GDI+
- **Form chính:** FrmStudentCard

---

## 1. Mô tả chức năng

- **Nhập liệu:** Nhập mã SV, họ tên, lớp, khoa, khóa học, ngày sinh, giới tính.
- **Chọn ảnh:** Dùng `OpenFileDialog` chọn file ảnh (JPG, PNG, BMP), hiển thị lên `PictureBox` với `SizeMode = Zoom`.
- **Xem trước thẻ (Preview):** Vẽ thẻ sinh viên lên `Panel` bằng GDI+ qua sự kiện `Paint`.
- **In ấn:**
  - `PrintPreviewDialog`: Xem trước bố cục trang in.
  - `PrintDialog`: Chọn máy in và in qua `PrintDocument`.
- **Validation:** Bắt buộc nhập Mã SV, Họ tên và nạp ảnh mới cho xem trước/in.
- **Làm mới:** Xóa thông tin nhập và trả form về mặc định.

---

## 2. Bảng 8 Test Cases kiểm thử

| STT | Tên test case | Dữ liệu đầu vào | Kết quả mong đợi |
| :---: | :--- | :--- | :--- |
| **TC01** | Khởi tạo Form | Chạy chương trình | Form tải đủ controls, các ô nhập rỗng, chưa có ảnh. |
| **TC02** | Bỏ trống Mã SV | Không nhập Mã SV, bấm in | Báo lỗi yêu cầu nhập Mã SV. |
| **TC03** | Bỏ trống Họ tên | Không nhập Họ tên, bấm in | Báo lỗi yêu cầu nhập Họ tên. |
| **TC04** | Chưa chọn ảnh | Điền text nhưng chưa chọn ảnh, bấm in | Báo lỗi yêu cầu chọn ảnh thẻ. |
| **TC05** | Chọn file ảnh hợp lệ | Chọn file .png/.jpg qua OpenFileDialog | Ảnh hiển thị đúng tỉ lệ trên PictureBox. |
| **TC06** | Vẽ preview thẻ bằng GDI+ | Nhập đủ thông tin hợp lệ | Panel vẽ thẻ có khung, ảnh và thông tin sinh viên. |
| **TC07** | Xem trước khi in | Bấm nút "Xem trước in" | PrintPreviewDialog hiển thị trang in chứa thẻ. |
| **TC08** | Mở hộp thoại in | Bấm nút "In thẻ" | PrintDialog hiển thị danh sách máy in để chọn in. |

---

## 3. Ảnh chụp minh chứng

### 3.1. Giao diện khi khởi chạy
![Giao diện khởi tạo](Images/01_GiaoDien_KhoiTao.png)

### 3.2. Bẫy lỗi thiếu thông tin bắt buộc
![Báo lỗi thiếu dữ liệu](Images/02_Validation_ThieuDuLieu.png)

### 3.3. Xem trước thẻ sinh viên vẽ bằng GDI+
![Preview thẻ](Images/03_Preview_VeThe_GDI.png)

### 3.4. Cửa sổ xem trước khi in (PrintPreviewDialog)
![Xem trước khi in](Images/05_PrintPreviewDialog.png)

### 3.5. Cửa sổ chọn máy in (PrintDialog)
![Hộp thoại in](Images/04_PrintDialog_ChonMayIn.png)
