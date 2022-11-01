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
    public partial class frmUp_nhacungcap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable khuong;
        string sql, constr, fname;
        int i, n;
        public frmUp_nhacungcap(string ma,string ten,string sdt,string email,string mst)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;
            mskDienthoai.Text = sdt;
            txtDiachi.Text = email;
            txtMasothue.Text = mst;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUp_nhacungcap_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
            khoa();
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            mokhoa();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (txtMasothue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã số thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasothue.Focus();
                return;
            }

            sql = "Update tblNhacungcap set TENNCC=N'" + txtTen.Text.Trim() + "',EMAIL=N'" + txtDiachi.Text.Trim() + "',SDT= N'" + mskDienthoai.Text + "'," +
                "MST=N'" + txtMasothue.Text.Trim() + "' where MANCC='" + txtMa.Text + "'";
            Class.Functions.RunSql(sql);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoa();
        }

        private void ketnoi()
        {
            sql = "select MANHANVIEN,TENNHANVIEN,DIACHI,SDT,TAIKHOAN,MATKHAU,QUYEN from tblNhanvien ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }

        private void khoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            mskDienthoai.Enabled = false;
            txtDiachi.Enabled = false;
            txtMasothue.Enabled = false;
        }

        private void mokhoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            mskDienthoai.Enabled = true;
            txtDiachi.Enabled = true;
            txtMasothue.Enabled = true;
        }
    }
}
