namespace ShopManagerMini.Forms
{
    partial class FrmProduct
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
            lblMaSP = new Label();
            txtMaSP = new TextBox();
            lblTenSP = new Label();
            txtTenSP = new TextBox();
            lblLoaiSP = new Label();
            cboLoaiSP = new ComboBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvProducts = new DataGridView();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // grpThongTin
            grpThongTin.Controls.Add(lblMaSP);
            grpThongTin.Controls.Add(txtMaSP);
            grpThongTin.Controls.Add(lblTenSP);
            grpThongTin.Controls.Add(txtTenSP);
            grpThongTin.Controls.Add(lblLoaiSP);
            grpThongTin.Controls.Add(cboLoaiSP);
            grpThongTin.Controls.Add(lblDonGia);
            grpThongTin.Controls.Add(txtDonGia);
            grpThongTin.Controls.Add(lblSoLuong);
            grpThongTin.Controls.Add(txtSoLuong);
            grpThongTin.ForeColor = Color.RebeccaPurple;
            grpThongTin.Location = new Point(12, 10);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(796, 150);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sản phẩm";
            // lblMaSP
            lblMaSP.ForeColor = SystemColors.ControlText;
            lblMaSP.Location = new Point(20, 35);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(80, 23);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã SP";
            lblMaSP.TextAlign = ContentAlignment.MiddleLeft;
            // txtMaSP
            txtMaSP.Location = new Point(105, 35);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ForeColor = SystemColors.WindowText;
            txtMaSP.Size = new Size(230, 23);
            txtMaSP.TabIndex = 1;
            // lblTenSP
            lblTenSP.ForeColor = SystemColors.ControlText;
            lblTenSP.Location = new Point(20, 70);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(80, 23);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên SP";
            lblTenSP.TextAlign = ContentAlignment.MiddleLeft;
            // txtTenSP
            txtTenSP.Location = new Point(105, 70);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.ForeColor = SystemColors.WindowText;
            txtTenSP.Size = new Size(230, 23);
            txtTenSP.TabIndex = 3;
            // lblLoaiSP
            lblLoaiSP.ForeColor = SystemColors.ControlText;
            lblLoaiSP.Location = new Point(20, 105);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(80, 23);
            lblLoaiSP.TabIndex = 4;
            lblLoaiSP.Text = "Loại SP";
            lblLoaiSP.TextAlign = ContentAlignment.MiddleLeft;
            // cboLoaiSP
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Location = new Point(105, 105);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.ForeColor = SystemColors.WindowText;
            cboLoaiSP.Size = new Size(230, 23);
            cboLoaiSP.TabIndex = 5;
            // lblDonGia
            lblDonGia.ForeColor = SystemColors.ControlText;
            lblDonGia.Location = new Point(400, 35);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(80, 23);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn giá";
            lblDonGia.TextAlign = ContentAlignment.MiddleLeft;
            // txtDonGia
            txtDonGia.Location = new Point(485, 35);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ForeColor = SystemColors.WindowText;
            txtDonGia.Size = new Size(260, 23);
            txtDonGia.TabIndex = 7;
            // lblSoLuong
            lblSoLuong.ForeColor = SystemColors.ControlText;
            lblSoLuong.Location = new Point(400, 70);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(80, 23);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số lượng";
            lblSoLuong.TextAlign = ContentAlignment.MiddleLeft;
            // txtSoLuong
            txtSoLuong.Location = new Point(485, 70);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.ForeColor = SystemColors.WindowText;
            txtSoLuong.Size = new Size(260, 23);
            txtSoLuong.TabIndex = 9;
            // btnThem
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(12, 172);
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
            btnSua.Location = new Point(120, 172);
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
            btnXoa.Location = new Point(228, 172);
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
            btnLamMoi.Location = new Point(336, 172);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 34);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // txtTimKiem
            txtTimKiem.Location = new Point(555, 178);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.ForeColor = SystemColors.WindowText;
            txtTimKiem.PlaceholderText = "Nhập mã hoặc tên sản phẩm";
            txtTimKiem.Size = new Size(155, 23);
            txtTimKiem.TabIndex = 5;
            // btnTimKiem
            btnTimKiem.BackColor = Color.RebeccaPurple;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(718, 172);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 34);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // dgvProducts
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.Location = new Point(12, 220);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(796, 328);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // FrmProduct
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 560);
            Controls.Add(dgvProducts);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpThongTin);
            Name = "FrmProduct";
            Text = "Quản lý sản phẩm";
            Load += FrmProduct_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpThongTin;
        private Label lblMaSP;
        private TextBox txtMaSP;
        private Label lblTenSP;
        private TextBox txtTenSP;
        private Label lblLoaiSP;
        private ComboBox cboLoaiSP;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvProducts;
    }
}
