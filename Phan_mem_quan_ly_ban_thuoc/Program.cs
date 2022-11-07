using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin a = new frmLogin();
            Application.Run(a);
            if (a.islogin == true)
            {
                Application.Run(new Forms.frmMain(a.fullname, a.quyenhan));
            }
        }

    }
}
