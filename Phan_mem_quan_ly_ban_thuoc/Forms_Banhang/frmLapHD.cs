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
using Phan_mem_quan_ly_ban_thuoc.Class;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Banhang
{
    
    public partial class frmLapHD : Form
    {
        DataTable khuong;
        string sql;
        public frmLapHD(string hello, string hello1)
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

        private void frmLapHD_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
            khoidau();
            lblChuongtrinh.Text = "Lập hoá đơn bán hàng !!! Đang chạy ....";

        }
               
        private void khoidau()
        {
            
            txtNgaynhap.Text = DateTime.Now.ToShortDateString();
            txtMaHD.Text = Class.Functions.CreateKey("HD");
            Class.Functions.FillCombo("SELECT MAKHACH, TENKHACH FROM tblKhachhang", cboKhachhang, "MAKHACH", "TENKHACH");
            cboKhachhang.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT a.MATHUOC, a.TENTHUOC FROM tblThuoc as a,tblCTPhieunhap as b where a.MATHUOC=b.MATHUOC group by a.MATHUOC, a.TENTHUOC", cboThuoc, "MATHUOC", "TENTHUOC");
            cboThuoc.SelectedIndex = -1;            
            txtNhanvien.Text = lblNguoidung.Text;
        }

        private void cboThuoc_TextChanged(object sender, EventArgs e)
        {
            Class.Functions.FillCombo("SELECT LOSX FROM tblCTPhieunhap where MATHUOC=N'" + cboThuoc.SelectedValue + "'", cboLosx, "LOSX", "LOSX");
            cboLosx.SelectedIndex = -1;
            string str;
            if (cboThuoc.Text == "")
            {
                txtDVT.Text = "";
            }
            
            str = "Select DVT from tblThuoc where MATHUOC = N'" + cboThuoc.SelectedValue + "'";
            txtDVT.Text = Class.Functions.GetFieldValues(str);
            str = "Select DONGIA from tblCTPhieunhap where MATHUOC=N'" + cboThuoc.SelectedValue + "'";
            txtDongia.Text = Class.Functions.GetFieldValues(str);


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql;
            double tong, Tongmoi;
            double sl;
            sql = "SELECT MABAN FROM tblHoadonban WHERE MABAN=N'" + txtMaHD.Text + "'";
            if (!Functions.CheckKey(sql))
            {                
                if (txtNgaynhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgaynhap.Focus();
                    return;
                }
                if (cboKhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboKhachhang.Focus();
                    return;
                }
                sql = "INSERT INTO tblHoadonban(MABAN, NGAYNHAP, MAKHACH,MANHANVIEN,TONGTIEN) VALUES(N'" + txtMaHD.Text.Trim() + "', '" +
                Functions.ConvertDateTime(txtNgaynhap.Text.Trim()) + "',N'" + cboKhachhang.SelectedValue + "',N'" + txtNhanvien.Text.Trim() + "'," + txtTongtien.Text + ")";
                Functions.RunSql(sql);
            }


            if (cboThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThuoc.Focus();
                return;
            }            
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (cboLosx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lô sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongia.Focus();
                return;
            }

            sql = "SELECT MATHUOC FROM tblCTHoadonban WHERE MATHUOC=N'" + cboThuoc.SelectedValue + "' AND MABAN = N'" + txtMaHD.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cboThuoc.Focus();
                return;
            }

            DateTime thoigian1 = Convert.ToDateTime(Functions.GetFieldValues("SELECT nhap.HSD from tblThuoc as thuoc,tblCTPhieunhap as nhap WHERE thuoc.MATHUOC = nhap.MATHUOC and nhap.LOSX = N'" + cboLosx.SelectedValue + "' and thuoc.MATHUOC = N'" + cboThuoc.SelectedValue + "'"));
            DateTime thoigian3 = Convert.ToDateTime(Functions.GetFieldValues("SELECT ban.NGAYNHAP from tblHoadonban as ban WHERE  ban.NGAYNHAP = '" + Functions.ConvertDateTime(txtNgaynhap.Text.Trim()) + "'"));
            DateTime thoigian2 = DateTime.Now;
            TimeSpan thoigianconlai = thoigian1 - thoigian3;
            int sosanh = thoigianconlai.Days;
            if (sosanh < 0)
            {
                MessageBox.Show("Thuốc : " + cboThuoc.Text + " Lô : " + cboLosx.Text + " đã hết hạn sử dụng. Vui lòng chọn lô sản xuất khác !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLosx.Text = "";
                cboLosx.Focus();
                return;
            }


            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT (nhap.SLUONG-ISNULL(ban.SLUONG,0)) from tblThuoc as thuoc,tblCTPhieunhap as nhap left join tblCTHoadonban as ban on nhap.MATHUOC = ban.MATHUOC WHERE thuoc.MATHUOC = nhap.MATHUOC and thuoc.MATHUOC = N'" + cboThuoc.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }

            
            
            


            double thanhtien = Convert.ToDouble(txtSoluong.Text) * Convert.ToDouble(txtDongia.Text);
            sql = "INSERT INTO tblCTHoadonban(MABAN,MATHUOC,LOSX,DVT,DONGIA,SLUONG,THANHTIEN)" +
                " VALUES(N'" + txtMaHD.Text.Trim() + "', N'" + cboThuoc.SelectedValue + "', N'" +
                cboLosx.Text.Trim() + "', N'" + txtDVT.Text.Trim() +
                "', N'" + txtDongia.Text.Trim() + "'," + txtSoluong.Text + "," + thanhtien + ")"; 
            Functions.RunSql(sql);
            ketnoi();
                        
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM tblHoadonban WHERE MABAN = N'" + txtMaHD.Text + "'"));
            Tongmoi = tong + (Convert.ToDouble(txtDongia.Text) * Convert.ToDouble(txtSoluong.Text));
            sql = "UPDATE tblHoadonban SET TONGTIEN =" + Tongmoi + " WHERE MABAN = N'" + txtMaHD.Text + "'";
            Functions.RunSql(sql);
            txtTong.Text = Tongmoi.ToString();
            double tongket = Tongmoi - Tongmoi*Convert.ToDouble(txtGiamgia.Text);
            txtTongtien.Text = tongket.ToString();
            ResetValuesHang();
            
        }

        private void ketnoi()
        {
            sql = "select a.MATHUOC,a.TENTHUOC,b.LOSX,b.DVT,b.DONGIA,b.SLUONG,b.THANHTIEN from tblThuoc as a,tblCTHoadonban as b where a.MATHUOC=b.MATHUOC and b.MABAN = N'" + txtMaHD.Text.Trim() + "'";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }

        private void ResetValuesHang()
        {
            cboThuoc.Text = "";
            txtSoluong.Text = "";
            txtDongia.Text = "0";
            cboLosx.Text = "";
            txtDVT.Text = "";
            
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, gg;            
            gg = Convert.ToDouble(txtGiamgia.Text);            
            tt = Convert.ToDouble(txtTong.Text);
            tt = tt - tt * gg * 0.01;
            txtTongtien.Text = tt.ToString(); 
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtTongtien.Text);
            b = Convert.ToDouble(txtKhachtra.Text);
            c = b - a;
            txtTrakhach.Text = c.ToString();
        }

        private void txtKhachtra_TextChanged(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtTongtien.Text);
            b = Convert.ToDouble(txtKhachtra.Text);
            c = b - a;
            txtTrakhach.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khoidau();
            ketnoi();
            double aa = Convert.ToDouble(txtTrakhach.Text);
            if (Convert.ToDouble(txtTrakhach.Text)>0)
            {
                MessageBox.Show("Bạn cần phải trả khách thêm " + aa, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn cần thu thêm của khách " + aa*(-1), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            txtSoluong.Text = "";
            txtKhachtra.Text = "0";
            txtGiamgia.Text = "0";
            txtTong.Text = "0";
            txtTongtien.Text = "0";
            txtTrakhach.Text = "0";
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            double tong, Tongmoi;
            double sl;
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM tblHoadonban WHERE MABAN = N'" + txtMaHD.Text + "'"));
            if (khuong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                Tongmoi = tong - (Convert.ToDouble(txtDongia.Text) * Convert.ToDouble(txtSoluong.Text));
                sql = "UPDATE tblHoadonban SET TONGTIEN =" + Tongmoi + " WHERE MABAN = N'" + txtMaHD.Text + "'";
                Functions.RunSql(sql);
                txtTong.Text = Tongmoi.ToString();
                double tongket = Tongmoi - Tongmoi * Convert.ToDouble(txtGiamgia.Text);
                txtTongtien.Text = tongket.ToString();
                ResetValuesHang();

                sql = "DELETE tblCTHoadonban WHERE MABAN=N'" + txtMaHD.Text + "' and MATHUOC=N'" + txtMathuoc.Text + "'";
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                Class.Functions.RunSqlDel(sql);
                ketnoi();
            }

            
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMathuoc.Text = grdData.Rows[i].Cells["MATHUOC"].Value.ToString();
            txtDongia.Text = grdData.Rows[i].Cells["DONGIA"].Value.ToString();
            txtSoluong.Text = grdData.Rows[i].Cells["SLUONG"].Value.ToString();
            txtDVT.Text = grdData.Rows[i].Cells["DVT"].Value.ToString();
            cboLosx.Text= grdData.Rows[i].Cells["LOSX"].Value.ToString();
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

        private void doanhThuTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hello = lblNguoidung.Text;
            Forms_SP_Reports.frm_SP_DT_Khachhang f = new Forms_SP_Reports.frm_SP_DT_Khachhang(hello);
            f.ShowDialog();
        }

        private void btnThemnhom_Click(object sender, EventArgs e)
        {            
            Forms_Addnew.frmAdd_khachhang f = new Forms_Addnew.frmAdd_khachhang();
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
    }

}
