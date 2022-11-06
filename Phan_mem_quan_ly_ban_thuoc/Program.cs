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
            //Application.Run(new frmLogin());
            //Application.Run(new Forms_SP_Reports.frm_SP_Doanhthu_Theothang("Khương"));

            /*
            frmLogin a = new frmLogin();
            Application.Run(a);
            if(a.islogin==true)
            {
                Application.Run(new Forms.frmMain(a.fullname,a.quyenhan));
            }
            */
            //Application.Run(new Forms.frmDMKhachhang("NV001", "admin"));
            //Application.Run(new Forms.frmMain("NV002", "admin"));
            Application.Run(new Forms.frmQuanlynhanvien("NV001", "admin"));
            /**/
        }

    }
}
