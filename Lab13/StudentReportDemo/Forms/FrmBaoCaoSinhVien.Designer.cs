using System.Drawing;
using System.Windows.Forms;

namespace StudentReportDemo.Forms
{
    partial class FrmBaoCaoSinhVien
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
            tlpMain = new TableLayoutPanel();
            grpBoLoc = new GroupBox();
            tlpBoLoc = new TableLayoutPanel();
            lblLop = new Label();
            cboLop = new ComboBox();
            lblKetQua = new Label();
            cboKetQua = new ComboBox();
            lblTuKhoa = new Label();
            txtTuKhoa = new TextBox();
            flpChucNang = new FlowLayoutPanel();
            btnXemBaoCao = new Button();
            btnThongKe = new Button();
            btnXuatFile = new Button();
            grpKetQua = new GroupBox();
            dgvBaoCao = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colMaLop = new DataGridViewTextBoxColumn();
            colTenLop = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colKetQua = new DataGridViewTextBoxColumn();
            colTkMaLop = new DataGridViewTextBoxColumn();
            colTkTenLop = new DataGridViewTextBoxColumn();
            colTkSoSinhVien = new DataGridViewTextBoxColumn();
            colTkSoDat = new DataGridViewTextBoxColumn();
            colTkSoKhongDat = new DataGridViewTextBoxColumn();
            colTkDiemTrungBinh = new DataGridViewTextBoxColumn();
            stsThongKe = new StatusStrip();
            tslTongSo = new ToolStripStatusLabel();
            tslSoDat = new ToolStripStatusLabel();
            tslSoKhongDat = new ToolStripStatusLabel();
            tslDiemTrungBinh = new ToolStripStatusLabel();
            sfdBaoCao = new SaveFileDialog();

            var canGiua = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            var canGiuaDiem = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "0.00"
            };
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

            tlpMain.SuspendLayout();
            grpBoLoc.SuspendLayout();
            tlpBoLoc.SuspendLayout();
            flpChucNang.SuspendLayout();
            grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            stsThongKe.SuspendLayout();
            SuspendLayout();

            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(grpBoLoc, 0, 0);
            tlpMain.Controls.Add(grpKetQua, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
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
            grpBoLoc.Text = "Điều kiện báo cáo";

            tlpBoLoc.ColumnCount = 6;
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpBoLoc.Controls.Add(lblLop, 0, 0);
            tlpBoLoc.Controls.Add(cboLop, 1, 0);
            tlpBoLoc.Controls.Add(lblKetQua, 2, 0);
            tlpBoLoc.Controls.Add(cboKetQua, 3, 0);
            tlpBoLoc.Controls.Add(lblTuKhoa, 4, 0);
            tlpBoLoc.Controls.Add(txtTuKhoa, 5, 0);
            tlpBoLoc.Controls.Add(flpChucNang, 0, 1);
            tlpBoLoc.Dock = DockStyle.Fill;
            tlpBoLoc.Font = new Font("Segoe UI", 10F);
            tlpBoLoc.ForeColor = SystemColors.ControlText;
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 2;
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBoLoc.TabIndex = 0;

            lblLop.Anchor = AnchorStyles.Left;
            lblLop.AutoSize = true;
            lblLop.Name = "lblLop";
            lblLop.Text = "Lớp:";

            cboLop.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Margin = new Padding(3, 3, 20, 3);
            cboLop.Name = "cboLop";
            cboLop.TabIndex = 0;

            lblKetQua.Anchor = AnchorStyles.Left;
            lblKetQua.AutoSize = true;
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Text = "Kết quả:";

            cboKetQua.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboKetQua.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKetQua.FormattingEnabled = true;
            cboKetQua.Margin = new Padding(3, 3, 20, 3);
            cboKetQua.Name = "cboKetQua";
            cboKetQua.TabIndex = 1;

            lblTuKhoa.Anchor = AnchorStyles.Left;
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Text = "Từ khóa:";

            txtTuKhoa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.PlaceholderText = "Mã sinh viên hoặc họ tên";
            txtTuKhoa.TabIndex = 2;

            flpChucNang.Controls.Add(btnXemBaoCao);
            flpChucNang.Controls.Add(btnThongKe);
            flpChucNang.Controls.Add(btnXuatFile);
            flpChucNang.Dock = DockStyle.Fill;
            flpChucNang.Margin = new Padding(0);
            flpChucNang.Name = "flpChucNang";
            flpChucNang.TabIndex = 3;
            tlpBoLoc.SetColumnSpan(flpChucNang, 6);

            btnXemBaoCao.BackColor = Color.FromArgb(31, 78, 140);
            btnXemBaoCao.Cursor = Cursors.Hand;
            btnXemBaoCao.FlatAppearance.BorderSize = 0;
            btnXemBaoCao.FlatStyle = FlatStyle.Flat;
            btnXemBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXemBaoCao.ForeColor = Color.White;
            btnXemBaoCao.Margin = new Padding(3, 3, 12, 3);
            btnXemBaoCao.Name = "btnXemBaoCao";
            btnXemBaoCao.Size = new Size(150, 38);
            btnXemBaoCao.TabIndex = 0;
            btnXemBaoCao.Text = "Xem báo cáo";
            btnXemBaoCao.UseVisualStyleBackColor = false;
            btnXemBaoCao.Click += btnXemBaoCao_Click;

            btnThongKe.BackColor = Color.FromArgb(40, 140, 90);
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Margin = new Padding(3, 3, 12, 3);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(150, 38);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;

            btnXuatFile.BackColor = Color.FromArgb(226, 231, 239);
            btnXuatFile.Cursor = Cursors.Hand;
            btnXuatFile.FlatAppearance.BorderSize = 0;
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatFile.ForeColor = Color.FromArgb(40, 50, 70);
            btnXuatFile.Margin = new Padding(3, 3, 12, 3);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(150, 38);
            btnXuatFile.TabIndex = 2;
            btnXuatFile.Text = "Xuất file";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;

            grpKetQua.Controls.Add(dgvBaoCao);
            grpKetQua.Dock = DockStyle.Fill;
            grpKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpKetQua.ForeColor = Color.FromArgb(31, 78, 140);
            grpKetQua.Margin = new Padding(0);
            grpKetQua.Name = "grpKetQua";
            grpKetQua.Padding = new Padding(10, 6, 10, 10);
            grpKetQua.TabIndex = 1;
            grpKetQua.TabStop = false;
            grpKetQua.Text = "Danh sách sinh viên";

            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToDeleteRows = false;
            dgvBaoCao.AllowUserToResizeRows = false;
            dgvBaoCao.AlternatingRowsDefaultCellStyle = kieuDongXen;
            dgvBaoCao.AutoGenerateColumns = false;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = Color.White;
            dgvBaoCao.BorderStyle = BorderStyle.None;
            dgvBaoCao.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBaoCao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBaoCao.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            dgvBaoCao.ColumnHeadersHeight = 36;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBaoCao.Columns.AddRange(new DataGridViewColumn[]
            {
                colMaSV, colHoTen, colMaLop, colTenLop, colDiem, colKetQua,
                colTkMaLop, colTkTenLop, colTkSoSinhVien, colTkSoDat, colTkSoKhongDat, colTkDiemTrungBinh
            });
            dgvBaoCao.DefaultCellStyle = kieuDong;
            dgvBaoCao.Dock = DockStyle.Fill;
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.Font = new Font("Segoe UI", 10F);
            dgvBaoCao.GridColor = Color.FromArgb(225, 230, 238);
            dgvBaoCao.MultiSelect = false;
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.RowHeadersVisible = false;
            dgvBaoCao.RowTemplate.Height = 30;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.TabIndex = 0;
            dgvBaoCao.CellFormatting += dgvBaoCao_CellFormatting;

            colMaSV.DataPropertyName = "MaSV";
            colMaSV.FillWeight = 16F;
            colMaSV.HeaderText = "Mã SV";
            colMaSV.Name = "colMaSV";

            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 28F;
            colHoTen.HeaderText = "Họ tên";
            colHoTen.Name = "colHoTen";

            colMaLop.DataPropertyName = "MaLop";
            colMaLop.FillWeight = 16F;
            colMaLop.HeaderText = "Mã lớp";
            colMaLop.Name = "colMaLop";

            colTenLop.DataPropertyName = "TenLop";
            colTenLop.FillWeight = 22F;
            colTenLop.HeaderText = "Tên lớp";
            colTenLop.Name = "colTenLop";

            colDiem.DataPropertyName = "Diem";
            colDiem.DefaultCellStyle = canGiuaDiem;
            colDiem.FillWeight = 9F;
            colDiem.HeaderText = "Điểm";
            colDiem.Name = "colDiem";

            colKetQua.DataPropertyName = "KetQua";
            colKetQua.DefaultCellStyle = canGiua;
            colKetQua.FillWeight = 12F;
            colKetQua.HeaderText = "Kết quả";
            colKetQua.Name = "colKetQua";

            colTkMaLop.DataPropertyName = "MaLop";
            colTkMaLop.FillWeight = 20F;
            colTkMaLop.HeaderText = "Mã lớp";
            colTkMaLop.Name = "colTkMaLop";
            colTkMaLop.Visible = false;

            colTkTenLop.DataPropertyName = "TenLop";
            colTkTenLop.FillWeight = 28F;
            colTkTenLop.HeaderText = "Tên lớp";
            colTkTenLop.Name = "colTkTenLop";
            colTkTenLop.Visible = false;

            colTkSoSinhVien.DataPropertyName = "SoSinhVien";
            colTkSoSinhVien.DefaultCellStyle = canGiua;
            colTkSoSinhVien.FillWeight = 14F;
            colTkSoSinhVien.HeaderText = "Số sinh viên";
            colTkSoSinhVien.Name = "colTkSoSinhVien";
            colTkSoSinhVien.Visible = false;

            colTkSoDat.DataPropertyName = "SoDat";
            colTkSoDat.DefaultCellStyle = canGiua;
            colTkSoDat.FillWeight = 12F;
            colTkSoDat.HeaderText = "Số đạt";
            colTkSoDat.Name = "colTkSoDat";
            colTkSoDat.Visible = false;

            colTkSoKhongDat.DataPropertyName = "SoKhongDat";
            colTkSoKhongDat.DefaultCellStyle = canGiua;
            colTkSoKhongDat.FillWeight = 14F;
            colTkSoKhongDat.HeaderText = "Số không đạt";
            colTkSoKhongDat.Name = "colTkSoKhongDat";
            colTkSoKhongDat.Visible = false;

            colTkDiemTrungBinh.DataPropertyName = "DiemTrungBinh";
            colTkDiemTrungBinh.DefaultCellStyle = canGiuaDiem;
            colTkDiemTrungBinh.FillWeight = 14F;
            colTkDiemTrungBinh.HeaderText = "Điểm trung bình";
            colTkDiemTrungBinh.Name = "colTkDiemTrungBinh";
            colTkDiemTrungBinh.Visible = false;

            stsThongKe.BackColor = Color.FromArgb(236, 240, 246);
            stsThongKe.Font = new Font("Segoe UI", 10F);
            stsThongKe.Items.AddRange(new ToolStripItem[] { tslTongSo, tslSoDat, tslSoKhongDat, tslDiemTrungBinh });
            stsThongKe.Name = "stsThongKe";
            stsThongKe.SizingGrip = false;
            stsThongKe.TabIndex = 1;

            tslTongSo.Margin = new Padding(8, 3, 24, 2);
            tslTongSo.Name = "tslTongSo";
            tslTongSo.Text = "Tổng số sinh viên: 0";

            tslSoDat.ForeColor = Color.SeaGreen;
            tslSoDat.Margin = new Padding(0, 3, 24, 2);
            tslSoDat.Name = "tslSoDat";
            tslSoDat.Text = "Đạt: 0";

            tslSoKhongDat.ForeColor = Color.Firebrick;
            tslSoKhongDat.Margin = new Padding(0, 3, 24, 2);
            tslSoKhongDat.Name = "tslSoKhongDat";
            tslSoKhongDat.Text = "Không đạt: 0";

            tslDiemTrungBinh.Margin = new Padding(0, 3, 0, 2);
            tslDiemTrungBinh.Name = "tslDiemTrungBinh";
            tslDiemTrungBinh.Text = "Điểm trung bình: 0.00";

            sfdBaoCao.DefaultExt = "csv";
            sfdBaoCao.FileName = "BaoCaoSinhVien";
            sfdBaoCao.Filter = "CSV (*.csv)|*.csv|Text (*.txt)|*.txt";
            sfdBaoCao.Title = "Xuất báo cáo sinh viên";

            AcceptButton = btnXemBaoCao;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1000, 620);
            Controls.Add(tlpMain);
            Controls.Add(stsThongKe);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(900, 560);
            Name = "FrmBaoCaoSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COMP1019 - Lab 13: Báo cáo danh sách sinh viên theo lớp";
            Load += FrmBaoCaoSinhVien_Load;

            tlpMain.ResumeLayout(false);
            grpBoLoc.ResumeLayout(false);
            tlpBoLoc.ResumeLayout(false);
            tlpBoLoc.PerformLayout();
            flpChucNang.ResumeLayout(false);
            grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            stsThongKe.ResumeLayout(false);
            stsThongKe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tlpMain;
        private GroupBox grpBoLoc;
        private TableLayoutPanel tlpBoLoc;
        private Label lblLop;
        private ComboBox cboLop;
        private Label lblKetQua;
        private ComboBox cboKetQua;
        private Label lblTuKhoa;
        private TextBox txtTuKhoa;
        private FlowLayoutPanel flpChucNang;
        private Button btnXemBaoCao;
        private Button btnThongKe;
        private Button btnXuatFile;
        private GroupBox grpKetQua;
        private DataGridView dgvBaoCao;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colMaLop;
        private DataGridViewTextBoxColumn colTenLop;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colKetQua;
        private DataGridViewTextBoxColumn colTkMaLop;
        private DataGridViewTextBoxColumn colTkTenLop;
        private DataGridViewTextBoxColumn colTkSoSinhVien;
        private DataGridViewTextBoxColumn colTkSoDat;
        private DataGridViewTextBoxColumn colTkSoKhongDat;
        private DataGridViewTextBoxColumn colTkDiemTrungBinh;
        private StatusStrip stsThongKe;
        private ToolStripStatusLabel tslTongSo;
        private ToolStripStatusLabel tslSoDat;
        private ToolStripStatusLabel tslSoKhongDat;
        private ToolStripStatusLabel tslDiemTrungBinh;
        private SaveFileDialog sfdBaoCao;
    }
}
