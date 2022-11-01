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
        public frmTKHoadon(string hello, string hello1)
        {
            InitializeComponent();
            lblNguoidung.Text = hello;
            lblQuyen.Text = hello1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoigian.Text = System.DateTime.Now.ToString();
            int n = grdData.RowCount - 1;
            lblTong.Text = "Tổng số : " + n.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Forms_Messagebox.frm_Message_Thoat f = new Forms_Messagebox.frm_Message_Thoat();
            f.ShowDialog();
        }

        private void Dangnhaplai_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Visible = false;
        }

        private void Quanlynguoidung_Click(object sender, EventArgs e)
        {

            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            if (hello1 == "nhanvien")
            {
                MessageBox.Show("Bạn không phải là người quản lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Forms.frmQuanlynhanvien f = new Forms.frmQuanlynhanvien(hello, hello1);
                f.Show();
                this.Visible = false;
            }

        }

        private void DMThuoc_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmDMThuoc f = new Forms.frmDMThuoc(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void DMNhomthuoc_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmDMNhomthuoc f = new Forms.frmDMNhomthuoc(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void DMKhachhang_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmDMKhachhang f = new Forms.frmDMKhachhang(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void DMNhacungcap_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmDMNhacungcap f = new Forms.frmDMNhacungcap(hello, hello1);
            f.Show();
            this.Visible = false;

        }

        private void HDNhap_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms_Quanlykho.frmHDNhap f = new Forms_Quanlykho.frmHDNhap(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void Tonkho_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms_Quanlykho.frmTonkho f = new Forms_Quanlykho.frmTonkho(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void Truyxuat_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms_Quanlykho.frmTruyxuat f = new Forms_Quanlykho.frmTruyxuat(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void LapHD_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms_Banhang.frmLapHD f = new Forms_Banhang.frmLapHD(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void TKHoadon_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms_Banhang.frmTKHoadon f = new Forms_Banhang.frmTKHoadon(hello, hello1);
            f.Show();
            this.Visible = false;
        }

        private void BCDoanhthu_Click(object sender, EventArgs e)
        {
            //Đợi thầy dạy report
        }

        private void BCNhaphang_Click(object sender, EventArgs e)
        {
            //Đợi thầy dạy report
        }

        private void BCHSD_Click(object sender, EventArgs e)
        {
            //Đợi thầy dạy report
        }

        private void Main_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmMain f = new Forms.frmMain(hello, hello1);
            f.Show();
            this.Visible = false;

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms_Banhang.frmLapHD f = new Forms_Banhang.frmLapHD(hello, hello1);
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
            FontFamily f = new FontFamily("Nunito");/*Khởi tạo font mới*/
            grdData.Font = new Font(f, 10, FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
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

        private void DT_Nhomthuoc_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Doanhthu_Nhomthuoc f = new Forms_SP_Reports.frm_SP_Doanhthu_Nhomthuoc(hello);
            f.ShowDialog();
        }

        private void DT_Theothang_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Doanhthu_Theothang f = new Forms_SP_Reports.frm_SP_Doanhthu_Theothang(hello);
            f.ShowDialog();
        }

        private void BCNhaphang_Click_1(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Tonkho f = new Forms_SP_Reports.frm_SP_Tonkho(hello);
            f.ShowDialog();
        }

        private void BCHSD_Click_1(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Thuoc_Hethan f = new Forms_SP_Reports.frm_SP_Thuoc_Hethan(hello);
            f.ShowDialog();
        }

        private void Huongdan_Click(object sender, EventArgs e)
        {
            Forms_Messagebox.frm_Message_Hotro f = new Forms_Messagebox.frm_Message_Hotro();
            f.ShowDialog();
        }

        private void doanhThuTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_DT_Khachhang f = new Forms_SP_Reports.frm_SP_DT_Khachhang(hello);
            f.ShowDialog();
        }
    }
}
