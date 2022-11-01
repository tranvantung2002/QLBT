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

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Addnew
{
    public partial class frmAdd_nhomthuoc : Form
    {
        DataTable khuong;
        string sql;
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
            sql = "SELECT MANHOM FROM tblNhomthuoc WHERE MANHOM=N'" + txtMa.Text.Trim() + "'";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            if (grdData.Rows.Count > 1)
            {
                MessageBox.Show("Mã nhóm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                txtMa.Text = "";
                return;
            }
            else
            {
                sql = "INSERT INTO tblNhomthuoc(MANHOM,TENNHOM,GHICHU) " +
                "VALUES(N'" + txtMa.Text.Trim() + "', N'" + txtTen.Text.Trim() + "', N'" + txtGhichu.Text.Trim() + "')";
                Class.Functions.RunSql(sql);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            reset();
            txtMa.Focus();
            return;
        }

        public frmAdd_nhomthuoc()
        {
            InitializeComponent();
        }

        private void frmAdd_nhomthuoc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
        }

        private void ketnoi()
        {
            sql = "select MANHOM,TENNHOM,GHICHU from tblNhomthuoc ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }

        private void reset()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtGhichu.Text = "";
        }

    }
}
