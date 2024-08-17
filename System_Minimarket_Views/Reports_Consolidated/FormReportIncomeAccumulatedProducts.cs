using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Minimarket_Views.Reports_Consolidated
{
    public partial class FormReportIncomeAccumulatedProducts : Form
    {
        public FormReportIncomeAccumulatedProducts()
        {
            InitializeComponent();
        }

        private void FormReportIncomeAccumulatedProducts_Load(object sender, EventArgs e)
        {
            this.p_Report_Output_AccumulatedProductsTableAdapter.Fill(this.dataSetReportsConsolidated.P_Report_Output_AccumulatedProducts, date_start: Convert.ToDateTime(txt_p1.Text), date_end: Convert.ToDateTime(txt_p2.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
