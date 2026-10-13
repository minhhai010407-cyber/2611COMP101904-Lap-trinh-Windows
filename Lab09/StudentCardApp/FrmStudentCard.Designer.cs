using System;
using System.Drawing;
using System.Windows.Forms;
using StudentCardApp.CustomControls;

namespace StudentCardApp
{
    partial class FrmStudentCard
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            tlpLeft = new TableLayoutPanel();
            grpStudentInfo = new GroupBox();
            tlpInfo = new TableLayoutPanel();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblClass = new Label();
            cboClass = new ComboBox();
            lblFaculty = new Label();
            cboFaculty = new ComboBox();
            lblCourse = new Label();
            cboCourse = new ComboBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblGender = new Label();
            cboGender = new ComboBox();
            grpAvatar = new GroupBox();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            lblAvatarHint = new Label();
            tlpActions = new TableLayoutPanel();
            btnPrintPreview = new Button();
            btnPrint = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpPreview = new GroupBox();
            pnlCardPreview = new BufferedPanel();
            ofdAvatar = new OpenFileDialog();
            printDocCard = new System.Drawing.Printing.PrintDocument();

            tlpMain.SuspendLayout();
            tlpLeft.SuspendLayout();
            grpStudentInfo.SuspendLayout();
            tlpInfo.SuspendLayout();
            grpAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            tlpActions.SuspendLayout();
            grpPreview.SuspendLayout();
            SuspendLayout();

            // tlpMain: chia form thành vùng nhập liệu (trái) và vùng xem trước (phải)
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpLeft, 0, 0);
            tlpMain.Controls.Add(grpPreview, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.TabIndex = 0;

            // tlpLeft: nhóm thông tin, nhóm ảnh, nhóm nút
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.Controls.Add(grpStudentInfo, 0, 0);
            tlpLeft.Controls.Add(grpAvatar, 0, 1);
            tlpLeft.Controls.Add(tlpActions, 0, 2);
            tlpLeft.Dock = DockStyle.Fill;
            tlpLeft.Margin = new Padding(0, 0, 12, 0);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.RowCount = 3;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 282F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLeft.TabIndex = 0;

            // grpStudentInfo
            grpStudentInfo.Controls.Add(tlpInfo);
            grpStudentInfo.Dock = DockStyle.Fill;
            grpStudentInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpStudentInfo.ForeColor = Color.FromArgb(31, 78, 140);
            grpStudentInfo.Margin = new Padding(0, 0, 0, 8);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Padding = new Padding(10, 4, 10, 8);
            grpStudentInfo.TabIndex = 0;
            grpStudentInfo.TabStop = false;
            grpStudentInfo.Text = "Thông tin sinh viên";

            // tlpInfo: 7 dòng, mỗi dòng gồm nhãn + ô nhập
            tlpInfo.ColumnCount = 2;
            tlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInfo.Controls.Add(lblStudentId, 0, 0);
            tlpInfo.Controls.Add(txtStudentId, 1, 0);
            tlpInfo.Controls.Add(lblFullName, 0, 1);
            tlpInfo.Controls.Add(txtFullName, 1, 1);
            tlpInfo.Controls.Add(lblClass, 0, 2);
            tlpInfo.Controls.Add(cboClass, 1, 2);
            tlpInfo.Controls.Add(lblFaculty, 0, 3);
            tlpInfo.Controls.Add(cboFaculty, 1, 3);
            tlpInfo.Controls.Add(lblCourse, 0, 4);
            tlpInfo.Controls.Add(cboCourse, 1, 4);
            tlpInfo.Controls.Add(lblBirthDate, 0, 5);
            tlpInfo.Controls.Add(dtpBirthDate, 1, 5);
            tlpInfo.Controls.Add(lblGender, 0, 6);
            tlpInfo.Controls.Add(cboGender, 1, 6);
            tlpInfo.Dock = DockStyle.Fill;
            tlpInfo.Font = new Font("Segoe UI", 10F);
            tlpInfo.ForeColor = SystemColors.ControlText;
            tlpInfo.Name = "tlpInfo";
            tlpInfo.RowCount = 7;
            for (int i = 0; i < 7; i++)
            {
                tlpInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / 7F));
            }
            tlpInfo.TabIndex = 0;

            // Dòng 1: Mã sinh viên
            lblStudentId.Dock = DockStyle.Fill;
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Text = "Mã sinh viên *";
            lblStudentId.TextAlign = ContentAlignment.MiddleLeft;

            txtStudentId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStudentId.MaxLength = 20;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.TabIndex = 0;
            txtStudentId.TextChanged += InputChanged;

            // Dòng 2: Họ tên
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Name = "lblFullName";
            lblFullName.Text = "Họ và tên *";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;

            txtFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.MaxLength = 60;
            txtFullName.Name = "txtFullName";
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += InputChanged;

            // Dòng 3: Lớp
            lblClass.Dock = DockStyle.Fill;
            lblClass.Name = "lblClass";
            lblClass.Text = "Lớp";
            lblClass.TextAlign = ContentAlignment.MiddleLeft;

            cboClass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.FormattingEnabled = true;
            cboClass.Name = "cboClass";
            cboClass.TabIndex = 2;
            cboClass.SelectedIndexChanged += InputChanged;

            // Dòng 4: Khoa
            lblFaculty.Dock = DockStyle.Fill;
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Text = "Khoa";
            lblFaculty.TextAlign = ContentAlignment.MiddleLeft;

            cboFaculty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFaculty.FormattingEnabled = true;
            cboFaculty.Name = "cboFaculty";
            cboFaculty.TabIndex = 3;
            cboFaculty.SelectedIndexChanged += InputChanged;

            // Dòng 5: Khóa học
            lblCourse.Dock = DockStyle.Fill;
            lblCourse.Name = "lblCourse";
            lblCourse.Text = "Khóa học";
            lblCourse.TextAlign = ContentAlignment.MiddleLeft;

            cboCourse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Name = "cboCourse";
            cboCourse.TabIndex = 4;
            cboCourse.SelectedIndexChanged += InputChanged;

            // Dòng 6: Ngày sinh
            lblBirthDate.Dock = DockStyle.Fill;
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Text = "Ngày sinh";
            lblBirthDate.TextAlign = ContentAlignment.MiddleLeft;

            dtpBirthDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.TabIndex = 5;
            dtpBirthDate.ValueChanged += InputChanged;

            // Dòng 7: Giới tính
            lblGender.Dock = DockStyle.Fill;
            lblGender.Name = "lblGender";
            lblGender.Text = "Giới tính";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;

            cboGender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Name = "cboGender";
            cboGender.TabIndex = 6;
            cboGender.SelectedIndexChanged += InputChanged;

            // grpAvatar: ảnh đại diện
            grpAvatar.Controls.Add(picAvatar);
            grpAvatar.Controls.Add(btnChooseImage);
            grpAvatar.Controls.Add(lblAvatarHint);
            grpAvatar.Dock = DockStyle.Fill;
            grpAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAvatar.ForeColor = Color.FromArgb(31, 78, 140);
            grpAvatar.Margin = new Padding(0, 0, 0, 8);
            grpAvatar.Name = "grpAvatar";
            grpAvatar.TabIndex = 1;
            grpAvatar.TabStop = false;
            grpAvatar.Text = "Ảnh đại diện";

            picAvatar.BackColor = Color.FromArgb(236, 240, 246);
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(16, 28);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(120, 160);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabStop = false;

            btnChooseImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnChooseImage.BackColor = Color.White;
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.FlatAppearance.BorderColor = Color.FromArgb(31, 78, 140);
            btnChooseImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChooseImage.ForeColor = Color.FromArgb(31, 78, 140);
            btnChooseImage.Location = new Point(152, 28);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(208, 40);
            btnChooseImage.TabIndex = 7;
            btnChooseImage.Text = "Chọn ảnh...";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;

            lblAvatarHint.Font = new Font("Segoe UI", 9F);
            lblAvatarHint.ForeColor = Color.DimGray;
            lblAvatarHint.Location = new Point(152, 78);
            lblAvatarHint.Name = "lblAvatarHint";
            lblAvatarHint.Size = new Size(208, 90);
            lblAvatarHint.Text = "Hỗ trợ ảnh JPG, JPEG, PNG, BMP.\r\nNên chọn ảnh chân dung tỉ lệ 3x4. Ảnh được giữ đúng tỉ lệ, không bị méo.";

            // tlpActions: 4 nút chức năng
            tlpActions.ColumnCount = 2;
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpActions.Controls.Add(btnPrintPreview, 0, 0);
            tlpActions.Controls.Add(btnPrint, 1, 0);
            tlpActions.Controls.Add(btnReset, 0, 1);
            tlpActions.Controls.Add(btnExit, 1, 1);
            tlpActions.Dock = DockStyle.Top;
            tlpActions.Margin = new Padding(0);
            tlpActions.Name = "tlpActions";
            tlpActions.RowCount = 2;
            tlpActions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpActions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpActions.Size = new Size(388, 104);
            tlpActions.TabIndex = 2;

            btnPrintPreview.BackColor = Color.FromArgb(31, 78, 140);
            btnPrintPreview.Cursor = Cursors.Hand;
            btnPrintPreview.Dock = DockStyle.Fill;
            btnPrintPreview.FlatAppearance.BorderSize = 0;
            btnPrintPreview.FlatStyle = FlatStyle.Flat;
            btnPrintPreview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrintPreview.ForeColor = Color.White;
            btnPrintPreview.Name = "btnPrintPreview";
            btnPrintPreview.TabIndex = 8;
            btnPrintPreview.Text = "Xem trước in";
            btnPrintPreview.UseVisualStyleBackColor = false;
            btnPrintPreview.Click += btnPrintPreview_Click;

            btnPrint.BackColor = Color.FromArgb(40, 140, 90);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Name = "btnPrint";
            btnPrint.TabIndex = 9;
            btnPrint.Text = "In thẻ";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;

            btnReset.BackColor = Color.FromArgb(226, 231, 239);
            btnReset.Cursor = Cursors.Hand;
            btnReset.Dock = DockStyle.Fill;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(40, 50, 70);
            btnReset.Name = "btnReset";
            btnReset.TabIndex = 10;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;

            btnExit.BackColor = Color.FromArgb(214, 69, 65);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Name = "btnExit";
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;

            // grpPreview: vùng xem trước thẻ
            grpPreview.Controls.Add(pnlCardPreview);
            grpPreview.Dock = DockStyle.Fill;
            grpPreview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPreview.ForeColor = Color.FromArgb(31, 78, 140);
            grpPreview.Margin = new Padding(0);
            grpPreview.Name = "grpPreview";
            grpPreview.Padding = new Padding(10, 6, 10, 10);
            grpPreview.TabIndex = 1;
            grpPreview.TabStop = false;
            grpPreview.Text = "Xem trước thẻ sinh viên";

            pnlCardPreview.BackColor = Color.FromArgb(226, 231, 239);
            pnlCardPreview.Dock = DockStyle.Fill;
            pnlCardPreview.Name = "pnlCardPreview";
            pnlCardPreview.TabIndex = 0;
            pnlCardPreview.Paint += pnlCardPreview_Paint;

            // ofdAvatar: chỉ cho chọn file ảnh
            ofdAvatar.Filter = "Tất cả ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|JPG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            ofdAvatar.Title = "Chọn ảnh đại diện";

            // printDocCard: nội dung cần in
            printDocCard.DocumentName = "The sinh vien";
            printDocCard.PrintPage += printDocCard_PrintPage;

            // FrmStudentCard
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1060, 660);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1020, 700);
            Name = "FrmStudentCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COMP1019 - Lab 09: Thiết kế và in thẻ sinh viên";
            FormClosed += FrmStudentCard_FormClosed;
            Load += FrmStudentCard_Load;

            tlpMain.ResumeLayout(false);
            tlpLeft.ResumeLayout(false);
            grpStudentInfo.ResumeLayout(false);
            tlpInfo.ResumeLayout(false);
            grpAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            tlpActions.ResumeLayout(false);
            grpPreview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpLeft;
        private GroupBox grpStudentInfo;
        private TableLayoutPanel tlpInfo;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblClass;
        private ComboBox cboClass;
        private Label lblFaculty;
        private ComboBox cboFaculty;
        private Label lblCourse;
        private ComboBox cboCourse;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblGender;
        private ComboBox cboGender;
        private GroupBox grpAvatar;
        private PictureBox picAvatar;
        private Button btnChooseImage;
        private Label lblAvatarHint;
        private TableLayoutPanel tlpActions;
        private Button btnPrintPreview;
        private Button btnPrint;
        private Button btnReset;
        private Button btnExit;
        private GroupBox grpPreview;
        private BufferedPanel pnlCardPreview;
        private OpenFileDialog ofdAvatar;
        private System.Drawing.Printing.PrintDocument printDocCard;
    }
}
