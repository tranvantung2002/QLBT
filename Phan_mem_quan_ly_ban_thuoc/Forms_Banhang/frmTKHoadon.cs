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

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Banhang
{
    public partial class frmTKHoadon : Form
    {
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql,fname;
        public frmTKHoadon()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoigian.Text = System.DateTime.Now.ToString();
            int n = grdData.RowCount - 1;
            lblTong.Text = "Tổng số : " + n.ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            Forms_Banhang.frmLapHD f = new Forms_Banhang.frmLapHD();
            f.Show();
            this.Visible = false;
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
            ketnoi();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void frmTKHoadon_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Nunito");/*Khởi tạo font mới*/
            //grdData.Font = new Font(f, 10, FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
            grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
            grdData.Cursor = default;
            lblChuongtrinh.Text = "Tìm kiếm hoá đơn !!! Đang chạy ....";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT MATHUOC FROM tblCTHoadonban WHERE MABAN = N'" + txtMa.Text + "'";
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
                sql = "DELETE tblHoadonban WHERE MABAN=N'" + txtMa.Text + "'";
                Class.Functions.RunSqlDel(sql);
                ketnoi();
            }
        }

        private void DelHang(string Mahoadon, string Mahang)
        {
            string sql;
            sql = "DELETE tblCTHoadonban WHERE MABAN=N'" + Mahoadon + "' AND MATHUOC = N'" + Mahang + "'";
            Class.Functions.RunSqlDel(sql);
        }

        private void ketnoi()
        {
            sql = "select a.MABAN,a.NGAYNHAP,b.TENKHACH,a.TONGTIEN,a.GHICHU from tblHoadonban as a,tblKhachhang as b where a.MAKHACH=b.MAKHACH ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
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
                if (comTruong.Text == "Mã hoá đơn")
                {
                    dt.Clear();
                    sql = "select a.MABAN,a.NGAYNHAP,b.TENKHACH,a.TONGTIEN,a.GHICHU from tblHoadonban as a,tblKhachhang as b " +
                        "where a." + fname + "= N'" + comGT.Text + "' and a.MAKHACH=b.MAKHACH order by a.MABAN";
                    khuong = Class.Functions.GetDataToTable(sql);
                    grdData.DataSource = khuong; //đổ dl vào ô lưới
                    grdData.Refresh();
                }
                if (comTruong.Text == "Tên khách")
                {
                    dt.Clear();
                    sql = "select a.MABAN,a.NGAYNHAP,b.TENKHACH,a.TONGTIEN,a.GHICHU from tblHoadonban as a,tblKhachhang as b " +
                        "where b." + fname + "= N'" + comGT.Text + "' and a.MAKHACH=b.MAKHACH order by a.MABAN";
                    khuong = Class.Functions.GetDataToTable(sql);
                    grdData.DataSource = khuong; //đổ dl vào ô lưới
                    grdData.Refresh();
                }
                
            }
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMa.Text = grdData.Rows[i].Cells["MABAN"].Value.ToString();
        }

        private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string manhap = grdData.Rows[i].Cells["MABAN"].Value.ToString();
            string ngaynhap = grdData.Rows[i].Cells["NGAYNHAP"].Value.ToString();
            string tenncc = grdData.Rows[i].Cells["TENKHACH"].Value.ToString();
            string tongtien = grdData.Rows[i].Cells["TONGTIEN"].Value.ToString();
            Forms_CT_Hoadon.frm_CT_Hoadon f = new Forms_CT_Hoadon.frm_CT_Hoadon(manhap, ngaynhap, tenncc, tongtien);
            f.ShowDialog();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã hoá đơn")
            {
                fname = "MABAN";
                Class.Functions.FillCombo("select distinct " + fname + " from tblHoadonban", comGT, fname, fname);
                comGT.SelectedIndex = -1;
            }
            if (comTruong.Text == "Tên khách")
            {
                fname = "TENKHACH";
                Class.Functions.FillCombo("select distinct b." + fname + " from tblHoadonban as a,tblKhachhang as b where a.MAKHACH=b.MAKHACH", comGT, fname, fname);
                comGT.SelectedIndex = -1;
            }
            
        }

    }
}
