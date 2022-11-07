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
    public partial class frmUp_nhanvien : Form
    {
        DataTable khuong;
        string sql;

        public frmUp_nhanvien(string manhanvien, string tennhanvien, string diachi, string sodienthoai, string taikhoan, string matkhau, string quyen)
        {
            InitializeComponent();
            txtMa.Text = manhanvien;
            txtTen.Text = tennhanvien;
            txtDiachi.Text = diachi;
            mskDienthoai.Text = sodienthoai;
            txtTaikhoan.Text = taikhoan;
            txtMatkhau.Text = matkhau;
            if (quyen == "admin")
            {
                rdAdmin.Checked = true;
            }
            else rdAdmin.Checked = false;
        }

        private void frmUp_nhanvien_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
            mokhoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtDiachi.Enabled = false;
            txtTaikhoan.Enabled = false;
            txtMatkhau.Enabled = false;
            mskDienthoai.Enabled = false;
            rdAdmin.Enabled = false;
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            mokhoa();
        }

        private void mokhoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiachi.Enabled = true;
            txtTaikhoan.Enabled = true;
            txtMatkhau.Enabled = true;
            mskDienthoai.Enabled = true;
            rdAdmin.Enabled = true;
        }


        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql, quyenhan;
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtTaikhoan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();
                return;
            }
            if (txtMatkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                return;
            }
            if (rdAdmin.Checked == true)
            {
                quyenhan = "admin";
            }
            else
                quyenhan = "nhanvien";

            sql = "Update tblNhanvien set TENNHANVIEN=N'" + txtTen.Text.Trim() + "',DIACHI=N'" + txtDiachi.Text.Trim() + "',SDT= N'" + mskDienthoai.Text + "'," +
                "TAIKHOAN=N'" + txtTaikhoan.Text.Trim() + "',MATKHAU=N'" + txtMatkhau.Text.Trim() + "'," +
                        "QUYEN=N'" + quyenhan + "' where MANHANVIEN='" + txtMa.Text + "'";
            Class.Functions.RunSql(sql);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoa();
        }
    }
}
