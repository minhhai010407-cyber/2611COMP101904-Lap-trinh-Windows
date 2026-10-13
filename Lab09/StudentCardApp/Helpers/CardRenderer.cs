using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using StudentCardApp.Models;

namespace StudentCardApp.Helpers
{
    /// <summary>
    /// Vẽ thẻ sinh viên bằng GDI+.
    /// Dùng chung cho Panel preview và PrintDocument nên preview và bản in luôn giống nhau.
    /// Thẻ được thiết kế trên hệ tọa độ 856 x 540 rồi scale vào vùng cần vẽ.
    /// </summary>
    public static class CardRenderer
    {
        // Kích thước logic của thẻ (tỉ lệ 85.6 x 54 mm, giống thẻ ngang thật)
        private const float LogicalWidth = 856f;
        private const float LogicalHeight = 540f;
        private const float CornerRadius = 26f;

        /// <summary>Tỉ lệ rộng / cao của thẻ.</summary>
        public const float AspectRatio = LogicalWidth / LogicalHeight;

        /// <summary>Chiều rộng thẻ khi in (đơn vị 1/100 inch, ~85.6 mm).</summary>
        public const int PrintWidth = 337;

        private const string FontName = "Segoe UI";

        // Vị trí các thành phần trên thẻ
        private const float HeaderHeight = 132f;
        private const float InfoLeft = 285f;
        private const float InfoTop = 160f;
        private const float InfoRight = 36f;
        private const float LabelWidth = 140f;
        private const float RowHeight = 44f;
        private static readonly RectangleF AvatarFrame = new RectangleF(40f, 172f, 210f, 280f); // tỉ lệ 3x4

        // Bảng màu
        private static readonly Color PrimaryColor = Color.FromArgb(31, 78, 140);
        private static readonly Color DarkColor = Color.FromArgb(16, 52, 102);
        private static readonly Color AccentColor = Color.FromArgb(255, 200, 61);
        private static readonly Color LabelColor = Color.FromArgb(95, 105, 120);
        private static readonly Color ValueColor = Color.FromArgb(25, 35, 55);
        private static readonly Color LineColor = Color.FromArgb(205, 218, 236);

        private static readonly StringFormat CenterFormat = CreateFormat(StringAlignment.Center);
        private static readonly StringFormat LeftFormat = CreateFormat(StringAlignment.Near);

        /// <summary>
        /// Tính hình chữ nhật lớn nhất đúng tỉ lệ thẻ, canh giữa trong vùng cho trước.
        /// </summary>
        public static RectangleF FitToArea(RectangleF area)
        {
            float width = System.Math.Min(area.Width, area.Height * AspectRatio);
            float height = width / AspectRatio;
            return new RectangleF(
                area.X + (area.Width - width) / 2f,
                area.Y + (area.Height - height) / 2f,
                width,
                height);
        }

        /// <summary>
        /// Vẽ bóng đổ nhẹ phía sau thẻ (chỉ dùng cho preview).
        /// </summary>
        public static void DrawShadow(Graphics g, RectangleF card)
        {
            float radius = CornerRadius * card.Width / LogicalWidth;
            var shadowRect = new RectangleF(card.X + 5f, card.Y + 5f, card.Width, card.Height);

            using GraphicsPath path = CreateRoundedPath(shadowRect, radius);
            using var brush = new SolidBrush(Color.FromArgb(45, 0, 0, 0));

            SmoothingMode oldMode = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = oldMode;
        }

        /// <summary>
        /// Vẽ thẻ sinh viên vào hình chữ nhật <paramref name="bounds"/> của <paramref name="g"/>.
        /// </summary>
        public static void Draw(Graphics g, RectangleF bounds, StudentInfo info)
        {
            GraphicsState state = g.Save();
            try
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                float scale = bounds.Width / LogicalWidth;
                g.TranslateTransform(bounds.X, bounds.Y);
                g.ScaleTransform(scale, scale);

                using GraphicsPath outline = CreateRoundedPath(new RectangleF(0f, 0f, LogicalWidth, LogicalHeight), CornerRadius);
                FillBackground(g, outline);

                g.SetClip(outline); // header và footer bo theo góc thẻ
                DrawHeader(g);
                DrawFooter(g);
                g.ResetClip();

                DrawAvatar(g, info.Avatar);
                DrawInformation(g, info);
                DrawBorder(g);
            }
            finally
            {
                g.Restore(state);
            }
        }

        private static void FillBackground(Graphics g, GraphicsPath outline)
        {
            var area = new RectangleF(0f, 0f, LogicalWidth, LogicalHeight);
            using var brush = new LinearGradientBrush(area, Color.FromArgb(232, 242, 255), Color.White, LinearGradientMode.Vertical);
            g.FillPath(brush, outline);
        }

        private static void DrawHeader(Graphics g)
        {
            using var headerBrush = new SolidBrush(PrimaryColor);
            using var accentBrush = new SolidBrush(AccentColor);
            using var schoolFont = new Font(FontName, 26f, FontStyle.Bold, GraphicsUnit.World);
            using var titleFont = new Font(FontName, 40f, FontStyle.Bold, GraphicsUnit.World);

            g.FillRectangle(headerBrush, 0f, 0f, LogicalWidth, HeaderHeight);
            g.FillRectangle(accentBrush, 0f, HeaderHeight, LogicalWidth, 6f);

            g.DrawString("TRƯỜNG ĐẠI HỌC SƯ PHẠM TP. HỒ CHÍ MINH", schoolFont, Brushes.White,
                new RectangleF(0f, 14f, LogicalWidth, 44f), CenterFormat);
            g.DrawString("THẺ SINH VIÊN", titleFont, accentBrush,
                new RectangleF(0f, 62f, LogicalWidth, 62f), CenterFormat);
        }

        private static void DrawFooter(Graphics g)
        {
            using var footerBrush = new SolidBrush(PrimaryColor);
            using var accentBrush = new SolidBrush(AccentColor);

            g.FillRectangle(accentBrush, 0f, LogicalHeight - 34f, LogicalWidth, 4f);
            g.FillRectangle(footerBrush, 0f, LogicalHeight - 30f, LogicalWidth, 30f);
        }

        private static void DrawAvatar(Graphics g, Image avatar)
        {
            if (avatar == null)
            {
                using var placeholderBrush = new SolidBrush(Color.FromArgb(225, 230, 238));
                using var textBrush = new SolidBrush(Color.FromArgb(140, 150, 165));
                using var font = new Font(FontName, 22f, FontStyle.Bold, GraphicsUnit.World);

                g.FillRectangle(placeholderBrush, AvatarFrame);
                g.DrawString("ẢNH 3x4", font, textBrush, AvatarFrame, CenterFormat);
            }
            else
            {
                DrawImageCover(g, avatar, AvatarFrame);
            }

            using var borderPen = new Pen(PrimaryColor, 3f);
            g.DrawRectangle(borderPen, AvatarFrame.X, AvatarFrame.Y, AvatarFrame.Width, AvatarFrame.Height);
        }

        /// <summary>
        /// Vẽ ảnh lấp đầy khung, cắt phần thừa ở giữa để ảnh không bị méo.
        /// </summary>
        private static void DrawImageCover(Graphics g, Image image, RectangleF frame)
        {
            float frameRatio = frame.Width / frame.Height;
            float imageRatio = (float)image.Width / image.Height;

            RectangleF source;
            if (imageRatio > frameRatio)
            {
                // Ảnh rộng hơn khung: cắt hai bên
                float width = image.Height * frameRatio;
                source = new RectangleF((image.Width - width) / 2f, 0f, width, image.Height);
            }
            else
            {
                // Ảnh cao hơn khung: cắt trên và dưới
                float height = image.Width / frameRatio;
                source = new RectangleF(0f, (image.Height - height) / 2f, image.Width, height);
            }

            g.DrawImage(image, frame, source, GraphicsUnit.Pixel);
        }

        private static void DrawInformation(Graphics g, StudentInfo info)
        {
            using var labelFont = new Font(FontName, 20f, FontStyle.Regular, GraphicsUnit.World);
            using var valueFont = new Font(FontName, 22f, FontStyle.Bold, GraphicsUnit.World);
            using var labelBrush = new SolidBrush(LabelColor);
            using var valueBrush = new SolidBrush(ValueColor);
            using var highlightBrush = new SolidBrush(PrimaryColor);
            using var linePen = new Pen(LineColor, 1.5f);

            (string Label, string Value, bool Highlight)[] rows =
            {
                ("Mã SV:", info.StudentId, true),
                ("Họ tên:", info.FullName.ToUpperInvariant(), true),
                ("Ngày sinh:", info.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), false),
                ("Giới tính:", info.Gender, false),
                ("Lớp:", info.ClassName, false),
                ("Khoa:", info.Faculty, false),
                ("Khóa:", info.Course, false)
            };

            float valueLeft = InfoLeft + LabelWidth;
            float valueWidth = LogicalWidth - InfoRight - valueLeft;
            float y = InfoTop;

            foreach (var row in rows)
            {
                g.DrawString(row.Label, labelFont, labelBrush,
                    new RectangleF(InfoLeft, y, LabelWidth, RowHeight), LeftFormat);
                g.DrawString(row.Value, valueFont, row.Highlight ? highlightBrush : valueBrush,
                    new RectangleF(valueLeft, y, valueWidth, RowHeight), LeftFormat);
                g.DrawLine(linePen, InfoLeft, y + RowHeight, LogicalWidth - InfoRight, y + RowHeight);

                y += RowHeight;
            }
        }

        private static void DrawBorder(Graphics g)
        {
            using var pen = new Pen(DarkColor, 4f);
            using GraphicsPath path = CreateRoundedPath(
                new RectangleF(2f, 2f, LogicalWidth - 4f, LogicalHeight - 4f), CornerRadius - 2f);
            g.DrawPath(pen, path);
        }

        private static GraphicsPath CreateRoundedPath(RectangleF rect, float radius)
        {
            float d = radius * 2f;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static StringFormat CreateFormat(StringAlignment alignment)
        {
            return new StringFormat(StringFormatFlags.NoWrap)
            {
                Alignment = alignment,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };
        }
    }
}
