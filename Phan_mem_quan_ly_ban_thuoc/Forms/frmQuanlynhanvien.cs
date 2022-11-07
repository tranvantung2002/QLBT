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
    public partial class frmQuanlynhanvien : Form
    {
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql,  fname;

        public frmQuanlynhanvien()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if(comTruong.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn trường cần tìm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comGT.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn giá trị cần tìm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                dt.Clear();
                sql = "select MANHANVIEN,TENNHANVIEN,DIACHI,SDT,TAIKHOAN,MATKHAU,QUYEN from tblNhanvien " +
                    "where " + fname + "= N'" + comGT.Text + "' order by MANHANVIEN";
                khuong = Class.Functions.GetDataToTable(sql);
                grdData.DataSource = khuong; //đổ dl vào ô lưới
                grdData.Refresh();
            }       
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            comTruong.Text = "";
            comGT.Text = "";
            ketnoi();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã nhân viên")
            {
                fname = "MANHANVIEN";
            }
            if (comTruong.Text == "Tên nhân viên")
            { 
                fname = "TENNHANVIEN"; 
            }
            if (comTruong.Text == "Quyền")
            {
                fname = "QUYEN";
            }
            Class.Functions.FillCombo("select distinct " + fname + " from tblNhanvien", comGT, fname, fname);
            comGT.SelectedIndex = -1;
        }



        private void btnAddnew_Click(object sender, EventArgs e)
        {
            string a="", b="", c="", d="", matkhau="", fh="", g="";
            Forms_Addnew.frmAdd_nhanvien f = new Forms_Addnew.frmAdd_nhanvien(a,b,c,d,matkhau,fh,g);
            f.ShowDialog();
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
                sql = "DELETE tblNhanvien WHERE MANHANVIEN=N'" + txtMa.Text + "'";
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                Class.Functions.RunSqlDel(sql);
                ketnoi();
                
            }
        }


        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMa.Text = grdData.Rows[i].Cells["MANHANVIEN"].Value.ToString();
        }

        private void grdData_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string manhanvien = grdData.Rows[i].Cells["MANHANVIEN"].Value.ToString();
            string tennhanvien = grdData.Rows[i].Cells["TENNHANVIEN"].Value.ToString();
            string diachi = grdData.Rows[i].Cells["DIACHI"].Value.ToString();
            string sodienthoai = grdData.Rows[i].Cells["SDT"].Value.ToString();
            string taikhoan = grdData.Rows[i].Cells["TAIKHOAN"].Value.ToString();
            string matkhau = grdData.Rows[i].Cells["MATKHAU"].Value.ToString();
            string quyen = grdData.Rows[i].Cells["QUYEN"].Value.ToString();
            Forms_Update.frmUp_nhanvien f = new Forms_Update.frmUp_nhanvien(manhanvien, tennhanvien, diachi, sodienthoai, taikhoan, matkhau, quyen);
            f.ShowDialog();
        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanlynhanvien_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Nunito");/*Khởi tạo font mới*/
            //grdData.Font = new Font(f, 10,FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
            grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
        }

        private void ketnoi()
        {
            sql = "select MANHANVIEN,TENNHANVIEN,DIACHI,SDT,TAIKHOAN,MATKHAU,QUYEN from tblNhanvien ";
            khuong = Class.Functions.GetDataToTable(sql);           
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string manhanvien = grdData.Rows[i].Cells["MANHANVIEN"].Value.ToString();
            string tennhanvien = grdData.Rows[i].Cells["TENNHANVIEN"].Value.ToString();
            string diachi = grdData.Rows[i].Cells["DIACHI"].Value.ToString();
            string sodienthoai = grdData.Rows[i].Cells["SDT"].Value.ToString();
            string taikhoan = grdData.Rows[i].Cells["TAIKHOAN"].Value.ToString();
            string matkhau = grdData.Rows[i].Cells["MATKHAU"].Value.ToString();
            string quyen = grdData.Rows[i].Cells["QUYEN"].Value.ToString();
            Forms_Update.frmUp_nhanvien f = new Forms_Update.frmUp_nhanvien(manhanvien, tennhanvien, diachi, sodienthoai, taikhoan, matkhau, quyen);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?Y/N", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int i = grdData.CurrentRow.Index;
                sql = "delete from tblNhanvien where MANHANVIEN = '" + grdData.Rows[i].Cells["MANHANVIEN"].Value.ToString() + "';";
                Class.Functions.RunSqlDel(sql);
                ketnoi();
            }
        }
    }
}
