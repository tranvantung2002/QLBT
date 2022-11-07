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
        string name = "", quyen = "";
        public frmMain(string fullname, string quyenhan)
        {
            InitializeComponent();
            name = fullname;
            quyen = quyenhan;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Forms_Messagebox.frm_Message_Thoat f = new Forms_Messagebox.frm_Message_Thoat();
            f.ShowDialog();
        }


        private void Quanlynguoidung_Click(object sender, EventArgs e)
        {

            if (quyen.ToLower() == "nhanvien".ToLower())
            {
                MessageBox.Show("Bạn không phải là người quản lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Forms.frmQuanlynhanvien f = new Forms.frmQuanlynhanvien();
                LoadForm(f, "Quản lý nhân viên");
            }

        }

        private void DMThuoc_Click(object sender, EventArgs e)
        {
            Forms.frmDMThuoc f = new Forms.frmDMThuoc();
            LoadForm(f, "Danh mục thuốc");
        }

        private void DMNhomthuoc_Click(object sender, EventArgs e)
        {
            Forms.frmDMNhomthuoc f = new Forms.frmDMNhomthuoc();
            LoadForm(f, "Quản nhóm thuốc");
        }

        private void DMKhachhang_Click(object sender, EventArgs e)
        {
            Forms.frmDMKhachhang f = new Forms.frmDMKhachhang();
            LoadForm(f, "Quản lý khách hàng");
        }

        private void DMNhacungcap_Click(object sender, EventArgs e)
        {
            Forms.frmDMNhacungcap f = new Forms.frmDMNhacungcap();
            LoadForm(f, "Quản lý nhà cung cấp");
        }

        private void HDNhap_Click(object sender, EventArgs e)
        {
            Forms_Quanlykho.frmHDNhap f = new Forms_Quanlykho.frmHDNhap();
            LoadForm(f, "Quản lý hoá đơn nhập");
        }

        private void Tonkho_Click(object sender, EventArgs e)
        {
            Forms_Quanlykho.frmTonkho f = new Forms_Quanlykho.frmTonkho();
            LoadForm(f, "Quản lý hàng tồn kho");
        }

        private void Truyxuat_Click(object sender, EventArgs e)
        {
            Forms_Quanlykho.frmTruyxuat f = new Forms_Quanlykho.frmTruyxuat();
            LoadForm(f, "Quản lý truy xuất");
        }

        private void LapHD_Click(object sender, EventArgs e)
        {
            Forms_Banhang.frmLapHD f = new Forms_Banhang.frmLapHD();
            LoadForm(f, "Quản lý lập hoá đơn");
        }

        private void TKHoadon_Click(object sender, EventArgs e)
        {
            Forms_Banhang.frmTKHoadon f = new Forms_Banhang.frmTKHoadon();
            LoadForm(f, "Quản lý hoá đơn");
        }

        private void Main_Click(object sender, EventArgs e)
        {
            panelApp.Controls.Clear();
            LbTieuDe.Text = "Chương trình quản lí bán thuốc";
        }

        private void Huongdan_Click(object sender, EventArgs e)
        {
            Forms_Messagebox.frm_Message_Hotro f = new Forms_Messagebox.frm_Message_Hotro();
            f.ShowDialog();
        }

        private void DT_Nhomthuoc_Click(object sender, EventArgs e)
        {
            Forms_SP_Reports.frm_SP_Doanhthu_Nhomthuoc f = new Forms_SP_Reports.frm_SP_Doanhthu_Nhomthuoc();
            f.ShowDialog();
        }

        private void DT_Theothang_Click(object sender, EventArgs e)
        {
            Forms_SP_Reports.frm_SP_Doanhthu_Theothang f = new Forms_SP_Reports.frm_SP_Doanhthu_Theothang();
            f.ShowDialog();
        }

        private void doanhThuTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_SP_Reports.frm_SP_DT_Khachhang f = new Forms_SP_Reports.frm_SP_DT_Khachhang();
            f.ShowDialog();
        }

        private void BCNhaphang_Click(object sender, EventArgs e)
        {
            Forms_SP_Reports.frm_SP_Tonkho f = new Forms_SP_Reports.frm_SP_Tonkho();
            f.ShowDialog();
        }

        private void BCHSD_Click(object sender, EventArgs e)
        {
            Forms_SP_Reports.frm_SP_Thuoc_Hethan f = new Forms_SP_Reports.frm_SP_Thuoc_Hethan();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(141, 153, 174);
            lblNguoidung.Text = $"Người dùng  : {name} \nQuyền : {quyen}";
            lbtime.Text = $"Thời gian hiện tại là  :{DateTime.Now.ToString()}";
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 45, 46);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 45, 46);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 45, 46);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = $"Thời gian hiện tại là  :{DateTime.Now.ToString()}";
        }

        void LoadForm(Form f, string s)
        {
            if (panelApp.Controls.Count > 0)
            {
                if (panelApp.Controls[0].Name != f.Name)
                {
                    f.TopLevel = false;
                    f.FormBorderStyle = FormBorderStyle.None;
                    f.Dock = DockStyle.Fill;
                    panelApp.Controls.Add(f);
                    panelApp.Tag = f;
                    f.BringToFront();
                    f.Show();
                    LbTieuDe.Text = s;

                }
            }
            else
            {
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                panelApp.Controls.Add(f);
                panelApp.Tag = f;
                f.BringToFront();
                f.Show();
                LbTieuDe.Text = s;
            }

        }
    }
}
