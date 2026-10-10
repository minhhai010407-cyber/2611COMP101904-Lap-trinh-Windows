namespace ShopManagerMini.Forms
{
    partial class FrmAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenUngDung = new Label();
            lblMoTa = new Label();
            lblHocPhan = new Label();
            lblSinhVien = new Label();
            lblLop = new Label();
            btnDong = new Button();
            SuspendLayout();
            // lblTenUngDung
            lblTenUngDung.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTenUngDung.ForeColor = Color.RebeccaPurple;
            lblTenUngDung.Location = new Point(0, 20);
            lblTenUngDung.Name = "lblTenUngDung";
            lblTenUngDung.Size = new Size(420, 45);
            lblTenUngDung.TabIndex = 0;
            lblTenUngDung.Text = "ShopManagerMini";
            lblTenUngDung.TextAlign = ContentAlignment.MiddleCenter;
            // lblMoTa
            lblMoTa.Location = new Point(0, 70);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(420, 23);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Ứng dụng quản lý cửa hàng mini";
            lblMoTa.TextAlign = ContentAlignment.MiddleCenter;
            // lblHocPhan
            lblHocPhan.Location = new Point(40, 120);
            lblHocPhan.Name = "lblHocPhan";
            lblHocPhan.Size = new Size(340, 23);
            lblHocPhan.TabIndex = 2;
            lblHocPhan.Text = "Học phần: COMP1019 - Lập trình trên Windows";
            // lblSinhVien
            lblSinhVien.Location = new Point(40, 150);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Size = new Size(340, 23);
            lblSinhVien.TabIndex = 3;
            lblSinhVien.Text = "Sinh viên: Ngô Minh Hải";
            // lblLop
            lblLop.Location = new Point(40, 180);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(340, 23);
            lblLop.TabIndex = 4;
            lblLop.Text = "Lớp: 51.01.CNTTA";
            // btnDong
            btnDong.BackColor = Color.RebeccaPurple;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(150, 230);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(120, 36);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // FrmAbout
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 290);
            Controls.Add(btnDong);
            Controls.Add(lblLop);
            Controls.Add(lblSinhVien);
            Controls.Add(lblHocPhan);
            Controls.Add(lblMoTa);
            Controls.Add(lblTenUngDung);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            Text = "Giới thiệu";
            ResumeLayout(false);
        }

        private Label lblTenUngDung;
        private Label lblMoTa;
        private Label lblHocPhan;
        private Label lblSinhVien;
        private Label lblLop;
        private Button btnDong;
    }
}
