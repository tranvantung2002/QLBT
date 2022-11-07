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
    public partial class frmUp_khachhang : Form
    {
        DataTable khuong;
        string sql;
        public frmUp_khachhang(string a,string b,string c,string d,string e)
        {
            InitializeComponent();
            txtMa.Text = a;
            txtTen.Text = b;
            mskDienthoai.Text = d;
            txtDiachi.Text = c;
            txtMasothue.Text = e;

        }

        private void frmUp_khachhang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
            //khoa();
            mokhoa();
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            mokhoa();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (txtMasothue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasothue.Focus();
                return;
            }

            sql = "Update tblKhachhang set TENKHACH=N'" + txtTen.Text.Trim() + "',EMAIL=N'" + txtMasothue.Text.Trim() + "',SDT= N'" + mskDienthoai.Text + "'," +
                "DIACHI=N'" + txtDiachi.Text.Trim() + "' where MAKHACH='" + txtMa.Text + "'";
            Class.Functions.RunSql(sql);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ketnoi()
        {
            sql = "select MAKHACH,TENKHACH,DIACHI,EMAIL,SDT from tblKhachhang ";
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
