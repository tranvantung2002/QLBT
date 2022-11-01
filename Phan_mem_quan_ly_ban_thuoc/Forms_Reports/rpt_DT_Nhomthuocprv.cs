using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Reports
{
    public partial class rpt_DT_Nhomthuocprv : Form
    {
        public rpt_DT_Nhomthuocprv(Reports.rptDT_Nhomthuoc rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }



        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
