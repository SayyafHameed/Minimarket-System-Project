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
    public partial class Form_DashBoard : Form
    {
        public Form_DashBoard()
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
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_body.Controls.Add(childForm);
            label4.Text = nameScreen;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
                
        private void Form_DashBoard_Load(object sender, EventArgs e)
        {
            this.pnl_proccess.Visible = false;
            this.pnl_reports.Visible = false;
            this.pnl_datamaster.Visible = false;
            this.pnl_systems.Visible = false;
        }

        private void Btn_proccess_Click(object sender, EventArgs e)
        {
            if (this.pnl_proccess.Visible == false)
            {
                this.pnl_proccess.Visible = true;
            }
            else
            {
                this.pnl_proccess.Visible = false;
            }
            this.pnl_reports.Visible = false;
            this.pnl_datamaster.Visible = false;
            this.pnl_systems.Visible = false;
        }

        private void Btn_reports_Click(object sender, EventArgs e)
        {
            if (this.pnl_reports.Visible == false)
            {
                this.pnl_reports.Visible = true;
            }
            else
            {
                this.pnl_reports.Visible = false;
            }
            this.pnl_proccess.Visible = false;
            this.pnl_datamaster.Visible = false;
            this.pnl_systems.Visible = false;
        }

        private void Btn_masterData_Click(object sender, EventArgs e)
        {
            if (this.pnl_datamaster.Visible == false)
            {
                this.pnl_datamaster.Visible = true;
            }
            else
            {
                this.pnl_datamaster.Visible = false;
            }
            this.pnl_proccess.Visible = false;
            this.pnl_reports.Visible = false;
            this.pnl_systems.Visible = false;
        }

        private void Btn_system_Click(object sender, EventArgs e)
        {
            if (this.pnl_systems.Visible == false)
            {
                this.pnl_systems.Visible = true;
            }
            else
            {
                this.pnl_systems.Visible = false;
            }
            this.pnl_proccess.Visible = false;
            this.pnl_reports.Visible = false;
            this.pnl_datamaster.Visible = false;
        }

        private void Btn_enterProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Enter_Products(), "Enter Products");
        }

        private void Btn_outputProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Exit_Products(), "Output Products");
        }

        private void Btn_report1_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptIncomePurchasesProducts(), "Report Income Purchases Products");
        }

        private void Btn_report2_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptIncomeAccumulatedProducts(), "Report Income Accumulated Products");
        }

        private void Btn_report3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptOutputSalesProducts(), "Report Output Sales Products");
        }

        private void Btn_report4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports_Consolidated.FormRptOutputAccumulatedProducts(), "Report Output Accumulated Products");
        }

        private void Btn_products_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Products(), "Products");
        }

        private void Btn_brand_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Brands(), "Brands");
        }

        private void Btn_measurements_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Measured_Units(), "Measured Units");
        }

        private void Btn_categories_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Categories(), "Categories");
        }

        private void Btn_Warehouses_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Stores(), "Warehouse");
        }

        private void Btn_clients_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Clients(), "Clients");
        }

        private void Btn_suppliers_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Suppliers(), "Suppliers");
        }

        private void Btn_items_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Items(), "Items");
        }

        private void Btn_districts_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Districts(), "Enter Products");
        }

        private void Btn_provinces_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Provinces(), "Provinces");
        }

        private void Btn_apartments_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Departments(), "Apartments");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Users(), "Users");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_date.Text = DateTime.Now.ToLongDateString();
            Lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnl_title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
