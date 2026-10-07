namespace ProductManager
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuThem = new ToolStripMenuItem();
            mnuSua = new ToolStripMenuItem();
            mnuXoa = new ToolStripMenuItem();
            mnuTimKiem = new ToolStripMenuItem();
            mnuLamMoi = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuGioiThieu = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbThem = new ToolStripButton();
            tsbSua = new ToolStripButton();
            tsbXoa = new ToolStripButton();
            tsSep1 = new ToolStripSeparator();
            tsbLamMoi = new ToolStripButton();
            tsSep2 = new ToolStripSeparator();
            tslTimKiem = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            tsbTimKiem = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblSoLuong = new ToolStripStatusLabel();
            grpThongTin = new GroupBox();
            btnChonAnh = new Button();
            picAnh = new PictureBox();
            chkConKinhDoanh = new CheckBox();
            dtpNgayNhap = new DateTimePicker();
            lblNgayNhap = new Label();
            numSoLuong = new NumericUpDown();
            lblSoLuongNhap = new Label();
            numDonGia = new NumericUpDown();
            lblDonGia = new Label();
            cboLoaiSP = new ComboBox();
            lblLoaiSP = new Label();
            txtTenSP = new TextBox();
            lblTenSP = new Label();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            dgvProducts = new DataGridView();
            cmsGrid = new ContextMenuStrip(components);
            mnuCtxSua = new ToolStripMenuItem();
            mnuCtxXoa = new ToolStripMenuItem();
            mnuCtxChiTiet = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            errProvider = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            cmsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // menuStrip1
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuQuanLy, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1040, 24);
            menuStrip1.TabIndex = 0;
            // mnuFile
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuFile.Name = "mnuFile";
            mnuFile.Text = "File";
            // mnuThoat
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // mnuQuanLy
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuThem, mnuSua, mnuXoa, mnuTimKiem, mnuLamMoi });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Text = "Quản lý";
            // mnuThem
            mnuThem.Name = "mnuThem";
            mnuThem.Text = "Thêm";
            mnuThem.Click += tsbThem_Click;
            // mnuSua
            mnuSua.Name = "mnuSua";
            mnuSua.Text = "Sửa";
            mnuSua.Click += tsbSua_Click;
            // mnuXoa
            mnuXoa.Name = "mnuXoa";
            mnuXoa.Text = "Xóa";
            mnuXoa.Click += tsbXoa_Click;
            // mnuTimKiem
            mnuTimKiem.Name = "mnuTimKiem";
            mnuTimKiem.Text = "Tìm kiếm";
            mnuTimKiem.Click += tsbTimKiem_Click;
            // mnuLamMoi
            mnuLamMoi.Name = "mnuLamMoi";
            mnuLamMoi.Text = "Làm mới";
            mnuLamMoi.Click += tsbLamMoi_Click;
            // mnuTroGiup
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuGioiThieu });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Text = "Trợ giúp";
            // mnuGioiThieu
            mnuGioiThieu.Name = "mnuGioiThieu";
            mnuGioiThieu.Text = "Giới thiệu";
            mnuGioiThieu.Click += mnuGioiThieu_Click;
            // toolStrip1
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbThem, tsbSua, tsbXoa, tsSep1, tsbLamMoi, tsSep2, tslTimKiem, txtTimKiem, tsbTimKiem });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1040, 25);
            toolStrip1.TabIndex = 1;
            // tsbThem
            tsbThem.Name = "tsbThem";
            tsbThem.Size = new Size(50, 22);
            tsbThem.Text = "Thêm";
            tsbThem.Click += tsbThem_Click;
            // tsbSua
            tsbSua.Name = "tsbSua";
            tsbSua.Size = new Size(38, 22);
            tsbSua.Text = "Sửa";
            tsbSua.Click += tsbSua_Click;
            // tsbXoa
            tsbXoa.Name = "tsbXoa";
            tsbXoa.Size = new Size(38, 22);
            tsbXoa.Text = "Xóa";
            tsbXoa.Click += tsbXoa_Click;
            // tsSep1
            tsSep1.Name = "tsSep1";
            tsSep1.Size = new Size(6, 25);
            // tsbLamMoi
            tsbLamMoi.Name = "tsbLamMoi";
            tsbLamMoi.Size = new Size(62, 22);
            tsbLamMoi.Text = "Làm mới";
            tsbLamMoi.Click += tsbLamMoi_Click;
            // tsSep2
            tsSep2.Name = "tsSep2";
            tsSep2.Size = new Size(6, 25);
            // tslTimKiem
            tslTimKiem.Name = "tslTimKiem";
            tslTimKiem.Size = new Size(63, 22);
            tslTimKiem.Text = "Tìm kiếm:";
            // txtTimKiem
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 25);
            // tsbTimKiem
            tsbTimKiem.Name = "tsbTimKiem";
            tsbTimKiem.Size = new Size(66, 22);
            tsbTimKiem.Text = "Tìm kiếm";
            tsbTimKiem.Click += tsbTimKiem_Click;
            // statusStrip1
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblSoLuong });
            statusStrip1.Location = new Point(0, 658);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1040, 22);
            statusStrip1.TabIndex = 2;
            // lblStatus
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(892, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // lblSoLuong
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(133, 17);
            lblSoLuong.Text = "Số lượng: 0";
            // grpThongTin
            grpThongTin.Controls.Add(btnChonAnh);
            grpThongTin.Controls.Add(picAnh);
            grpThongTin.Controls.Add(chkConKinhDoanh);
            grpThongTin.Controls.Add(dtpNgayNhap);
            grpThongTin.Controls.Add(lblNgayNhap);
            grpThongTin.Controls.Add(numSoLuong);
            grpThongTin.Controls.Add(lblSoLuongNhap);
            grpThongTin.Controls.Add(numDonGia);
            grpThongTin.Controls.Add(lblDonGia);
            grpThongTin.Controls.Add(cboLoaiSP);
            grpThongTin.Controls.Add(lblLoaiSP);
            grpThongTin.Controls.Add(txtTenSP);
            grpThongTin.Controls.Add(lblTenSP);
            grpThongTin.Controls.Add(txtMaSP);
            grpThongTin.Controls.Add(lblMaSP);
            grpThongTin.Font = new Font("Segoe UI", 9F);
            grpThongTin.Location = new Point(12, 58);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(300, 585);
            grpThongTin.TabIndex = 3;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sản phẩm";
            // lblMaSP
            lblMaSP.Location = new Point(10, 30);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(90, 23);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã SP";
            // txtMaSP
            txtMaSP.Location = new Point(105, 27);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(180, 23);
            txtMaSP.TabIndex = 1;
            // lblTenSP
            lblTenSP.Location = new Point(10, 65);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(90, 23);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên SP";
            // txtTenSP
            txtTenSP.Location = new Point(105, 62);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(180, 23);
            txtTenSP.TabIndex = 3;
            // lblLoaiSP
            lblLoaiSP.Location = new Point(10, 100);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(90, 23);
            lblLoaiSP.TabIndex = 4;
            lblLoaiSP.Text = "Loại SP";
            // cboLoaiSP
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Location = new Point(105, 97);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(180, 23);
            cboLoaiSP.TabIndex = 5;
            // lblDonGia
            lblDonGia.Location = new Point(10, 135);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(90, 23);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn giá";
            // numDonGia
            numDonGia.Location = new Point(105, 132);
            numDonGia.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(180, 23);
            numDonGia.TabIndex = 7;
            numDonGia.ThousandsSeparator = true;
            // lblSoLuongNhap
            lblSoLuongNhap.Location = new Point(10, 170);
            lblSoLuongNhap.Name = "lblSoLuongNhap";
            lblSoLuongNhap.Size = new Size(90, 23);
            lblSoLuongNhap.TabIndex = 8;
            lblSoLuongNhap.Text = "Số lượng";
            // numSoLuong
            numSoLuong.Location = new Point(105, 167);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(180, 23);
            numSoLuong.TabIndex = 9;
            // lblNgayNhap
            lblNgayNhap.Location = new Point(10, 205);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(90, 23);
            lblNgayNhap.TabIndex = 10;
            lblNgayNhap.Text = "Ngày nhập";
            // dtpNgayNhap
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(105, 202);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(180, 23);
            dtpNgayNhap.TabIndex = 11;
            // chkConKinhDoanh
            chkConKinhDoanh.Location = new Point(105, 237);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(180, 24);
            chkConKinhDoanh.TabIndex = 12;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            // picAnh
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(10, 275);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(275, 230);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 13;
            picAnh.TabStop = false;
            // btnChonAnh
            btnChonAnh.Location = new Point(10, 515);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(275, 30);
            btnChonAnh.TabIndex = 14;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // dgvProducts
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ContextMenuStrip = cmsGrid;
            dgvProducts.Location = new Point(325, 58);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(700, 585);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.MouseDown += dgvProducts_MouseDown;
            // cmsGrid
            cmsGrid.Items.AddRange(new ToolStripItem[] { mnuCtxSua, mnuCtxXoa, mnuCtxChiTiet });
            cmsGrid.Name = "cmsGrid";
            cmsGrid.Size = new Size(181, 70);
            // mnuCtxSua
            mnuCtxSua.Name = "mnuCtxSua";
            mnuCtxSua.Text = "Sửa";
            mnuCtxSua.Click += mnuCtxSua_Click;
            // mnuCtxXoa
            mnuCtxXoa.Name = "mnuCtxXoa";
            mnuCtxXoa.Text = "Xóa";
            mnuCtxXoa.Click += tsbXoa_Click;
            // mnuCtxChiTiet
            mnuCtxChiTiet.Name = "mnuCtxChiTiet";
            mnuCtxChiTiet.Text = "Xem chi tiết";
            mnuCtxChiTiet.Click += mnuCtxChiTiet_Click;
            // openFileDialog1
            openFileDialog1.Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp|*.*";
            // errProvider
            errProvider.ContainerControl = this;
            // FrmProduct
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 680);
            Controls.Add(grpThongTin);
            Controls.Add(dgvProducts);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += FrmProduct_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            cmsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuThem;
        private ToolStripMenuItem mnuSua;
        private ToolStripMenuItem mnuXoa;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripMenuItem mnuLamMoi;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuGioiThieu;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbThem;
        private ToolStripButton tsbSua;
        private ToolStripButton tsbXoa;
        private ToolStripSeparator tsSep1;
        private ToolStripButton tsbLamMoi;
        private ToolStripSeparator tsSep2;
        private ToolStripLabel tslTimKiem;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton tsbTimKiem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblSoLuong;
        private GroupBox grpThongTin;
        private Label lblMaSP;
        private TextBox txtMaSP;
        private Label lblTenSP;
        private TextBox txtTenSP;
        private Label lblLoaiSP;
        private ComboBox cboLoaiSP;
        private Label lblDonGia;
        private NumericUpDown numDonGia;
        private Label lblSoLuongNhap;
        private NumericUpDown numSoLuong;
        private Label lblNgayNhap;
        private DateTimePicker dtpNgayNhap;
        private CheckBox chkConKinhDoanh;
        private PictureBox picAnh;
        private Button btnChonAnh;
        private DataGridView dgvProducts;
        private ContextMenuStrip cmsGrid;
        private ToolStripMenuItem mnuCtxSua;
        private ToolStripMenuItem mnuCtxXoa;
        private ToolStripMenuItem mnuCtxChiTiet;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errProvider;
    }
}
