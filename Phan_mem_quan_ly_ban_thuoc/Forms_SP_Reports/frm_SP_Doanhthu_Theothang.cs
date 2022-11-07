using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phan_mem_quan_ly_ban_thuoc.Reports;
using System.Data.SqlClient;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_SP_Reports
{
    public partial class frm_SP_Doanhthu_Theothang : Form
    {
        DataTable khuong;
        public frm_SP_Doanhthu_Theothang()
        {
            InitializeComponent();
        }

        private void frm_SP_Doanhthu_Theothang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            string sql;
            double tt;
            rptDT_Theothang rpt = new rptDT_Theothang();
            

            sql = "select month(b.NGAYNHAP) as THANG ,sum(a.SLUONG) as SLUONG, sum(a.THANHTIEN) as THANHTIEN1 " +
                "from  tblCTHoadonban as a,tblHoadonban as b " +
                "where a.MABAN=b.MABAN group by month(NGAYNHAP)";
            khuong = Class.Functions.GetDataToTable(sql);
            rpt.SetDataSource(khuong);            
            rpt.DataDefinition.FormulaFields["NGUOILAP"].Text = "'" + txtNguoidung.Text + "'";
            string s = txtNguoidung.Text;
            s = s.Trim();
            txtTen.Text = s.Substring(s.LastIndexOf(' ') + 1);
            rpt.DataDefinition.FormulaFields["TEN"].Text = "'" + txtTen.Text + "'";
            Forms_Reports.rpt_DT_Theothangprv aa = new Forms_Reports.rpt_DT_Theothangprv(rpt);
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
