﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Minimarket_Views.Reports
{
    public partial class FormRptDepartements : Form
    {
        public FormRptDepartements()
        {
            InitializeComponent();
        }

        private void FormRptDepartements_Load(object sender, EventArgs e)
        {
            this.p_Listing_deTableAdapter.Fill(this.dataSet_MiniMarket.P_Listing_de, cText: text_p1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}