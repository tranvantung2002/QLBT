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
    public partial class frm_SP_DT_Khachhang : Form
    {
        DataTable khuong;
        public frm_SP_DT_Khachhang(string a)
        {
            InitializeComponent();
            txtNguoidung.Text = a;
        }

        private void frm_SP_DT_Khachhang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            string sql;
            double tt;
            rpt_Khachhang_TOP rpt = new rpt_Khachhang_TOP();
            sql = "select  b.TENKHACH,b.DIACHI,sum(a.TONGTIEN) as THANHTIEN " +
                "from  tblKhachhang as b,tblHoadonban as a " +
                "where a.MAKHACH=b.MAKHACH group by b.TENKHACH,b.DIACHI order by sum(a.TONGTIEN) desc";
            khuong = Class.Functions.GetDataToTable(sql);
            rpt.SetDataSource(khuong);
            rpt.DataDefinition.FormulaFields["NGUOILAP"].Text = "'" + txtNguoidung.Text + "'";
            string s = txtNguoidung.Text;
            s = s.Trim();
            txtTen.Text = s.Substring(s.LastIndexOf(' ') + 1);
            rpt.DataDefinition.FormulaFields["TEN"].Text = "'" + txtTen.Text + "'";
            Forms_Reports.rpt_DT_Khachhang aa = new Forms_Reports.rpt_DT_Khachhang(rpt);
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
