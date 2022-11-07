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
    public partial class frmTonkho : Form
    {
        DataTable dt = new DataTable();
        DataTable khuong;
        string sql, fname;
        public frmTonkho()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoigian.Text = System.DateTime.Now.ToString();
            int n = grdData.RowCount - 1;
            lblTong.Text = "Tổng số : " + n.ToString();
        }

  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmTonkho_Load(object sender, EventArgs e)
        {
            //FontFamily f = new FontFamily("Nunito");/*Khởi tạo font mới*/
            //grdData.Font = new Font(f, 10, FontStyle.Bold);/* Gnas forn mới cho font cần đổi*/
            grdData.ForeColor = Color.Black;
            Class.Functions.Connect();
            ketnoi();
            grdData.Cursor = default;
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã thuốc")
            {
                fname = "MATHUOC";
                Class.Functions.FillCombo("select distinct b.MATHUOC,b.TENTHUOC from tblCTPhieunhap as a,tblThuoc as b where a.MATHUOC=b.MATHUOC", comGT,"MATHUOC", "TENTHUOC");
                comGT.SelectedIndex = -1;
            }
            if (comTruong.Text == "Mã nhóm")
            {
                fname = "MANHOM";
                Class.Functions.FillCombo("select distinct c.MANHOM,c.TENNHOM from tblCTPhieunhap as a,tblThuoc as b,tblNhomthuoc as c where a.MATHUOC=b.MATHUOC and b.MANHOM=c.MANHOM", comGT,"MANHOM", "TENNHOM");
                comGT.SelectedIndex = -1;
            }
            
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
                    sql = "select nhap.MATHUOC ,thuoc.TENTHUOC ,nhap.LOSX ,thuoc.DVT,nhap.DONGIA, sum(nhap.SLUONG) as SLUONG2 ,sum(ISNULL(ban.SLUONG,0)) as SLUONG1,sum(nhap.SLUONG-ISNULL(ban.SLUONG,0)) as TONKHO1,thuoc.MANHOM " +
                   "from tblThuoc as thuoc,tblCTPhieunhap as nhap left join tblCTHoadonban as ban on nhap.MATHUOC = ban.MATHUOC and nhap.LOSX=ban.LOSX " +
                   "where thuoc." + fname + "= N'" + comGT.SelectedValue + "' and thuoc.MATHUOC = nhap.MATHUOC group by nhap.MATHUOC ,thuoc.TENTHUOC ,nhap.LOSX ,thuoc.DVT,nhap.DONGIA,thuoc.MANHOM";
                    khuong = Class.Functions.GetDataToTable(sql);
                    grdData.DataSource = khuong;
                    grdData.Refresh();
               
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
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

        private void ketnoi()
        {
            sql = "select nhap.MATHUOC ,thuoc.TENTHUOC ,nhap.LOSX ,thuoc.DVT,nhap.DONGIA, sum(nhap.SLUONG) as SLUONG2 ,sum(ISNULL(ban.SLUONG,0)) as SLUONG1,sum(nhap.SLUONG-ISNULL(ban.SLUONG,0)) as TONKHO1,thuoc.MANHOM " +
                "from tblThuoc as thuoc,tblCTPhieunhap as nhap left join tblCTHoadonban as ban on nhap.MATHUOC = ban.MATHUOC and nhap.LOSX=ban.LOSX " +
                "where thuoc.MATHUOC = nhap.MATHUOC group by nhap.MATHUOC ,thuoc.TENTHUOC ,nhap.LOSX ,thuoc.DVT,nhap.DONGIA,thuoc.MANHOM";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }
    }
}
