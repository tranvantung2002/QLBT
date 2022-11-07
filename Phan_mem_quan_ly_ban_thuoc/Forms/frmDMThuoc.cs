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
    public partial class frmDMThuoc : Form
    {
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql, fname;
        public frmDMThuoc()
        {
            InitializeComponent();
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
                sql = "DELETE tblThuoc WHERE MATHUOC=N'" + txtMa.Text + "'";
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                Class.Functions.RunSqlDel(sql);
                ketnoi();

            }
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            txtMa.Text = grdData.Rows[i].Cells["MATHUOC"].Value.ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            Forms_Addnew.frmAdd_thuoc f = new Forms_Addnew.frmAdd_thuoc();
            f.ShowDialog();
        }

        private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            string mathuoc = grdData.Rows[i].Cells["MATHUOC"].Value.ToString();
            string tenthuoc = grdData.Rows[i].Cells["TENTHUOC"].Value.ToString();
            string tennhom = grdData.Rows[i].Cells["TENNHOM"].Value.ToString();
            string hoatchat = grdData.Rows[i].Cells["HOATCHATCHINH"].Value.ToString();
            string hamluong = grdData.Rows[i].Cells["HAMLUONG"].Value.ToString();
            string hangsx = grdData.Rows[i].Cells["HANGSX"].Value.ToString();
            string nuocsx = grdData.Rows[i].Cells["NUOCSX"].Value.ToString();
            string quycach = grdData.Rows[i].Cells["QUYCACHDONGGOI"].Value.ToString();
            string dvt = grdData.Rows[i].Cells["DVT"].Value.ToString();

            Forms_Update.frmUp_thuoc f = new Forms_Update.frmUp_thuoc(mathuoc, tenthuoc, tennhom, hoatchat, hamluong, hangsx, nuocsx, quycach, dvt);
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã thuốc")
            {
                fname = "MATHUOC";
            }
            if (comTruong.Text == "Mã nhóm")
            {
                fname = "MANHOM";
            }
            if (comTruong.Text == "Hãng sản xuất")
            {
                fname = "HANGSX";
            }
            if (comTruong.Text == "Nước sản xuất")
            {
                fname = "NUOCSX";
            }
            Class.Functions.FillCombo("select distinct " + fname + " from tblThuoc", comGT, fname, fname);
            comGT.SelectedIndex = -1;

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
                sql = "select  a.MATHUOC,b.TENNHOM,b.MANHOM,a.TENTHUOC,a.HOATCHATCHINH,a.HAMLUONG,a.HANGSX,a.NUOCSX,a.QUYCACHDONGGOI,a.DVT from tblThuoc as a,tblNhomthuoc as b " +
                    "where a." + fname + "= N'" + comGT.Text + "' and a.MANHOM=b.MANHOM  order by a.MATHUOC,a.MANHOM";
                khuong = Class.Functions.GetDataToTable(sql);
                grdData.DataSource = khuong; //đổ dl vào ô lưới
                grdData.Refresh();

            }
        }
    
        private void btnTK_Click(object sender, EventArgs e)
        {
            comTruong.Text = "";
            comGT.Text = "";
            ketnoi();
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

        private void frmDMThuoc_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Exo");/*Khởi tạo font mới*/
            //grdData.Font = new Font(f, 10, FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
            grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
            grdData.Cursor = default;
            lblChuongtrinh.Text = "Danh mục thuốc !!! Đang chạy ....";

        }

        private void ketnoi()
        {
            sql = "select a.MATHUOC,b.TENNHOM,b.MANHOM,a.TENTHUOC,a.HOATCHATCHINH,a.HAMLUONG,a.HANGSX,a.NUOCSX,a.QUYCACHDONGGOI,a.DVT from tblThuoc as a,tblNhomthuoc as b where a.MANHOM=b.MANHOM ";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }


        private void Huongdan_Click(object sender, EventArgs e)
        {
            Forms_Messagebox.frm_Message_Hotro f = new Forms_Messagebox.frm_Message_Hotro();
            f.ShowDialog();
        }

        private void btnLoc_MouseLeave(object sender, EventArgs e)
        {
            btnLoc.BackColor = Color.FromArgb(34, 54, 86);
        }

        private void btnLoc_MouseHover(object sender, EventArgs e)
        {
            btnLoc.BackColor = Color.FromArgb(141, 153, 174);
        }
    }
}
