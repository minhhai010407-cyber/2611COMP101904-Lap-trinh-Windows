namespace ShopManagerMini.Forms
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblLoaiKhachHang = new Label();
            cboLoaiKhachHang = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvCustomers = new DataGridView();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // grpThongTin
            grpThongTin.Controls.Add(lblMaKH);
            grpThongTin.Controls.Add(txtMaKH);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblSoDienThoai);
            grpThongTin.Controls.Add(txtSoDienThoai);
            grpThongTin.Controls.Add(lblLoaiKhachHang);
            grpThongTin.Controls.Add(cboLoaiKhachHang);
            grpThongTin.ForeColor = Color.RebeccaPurple;
            grpThongTin.Location = new Point(12, 10);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(736, 115);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin khách hàng";
            // lblMaKH
            lblMaKH.ForeColor = SystemColors.ControlText;
            lblMaKH.Location = new Point(20, 35);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(90, 23);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã KH";
            lblMaKH.TextAlign = ContentAlignment.MiddleLeft;
            // txtMaKH
            txtMaKH.Location = new Point(115, 35);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ForeColor = SystemColors.WindowText;
            txtMaKH.Size = new Size(210, 23);
            txtMaKH.TabIndex = 1;
            // lblHoTen
            lblHoTen.ForeColor = SystemColors.ControlText;
            lblHoTen.Location = new Point(20, 70);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(90, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // txtHoTen
            txtHoTen.Location = new Point(115, 70);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ForeColor = SystemColors.WindowText;
            txtHoTen.Size = new Size(210, 23);
            txtHoTen.TabIndex = 3;
            // lblSoDienThoai
            lblSoDienThoai.ForeColor = SystemColors.ControlText;
            lblSoDienThoai.Location = new Point(380, 35);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(110, 23);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại";
            lblSoDienThoai.TextAlign = ContentAlignment.MiddleLeft;
            // txtSoDienThoai
            txtSoDienThoai.Location = new Point(495, 35);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.ForeColor = SystemColors.WindowText;
            txtSoDienThoai.Size = new Size(220, 23);
            txtSoDienThoai.TabIndex = 5;
            // lblLoaiKhachHang
            lblLoaiKhachHang.ForeColor = SystemColors.ControlText;
            lblLoaiKhachHang.Location = new Point(380, 70);
            lblLoaiKhachHang.Name = "lblLoaiKhachHang";
            lblLoaiKhachHang.Size = new Size(110, 23);
            lblLoaiKhachHang.TabIndex = 6;
            lblLoaiKhachHang.Text = "Loại khách hàng";
            lblLoaiKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            // cboLoaiKhachHang
            cboLoaiKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiKhachHang.Location = new Point(495, 70);
            cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            cboLoaiKhachHang.ForeColor = SystemColors.WindowText;
            cboLoaiKhachHang.Size = new Size(220, 23);
            cboLoaiKhachHang.TabIndex = 7;
            // btnThem
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(12, 137);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 34);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // btnSua
            btnSua.BackColor = Color.SteelBlue;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(120, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 34);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // btnXoa
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(228, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // btnLamMoi
            btnLamMoi.BackColor = Color.SlateGray;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(336, 137);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 34);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // txtTimKiem
            txtTimKiem.Location = new Point(480, 143);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.ForeColor = SystemColors.WindowText;
            txtTimKiem.PlaceholderText = "Nhập mã hoặc họ tên";
            txtTimKiem.Size = new Size(170, 23);
            txtTimKiem.TabIndex = 5;
            // btnTimKiem
            btnTimKiem.BackColor = Color.RebeccaPurple;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(658, 137);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 34);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // dgvCustomers
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = SystemColors.Window;
            dgvCustomers.Location = new Point(12, 185);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(736, 323);
            dgvCustomers.TabIndex = 7;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // FrmCustomer
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 520);
            Controls.Add(dgvCustomers);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpThongTin);
            Name = "FrmCustomer";
            Text = "Quản lý khách hàng";
            Load += FrmCustomer_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpThongTin;
        private Label lblMaKH;
        private TextBox txtMaKH;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblLoaiKhachHang;
        private ComboBox cboLoaiKhachHang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvCustomers;
    }
}
