namespace ShopManagerMini.Forms
{
    partial class FrmMain
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
            mnuHeThong = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuQuanLySanPham = new ToolStripMenuItem();
            mnuQuanLyKhachHang = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuGioiThieu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblNguoiDung = new ToolStripStatusLabel();
            lblVaiTro = new ToolStripStatusLabel();
            lblThoiGian = new ToolStripStatusLabel();
            timerThoiGian = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // menuStrip1
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 0;
            // mnuHeThong
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Text = "Hệ thống";
            // mnuDangXuat
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // mnuThoat
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // mnuDanhMuc
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLySanPham, mnuQuanLyKhachHang });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Text = "Danh mục";
            // mnuQuanLySanPham
            mnuQuanLySanPham.Name = "mnuQuanLySanPham";
            mnuQuanLySanPham.Text = "Quản lý sản phẩm";
            mnuQuanLySanPham.Click += mnuQuanLySanPham_Click;
            // mnuQuanLyKhachHang
            mnuQuanLyKhachHang.Name = "mnuQuanLyKhachHang";
            mnuQuanLyKhachHang.Text = "Quản lý khách hàng";
            mnuQuanLyKhachHang.Click += mnuQuanLyKhachHang_Click;
            // mnuTroGiup
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuGioiThieu });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Text = "Trợ giúp";
            // mnuGioiThieu
            mnuGioiThieu.Name = "mnuGioiThieu";
            mnuGioiThieu.Text = "Giới thiệu";
            mnuGioiThieu.Click += mnuGioiThieu_Click;
            // statusStrip1
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblNguoiDung, lblVaiTro, lblThoiGian });
            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 1;
            // lblNguoiDung
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(700, 17);
            lblNguoiDung.Spring = true;
            lblNguoiDung.Text = "Người dùng:";
            lblNguoiDung.TextAlign = ContentAlignment.MiddleLeft;
            // lblVaiTro
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(100, 17);
            lblVaiTro.Text = "Vai trò:";
            // lblThoiGian
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(130, 17);
            lblThoiGian.Text = "Thời gian";
            // timerThoiGian
            timerThoiGian.Enabled = true;
            timerThoiGian.Interval = 1000;
            timerThoiGian.Tick += timerThoiGian_Tick;
            // FrmMain
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopManagerMini - Quản lý cửa hàng mini";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuQuanLySanPham;
        private ToolStripMenuItem mnuQuanLyKhachHang;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuGioiThieu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblNguoiDung;
        private ToolStripStatusLabel lblVaiTro;
        private ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.Timer timerThoiGian;
    }
}
