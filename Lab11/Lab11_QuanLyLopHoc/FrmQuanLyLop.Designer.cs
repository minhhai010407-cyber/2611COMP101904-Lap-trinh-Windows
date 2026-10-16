namespace Lab11_QuanLyLopHoc
{
    partial class FrmQuanLyLop
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblMaLop;
        private TextBox txtMaLop;
        private Label lblTenLop;
        private TextBox txtTenLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox grpTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvLop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpThongTin = new GroupBox();
            lblMaLop = new Label();
            txtMaLop = new TextBox();
            lblTenLop = new Label();
            txtTenLop = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTimKiem = new GroupBox();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvLop = new DataGridView();
            grpThongTin.SuspendLayout();
            grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();

            lblTitle.AutoSize = false;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 55, 109);
            lblTitle.Height = 50;
            lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            grpThongTin.Controls.Add(lblMaLop);
            grpThongTin.Controls.Add(txtMaLop);
            grpThongTin.Controls.Add(lblTenLop);
            grpThongTin.Controls.Add(txtTenLop);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Font = new Font("Segoe UI", 9.5F);
            grpThongTin.Location = new Point(20, 55);
            grpThongTin.Size = new Size(740, 130);
            grpThongTin.Text = "Thông tin lớp học";

            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(25, 35);
            lblMaLop.Text = "Mã lớp:";

            txtMaLop.Location = new Point(95, 31);
            txtMaLop.MaxLength = 20;
            txtMaLop.Size = new Size(210, 29);

            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(340, 35);
            lblTenLop.Text = "Tên lớp:";

            txtTenLop.Location = new Point(410, 31);
            txtTenLop.MaxLength = 100;
            txtTenLop.Size = new Size(305, 29);

            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(95, 78);
            btnThem.Size = new Size(110, 34);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;

            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(220, 78);
            btnSua.Size = new Size(110, 34);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;

            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(345, 78);
            btnXoa.Size = new Size(110, 34);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(470, 78);
            btnLamMoi.Size = new Size(110, 34);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            grpTimKiem.Controls.Add(lblTimKiem);
            grpTimKiem.Controls.Add(txtTimKiem);
            grpTimKiem.Controls.Add(btnTimKiem);
            grpTimKiem.Font = new Font("Segoe UI", 9.5F);
            grpTimKiem.Location = new Point(20, 195);
            grpTimKiem.Size = new Size(740, 70);
            grpTimKiem.Text = "Tìm kiếm";

            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(25, 30);
            lblTimKiem.Text = "Từ khóa (Mã / Tên lớp):";

            txtTimKiem.Location = new Point(195, 26);
            txtTimKiem.Size = new Size(390, 29);

            btnTimKiem.BackColor = Color.FromArgb(23, 162, 184);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(605, 24);
            btnTimKiem.Size = new Size(110, 33);
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;

            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLop.BackgroundColor = Color.White;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Location = new Point(20, 278);
            dgvLop.MultiSelect = false;
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersVisible = false;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(740, 240);
            dgvLop.CellClick += dgvLop_CellClick;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(780, 540);
            Controls.Add(dgvLop);
            Controls.Add(grpTimKiem);
            Controls.Add(grpThongTin);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp học - EduManagerDB";
            Load += FrmQuanLyLop_Load;

            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
        }
    }
}
