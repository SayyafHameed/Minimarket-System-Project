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
    public partial class FormReportOutputAccumulatedProducts : Form
    {
        public FormReportOutputAccumulatedProducts()
        {
            InitializeComponent();
        }

        private void FormReportOutputAccumulatedProducts_Load(object sender, EventArgs e)
        {
            this.p_Report_Output2_AccumulatedxProductsTableAdapter.Fill(this.dataSetReportsConsolidated.P_Report_Output2_AccumulatedxProducts, date_start: Convert.ToDateTime(txt_p1.Text), date_end: Convert.ToDateTime(txt_p2.Text));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
