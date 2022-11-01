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

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Addnew
{
    public partial class frmAdd_Phieunhap : Form
    {
        DataTable khuong;
        string sql;
        public frmAdd_Phieunhap()
        {
            InitializeComponent();
        }

        private void frmAdd_Phieunhap_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            khoidau();
            ketnoi();

        }




        private void ketnoi()
        {
            sql = "select a.MATHUOC,a.TENTHUOC,b.LOSX,b.HSD,b.DVT,b.DONGIA,b.SLUONG,b.THANHTIEN from tblThuoc as a,tblCTPhieunhap as b where a.MATHUOC=b.MATHUOC and b.MANHAP = N'" + txtManhap.Text.Trim() + "'";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }

        private void khoidau()
        {
            txtManhap.Enabled = false;
            txtTongtien.Enabled = false;
            txtQuycachdonggoi.Enabled = false;
            txtDVT.Enabled = false;
            txtNgaynhap.Text = DateTime.Now.ToShortDateString();
            txtManhap.Text = Class.Functions.CreateKey("PN");
            Class.Functions.FillCombo("SELECT MANCC, TENNCC FROM tblNhacungcap", cboNhacungcap, "MANCC", "TENNCC");
            cboNhacungcap.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MATHUOC, TENTHUOC FROM tblThuoc", cboTenthuoc, "MATHUOC", "TENTHUOC");
            cboNhacungcap.SelectedIndex = -1;
            txtTongtien.Text = "0";
        }

        private void cboTenthuoc_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboTenthuoc.Text == "")
            {
                txtDVT.Text = "";
                txtQuycachdonggoi.Text = "";
            }
            //Khi kich chon Ma khach thi ten khach, dia chi, dien thoai se tu dong hien ra
            str = "Select DVT from tblThuoc where MATHUOC = N'" + cboTenthuoc.SelectedValue + "'";
            txtDVT.Text = Class.Functions.GetFieldValues(str);
            str = "Select QUYCACHDONGGOI from tblThuoc where MATHUOC = N'" + cboTenthuoc.SelectedValue + "'";
            txtQuycachdonggoi.Text = Class.Functions.GetFieldValues(str);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            double tong, Tongmoi;
            sql = "SELECT MANHAP FROM tblPhieunhap WHERE MANHAP=N'" + txtManhap.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtNgaynhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgaynhap.Focus();
                    return;
                }
                if (cboNhacungcap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNhacungcap.Focus();
                    return;
                }
                sql = "INSERT INTO tblPhieunhap(MANHAP, NGAYNHAP, MANCC,TONGTIEN) VALUES(N'" + txtManhap.Text.Trim() + "', '" +
                Functions.ConvertDateTime(txtNgaynhap.Text.Trim()) + "',N'" + cboNhacungcap.SelectedValue + "'," + txtTongtien.Text + ")";
                Functions.RunSql(sql);
            }
            
            ///////////////////////////////////////////////////////
            // Lưu thông tin của các mặt hàng
            if (cboTenthuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTenthuoc.Focus();
                return;
            }
            if (mskHSD.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaynhap.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongia.Focus();
                return;
            }
            
            sql = "SELECT MATHUOC FROM tblCTPhieunhap WHERE MATHUOC=N'" + cboTenthuoc.SelectedValue + "' AND MANHAP = N'" + txtManhap.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cboTenthuoc.Focus();
                return;
            }
            

            double thanhtien = Convert.ToDouble(txtSoluong.Text) * Convert.ToDouble(txtDongia.Text);
            sql = "INSERT INTO tblCTPhieunhap(MANHAP,MATHUOC,LOSX,HSD,DVT,DONGIA,SLUONG,THANHTIEN)" +
                " VALUES(N'" + txtManhap.Text.Trim() + "', N'" + cboTenthuoc.SelectedValue + "', N'" + 
                txtLosanxuat.Text.Trim() + "', N'" + Functions.ConvertDateTime(mskHSD.Text.Trim()) + "', N'" + txtDVT.Text.Trim() + 
                "', N'" + txtDongia.Text.Trim() + "'," + txtSoluong.Text + "," + thanhtien + ")";
            Functions.RunSql(sql);
            ketnoi();
            
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM tblPhieunhap WHERE MANHAP = N'" + txtManhap.Text + "'"));
            Tongmoi = tong + ( Convert.ToDouble(txtDongia.Text) * Convert.ToDouble(txtSoluong.Text));
            sql = "UPDATE tblPhieunhap SET TONGTIEN =" + Tongmoi + " WHERE MANHAP = N'" + txtManhap.Text + "'";
            Functions.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();            
            ResetValuesHang();
            txtNgaynhap.Enabled = false;
            cboNhacungcap.Enabled = false;
        }
        private void ResetValuesHang()
        {
            cboTenthuoc.Text = "";
            txtSoluong.Text = "";
            txtDongia.Text = "0";
            txtLosanxuat.Text = "";
            txtDVT.Text = "";
            txtQuycachdonggoi.Text = "";
            mskHSD.Text = "  /  /    ";
        }

    

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {        
            khoidau();
            ketnoi();
            cboNhacungcap.Enabled = true;
        }

        private void btnThemnhom_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_nhacungcap f = new Forms_Addnew.frmAdd_nhacungcap();
            f.ShowDialog();
        }

        private void cboTenthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
