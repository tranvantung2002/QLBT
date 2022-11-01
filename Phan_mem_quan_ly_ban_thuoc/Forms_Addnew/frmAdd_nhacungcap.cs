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
    public partial class frmAdd_nhacungcap : Form
    {        
        DataTable khuong;
        string sql;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmAdd_nhacungcap()
        {
            InitializeComponent();
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            reset1();
            txtMa.Focus();
            return;
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
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (txtMasothue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã số thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasothue.Focus();
                return;
            }

            sql = "SELECT MANCC FROM tblNhacungcap WHERE MANCC=N'" + txtMa.Text.Trim() + "'";            
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            if (grdData.Rows.Count > 1)
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                txtMa.Text = "";
                return;
            }
            else
            {
                sql = "INSERT INTO tblNhacungcap(MANCC,TENNCC,SDT, EMAIL, MST) " +
                "VALUES(N'" + txtMa.Text.Trim() + "', N'" + txtTen.Text.Trim() + "', N'" + mskDienthoai.Text + "', N'" + txtDiachi.Text.Trim() + "',N'" + txtMasothue.Text.Trim() + "')";
                Class.Functions.RunSql(sql);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset1();
        }

        private void reset1()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtMasothue.Text = "";
            mskDienthoai.Text = "(   )     ";
        }

        private void frmAdd_nhacungcap_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
        }

        private void ketnoi()
        {
            sql = "select MANHANVIEN,TENNHANVIEN,DIACHI,SDT,TAIKHOAN,MATKHAU,QUYEN from tblNhanvien ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }
    }
}
