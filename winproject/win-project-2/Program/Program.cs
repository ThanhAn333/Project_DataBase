using System;
using System.Windows.Forms;
using win_project_2.Forms;
using win_project_2.SQLConn;

namespace win_project_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
                // Nếu kết nối thành công, mở LoginForm
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FAdmin());
     
        }
    }
}
