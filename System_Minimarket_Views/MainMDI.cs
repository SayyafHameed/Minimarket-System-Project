using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Minimarket_Views
{
    public partial class MainMDI : Form
    {
        public MainMDI()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        private Form activeForm = null;

        #endregion
        #region "My Method"
        private void openChildForm(Form childForm, string nameScreen)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            //childForm.MdiParent = this;
            //childForm.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = nameScreen;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void ExitOfProductsSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Exit_Products(), "Output Products");
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Products(), "Products");
            
        }

        private void brandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Brands(), "Brands");
        }

        private void unitsOfMeasurementsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form_Measured_Units(), "Measured Units");
        }

        private void categoriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form_Categories(), "Categories");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form_Stores(), "Warehouse");
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Clients(), "Clients");
        }

        private void suppliersToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form_Suppliers(), "Suppliers");
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Items(), "Items");
        }

        private void districtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Districts(), "Districts");
        }

        private void provincesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Provinces(), "Provinces");
        }

        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Departments(), "Apartments");
        }

        private void ticketsOfProductsShoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Enter_Products(), "Enter Products");
        }

        private void exitTheSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tb_products_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form_Products(), "Products");
        }

        private void Tb_clients_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Clients(), "Clients");
        }

        private void Tb_suppliers_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Suppliers(), "Suppliers");
        }

        private void Tb_enter_products_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Enter_Products(), "Enter Products");
        }

        private void Tb_output_products_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Exit_Products(), "Output Products");
        }

        private void incomeFromPurchasesByProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptIncomePurchasesProducts(), "Report Income Purchases Products");
        }

        private void outputOfSalesByProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptOutputSalesProducts(), "Report Output Sales Products");
        }

        private void accumulatedIncomeFromProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptIncomeAccumulatedProducts(), "Report Income Accumulated Products");
        }

        private void accumulatedOutputByProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptOutputAccumulatedProducts(), "Report Output Accumulated Products");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
