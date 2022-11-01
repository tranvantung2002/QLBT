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
    public partial class frm_SP_Doanhthu_Nhomthuoc : Form
    {
        DataTable khuong;
        public frm_SP_Doanhthu_Nhomthuoc(string a)
        {
            InitializeComponent();
            txtNguoidung.Text = a;
        }

        private void frm_SP_Doanhthu_Nhomthuoc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();


        } 
        private void ketnoi()
        {
            Class.Functions.FillCombo("SELECT MANHOM, TENNHOM FROM tblNhomthuoc", cboNhomthuoc, "MANHOM", "TENNHOM");
            cboNhomthuoc.SelectedIndex = -1;
        }
        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            string sql;
            double tt;
            rptDT_Nhomthuoc rpt = new rptDT_Nhomthuoc();
            sql = "select a.MATHUOC, a.TENTHUOC,b.LOSX, sum(b.THANHTIEN) as THANHTIEN1 from tblThuoc as a, tblCTHoadonban as b,tblNhomthuoc as c where a.MATHUOC=b.MATHUOC and a.MANHOM=c.MANHOM and c.TENNHOM =N'" + cboNhomthuoc.Text +"' group by a.MATHUOC,a.TENTHUOC,b.LOSX";
            khuong = Class.Functions.GetDataToTable(sql);            
            rpt.SetDataSource(khuong);
            rpt.DataDefinition.FormulaFields["MANHOM"].Text = "'" + cboNhomthuoc.Text + "'";
            rpt.DataDefinition.FormulaFields["NGUOILAP"].Text = "'" + txtNguoidung.Text + "'";
            string s = txtNguoidung.Text;
            s = s.Trim();
            txtTen.Text = s.Substring(s.LastIndexOf(' ') + 1);
            rpt.DataDefinition.FormulaFields["TEN"].Text = "'" + txtTen.Text + "'";
            Forms_Reports.rpt_DT_Nhomthuocprv aa = new Forms_Reports.rpt_DT_Nhomthuocprv(rpt);
            aa.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
