using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace COMP1019_Lab08_SimplePaint;

public partial class FrmPaint : Form
{
    private List<DrawItem> dsNetVe = new List<DrawItem>();
    private DrawItem netDangVe = null;
    private Color mauVe = Color.Black;
    private Bitmap anhNen = null;

    public FrmPaint()
    {
        InitializeComponent();
    }

    private void FrmPaint_Load(object sender, EventArgs e)
    {
        cboMode.Items.AddRange(new object[] { "Pen", "Line", "Rectangle", "Ellipse" });
        cboMode.SelectedIndex = 0;
        pnlColor.BackColor = mauVe;
        CapNhatTrangThai();
    }

    private void FrmPaint_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (anhNen != null) anhNen.Dispose();
    }

    private void FrmPaint_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.Z)
        {
            Undo();
            e.SuppressKeyPress = true;
        }
    }

    private ToolMode LayCheDoVe()
    {
        return (ToolMode)cboMode.SelectedIndex;
    }

    private Rectangle LayHinhChuNhat(Point a, Point b)
    {
        int x = Math.Min(a.X, b.X);
        int y = Math.Min(a.Y, b.Y);
        int rong = Math.Abs(a.X - b.X);
        int cao = Math.Abs(a.Y - b.Y);
        return new Rectangle(x, y, rong, cao);
    }

    private void CapNhatTrangThai()
    {
        lblCount.Text = "Số nét vẽ: " + dsNetVe.Count;
    }

    private void VeNet(Graphics g, DrawItem net)
    {
        using (Pen pen = new Pen(net.Color, net.Width))
        using (SolidBrush brush = new SolidBrush(net.Color))
        {
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            if (net.Mode == ToolMode.Pen)
            {
                pen.LineJoin = LineJoin.Round;
                if (net.Points.Count == 1)
                {
                    float banKinh = net.Width / 2f;
                    g.FillEllipse(brush, net.Points[0].X - banKinh, net.Points[0].Y - banKinh, net.Width, net.Width);
                }
                else if (net.Points.Count > 1)
                {
                    g.DrawLines(pen, net.Points.ToArray());
                }
            }
            else if (net.Mode == ToolMode.Line)
            {
                g.DrawLine(pen, net.Start, net.End);
            }
            else if (net.Mode == ToolMode.Rectangle)
            {
                Rectangle hinh = LayHinhChuNhat(net.Start, net.End);
                if (net.Fill) g.FillRectangle(brush, hinh);
                g.DrawRectangle(pen, hinh);
            }
            else if (net.Mode == ToolMode.Ellipse)
            {
                Rectangle hinh = LayHinhChuNhat(net.Start, net.End);
                if (net.Fill) g.FillEllipse(brush, hinh);
                g.DrawEllipse(pen, hinh);
            }
        }
    }

    private void VeTatCa(Graphics g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        if (anhNen != null) g.DrawImage(anhNen, 0, 0);
        foreach (DrawItem net in dsNetVe)
            VeNet(g, net);
    }

    private void canvas_Paint(object sender, PaintEventArgs e)
    {
        VeTatCa(e.Graphics);
        if (netDangVe != null) VeNet(e.Graphics, netDangVe);
    }

    private void canvas_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left || netDangVe != null) return;

        netDangVe = new DrawItem
        {
            Mode = LayCheDoVe(),
            Color = mauVe,
            Width = (int)nudWidth.Value,
            Fill = chkFill.Checked,
            Start = e.Location,
            End = e.Location
        };
        if (netDangVe.Mode == ToolMode.Pen) netDangVe.Points.Add(e.Location);
        canvas.Invalidate();
    }

    private void canvas_MouseMove(object sender, MouseEventArgs e)
    {
        lblStatus.Text = "Tọa độ: " + e.X + ", " + e.Y;
        if (netDangVe == null) return;

        netDangVe.End = e.Location;
        if (netDangVe.Mode == ToolMode.Pen) netDangVe.Points.Add(e.Location);
        canvas.Invalidate();
    }

    private void canvas_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left || netDangVe == null) return;

        netDangVe.End = e.Location;
        bool hopLe = netDangVe.Mode == ToolMode.Pen || netDangVe.Start != netDangVe.End;
        if (hopLe) dsNetVe.Add(netDangVe);
        netDangVe = null;

        CapNhatTrangThai();
        canvas.Invalidate();
    }

    private void canvas_MouseLeave(object sender, EventArgs e)
    {
        if (netDangVe == null) lblStatus.Text = "Tọa độ: -";
    }

    private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToolMode cheDo = LayCheDoVe();
        chkFill.Enabled = cheDo == ToolMode.Rectangle || cheDo == ToolMode.Ellipse;
    }

    private void btnColor_Click(object sender, EventArgs e)
    {
        colorDialog.Color = mauVe;
        if (colorDialog.ShowDialog() != DialogResult.OK) return;
        mauVe = colorDialog.Color;
        pnlColor.BackColor = mauVe;
    }

    private void btnBackColor_Click(object sender, EventArgs e)
    {
        colorDialog.Color = canvas.BackColor;
        if (colorDialog.ShowDialog() != DialogResult.OK) return;
        canvas.BackColor = colorDialog.Color;
    }

    private void Undo()
    {
        if (netDangVe != null || dsNetVe.Count == 0) return;
        dsNetVe.RemoveAt(dsNetVe.Count - 1);
        CapNhatTrangThai();
        canvas.Invalidate();
    }

    private void btnUndo_Click(object sender, EventArgs e)
    {
        Undo();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        if (dsNetVe.Count == 0 && anhNen == null) return;

        DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ vùng vẽ?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (kq != DialogResult.Yes) return;

        dsNetVe.Clear();
        if (anhNen != null)
        {
            anhNen.Dispose();
            anhNen = null;
        }
        CapNhatTrangThai();
        canvas.Invalidate();
    }

    private void btnOpenImage_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            using (Image anh = Image.FromFile(openFileDialog.FileName))
            {
                double tiLe = Math.Min((double)canvas.ClientSize.Width / anh.Width, (double)canvas.ClientSize.Height / anh.Height);
                int rong = Math.Max(1, (int)(anh.Width * tiLe));
                int cao = Math.Max(1, (int)(anh.Height * tiLe));
                Bitmap anhMoi = new Bitmap(anh, rong, cao);
                if (anhNen != null) anhNen.Dispose();
                anhNen = anhMoi;
            }
            canvas.Invalidate();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không mở được ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            using (Bitmap bmp = new Bitmap(canvas.ClientSize.Width, canvas.ClientSize.Height))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(canvas.BackColor);
                VeTatCa(g);
                bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            MessageBox.Show("Đã lưu ảnh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không lưu được ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
