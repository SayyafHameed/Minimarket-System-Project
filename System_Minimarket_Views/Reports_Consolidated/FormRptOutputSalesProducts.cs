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
    public partial class FormRptOutputSalesProducts : Form
    {
        public FormRptOutputSalesProducts()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_preview_Click(object sender, EventArgs e)
        {
            FormReportOutputSalesProducts oRpt_OSP = new FormReportOutputSalesProducts();
            oRpt_OSP.txt_p1.Text = Convert.ToString(Dp_date_st.Value);
            oRpt_OSP.txt_p2.Text = Convert.ToString(Dp_date_en.Value);
            oRpt_OSP.ShowDialog();
        }
    }
}
