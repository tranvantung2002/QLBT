using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_CT_Hoadon
{
    public partial class frm_CT_Hoadon : Form
    {
        string sql;
        DataTable khuong;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frm_CT_Hoadon(string manhap, string ngaynhap, string tenncc, string tongtien)
        {
            InitializeComponent();
            txtMa.Text = manhap;
            txtNgaynhap.Text = ngaynhap;
            txtNhacungcap.Text = tenncc;
            txtTongtien.Text = tongtien;

        }

        private void frm_CT_Hoadon_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ketnoi();
        }

        private void ketnoi()
        {
            sql = "select b.TENTHUOC,a.LOSX,a.DVT,a.DONGIA,a.SLUONG,a.THANHTIEN from tblCTHoadonban as a,tblThuoc as b where a.MATHUOC=b.MATHUOC and a.MABAN=N'" + txtMa.Text.Trim() + "'";
            khuong = Class.Functions.GetDataToTable(sql);
            grdData.DataSource = khuong; //đổ dl vào ô lưới
            grdData.Refresh();
        }
    }
}
