namespace Lab01_ThongTinCaNhan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            label4 = new Label();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label5 = new Label();
            txtKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(216, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN CÁ NHÂN";
            lblTitle.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 57);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 107);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Năm sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 154);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(132, 57);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(252, 27);
            txtHoTen.TabIndex = 4;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(132, 107);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(125, 27);
            txtNamSinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(radNam);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 61);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính:";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(222, 26);
            radNu.Name = "radNu";
            radNu.Size = new Size(52, 24);
            radNu.TabIndex = 1;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            radNu.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(74, 26);
            radNam.Name = "radNam";
            radNam.Size = new Size(64, 24);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 257);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Khoa/Lớp:";
            label4.Click += label4_Click;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(132, 254);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(204, 28);
            cboKhoa.TabIndex = 9;
            // 
            // btnHienThi
            // 
            btnHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHienThi.Location = new Point(111, 517);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 10;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(281, 517);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(447, 517);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 314);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 13;
            label5.Text = "Kết quả ";
            label5.Click += label5_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(31, 366);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(753, 132);
            txtKetQua.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(txtKetQua);
            Controls.Add(label5);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnHienThi);
            Controls.Add(cboKhoa);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoTen;
        private TextBox txtNamSinh;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private RadioButton radNu;
        private RadioButton radNam;
        private Label label4;
        private ComboBox cboKhoa;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnThoat;
        private Label label5;
        private TextBox txtKetQua;
    }
}
