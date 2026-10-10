# BÁO CÁO THỰC HÀNH BUỔI 7: SDI, MDI VÀ ỨNG DỤNG NHIỀU FORM TRONG C# WINFORMS

* **Học phần:** 2611COMP101904 - Lập trình trên Windows
* **Giảng viên hướng dẫn:** ThS. Lê Thanh Thoại
* **Sinh viên thực hiện:** Ngô Minh Hải
* **Môi trường phát triển:** Microsoft Visual Studio - C# Windows Forms App 
* **Tên ứng dụng:** ShopManagerMini

---

## 1. Giới thiệu và Kiến trúc Hệ thống

Dự án `ShopManagerMini` được xây dựng nhằm hiện thực hóa giải pháp quản lý cửa hàng mini nhiều Form, áp dụng kiến trúc đa tài liệu MDI (Multiple Document Interface) và luồng điều khiển hướng sự kiện:

* **Mô hình kiến trúc MDI Parent - Child:** `FrmMain` đóng vai trò là Form cha chứa (`IsMdiContainer = true`), quản lý vòng đời và không gian hiển thị của các Form con (`FrmProduct`, `FrmCustomer`, `FrmAbout`) bên trong vùng làm việc, ngăn chặn việc phân mảnh cửa sổ độc lập ngoài màn hình desktop.
* **Cơ chế xác thực và Điều phối luồng khởi động (Modal Authentication Flow):** Sử dụng `FrmLogin` chạy dưới dạng hộp thoại độc quyền (`ShowDialog()`). Dữ liệu người dùng được đóng gói trong đối tượng `User` và truyền sang Form chính `FrmMain` thông qua hàm khởi tạo (Constructor).
* **Quản lý Form con đơn lẻ (Singleton Child Navigation):** Kiểm tra tập hợp `this.MdiChildren` thông qua hàm `DaMoForm(Type)` nhằm kích hoạt (`Activate()`) lại thể hiện sẵn có thay vì khởi tạo trùng lặp khi người dùng chọn menu nhiều lần.
* **Lưu trữ dữ liệu trong bộ nhớ (In-Memory Data Binding):** Toàn bộ thực thể `User`, `Product`, `Customer` được quản lý bằng cấu trúc danh sách liên kết trong bộ nhớ và đồng bộ hiển thị lên `DataGridView`.

---

## 2. Đặc tả Danh mục Form và Chức năng

| Tên Form | Vai trò kiến trúc | Trách nhiệm chức năng chính |
| :--- | :--- | :--- |
| `FrmLogin` | Modal Form | Tiếp nhận xác thực tài khoản mẫu, bẫy lỗi nhập liệu, trả `DialogResult.OK` khi hợp lệ. |
| `FrmMain` | MDI Container | Form trung tâm chứa `MenuStrip`, `StatusStrip` hiển thị định danh/vai trò người dùng và quản lý Form con. |
| `FrmProduct` | MDI Child | Quản lý danh mục sản phẩm (Thêm, Sửa, Xóa, Tìm kiếm), hiển thị `DataGridView` và bẫy lỗi ràng buộc. |
| `FrmCustomer` | MDI Child | Quản lý danh sách khách hàng, hiển thị bảng thông tin đối tác và thêm mới dữ liệu. |
| `FrmAbout` | Child Form | Hiển thị thông tin bản quyền ứng dụng, thông tin sinh viên thực hiện và lớp học phần. |

---

## 3. Minh chứng Thực nghiệm và Kiểm thử Hệ thống (Test Cases)

Dưới đây là các minh chứng thực nghiệm tương ứng với các tiêu chí trong Rubric đánh giá:

### 3.1. Xác thực Đầu vào và Bẫy lỗi Đăng nhập
Kiểm tra tính hợp lệ của tài khoản mẫu, kích hoạt hộp thoại thông báo cảnh báo khi bỏ trống hoặc nhập sai thông tin xác thực:
![Bẫy lỗi đăng nhập](Images/01_DangNhap.png)

### 3.2. Đăng nhập Thành công và Điều phối Dữ liệu Người dùng
Đăng nhập thành công với tài khoản quản trị/nhân viên, điều hướng vào `FrmMain` và hiển thị chính xác tên người dùng cùng vai trò trên thanh `StatusStrip`:
![Đăng nhập thành công](Images/02_DangNhap_ThanhCong.png)

### 3.3. Quản lý Không gian MDI Container
Khởi tạo và quản lý đồng thời các Form nghiệp vụ con bên trong vùng làm việc của `FrmMain`, không mở thành các cửa sổ rời rạc:
![Kiến trúc MDI](Images/03_MDI_ChuaNhieuFormCon.png)

### 3.4. Quản lý Danh mục Sản phẩm trên DataGridView
Giao diện quản lý danh mục sản phẩm thực hiện kiểm soát ràng buộc dữ liệu, hiển thị danh sách trực quan trên bảng `DataGridView`:
![Quản lý sản phẩm](Images/04_Product.png)

### 3.5. Thực thi Thao tác Thêm Bản ghi Dữ liệu
Thực hiện nhập liệu thông tin mới và cập nhật thành công bản ghi vào bộ nhớ hệ thống:
![Thêm dữ liệu](Images/05_Custome.png)

### 3.6. Thông tin Bản quyền và Định danh Sinh viên
Màn hình `FrmAbout` hiển thị đầy đủ thông tin hệ thống, xác thực định danh sinh viên thực hiện dự án:
![Thông tin giới thiệu](Images/06_FrmAbout_ThongTin.png)

### 3.7. Hộp thoại Xác nhận An toàn (Confirmation Dialog)
Cơ chế bảo vệ dữ liệu với hộp thoại xác nhận lựa chọn trước khi thực thi thao tác xóa thực thể hoặc thoát chương trình:
![Xác nhận an toàn](Images/07_XacNhan_Xoa_Thoat.png)

---

## 4. Trả lời Câu hỏi Lý thuyết Chuyên đề

### Câu 1: SDI và MDI khác nhau như thế nào?
* **SDI (Single Document Interface):** Mỗi Form là một cửa sổ độc lập, có nút đóng, thu nhỏ, phóng to riêng và nằm ngang hàng với các Form khác. Đóng Form này không ảnh hưởng Form kia. Ví dụ: Notepad, hoặc các bài lab trước như `CourseRegistrationApp` và `ProductManager` (chỉ có một Form).
* **MDI (Multiple Document Interface):** Có một Form cha làm khung chứa (`IsMdiContainer = true`), các Form con chỉ hiển thị bên trong vùng làm việc của Form cha và không được kéo ra ngoài. Đóng Form cha thì mọi Form con đóng theo. Ví dụ: Word hoặc Excel bản cũ, nhiều tài liệu mở trong một cửa sổ chính.

| Tiêu chí | SDI | MDI |
| :--- | :--- | :--- |
| **Vị trí Form** | Độc lập, tự do trên màn hình | Nằm trong Form cha |
| **Quan hệ** | Ngang hàng | Cha - con (`MdiParent`) |
| **Đóng Form cha** | Không ảnh hưởng Form khác | Đóng luôn các Form con |
| **Thiết lập** | Không cần | Cha: `IsMdiContainer = true`; Con: `MdiParent = this` |
| **Trong bài này** | `FrmLogin` | `FrmMain` (cha), `FrmProduct`, `FrmCustomer`, `FrmAbout` (con) |

---

### Câu 2: Vì sao Form đăng nhập nên dùng `ShowDialog()`?
`ShowDialog()` mở Form ở chế độ modal: dòng lệnh gọi nó sẽ dừng lại, người dùng không thao tác được với Form khác cho đến khi Form đăng nhập đóng. Có 3 lý do chính:
* **Chặn đi tiếp khi chưa đăng nhập:** Với `Show()` thì Form đăng nhập chỉ là một cửa sổ bình thường, chương trình vẫn chạy tiếp và có thể mở Form chính dù chưa đăng nhập.
* **Có kết quả trả về:** `ShowDialog()` trả về `DialogResult` (`OK` khi đăng nhập thành công, `Cancel` khi bấm Thoát), nên nơi gọi biết phải làm gì tiếp.
* **Đúng thứ tự:** Chỉ khi đăng nhập xong thì mới tạo `FrmMain`.

Trong `Program.cs`:
```csharp
FrmLogin frmLogin = new FrmLogin();
if (frmLogin.ShowDialog() != DialogResult.OK) break;
FrmMain frmMain = new FrmMain(frmLogin.NguoiDung, dsSanPham, dsKhachHang);
Application.Run(frmMain);
```

---

### Câu 3: Dữ liệu user được truyền từ FrmLogin sang FrmMain bằng cách nào?
Truyền theo 3 bước:
1. `FrmLogin` lưu user vào property:
   ```csharp
   public User NguoiDung { get; private set; }
   ```
   Khi tên đăng nhập và mật khẩu đúng, nó gán `NguoiDung = u;` rồi `DialogResult = DialogResult.OK;` để đóng Form.
2. `Program.cs` đọc property `frmLogin.NguoiDung` sau khi `ShowDialog()` trả về `OK`.
3. Truyền vào constructor của `FrmMain`:
   ```csharp
   new FrmMain(frmLogin.NguoiDung, dsSanPham, dsKhachHang);
   ```

`FrmMain` nhận user và hiển thị lên `StatusStrip`:
```csharp
lblNguoiDung.Text = "Người dùng: " + nguoiDung.HoTen;
lblVaiTro.Text = "Vai trò: " + nguoiDung.VaiTro;
```
*(Lớp `User` nằm trong thư mục `Models`, gồm `Username`, `Password`, `HoTen`, `VaiTro`)*.

---

### Câu 4: Bấm menu sản phẩm nhiều lần thì xử lý thế nào để không mở trùng Form?
Trước khi tạo Form mới, chương trình kiểm tra trong danh sách Form con đang mở (`MdiChildren`) xem đã có Form cùng loại chưa. Nếu có thì chỉ đưa Form đó lên phía trước:

```csharp
private bool DaMoForm(Type loaiForm)
{
    foreach (Form f in MdiChildren)
    {
        if (f.GetType() == loaiForm)
        {
            if (f.WindowState == FormWindowState.Minimized) 
                f.WindowState = FormWindowState.Normal;
            f.Activate();
            return true;
        }
    }
    return false;
}
```

Khi bấm menu:
```csharp
if (DaMoForm(typeof(FrmProduct))) return;
FrmProduct frm = new FrmProduct(dsSanPham);
frm.MdiParent = this;
frm.Show();
```

**Kết quả:** Bấm lần đầu thì tạo và hiển thị Form. Bấm lần sau, nếu Form đang mở thì kích hoạt lại (hoặc khôi phục nếu đang thu nhỏ), không tạo thêm. Nếu đã đóng Form thì bấm lại sẽ tạo mới. Cách này dùng chung cho `FrmProduct`, `FrmCustomer` và `FrmAbout`.

---

### Câu 5: Khi nào dùng constructor, khi nào dùng property để truyền dữ liệu giữa các Form?

| Tiêu chí | Constructor | Property |
| :--- | :--- | :--- |
| **Dùng khi** | Dữ liệu bắt buộc có ngay lúc tạo Form | Dữ liệu có sau, hoặc cần lấy ngược về Form gọi |
| **Ưu điểm** | Không thể quên truyền, Form luôn có dữ liệu để chạy | Linh hoạt, gán hoặc đọc bất cứ lúc nào |
| **Nhược điểm** | Cứng, thêm dữ liệu phải sửa constructor | Có thể quên gán, dễ gặp giá trị null |
| **Trong bài này** | `new FrmMain(user, dsSanPham, dsKhachHang)`, `new FrmProduct(dsSanPham)` | `FrmLogin.NguoiDung`, `FrmMain.DangXuat` |
