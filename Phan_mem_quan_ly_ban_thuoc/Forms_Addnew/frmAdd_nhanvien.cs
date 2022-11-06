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
    public partial class frmAdd_nhanvien : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable khuong;
        string sql, constr, fname;
        int i, n;
        public frmAdd_nhanvien(string manhanvien,string tennhanvien,string diachi,string sodienthoai,string taikhoan,string matkhau,string quyen)
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
        private void ketnoi()
        {
            sql = "select MANHANVIEN,TENNHANVIEN,DIACHI,SDT,TAIKHOAN,MATKHAU,QUYEN from tblNhanvien ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ketnoi();
            this.Close();
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            reset1();
            txtMa.Focus();
            return;
        }

        private void reset1()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            mskDienthoai.Text = "(   )     ";
            rdAdmin.Checked = false;
        }

        private void frmAdd_nhanvien_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
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

            sql = "SELECT MANHANVIEN FROM tblNhanvien WHERE MANHANVIEN=N'" + txtMa.Text.Trim() + "'";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            if (grdData.Rows.Count > 1)
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                txtMa.Text = "";
                return;
            }
            else
            {
                sql = "INSERT INTO tblNhanvien(MANHANVIEN,TENNHANVIEN,SDT, DIACHI, TAIKHOAN, MATKHAU, QUYEN) " +
                "VALUES(N'" + txtMa.Text.Trim() + "', N'" + txtTen.Text.Trim() + "', N'" + mskDienthoai.Text + "', N'" + txtDiachi.Text.Trim() +"',N'" + txtTaikhoan.Text.Trim() + "', N'" + txtMatkhau.Text.Trim() + "', N'" + quyenhan + "')";
                Class.Functions.RunSql(sql);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi();
            }
            reset1();
        }


    }
}
