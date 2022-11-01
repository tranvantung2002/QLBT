using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Update
{
    public partial class frmUp_nhomthuoc : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr, fname, sql1, sql2;
        int i, n;
        DataTable khuong;

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            mokhoa();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            sql = "Update tblNhomthuoc set TENNHOM=N'" + txtTen.Text.Trim() + "',GHICHU=N'" + txtGhichu.Text.Trim() + "' where MANHOM='" + txtMa.Text + "'";
            Class.Functions.RunSql(sql);
            MessageBox.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            khoa();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmUp_nhomthuoc(string manhom,string tennhom,string ghichu)
        {
            InitializeComponent();
            txtMa.Text = manhom;
            txtTen.Text = tennhom;
            txtGhichu.Text = ghichu;
        }

        private void frmUp_nhomthuoc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
            khoa();
        }

        private void ketnoi()
        {
            sql = "select MANHOM,TENNHOM,GHICHU from tblNhomthuoc ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }

        private void khoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtGhichu.Enabled = false;
        }


        private void mokhoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtGhichu.Enabled = true;
        }
    }
}
