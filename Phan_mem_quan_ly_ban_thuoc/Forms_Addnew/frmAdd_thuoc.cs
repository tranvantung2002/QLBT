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

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Addnew
{
    public partial class frmAdd_thuoc : Form
    {
        DataTable khuong;
        string sql;
        public frmAdd_thuoc()
        {
            InitializeComponent();
        }

        private void btnThemlai_Click(object sender, EventArgs e)
        {
            ketnoicbo();
            reset1();
            txtMa.Focus();
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset1()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtHangSX.Text = "";
            txtNuocSX.Text = "";
            txtHoatchat.Text = "";
            txtHamluong.Text = "";
            txtDVT.Text = "";
            txtQuycach.Text = "";
            cboNhomthuoc.Text = "";
        }

        private void btnThemnhom_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_nhomthuoc f = new Forms_Addnew.frmAdd_nhomthuoc();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if(cboNhomthuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải tìm tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhomthuoc.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtHamluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hàm lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHamluong.Focus();
                return;
            }
            if (txtHangSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHangSX.Focus();
                return;
            }
            if (txtHoatchat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hoạt chất chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoatchat.Focus();
                return;
            }
            if (txtNuocSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuocSX.Focus();
                return;
            }
            if (txtQuycach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quy cách đóng gói", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuycach.Focus();
                return;
            }
            if (txtDVT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDVT.Focus();
                return;
            }
            sql = "SELECT MATHUOC FROM tblThuoc WHERE MATHUOC=N'" + txtMa.Text.Trim() + "'";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            if (grdData.Rows.Count > 1)
            {
                MessageBox.Show("Mã thuốc này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                txtMa.Text = "";
                return;
            }
            else
            {
                sql = "INSERT INTO tblThuoc(MATHUOC,MANHOM,TENTHUOC,HOATCHATCHINH,HAMLUONG,HANGSX,NUOCSX,QUYCACHDONGGOI,DVT) " +
                "VALUES(N'" + txtMa.Text.Trim() + "',N'" + cboNhomthuoc.SelectedValue + "', N'" + txtTen.Text.Trim() + "', N'" 
                + txtHoatchat.Text + "', N'" + txtHamluong.Text.Trim() + "',N'" + txtHangSX.Text.Trim() + "', N'" + txtNuocSX.Text.Trim() + "',N'" 
                + txtQuycach.Text.Trim() + "', N'" + txtDVT.Text.Trim() + "')";
                Class.Functions.RunSql(sql);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset1();
        }

        private void frmAdd_thuoc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
            ketnoicbo();            
            grdData.Cursor = default;
        }

        private void ketnoicbo()
        {
            Class.Functions.FillCombo("select MANHOM, TENNHOM from tblNhomthuoc", cboNhomthuoc, "MANHOM", "TENNHOM");
            cboNhomthuoc.SelectedIndex = -1;
        }

        private void ketnoi()
        {
            sql = "select MATHUOC,MANHOM,TENTHUOC,HOATCHATCHINH,HAMLUONG,HANGSX,NUOCSX,QUYCACHDONGGOI,DVT from tblThuoc ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong;
            grdData.Refresh();
        }

        
    }
}
