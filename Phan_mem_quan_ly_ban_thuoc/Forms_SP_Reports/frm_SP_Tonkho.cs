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
    public partial class frm_SP_Tonkho : Form
    {
        DataTable khuong;
        public frm_SP_Tonkho(string a)
        {
            InitializeComponent();
            txtNguoidung.Text = a;
        }

        private void frm_SP_Tonkho_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            string sql;
            double tt;
            rpt_Tonkho rpt = new rpt_Tonkho();


            sql = "select nhap.MATHUOC as MATHUOC ,thuoc.TENTHUOC As TENTHUOC,thuoc.DVT AS DVT, sum(nhap.SLUONG-ISNULL(ban.SLUONG,0)) as SOLUONG " +
                "from tblThuoc as thuoc,tblCTPhieunhap as nhap left join tblCTHoadonban as ban on nhap.MATHUOC = ban.MATHUOC and nhap.LOSX=ban.LOSX " +
                "where thuoc.MATHUOC = nhap.MATHUOC group by nhap.MATHUOC ,thuoc.TENTHUOC ,thuoc.DVT";

            khuong = Class.Functions.GetDataToTable(sql);
            rpt.SetDataSource(khuong);
            rpt.DataDefinition.FormulaFields["NGUOILAP"].Text = "'" + txtNguoidung.Text + "'";
            string s = txtNguoidung.Text;
            s = s.Trim();
            txtTen.Text = s.Substring(s.LastIndexOf(' ') + 1);
            rpt.DataDefinition.FormulaFields["TEN"].Text = "'" + txtTen.Text + "'";
            Forms_Reports.rpt_Tonkho aa = new Forms_Reports.rpt_Tonkho(rpt);
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
