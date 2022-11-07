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

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Quanlykho
{
    public partial class frmHDNhap : Form
    {
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql, fname;
        public frmHDNhap()
        {
            InitializeComponent();
        }

        private void frmHDNhap_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Nunito");/*Khởi tạo font mới*/
            //grdData.Font = new Font(f, 10, FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
            grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
            grdData.Cursor = default;

        }

        private void ketnoi()
        {
            sql = "select a.MANHAP,a.NGAYNHAP,b.TENNCC,a.TONGTIEN,a.GHICHU from tblPhieunhap as a,tblNhacungcap as b where a.MANCC=b.MANCC ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
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

        private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string manhap = grdData.Rows[i].Cells["MANHAP"].Value.ToString();
            string ngaynhap = grdData.Rows[i].Cells["NGAYNHAP"].Value.ToString();
            string tenncc = grdData.Rows[i].Cells["TENNCC"].Value.ToString();
            string tongtien = grdData.Rows[i].Cells["TONGTIEN"].Value.ToString();
            Forms_Update.frmUp_Phieunhap f = new Forms_Update.frmUp_Phieunhap(manhap, ngaynhap, tenncc, tongtien);
            f.ShowDialog();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_Phieunhap f = new Forms_Addnew.frmAdd_Phieunhap();
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT MATHUOC FROM tblCTPhieunhap WHERE MANHAP = N'" + txtMa.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Class.Functions.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtMa.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE tblPhieunhap WHERE MANHAP=N'" + txtMa.Text + "'";
                Class.Functions.RunSqlDel(sql);
                ketnoi();              
            }
        }

        private void DelHang(string Mahoadon, string Mahang)
        {
            string sql;            
            sql = "DELETE tblCTPhieunhap WHERE MANHAP=N'" + Mahoadon + "' AND MATHUOC = N'" + Mahang + "'";
            Class.Functions.RunSqlDel(sql);
         }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMa.Text = grdData.Rows[i].Cells["MANHAP"].Value.ToString();
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
                sql = "select a.MANHAP,a.MANCC,a.NGAYNHAP,b.TENNCC,a.TONGTIEN,a.GHICHU from tblPhieunhap as a,tblNhacungcap as b " +
                    "where a." + fname + "= N'" + comGT.Text + "' and a.MANCC=b.MANCC order by a.MANCC ";
                khuong = Class.Functions.GetDataToTable(sql);
                grdData.DataSource = khuong;
                grdData.Refresh();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã nhập")
            {
                fname = "MANHAP";
            }
            if (comTruong.Text == "Mã nhà cung cấp")
            {
                fname = "MANCC";
            }
            Class.Functions.FillCombo("select distinct " + fname + " from tblPhieunhap", comGT, fname, fname);
            comGT.SelectedIndex = -1;
        }

    }
}
