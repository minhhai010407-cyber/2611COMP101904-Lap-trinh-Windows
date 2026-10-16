namespace Lab11_QuanLyLopHoc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmQuanLyLop());
        }
    }
}
