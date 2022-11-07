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

namespace Phan_mem_quan_ly_ban_thuoc.Forms
{
    public partial class frmDMKhachhang : Form
    {        
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql,  fname;
        public frmDMKhachhang()
        {
            InitializeComponent();
        }

        private void frmDMKhachhang_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Nunito");
            //grdData.Font = new Font(f, 10, FontStyle.Bold);
            //grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
            grdData.Cursor = default;
            lblChuongtrinh.Text = "Danh mục khách hàng !!! Đang chạy ....";

        }

        private void ketnoi()
        {
            sql = "select MAKHACH,TENKHACH,DIACHI,EMAIL,SDT from tblKhachhang ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã khách")
            {
                fname = "MAKHACH";
            }
            if (comTruong.Text == "Tên khách")
            {
                fname = "TENKHACH";
            }
            if (comTruong.Text == "Địa chỉ")
            {
                fname = "DIACHI";
            }
            Class.Functions.FillCombo("select distinct " + fname + " from tblKhachhang", comGT, fname, fname);
            comGT.SelectedIndex = -1;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            comTruong.Text = "";
            comGT.Text = "";
            ketnoi();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMa.Text = grdData.Rows[i].Cells["MAKHACH"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (khuong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhachhang WHERE MAKHACH=N'" + txtMa.Text + "'";
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                Class.Functions.RunSqlDel(sql);
                ketnoi();
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_khachhang f = new Forms_Addnew.frmAdd_khachhang();
            f.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // ketnoi();
        }

        private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string manhanvien = grdData.Rows[i].Cells["MAKHACH"].Value.ToString();
            string tennhanvien = grdData.Rows[i].Cells["TENKHACH"].Value.ToString();
            string diachi = grdData.Rows[i].Cells["DIACHI"].Value.ToString();
            string sodienthoai = grdData.Rows[i].Cells["SDT"].Value.ToString();
            string email = grdData.Rows[i].Cells["EMAIL"].Value.ToString();
            Forms_Update.frmUp_khachhang f = new Forms_Update.frmUp_khachhang(manhanvien, tennhanvien, diachi, sodienthoai, email);
            f.ShowDialog();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trường cần tìm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.Clear();
                sql = "select MAKHACH,TENKHACH,DIACHI,EMAIL,SDT from tblKhachhang " +
                    "where " + fname + "= N'" + comGT.Text + "' order by MAKHACH";
                khuong = Class.Functions.GetDataToTable(sql);
                grdData.DataSource = khuong; //đổ dl vào ô lưới
                grdData.Refresh();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
        }
  
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?Y/N", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int i = grdData.CurrentRow.Index;
                sql = "delete from tblKhachhang where MAKHACH = '" + grdData.Rows[i].Cells["MAKHACH"].Value.ToString() + "';";
                Class.Functions.RunSqlDel(sql);
                ketnoi();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string manhanvien = grdData.Rows[i].Cells["MAKHACH"].Value.ToString();
            string tennhanvien = grdData.Rows[i].Cells["TENKHACH"].Value.ToString();
            string diachi = grdData.Rows[i].Cells["DIACHI"].Value.ToString();
            string sodienthoai = grdData.Rows[i].Cells["SDT"].Value.ToString();
            string email = grdData.Rows[i].Cells["EMAIL"].Value.ToString();
            Forms_Update.frmUp_khachhang f = new Forms_Update.frmUp_khachhang(manhanvien, tennhanvien, diachi, sodienthoai, email);
            f.ShowDialog();
        }
    }
}
