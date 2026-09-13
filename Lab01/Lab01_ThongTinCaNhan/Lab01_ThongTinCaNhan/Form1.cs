namespace Lab01_ThongTinCaNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khoi tao danh sach lua chon cho ComboBox Khoa/Lop
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Sư phạm Toán");
            cboKhoa.Items.Add("Sư phạm Tiếng Anh");
            cboKhoa.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Xac nhan nguoi dung truoc khi dong ung dung
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xoa sach thong tin nhap va dua cac o ve trang thai ban dau
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            txtKetQua.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            cboKhoa.SelectedIndex = 0;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // 1. Kiem tra cac truong thong tin bat buoc khong duoc de trong
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtNamSinh.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên, Năm sinh và Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiem tra nam sinh hop le (phai la so nguyen va tu 1900 den nam hien tai)
            if (!int.TryParse(txtNamSinh.Text, out int namSinh) || namSinh < 1900 || namSinh > DateTime.Now.Year)
            {
                MessageBox.Show("Năm sinh phải là số nguyên và nằm trong khoảng từ 1900 đến năm hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiem tra bat buoc chon gioi tinh
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Kiem tra bat buoc chon Khoa/Lop
            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Khoa/Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Xu ly du lieu va tinh tuoi
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            int tuoi = DateTime.Now.Year - namSinh;
            string khoa = cboKhoa.SelectedItem.ToString();

            // 6. Hien thi thong tin tong hop ra man hinh
            txtKetQua.Text = "THÔNG TIN SINH VIÊN\r\n" +
                             "Họ tên: " + txtHoTen.Text + "\r\n" +
                             "Tuổi: " + tuoi.ToString() + "\r\n" +
                             "Email: " + txtEmail.Text + "\r\n" +
                             "Giới tính: " + gioiTinh + "\r\n" +
                             "Khoa/Lớp: " + khoa;
        }
    }
}