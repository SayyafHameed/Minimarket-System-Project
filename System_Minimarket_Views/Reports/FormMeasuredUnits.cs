using System;
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
    public partial class FormMeasuredUnits : Form
    {
        public FormMeasuredUnits()
        {
            InitializeComponent();
        }

        private void FormMeasuredUnits_Load(object sender, EventArgs e)
        {
            this.p_Listing_muTableAdapter.Fill(this.dataSet_MiniMarket.P_Listing_mu, cText: text_p1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
