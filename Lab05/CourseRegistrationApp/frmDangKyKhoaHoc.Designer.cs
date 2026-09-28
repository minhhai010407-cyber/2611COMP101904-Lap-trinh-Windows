namespace CourseRegistrationApp
{
    partial class frmDangKyKhoaHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            grpThongTinHocVien = new GroupBox();
            lblTrangThaiEmail = new Label();
            chkNhanEmail = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            lblDemKyTu = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            grpThongTinKhoaHoc = new GroupBox();
            lblTongTien = new Label();
            lblTongTienTieuDe = new Label();
            lblHocPhiThang = new Label();
            lblHocPhiThangTieuDe = new Label();
            numSoThang = new NumericUpDown();
            lblSoThang = new Label();
            radOffline = new RadioButton();
            radOnline = new RadioButton();
            lblHinhThuc = new Label();
            cboKhoaHoc = new ComboBox();
            lblKhoaHoc = new Label();
            btnDangKy = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            grpThongTinHocVien.SuspendLayout();
            grpThongTinKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            SuspendLayout();
            // lblTieuDe
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.SteelBlue;
            lblTieuDe.Location = new Point(0, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(820, 50);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG KÝ KHÓA HỌC";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // grpThongTinHocVien
            grpThongTinHocVien.Controls.Add(lblTrangThaiEmail);
            grpThongTinHocVien.Controls.Add(chkNhanEmail);
            grpThongTinHocVien.Controls.Add(dtpNgaySinh);
            grpThongTinHocVien.Controls.Add(lblNgaySinh);
            grpThongTinHocVien.Controls.Add(txtSoDienThoai);
            grpThongTinHocVien.Controls.Add(lblSoDienThoai);
            grpThongTinHocVien.Controls.Add(lblDemKyTu);
            grpThongTinHocVien.Controls.Add(txtHoTen);
            grpThongTinHocVien.Controls.Add(lblHoTen);
            grpThongTinHocVien.Font = new Font("Segoe UI", 10F);
            grpThongTinHocVien.ForeColor = Color.SteelBlue;
            grpThongTinHocVien.Location = new Point(25, 80);
            grpThongTinHocVien.Name = "grpThongTinHocVien";
            grpThongTinHocVien.Size = new Size(380, 270);
            grpThongTinHocVien.TabIndex = 1;
            grpThongTinHocVien.TabStop = false;
            grpThongTinHocVien.Text = "Thông tin học viên";
            // lblHoTen
            lblHoTen.ForeColor = Color.DimGray;
            lblHoTen.Location = new Point(10, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(80, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleRight;
            // txtHoTen
            txtHoTen.ForeColor = Color.Black;
            txtHoTen.Location = new Point(100, 40);
            txtHoTen.MaxLength = 50;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 25);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // lblDemKyTu
            lblDemKyTu.ForeColor = Color.Silver;
            lblDemKyTu.Location = new Point(305, 40);
            lblDemKyTu.Name = "lblDemKyTu";
            lblDemKyTu.Size = new Size(65, 25);
            lblDemKyTu.TabIndex = 2;
            lblDemKyTu.Text = "0/50";
            lblDemKyTu.TextAlign = ContentAlignment.MiddleLeft;
            // lblSoDienThoai
            lblSoDienThoai.ForeColor = Color.DimGray;
            lblSoDienThoai.Location = new Point(10, 85);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(80, 25);
            lblSoDienThoai.TabIndex = 3;
            lblSoDienThoai.Text = "SĐT";
            lblSoDienThoai.TextAlign = ContentAlignment.MiddleRight;
            // txtSoDienThoai
            txtSoDienThoai.ForeColor = Color.Black;
            txtSoDienThoai.Location = new Point(100, 85);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(200, 25);
            txtSoDienThoai.TabIndex = 4;
            // lblNgaySinh
            lblNgaySinh.ForeColor = Color.DimGray;
            lblNgaySinh.Location = new Point(10, 130);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(80, 25);
            lblNgaySinh.TabIndex = 5;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleRight;
            // dtpNgaySinh
            dtpNgaySinh.CustomFormat = "dd-MMM-yy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(100, 130);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 25);
            dtpNgaySinh.TabIndex = 6;
            // chkNhanEmail
            chkNhanEmail.ForeColor = Color.DimGray;
            chkNhanEmail.Location = new Point(100, 175);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(200, 25);
            chkNhanEmail.TabIndex = 7;
            chkNhanEmail.Text = "Nhận email thông báo";
            chkNhanEmail.CheckedChanged += chkNhanEmail_CheckedChanged;
            // lblTrangThaiEmail
            lblTrangThaiEmail.ForeColor = Color.DimGray;
            lblTrangThaiEmail.Location = new Point(100, 210);
            lblTrangThaiEmail.Name = "lblTrangThaiEmail";
            lblTrangThaiEmail.Size = new Size(260, 25);
            lblTrangThaiEmail.TabIndex = 8;
            lblTrangThaiEmail.Text = "Không nhận email thông báo";
            // grpThongTinKhoaHoc
            grpThongTinKhoaHoc.Controls.Add(lblTongTien);
            grpThongTinKhoaHoc.Controls.Add(lblTongTienTieuDe);
            grpThongTinKhoaHoc.Controls.Add(lblHocPhiThang);
            grpThongTinKhoaHoc.Controls.Add(lblHocPhiThangTieuDe);
            grpThongTinKhoaHoc.Controls.Add(numSoThang);
            grpThongTinKhoaHoc.Controls.Add(lblSoThang);
            grpThongTinKhoaHoc.Controls.Add(radOffline);
            grpThongTinKhoaHoc.Controls.Add(radOnline);
            grpThongTinKhoaHoc.Controls.Add(lblHinhThuc);
            grpThongTinKhoaHoc.Controls.Add(cboKhoaHoc);
            grpThongTinKhoaHoc.Controls.Add(lblKhoaHoc);
            grpThongTinKhoaHoc.Font = new Font("Segoe UI", 10F);
            grpThongTinKhoaHoc.ForeColor = Color.SteelBlue;
            grpThongTinKhoaHoc.Location = new Point(420, 80);
            grpThongTinKhoaHoc.Name = "grpThongTinKhoaHoc";
            grpThongTinKhoaHoc.Size = new Size(375, 270);
            grpThongTinKhoaHoc.TabIndex = 2;
            grpThongTinKhoaHoc.TabStop = false;
            grpThongTinKhoaHoc.Text = "Thông tin khóa học";
            // lblKhoaHoc
            lblKhoaHoc.ForeColor = Color.DimGray;
            lblKhoaHoc.Location = new Point(10, 40);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(95, 25);
            lblKhoaHoc.TabIndex = 0;
            lblKhoaHoc.Text = "Khoá học";
            lblKhoaHoc.TextAlign = ContentAlignment.MiddleRight;
            // cboKhoaHoc
            cboKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoaHoc.ForeColor = Color.Black;
            cboKhoaHoc.Location = new Point(115, 40);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(240, 25);
            cboKhoaHoc.TabIndex = 1;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // lblHinhThuc
            lblHinhThuc.ForeColor = Color.DimGray;
            lblHinhThuc.Location = new Point(10, 85);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(95, 25);
            lblHinhThuc.TabIndex = 2;
            lblHinhThuc.Text = "Hình thức học";
            lblHinhThuc.TextAlign = ContentAlignment.MiddleRight;
            // radOnline
            radOnline.Checked = true;
            radOnline.ForeColor = Color.DimGray;
            radOnline.Location = new Point(115, 85);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(90, 25);
            radOnline.TabIndex = 3;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            // radOffline
            radOffline.ForeColor = Color.DimGray;
            radOffline.Location = new Point(230, 85);
            radOffline.Name = "radOffline";
            radOffline.Size = new Size(110, 25);
            radOffline.TabIndex = 4;
            radOffline.Text = "Trực tiếp";
            // lblSoThang
            lblSoThang.ForeColor = Color.DimGray;
            lblSoThang.Location = new Point(10, 130);
            lblSoThang.Name = "lblSoThang";
            lblSoThang.Size = new Size(95, 25);
            lblSoThang.TabIndex = 5;
            lblSoThang.Text = "Số tháng";
            lblSoThang.TextAlign = ContentAlignment.MiddleRight;
            // numSoThang
            numSoThang.ForeColor = Color.Black;
            numSoThang.Location = new Point(115, 130);
            numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "numSoThang";
            numSoThang.Size = new Size(70, 25);
            numSoThang.TabIndex = 6;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.ValueChanged += numSoThang_ValueChanged;
            // lblHocPhiThangTieuDe
            lblHocPhiThangTieuDe.ForeColor = Color.DimGray;
            lblHocPhiThangTieuDe.Location = new Point(10, 175);
            lblHocPhiThangTieuDe.Name = "lblHocPhiThangTieuDe";
            lblHocPhiThangTieuDe.Size = new Size(95, 25);
            lblHocPhiThangTieuDe.TabIndex = 7;
            lblHocPhiThangTieuDe.Text = "Học phí / tháng";
            lblHocPhiThangTieuDe.TextAlign = ContentAlignment.MiddleRight;
            // lblHocPhiThang
            lblHocPhiThang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHocPhiThang.ForeColor = Color.DimGray;
            lblHocPhiThang.Location = new Point(115, 175);
            lblHocPhiThang.Name = "lblHocPhiThang";
            lblHocPhiThang.Size = new Size(200, 25);
            lblHocPhiThang.TabIndex = 8;
            lblHocPhiThang.Text = "0 VNĐ";
            lblHocPhiThang.TextAlign = ContentAlignment.MiddleLeft;
            // lblTongTienTieuDe
            lblTongTienTieuDe.ForeColor = Color.DimGray;
            lblTongTienTieuDe.Location = new Point(10, 215);
            lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            lblTongTienTieuDe.Size = new Size(95, 25);
            lblTongTienTieuDe.TabIndex = 9;
            lblTongTienTieuDe.Text = "Tổng tiền";
            lblTongTienTieuDe.TextAlign = ContentAlignment.MiddleRight;
            // lblTongTien
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Firebrick;
            lblTongTien.Location = new Point(115, 215);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(200, 25);
            lblTongTien.TabIndex = 10;
            lblTongTien.Text = "0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // btnDangKy
            btnDangKy.BackColor = Color.OliveDrab;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(105, 400);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(160, 40);
            btnDangKy.TabIndex = 3;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // btnLamMoi
            btnLamMoi.BackColor = Color.CornflowerBlue;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(330, 400);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(160, 40);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // btnThoat
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(555, 400);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // frmDangKyKhoaHoc
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(820, 480);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDangKy);
            Controls.Add(grpThongTinKhoaHoc);
            Controls.Add(grpThongTinHocVien);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDangKyKhoaHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG KÝ KHÓA HỌC";
            Load += frmDangKyKhoaHoc_Load;
            grpThongTinHocVien.ResumeLayout(false);
            grpThongTinHocVien.PerformLayout();
            grpThongTinKhoaHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Label lblTieuDe;
        private GroupBox grpThongTinHocVien;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblDemKyTu;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private CheckBox chkNhanEmail;
        private Label lblTrangThaiEmail;
        private GroupBox grpThongTinKhoaHoc;
        private Label lblKhoaHoc;
        private ComboBox cboKhoaHoc;
        private Label lblHinhThuc;
        private RadioButton radOnline;
        private RadioButton radOffline;
        private Label lblSoThang;
        private NumericUpDown numSoThang;
        private Label lblHocPhiThangTieuDe;
        private Label lblHocPhiThang;
        private Label lblTongTienTieuDe;
        private Label lblTongTien;
        private Button btnDangKy;
        private Button btnLamMoi;
        private Button btnThoat;
    }
}
