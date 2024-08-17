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
    public partial class FormRptStores : Form
    {
        public FormRptStores()
        {
            InitializeComponent();
        }

        private void FormRptStores_Load(object sender, EventArgs e)
        {
            this.p_Listing_stTableAdapter.Fill(this.dataSet_MiniMarket.P_Listing_st, cText: text_p1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
