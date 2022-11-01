using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_CTThuoc
{
    public partial class frmCT_thuoc : Form
    {
        public frmCT_thuoc(string  tenthuoc, string hoatchat, string hamluong, string hangsx, string nuocsx, string quycach, string dongia, string losx, string hansudung, string tonkho)
        {
            InitializeComponent();
            txtTen.Text = tenthuoc;
            txtHoatchat.Text = hoatchat;
            txtHamluong.Text = hamluong;
            txtHangSX.Text = hangsx;
            txtNuocSX.Text = nuocsx;
            txtQuycach.Text = quycach;
            txtDongia.Text = dongia;
            txtLosx.Text = losx;
            txtHSD.Text = hansudung;
            txtTonkho.Text = tonkho;
        }

        private void frmCT_thuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
