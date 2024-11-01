using OfficeOpenXml;
using System;
using System.Windows.Forms;
using win_project_2.Forms;
using win_project_2.Forms.General;
using win_project_2.SQLConn;

namespace win_project_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Nếu kết nối thành công, mở LoginForm
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
     
        }
    }
}
