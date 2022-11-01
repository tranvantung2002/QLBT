using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc.Forms
{
    public partial class frmMain : Form
    {
        public frmMain(string fullname,string quyenhan)
        {
            InitializeComponent();
            lblNguoidung.Text =  fullname;
            lblQuyen.Text = quyenhan; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoigian.Text = System.DateTime.Now.ToString();
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
            if(hello1=="nhanvien")
            {
                MessageBox.Show("Bạn không phải là người quản lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Forms.frmQuanlynhanvien f = new Forms.frmQuanlynhanvien(hello,hello1);
                f.Show();
                this.Visible = false;
            }    
            
        }

        private void DMThuoc_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmDMThuoc f = new Forms.frmDMThuoc(hello,hello1);
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

        private void Main_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            string hello1 = lblQuyen.Text;
            Forms.frmMain f = new Forms.frmMain(hello,hello1);
            f.Show();
            this.Visible = false;
            
        }

        private void Huongdan_Click(object sender, EventArgs e)
        {
            Forms_Messagebox.frm_Message_Hotro f = new Forms_Messagebox.frm_Message_Hotro();
            f.ShowDialog();
        }

        private void DT_Nhomthuoc_Click(object sender, EventArgs e)
        {
            string hello= lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Doanhthu_Nhomthuoc f = new Forms_SP_Reports.frm_SP_Doanhthu_Nhomthuoc(hello);
            f.ShowDialog();
        }

        private void DT_Theothang_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Doanhthu_Theothang f = new Forms_SP_Reports.frm_SP_Doanhthu_Theothang(hello);
            f.ShowDialog();
        }

        private void doanhThuTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_DT_Khachhang f = new Forms_SP_Reports.frm_SP_DT_Khachhang(hello);
            f.ShowDialog();
        }

        private void BCNhaphang_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Tonkho f = new Forms_SP_Reports.frm_SP_Tonkho(hello);
            f.ShowDialog();
        }

        private void BCHSD_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_Thuoc_Hethan f = new Forms_SP_Reports.frm_SP_Thuoc_Hethan(hello);
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
