using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using StudentCardApp.Helpers;
using StudentCardApp.Models;

namespace StudentCardApp
{
    public partial class FrmStudentCard : Form
    {
        // Danh sách mẫu cho các ComboBox
        private static readonly string[] SampleClasses =
        {
            "51.01.CNTT.A", "51.01.CNTT.B", "50.01.CNTT.A", "50.01.CNTT.B", "49.01.CNTT.A", "49.01.CNTT.B"
        };
        private static readonly string[] SampleFaculties =
        {
            "Công nghệ thông tin", "Toán - Tin học", "Vật lý", "Hóa học",
            "Sinh học", "Ngữ văn", "Tâm lý - Giáo dục", "Ngoại ngữ"
        };
        private static readonly string[] SampleCourses = { "K51", "K50", "K49" };
        private static readonly string[] Genders = { "Nam", "Nữ", "Khác" };

        private static readonly DateTime DefaultBirthDate = new DateTime(2005, 1, 1);
        private static readonly DateTime MinBirthDate = new DateTime(1950, 1, 1);
        private const int PreviewPadding = 24;

        // Màu báo ô nhập chưa hợp lệ
        private static readonly Color InvalidColor = Color.FromArgb(255, 228, 228);
        private static readonly Color AvatarBackColor = Color.FromArgb(236, 240, 246);

        // Ảnh đại diện đang chọn (bản sao trong bộ nhớ, không giữ khóa file gốc)
        private Bitmap _avatar;

        public FrmStudentCard()
        {
            InitializeComponent();
        }

        #region Form events

        private void FrmStudentCard_Load(object sender, EventArgs e)
        {
            cboClass.Items.AddRange(SampleClasses);
            cboFaculty.Items.AddRange(SampleFaculties);
            cboCourse.Items.AddRange(SampleCourses);
            cboGender.Items.AddRange(Genders);

            dtpBirthDate.MinDate = MinBirthDate;
            dtpBirthDate.MaxDate = DateTime.Today;

            ResetForm();
        }

        private void FrmStudentCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _avatar?.Dispose();
        }

        #endregion

        #region Nhập liệu và preview (F2)

        /// <summary>
        /// Dùng chung cho mọi ô nhập: bỏ tô đỏ của ô đó và vẽ lại preview.
        /// </summary>
        private void InputChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                SetInvalid(textBox, false);
            }
            pnlCardPreview.Invalidate();
        }

        private void pnlCardPreview_Paint(object sender, PaintEventArgs e)
        {
            Rectangle area = Rectangle.Inflate(pnlCardPreview.ClientRectangle, -PreviewPadding, -PreviewPadding);
            if (area.Width < 50 || area.Height < 30)
            {
                return;
            }

            RectangleF card = CardRenderer.FitToArea(area);
            CardRenderer.DrawShadow(e.Graphics, card);
            CardRenderer.Draw(e.Graphics, card, BuildStudentInfo());
        }

        #endregion

        #region Chọn ảnh (F1)

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (ofdAvatar.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                SetAvatar(LoadImageWithoutLock(ofdAvatar.FileName));
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException
                                       || ex is OutOfMemoryException || ex is ArgumentException)
            {
                MessageBox.Show(this,
                    "Không thể mở ảnh đã chọn. Vui lòng chọn file ảnh JPG, PNG hoặc BMP hợp lệ.",
                    "Lỗi mở ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Đọc ảnh vào bộ nhớ rồi đóng file ngay, tránh khóa file ảnh trên đĩa.
        /// </summary>
        private static Bitmap LoadImageWithoutLock(string path)
        {
            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var source = Image.FromStream(stream);
            return new Bitmap(source);
        }

        /// <summary>
        /// Gán ảnh mới cho PictureBox và preview, đồng thời giải phóng ảnh cũ.
        /// </summary>
        private void SetAvatar(Bitmap newAvatar)
        {
            Bitmap oldAvatar = _avatar;
            _avatar = newAvatar;
            picAvatar.Image = _avatar; // gán ảnh mới trước khi hủy ảnh cũ
            oldAvatar?.Dispose();

            if (_avatar != null)
            {
                SetInvalid(picAvatar, false);
            }
            pnlCardPreview.Invalidate();
        }

        #endregion

        #region Validation (F3)

        /// <summary>
        /// Kiểm tra mã sinh viên, họ tên và ảnh. Tô đỏ ô thiếu, báo lỗi và đưa con trỏ về ô đầu tiên bị thiếu.
        /// </summary>
        private bool ValidateInput()
        {
            ClearInvalidMarks();

            var errors = new List<string>();
            Control firstInvalid = null;

            void Fail(Control highlight, string message, Control focusTarget)
            {
                SetInvalid(highlight, true);
                errors.Add("- " + message);
                if (firstInvalid == null)
                {
                    firstInvalid = focusTarget;
                }
            }

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                Fail(txtStudentId, "Vui lòng nhập mã sinh viên.", txtStudentId);
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                Fail(txtFullName, "Vui lòng nhập họ và tên.", txtFullName);
            }

            if (_avatar == null)
            {
                Fail(picAvatar, "Vui lòng chọn ảnh đại diện.", btnChooseImage);
            }

            if (errors.Count == 0)
            {
                return true;
            }

            MessageBox.Show(this,
                "Chưa thể xem trước hoặc in thẻ:\r\n" + string.Join("\r\n", errors),
                "Thiếu dữ liệu bắt buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firstInvalid.Focus();
            return false;
        }

        #endregion

        #region In ấn (F4, F5)

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                using var previewDialog = new PrintPreviewDialog
                {
                    Document = printDocCard,
                    UseAntiAlias = true,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(1000, 720),
                    Text = "Xem trước khi in thẻ sinh viên"
                };
                previewDialog.ShowDialog(this);
            }
            catch (InvalidPrinterException)
            {
                ShowPrinterError();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                using var printDialog = new PrintDialog
                {
                    Document = printDocCard,
                    UseEXDialog = true
                };

                if (printDialog.ShowDialog(this) == DialogResult.OK)
                {
                    printDocCard.Print();
                }
            }
            catch (InvalidPrinterException)
            {
                ShowPrinterError();
            }
        }

        /// <summary>
        /// Vẽ thẻ lên trang in: kích thước thật ~85.6 mm, canh giữa theo chiều ngang, sát lề trên.
        /// </summary>
        private void printDocCard_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle margin = e.MarginBounds;
            float width = Math.Min(CardRenderer.PrintWidth, margin.Width);
            float height = width / CardRenderer.AspectRatio;
            var card = new RectangleF(margin.Left + (margin.Width - width) / 2f, margin.Top, width, height);

            CardRenderer.Draw(e.Graphics, card, BuildStudentInfo());
            e.HasMorePages = false;
        }

        private void ShowPrinterError()
        {
            MessageBox.Show(this,
                "Không tìm thấy máy in hợp lệ. Vui lòng cài đặt máy in (ví dụ Microsoft Print to PDF) rồi thử lại.",
                "Lỗi máy in", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Làm mới và thoát (F6)

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Đưa form về trạng thái ban đầu: xóa dữ liệu nhập, xóa ảnh, chọn lại giá trị mặc định.
        /// </summary>
        private void ResetForm()
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            cboClass.SelectedIndex = 0;
            cboFaculty.SelectedIndex = 0;
            cboCourse.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            dtpBirthDate.Value = DefaultBirthDate;

            SetAvatar(null);
            ClearInvalidMarks();
            txtStudentId.Focus();
        }

        #endregion

        #region Tô đỏ ô nhập chưa hợp lệ

        private void SetInvalid(Control control, bool invalid)
        {
            if (invalid)
            {
                control.BackColor = InvalidColor;
            }
            else
            {
                control.BackColor = control == picAvatar ? AvatarBackColor : SystemColors.Window;
            }
        }

        private void ClearInvalidMarks()
        {
            SetInvalid(txtStudentId, false);
            SetInvalid(txtFullName, false);
            SetInvalid(picAvatar, false);
        }

        #endregion

        /// <summary>
        /// Gom dữ liệu trên form thành một đối tượng StudentInfo để vẽ.
        /// </summary>
        private StudentInfo BuildStudentInfo()
        {
            return new StudentInfo
            {
                StudentId = txtStudentId.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                ClassName = cboClass.Text,
                Faculty = cboFaculty.Text,
                Course = cboCourse.Text,
                Gender = cboGender.Text,
                BirthDate = dtpBirthDate.Value.Date,
                Avatar = _avatar
            };
        }
    }
}
