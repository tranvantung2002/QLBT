﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_ban_thuoc.Forms_Reports
{
    public partial class rpt_DT_Khachhang : Form
    {
        public rpt_DT_Khachhang(Reports.rpt_Khachhang_TOP rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
