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
    public partial class FormReportOutputSalesProducts : Form
    {
        public FormReportOutputSalesProducts()
        {
            InitializeComponent();
        }

        private void FormReportOutputSalesProducts_Load(object sender, EventArgs e)
        {
            this.p_Report_Output_SalesProductsTableAdapter.Fill(this.dataSetReportsConsolidated.P_Report_Output_SalesProducts, date_start: Convert.ToDateTime(txt_p1.Text), date_end: Convert.ToDateTime(txt_p2.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
