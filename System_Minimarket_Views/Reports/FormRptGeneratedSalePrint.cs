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
    public partial class FormRptGeneratedSalePrint : Form
    {
        public FormRptGeneratedSalePrint()
        {
            InitializeComponent();
        }

        private void FormRptGeneratedSalePrint_Load(object sender, EventArgs e)
        {
            this.p_Print_Generated_SaleTableAdapter.Fill(this.dataSet_MiniMarket.P_Print_Generated_Sale, nId_op: Convert.ToInt32(text_p1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
