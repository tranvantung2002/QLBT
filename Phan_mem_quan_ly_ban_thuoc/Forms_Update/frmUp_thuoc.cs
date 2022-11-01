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

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Update
{
    public partial class frmUp_thuoc : Form
    {
        
        string sql;
        public frmUp_thuoc(string mathuoc, string tenthuoc, string manhom, string hoatchat, string hamluong, string hangsx, string nuocsx,string quycah,string dvt)
        {
            InitializeComponent();
            txtMa.Text = mathuoc;
            txtTen.Text = tenthuoc;
            cboNhomthuoc.Text = manhom;
            txtHoatchat.Text = hoatchat;
            txtHamluong.Text = hamluong;
            txtHangSX.Text = hangsx;
            txtNuocSX.Text = nuocsx;
            txtQuycach.Text = quycah;
            txtDVT.Text = dvt;
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            mokhoa();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }   
            if (txtHangSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtHoatchat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hoạt chất chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtQuycach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quy cách đóng gói", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtDVT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            sql = "Update tblThuoc set TENTHUOC=N'" + txtTen.Text.Trim() + "',MANHOM=N'" + cboNhomthuoc.SelectedValue + "',HAMLUONG= N'" + txtHamluong.Text.Trim() + "',HOATCHATCHINH=N'" + txtHoatchat.Text.Trim()+ "',QUYCACHDONGGOI=N'" + txtQuycach.Text.Trim() + "',HANGSX=N'" + txtHangSX.Text.Trim() + "',NUOCSX=N'"+ txtNuocSX.Text.Trim() + "',DVT=N'" + txtDVT.Text.Trim() + "' where MATHUOC='" + txtMa.Text + "'";
            Class.Functions.RunSql(sql);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNhomthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUp_thuoc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            khoa();
            
        }

        private void btnThemnhom_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_nhomthuoc f = new Forms_Addnew.frmAdd_nhomthuoc();
            f.ShowDialog();
        }

        private void cboNhomthuoc_MouseEnter(object sender, EventArgs e)
        {
            ketnoicbo();
        }

        private void ketnoicbo()
        {
            Class.Functions.FillCombo("select MANHOM, TENNHOM from tblNhomthuoc", cboNhomthuoc, "MANHOM", "TENNHOM");
            cboNhomthuoc.SelectedIndex = -1;
        }

        private void khoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cboNhomthuoc.Enabled = false;
            txtHoatchat.Enabled = false;
            txtHamluong.Enabled = false;
            txtHangSX.Enabled = false;
            txtNuocSX.Enabled = false;
            txtQuycach.Enabled = false;
            txtDVT.Enabled = false;
        }
        private void mokhoa()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            cboNhomthuoc.Enabled = true;
            txtHoatchat.Enabled = true;
            txtHamluong.Enabled = true;
            txtHangSX.Enabled = true;
            txtNuocSX.Enabled = true;
            txtQuycach.Enabled = true;
            txtDVT.Enabled = true;
        }


    }
}
