using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        public string tachdem(string s)
        {
            string ho, tendem, ten;
            ho = s.Substring(0, s.IndexOf(' '));
            tendem = s.Substring(s.IndexOf(' ') + 1, s.LastIndexOf(' ') - ho.Length - 1);
            ten = s.Substring(s.LastIndexOf(' ') + 1);
            return tendem;
        }
        

    }
}
