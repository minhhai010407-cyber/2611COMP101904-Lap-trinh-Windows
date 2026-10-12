namespace COMP1019_Lab08_SimplePaint
{
    partial class FrmPaint
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
            pnlToolbar = new Panel();
            lblMode = new Label();
            cboMode = new ComboBox();
            lblWidth = new Label();
            nudWidth = new NumericUpDown();
            btnColor = new Button();
            pnlColor = new Panel();
            chkFill = new CheckBox();
            btnBackColor = new Button();
            btnOpenImage = new Button();
            btnSave = new Button();
            btnUndo = new Button();
            btnClear = new Button();
            pnlStatus = new Panel();
            lblStatus = new Label();
            lblCount = new Label();
            pnlCanvasHost = new Panel();
            canvas = new DoubleBufferedPanel();
            colorDialog = new ColorDialog();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            pnlStatus.SuspendLayout();
            pnlCanvasHost.SuspendLayout();
            SuspendLayout();
            // pnlToolbar
            pnlToolbar.BackColor = Color.FromArgb(45, 36, 82);
            pnlToolbar.Controls.Add(btnClear);
            pnlToolbar.Controls.Add(btnUndo);
            pnlToolbar.Controls.Add(btnSave);
            pnlToolbar.Controls.Add(btnOpenImage);
            pnlToolbar.Controls.Add(btnBackColor);
            pnlToolbar.Controls.Add(chkFill);
            pnlToolbar.Controls.Add(pnlColor);
            pnlToolbar.Controls.Add(btnColor);
            pnlToolbar.Controls.Add(nudWidth);
            pnlToolbar.Controls.Add(lblWidth);
            pnlToolbar.Controls.Add(cboMode);
            pnlToolbar.Controls.Add(lblMode);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1100, 64);
            pnlToolbar.TabIndex = 0;
            // lblMode
            lblMode.ForeColor = Color.White;
            lblMode.Location = new Point(16, 21);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(52, 23);
            lblMode.TabIndex = 0;
            lblMode.Text = "Chế độ";
            lblMode.TextAlign = ContentAlignment.MiddleLeft;
            // cboMode
            cboMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMode.FlatStyle = FlatStyle.Flat;
            cboMode.Location = new Point(72, 20);
            cboMode.Name = "cboMode";
            cboMode.Size = new Size(110, 25);
            cboMode.TabIndex = 1;
            cboMode.SelectedIndexChanged += cboMode_SelectedIndexChanged;
            // lblWidth
            lblWidth.ForeColor = Color.White;
            lblWidth.Location = new Point(196, 21);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(52, 23);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Độ dày";
            lblWidth.TextAlign = ContentAlignment.MiddleLeft;
            // nudWidth
            nudWidth.Location = new Point(252, 20);
            nudWidth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(60, 25);
            nudWidth.TabIndex = 3;
            nudWidth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // btnColor
            btnColor.BackColor = Color.FromArgb(124, 58, 237);
            btnColor.Cursor = Cursors.Hand;
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnColor.ForeColor = Color.White;
            btnColor.Location = new Point(328, 13);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 38);
            btnColor.TabIndex = 4;
            btnColor.Text = "Chọn màu";
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // pnlColor
            pnlColor.BackColor = Color.Black;
            pnlColor.BorderStyle = BorderStyle.FixedSingle;
            pnlColor.Location = new Point(436, 18);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(28, 28);
            pnlColor.TabIndex = 5;
            // chkFill
            chkFill.Enabled = false;
            chkFill.ForeColor = Color.White;
            chkFill.Location = new Point(478, 21);
            chkFill.Name = "chkFill";
            chkFill.Size = new Size(75, 23);
            chkFill.TabIndex = 6;
            chkFill.Text = "Tô màu";
            // btnBackColor
            btnBackColor.BackColor = Color.FromArgb(99, 102, 241);
            btnBackColor.Cursor = Cursors.Hand;
            btnBackColor.FlatAppearance.BorderSize = 0;
            btnBackColor.FlatStyle = FlatStyle.Flat;
            btnBackColor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBackColor.ForeColor = Color.White;
            btnBackColor.Location = new Point(558, 13);
            btnBackColor.Name = "btnBackColor";
            btnBackColor.Size = new Size(100, 38);
            btnBackColor.TabIndex = 7;
            btnBackColor.Text = "Màu nền";
            btnBackColor.UseVisualStyleBackColor = false;
            btnBackColor.Click += btnBackColor_Click;
            // btnOpenImage
            btnOpenImage.BackColor = Color.FromArgb(14, 165, 233);
            btnOpenImage.Cursor = Cursors.Hand;
            btnOpenImage.FlatAppearance.BorderSize = 0;
            btnOpenImage.FlatStyle = FlatStyle.Flat;
            btnOpenImage.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOpenImage.ForeColor = Color.White;
            btnOpenImage.Location = new Point(666, 13);
            btnOpenImage.Name = "btnOpenImage";
            btnOpenImage.Size = new Size(105, 38);
            btnOpenImage.TabIndex = 8;
            btnOpenImage.Text = "Mở ảnh nền";
            btnOpenImage.UseVisualStyleBackColor = false;
            btnOpenImage.Click += btnOpenImage_Click;
            // btnSave
            btnSave.BackColor = Color.FromArgb(34, 197, 94);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(779, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 38);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu PNG";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // btnUndo
            btnUndo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUndo.BackColor = Color.FromArgb(245, 158, 11);
            btnUndo.Cursor = Cursors.Hand;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUndo.ForeColor = Color.White;
            btnUndo.Location = new Point(896, 13);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(90, 38);
            btnUndo.TabIndex = 10;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // btnClear
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(239, 68, 68);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(994, 13);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 38);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // pnlStatus
            pnlStatus.BackColor = Color.FromArgb(232, 227, 246);
            pnlStatus.Controls.Add(lblCount);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Dock = DockStyle.Bottom;
            pnlStatus.Location = new Point(0, 690);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(1100, 30);
            pnlStatus.TabIndex = 2;
            // lblStatus
            lblStatus.ForeColor = Color.FromArgb(45, 36, 82);
            lblStatus.Location = new Point(16, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 30);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Tọa độ: -";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // lblCount
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCount.ForeColor = Color.FromArgb(45, 36, 82);
            lblCount.Location = new Point(934, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(150, 30);
            lblCount.TabIndex = 1;
            lblCount.Text = "Số nét vẽ: 0";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            // pnlCanvasHost
            pnlCanvasHost.BackColor = Color.FromArgb(243, 240, 250);
            pnlCanvasHost.Controls.Add(canvas);
            pnlCanvasHost.Dock = DockStyle.Fill;
            pnlCanvasHost.Location = new Point(0, 64);
            pnlCanvasHost.Name = "pnlCanvasHost";
            pnlCanvasHost.Padding = new Padding(14);
            pnlCanvasHost.Size = new Size(1100, 626);
            pnlCanvasHost.TabIndex = 1;
            // canvas
            canvas.BackColor = Color.White;
            canvas.BorderStyle = BorderStyle.FixedSingle;
            canvas.Cursor = Cursors.Cross;
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(14, 14);
            canvas.Name = "canvas";
            canvas.Size = new Size(1072, 598);
            canvas.TabIndex = 0;
            canvas.Paint += canvas_Paint;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseLeave += canvas_MouseLeave;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // colorDialog
            colorDialog.FullOpen = true;
            // openFileDialog
            openFileDialog.Filter = "Tệp ảnh|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Tất cả tệp|*.*";
            openFileDialog.Title = "Chọn ảnh nền";
            // saveFileDialog
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.FileName = "SimplePaint.png";
            saveFileDialog.Filter = "Ảnh PNG|*.png";
            saveFileDialog.Title = "Lưu vùng vẽ";
            // toolTip1
            toolTip1.SetToolTip(btnColor, "Chọn màu nét vẽ");
            toolTip1.SetToolTip(btnBackColor, "Đổi màu nền vùng vẽ");
            toolTip1.SetToolTip(btnOpenImage, "Mở ảnh làm nền để vẽ đè lên");
            toolTip1.SetToolTip(btnSave, "Lưu vùng vẽ ra file PNG");
            toolTip1.SetToolTip(btnUndo, "Xóa nét vẽ gần nhất (Ctrl+Z)");
            toolTip1.SetToolTip(btnClear, "Xóa toàn bộ vùng vẽ");
            toolTip1.SetToolTip(chkFill, "Tô màu cho hình chữ nhật và ellipse");
            // FrmPaint
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 250);
            ClientSize = new Size(1100, 720);
            Controls.Add(pnlCanvasHost);
            Controls.Add(pnlStatus);
            Controls.Add(pnlToolbar);
            Font = new Font("Segoe UI", 9.5F);
            KeyPreview = true;
            MinimumSize = new Size(1120, 560);
            Name = "FrmPaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Paint - COMP1019 Lab 08";
            FormClosed += FrmPaint_FormClosed;
            Load += FrmPaint_Load;
            KeyDown += FrmPaint_KeyDown;
            pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlCanvasHost.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlToolbar;
        private Label lblMode;
        private ComboBox cboMode;
        private Label lblWidth;
        private NumericUpDown nudWidth;
        private Button btnColor;
        private Panel pnlColor;
        private CheckBox chkFill;
        private Button btnBackColor;
        private Button btnOpenImage;
        private Button btnSave;
        private Button btnUndo;
        private Button btnClear;
        private Panel pnlStatus;
        private Label lblStatus;
        private Label lblCount;
        private Panel pnlCanvasHost;
        private DoubleBufferedPanel canvas;
        private ColorDialog colorDialog;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolTip toolTip1;
    }
}
