using System.Windows.Forms;

namespace StudentCardApp.CustomControls
{
    /// <summary>
    /// Panel bật double buffer để vẽ GDI+ không bị nhấp nháy khi thay đổi kích thước.
    /// </summary>
    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
}
