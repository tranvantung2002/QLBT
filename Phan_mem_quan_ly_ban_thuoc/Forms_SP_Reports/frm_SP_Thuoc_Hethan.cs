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
    public partial class frm_SP_Thuoc_Hethan : Form
    {
        DataTable khuong;
        public frm_SP_Thuoc_Hethan()
        {
            InitializeComponent();
        }

        private void frm_SP_Thuoc_Hethan_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            string sql;
            double tt;
            rpt_Thuoc_Hethan rpt = new rpt_Thuoc_Hethan();

            sql = "select nhap.MATHUOC as MATHUOC ,thuoc.TENTHUOC As TENTHUOC,nhap.HSD AS NGAYHETHAN, sum(nhap.SLUONG-ISNULL(ban.SLUONG,0)) as SOLUONG " +
                "from tblThuoc as thuoc,tblCTPhieunhap as nhap left join tblCTHoadonban as ban on nhap.MATHUOC = ban.MATHUOC and nhap.LOSX=ban.LOSX " +
                "where thuoc.MATHUOC = nhap.MATHUOC and (nhap.HSD < getdate())  group by nhap.MATHUOC ,thuoc.TENTHUOC ,nhap.HSD";

            khuong = Class.Functions.GetDataToTable(sql);
            rpt.SetDataSource(khuong);
            rpt.DataDefinition.FormulaFields["NGUOILAP"].Text = "'" + txtNguoidung.Text + "'";
            string s = txtNguoidung.Text;
            s = s.Trim();
            txtTen.Text = s.Substring(s.LastIndexOf(' ') + 1);
            rpt.DataDefinition.FormulaFields["TEN"].Text = "'" + txtTen.Text + "'";
            Forms_Reports.rpt_Thuoc_Hethan aa = new Forms_Reports.rpt_Thuoc_Hethan(rpt);
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
