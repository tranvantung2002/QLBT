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
    public partial class frmDMNhomthuoc : Form
    {
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql,  fname;
        public frmDMNhomthuoc()
        {
            InitializeComponent();
        }

        private void frmDMNhomthuoc_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Nunito");/*Khởi tạo font mới*/
            //grdData.Font = new Font(f, 10, FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
            grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trường cần tìm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comGT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giá trị cần tìm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.Clear();
                sql = "select MANHOM,TENNHOM,GHICHU from tblNhomthuoc " +
                    "where " + fname + "= N'" + comGT.Text + "' order by MANHOM";
                khuong = Class.Functions.GetDataToTable(sql);
                grdData.DataSource = khuong; //đổ dl vào ô lưới
                grdData.Refresh();
            }
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

        private void btnTK_Click(object sender, EventArgs e)
        {
            comTruong.Text = "";
            comGT.Text = "";
            ketnoi();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ketnoi();
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
                sql = "DELETE tblNhomthuoc WHERE MANHOM=N'" + txtMa.Text + "'";
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                Class.Functions.RunSqlDel(sql);
                ketnoi();
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_nhomthuoc f = new Forms_Addnew.frmAdd_nhomthuoc();
            f.ShowDialog();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMa.Text = grdData.Rows[i].Cells["MANHOM"].Value.ToString();
        }

        private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string mathuoc = grdData.Rows[i].Cells["MANHOM"].Value.ToString();
            string tenthuoc = grdData.Rows[i].Cells["TENNHOM"].Value.ToString();
            string manhom = grdData.Rows[i].Cells["GHICHU"].Value.ToString();
            Forms_Update.frmUp_nhomthuoc f = new Forms_Update.frmUp_nhomthuoc(mathuoc, tenthuoc, manhom);
            f.ShowDialog();

        }

        private void ketnoi()
        {
            sql = "select MANHOM,TENNHOM,GHICHU from tblNhomthuoc ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Tên nhóm")
            {
                fname = "TENNHOM";
            }
            if (comTruong.Text == "Mã nhóm")
            {
                fname = "MANHOM";
            }
            Class.Functions.FillCombo("select distinct " + fname + " from tblNhomthuoc", comGT, fname, fname);
            comGT.SelectedIndex = -1;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
