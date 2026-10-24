using System.Drawing;
using System.Windows.Forms;

namespace QLSinhVienLab12.Forms
{
    partial class FrmNhapDiemTheoLop
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsLop = new BindingSource(components);
            bsMonHoc = new BindingSource(components);
            bsKetQua = new BindingSource(components);
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            tlpMain = new TableLayoutPanel();
            grpBoLoc = new GroupBox();
            tlpBoLoc = new TableLayoutPanel();
            lblLop = new Label();
            cboLop = new ComboBox();
            lblMonHoc = new Label();
            cboMonHoc = new ComboBox();
            btnTaiDanhSach = new Button();
            grpKetQua = new GroupBox();
            dgvKetQua = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            pnlLuu = new Panel();
            lblHuongDan = new Label();
            btnLuuTatCa = new Button();
            stsTrangThai = new StatusStrip();
            tslSiSo = new ToolStripStatusLabel();
            tslDaNhap = new ToolStripStatusLabel();
            tslDiemTrungBinh = new ToolStripStatusLabel();
            tslTrangThai = new ToolStripStatusLabel();

            var kieuTieuDe = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(31, 78, 140),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(31, 78, 140),
                SelectionForeColor = Color.White,
                WrapMode = DataGridViewTriState.False
            };
            var kieuDong = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(214, 228, 247),
                SelectionForeColor = Color.Black
            };
            var kieuDongXen = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(244, 247, 252),
                SelectionBackColor = Color.FromArgb(214, 228, 247),
                SelectionForeColor = Color.Black
            };
            var kieuODiem = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(255, 251, 235),
                Format = "0.0#"
            };
            var kieuOGhiChu = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 251, 235)
            };

            ((System.ComponentModel.ISupportInitialize)bsLop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMonHoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsKetQua).BeginInit();
            pnlTieuDe.SuspendLayout();
            tlpMain.SuspendLayout();
            grpBoLoc.SuspendLayout();
            tlpBoLoc.SuspendLayout();
            grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            pnlLuu.SuspendLayout();
            stsTrangThai.SuspendLayout();
            SuspendLayout();

            pnlTieuDe.BackColor = Color.FromArgb(31, 78, 140);
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Controls.Add(lblPhuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1000, 68);
            pnlTieuDe.TabIndex = 1;

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(20, 8);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "NHẬP ĐIỂM THEO LỚP";

            lblPhuDe.AutoSize = true;
            lblPhuDe.Font = new Font("Segoe UI", 9.5F);
            lblPhuDe.ForeColor = Color.FromArgb(200, 215, 235);
            lblPhuDe.Location = new Point(23, 40);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Text = "Quản lý kết quả học tập - QLSinhVienLab12";

            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(grpBoLoc, 0, 0);
            tlpMain.Controls.Add(grpKetQua, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.TabIndex = 0;

            grpBoLoc.Controls.Add(tlpBoLoc);
            grpBoLoc.Dock = DockStyle.Fill;
            grpBoLoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBoLoc.ForeColor = Color.FromArgb(31, 78, 140);
            grpBoLoc.Margin = new Padding(0, 0, 0, 8);
            grpBoLoc.Name = "grpBoLoc";
            grpBoLoc.Padding = new Padding(10, 4, 10, 8);
            grpBoLoc.TabIndex = 0;
            grpBoLoc.TabStop = false;
            grpBoLoc.Text = "Chọn lớp và môn học";

            tlpBoLoc.ColumnCount = 5;
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tlpBoLoc.Controls.Add(lblLop, 0, 0);
            tlpBoLoc.Controls.Add(cboLop, 1, 0);
            tlpBoLoc.Controls.Add(lblMonHoc, 2, 0);
            tlpBoLoc.Controls.Add(cboMonHoc, 3, 0);
            tlpBoLoc.Controls.Add(btnTaiDanhSach, 4, 0);
            tlpBoLoc.Dock = DockStyle.Fill;
            tlpBoLoc.Font = new Font("Segoe UI", 10F);
            tlpBoLoc.ForeColor = SystemColors.ControlText;
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 1;
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBoLoc.TabIndex = 0;

            lblLop.Anchor = AnchorStyles.Left;
            lblLop.AutoSize = true;
            lblLop.Name = "lblLop";
            lblLop.Text = "Lớp:";

            cboLop.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboLop.DataSource = bsLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Margin = new Padding(3, 3, 24, 3);
            cboLop.Name = "cboLop";
            cboLop.TabIndex = 0;
            cboLop.ValueMember = "MaLop";

            lblMonHoc.Anchor = AnchorStyles.Left;
            lblMonHoc.AutoSize = true;
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Text = "Môn học:";

            cboMonHoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboMonHoc.DataSource = bsMonHoc;
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Margin = new Padding(3, 3, 24, 3);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.TabIndex = 1;
            cboMonHoc.ValueMember = "MaMon";

            btnTaiDanhSach.BackColor = Color.FromArgb(31, 78, 140);
            btnTaiDanhSach.Cursor = Cursors.Hand;
            btnTaiDanhSach.Dock = DockStyle.Fill;
            btnTaiDanhSach.FlatAppearance.BorderSize = 0;
            btnTaiDanhSach.FlatStyle = FlatStyle.Flat;
            btnTaiDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaiDanhSach.ForeColor = Color.White;
            btnTaiDanhSach.Margin = new Padding(3, 3, 0, 3);
            btnTaiDanhSach.Name = "btnTaiDanhSach";
            btnTaiDanhSach.TabIndex = 2;
            btnTaiDanhSach.Text = "Tải danh sách";
            btnTaiDanhSach.UseVisualStyleBackColor = false;
            btnTaiDanhSach.Click += btnTaiDanhSach_Click;

            grpKetQua.Controls.Add(dgvKetQua);
            grpKetQua.Controls.Add(pnlLuu);
            grpKetQua.Dock = DockStyle.Fill;
            grpKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpKetQua.ForeColor = Color.FromArgb(31, 78, 140);
            grpKetQua.Margin = new Padding(0);
            grpKetQua.Name = "grpKetQua";
            grpKetQua.Padding = new Padding(10, 6, 10, 10);
            grpKetQua.TabIndex = 1;
            grpKetQua.TabStop = false;
            grpKetQua.Text = "Danh sách sinh viên";

            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AllowUserToDeleteRows = false;
            dgvKetQua.AllowUserToResizeRows = false;
            dgvKetQua.AlternatingRowsDefaultCellStyle = kieuDongXen;
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.BackgroundColor = Color.White;
            dgvKetQua.BorderStyle = BorderStyle.None;
            dgvKetQua.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKetQua.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKetQua.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            dgvKetQua.ColumnHeadersHeight = 36;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colDiem, colGhiChu });
            dgvKetQua.DataSource = bsKetQua;
            dgvKetQua.DefaultCellStyle = kieuDong;
            dgvKetQua.Dock = DockStyle.Fill;
            dgvKetQua.EnableHeadersVisualStyles = false;
            dgvKetQua.Font = new Font("Segoe UI", 10F);
            dgvKetQua.GridColor = Color.FromArgb(225, 230, 238);
            dgvKetQua.MultiSelect = false;
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKetQua.RowHeadersDefaultCellStyle = kieuTieuDe;
            dgvKetQua.RowHeadersWidth = 32;
            dgvKetQua.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvKetQua.RowTemplate.Height = 30;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvKetQua.TabIndex = 3;
            dgvKetQua.CellEndEdit += dgvKetQua_CellEndEdit;
            dgvKetQua.CellFormatting += dgvKetQua_CellFormatting;
            dgvKetQua.CellValidating += dgvKetQua_CellValidating;
            dgvKetQua.DataError += dgvKetQua_DataError;

            colMaSV.DataPropertyName = "MaSV";
            colMaSV.FillWeight = 20F;
            colMaSV.HeaderText = "Mã SV";
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;

            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 34F;
            colHoTen.HeaderText = "Họ tên";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;

            colDiem.DataPropertyName = "Diem";
            colDiem.DefaultCellStyle = kieuODiem;
            colDiem.FillWeight = 14F;
            colDiem.HeaderText = "Điểm (0 - 10)";
            colDiem.Name = "colDiem";

            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.DefaultCellStyle = kieuOGhiChu;
            colGhiChu.FillWeight = 32F;
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.MaxInputLength = 200;
            colGhiChu.Name = "colGhiChu";

            pnlLuu.Controls.Add(lblHuongDan);
            pnlLuu.Controls.Add(btnLuuTatCa);
            pnlLuu.Dock = DockStyle.Bottom;
            pnlLuu.Name = "pnlLuu";
            pnlLuu.Padding = new Padding(0, 12, 0, 0);
            pnlLuu.Size = new Size(960, 58);
            pnlLuu.TabIndex = 4;

            lblHuongDan.Dock = DockStyle.Fill;
            lblHuongDan.Font = new Font("Segoe UI", 9F);
            lblHuongDan.ForeColor = Color.DimGray;
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Text = "Nhập điểm từ 0 đến 10 cho từng sinh viên (ô nền vàng nhạt có thể chỉnh sửa). "
                + "Chỉ lưu khi mọi dòng đều hợp lệ; nếu có lỗi, toàn bộ thao tác lưu sẽ bị hủy.";
            lblHuongDan.TextAlign = ContentAlignment.MiddleLeft;

            btnLuuTatCa.BackColor = Color.FromArgb(40, 140, 90);
            btnLuuTatCa.Cursor = Cursors.Hand;
            btnLuuTatCa.Dock = DockStyle.Right;
            btnLuuTatCa.Enabled = false;
            btnLuuTatCa.FlatAppearance.BorderSize = 0;
            btnLuuTatCa.FlatStyle = FlatStyle.Flat;
            btnLuuTatCa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuuTatCa.ForeColor = Color.White;
            btnLuuTatCa.Name = "btnLuuTatCa";
            btnLuuTatCa.Size = new Size(190, 46);
            btnLuuTatCa.TabIndex = 4;
            btnLuuTatCa.Text = "Lưu tất cả";
            btnLuuTatCa.UseVisualStyleBackColor = false;
            btnLuuTatCa.Click += btnLuuTatCa_Click;

            stsTrangThai.BackColor = Color.FromArgb(236, 240, 246);
            stsTrangThai.Font = new Font("Segoe UI", 10F);
            stsTrangThai.Items.AddRange(new ToolStripItem[] { tslSiSo, tslDaNhap, tslDiemTrungBinh, tslTrangThai });
            stsTrangThai.Name = "stsTrangThai";
            stsTrangThai.SizingGrip = false;
            stsTrangThai.TabIndex = 2;

            tslSiSo.Margin = new Padding(8, 3, 20, 2);
            tslSiSo.Name = "tslSiSo";
            tslSiSo.Text = "Sĩ số: 0";

            tslDaNhap.Margin = new Padding(0, 3, 20, 2);
            tslDaNhap.Name = "tslDaNhap";
            tslDaNhap.Text = "Đã nhập điểm: 0";

            tslDiemTrungBinh.Margin = new Padding(0, 3, 20, 2);
            tslDiemTrungBinh.Name = "tslDiemTrungBinh";
            tslDiemTrungBinh.Text = "Điểm trung bình: --";

            tslTrangThai.ForeColor = Color.FromArgb(31, 78, 140);
            tslTrangThai.Margin = new Padding(0, 3, 8, 2);
            tslTrangThai.Name = "tslTrangThai";
            tslTrangThai.Spring = true;
            tslTrangThai.Text = "Sẵn sàng";
            tslTrangThai.TextAlign = ContentAlignment.MiddleRight;

            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1000, 640);
            Controls.Add(tlpMain);
            Controls.Add(pnlTieuDe);
            Controls.Add(stsTrangThai);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(920, 580);
            Name = "FrmNhapDiemTheoLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLSinhVienLab12 - Nhập điểm theo lớp";
            Load += FrmNhapDiemTheoLop_Load;

            ((System.ComponentModel.ISupportInitialize)bsLop).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMonHoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsKetQua).EndInit();
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            tlpMain.ResumeLayout(false);
            grpBoLoc.ResumeLayout(false);
            tlpBoLoc.ResumeLayout(false);
            tlpBoLoc.PerformLayout();
            grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            pnlLuu.ResumeLayout(false);
            stsTrangThai.ResumeLayout(false);
            stsTrangThai.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private BindingSource bsLop;
        private BindingSource bsMonHoc;
        private BindingSource bsKetQua;
        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblPhuDe;
        private TableLayoutPanel tlpMain;
        private GroupBox grpBoLoc;
        private TableLayoutPanel tlpBoLoc;
        private Label lblLop;
        private ComboBox cboLop;
        private Label lblMonHoc;
        private ComboBox cboMonHoc;
        private Button btnTaiDanhSach;
        private GroupBox grpKetQua;
        private DataGridView dgvKetQua;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colGhiChu;
        private Panel pnlLuu;
        private Label lblHuongDan;
        private Button btnLuuTatCa;
        private StatusStrip stsTrangThai;
        private ToolStripStatusLabel tslSiSo;
        private ToolStripStatusLabel tslDaNhap;
        private ToolStripStatusLabel tslDiemTrungBinh;
        private ToolStripStatusLabel tslTrangThai;
    }
}
