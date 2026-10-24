using System;
using System.Windows.Forms;
using StudentReportDemo.Forms;

namespace StudentReportDemo
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmBaoCaoSinhVien());
        }
    }
}
