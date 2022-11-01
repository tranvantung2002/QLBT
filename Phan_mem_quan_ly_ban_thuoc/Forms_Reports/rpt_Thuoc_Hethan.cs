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
    public partial class rpt_Thuoc_Hethan : Form
    {
        public rpt_Thuoc_Hethan(Reports.rpt_Thuoc_Hethan rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rpt_Thuoc_Hethan_Load(object sender, EventArgs e)
        {

        }
    }
}
