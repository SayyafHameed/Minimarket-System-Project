using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Minimarket.Business;
using System_Minimarket.Entities;

namespace System_Minimarket_Views
{
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_pr = 0;
        int Id_ca = 0;
        int Id_mu = 0;
        int Id_ma = 0;
        int guardState = 0; //No action
        #endregion

        #region "My Method"
        private void Format_pr()
        {
            Dgv_major.Columns[0].Width = 90;
            Dgv_major.Columns[0].HeaderText = "ID";
            Dgv_major.Columns[1].Width = 250;
            Dgv_major.Columns[1].HeaderText = "Products";
            Dgv_major.Columns[2].Width = 170;
            Dgv_major.Columns[2].HeaderText = "Brand";
            Dgv_major.Columns[3].Width = 90;
            Dgv_major.Columns[3].HeaderText = "Measured";
            Dgv_major.Columns[4].Width = 170;
            Dgv_major.Columns[4].HeaderText = "Category";
            Dgv_major.Columns[5].Width = 105;
            Dgv_major.Columns[5].HeaderText = "Stock Min";
            Dgv_major.Columns[6].Width = 105;
            Dgv_major.Columns[6].HeaderText = "Stock Max";
            Dgv_major.Columns[7].Visible = false;
            Dgv_major.Columns[8].Visible = false;
            Dgv_major.Columns[9].Visible = false;
            Dgv_major.Columns[10].Visible = false;

        }

        private void Listing_pr(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Products.Listing_pr(cText);
                this.Format_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void State_MainButtons(bool IState)
        {
            this.Btn_new.Enabled = IState;
            this.Btn_update.Enabled = IState;
            this.Btn_clear.Enabled = IState;
            this.Btn_report.Enabled = IState;
            this.Btn_exit.Enabled = IState;
        }

        private void State_ProcessButtons(bool lState)
        {
            this.Btn_cancel.Visible = lState;
            this.Btn_save.Visible = lState;
            this.Btn_return.Visible = !lState;
        }

        private void Choose_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_pr"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_pr = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_pr"].Value);
                Text_description_pr.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_pr"].Value);
                this.Id_ma = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_ma"].Value);
                Text_brand.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_ma"].Value);
                this.Id_mu = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_mu"].Value);
                Text_measur.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_mu"].Value);
                this.Id_ca = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_ca"].Value);
                Text_category.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_ca"].Value);
                Text_minimum.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["stock_min"].Value);
                Text_maximum.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["stock_max"].Value);
                Text_sale.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["su_sale"].Value);
                
            }

        }

        private void Format_ma_pr()
        {
            dgv_list_ma.Columns[0].Width = 200;
            dgv_list_ma.Columns[0].HeaderText = "Brand";
            dgv_list_ma.Columns[1].Visible = false;

        }

        private void Listing_ma_pr(string cText)
        {
            try
            {
                dgv_list_ma.DataSource = B_Products.Listing_ma_pr(cText);
                this.Format_ma_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_ma_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_list_ma.CurrentRow.Cells["id_ma"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_ma = Convert.ToInt32(dgv_list_ma.CurrentRow.Cells["id_ma"].Value);
                Text_brand.Text = Convert.ToString(dgv_list_ma.CurrentRow.Cells["description_ma"].Value);
            }
        }

        private void Format_mu_pr()
        {
            Dgv_measure.Columns[0].Width = 200;
            Dgv_measure.Columns[0].HeaderText = "Measured";
            Dgv_measure.Columns[1].Visible = false;

        }

        private void Listing_mu_pr(string cText)
        {
            try
            {
                Dgv_measure.DataSource = B_Products.Listing_mu_pr(cText);
                this.Format_mu_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_mu_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_measure.CurrentRow.Cells["id_mu"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_mu = Convert.ToInt32(Dgv_measure.CurrentRow.Cells["id_mu"].Value);
                Text_measur.Text = Convert.ToString(Dgv_measure.CurrentRow.Cells["description_mu"].Value); 
            }

        }

        private void Format_ca_pr()
        {
            Dgv_categories.Columns[0].Width = 200;
            Dgv_categories.Columns[0].HeaderText = "CATEGORIES";
            Dgv_categories.Columns[1].Visible = false;

        }

        private void Listing_ca_pr(string cText)
        {
            try
            {
                Dgv_categories.DataSource = B_Products.Listing_ca_pr(cText);
                this.Format_ca_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_ca_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_categories.CurrentRow.Cells["id_ca"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_ca = Convert.ToInt32(Dgv_categories.CurrentRow.Cells["id_ca"].Value);
                Text_category.Text = Convert.ToString(Dgv_categories.CurrentRow.Cells["description_ca"].Value);
            }

        }

        private void Format_stock_action()
        {
            Dgv_Stock_action.Columns[0].Width = 200;
            Dgv_Stock_action.Columns[0].HeaderText = "STORE";
            Dgv_Stock_action.Columns[1].Width = 125;
            Dgv_Stock_action.Columns[1].HeaderText = "STOCK ACTION";
            Dgv_Stock_action.Columns[2].Width = 125;
            Dgv_Stock_action.Columns[2].HeaderText = "Buy";

        }

        private void Listing_stock_action(int nId_pr)
        {
            try
            {
                Dgv_Stock_action.DataSource = B_Products.Stock_Actions(nId_pr);
                this.Format_stock_action();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        private void Form_Products_Load(object sender, EventArgs e)
        {
            this.Listing_pr("%");
            this.Listing_ma_pr("%");
            this.Listing_mu_pr("%");
            this.Listing_ca_pr("%");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Text_description_pr.Text == String.Empty ||
                Text_measur.Text == String.Empty ||
                Text_brand.Text == String.Empty ||
                Text_category.Text == String.Empty)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                E_Products oPr = new E_Products();
                string Rpta = "";
                oPr.Id_pr = this.Id_pr;
                oPr.Description_pr = Text_description_pr.Text.Trim();
                oPr.Id_ma = this.Id_ma;
                oPr.Id_mu = this.Id_mu;
                oPr.Id_ca = this.Id_ca;
                oPr.Stock_min = Convert.ToDecimal(Text_minimum.Text);
                oPr.Stock_max = Convert.ToDecimal(Text_maximum.Text);
                oPr.Buy = Convert.ToDecimal(Text_sale.Text);

                Rpta = B_Products.Save_pr(guardState, oPr);
                if (Rpta == "OK")
                {
                    this.Listing_pr("%");
                    MessageBox.Show("Data has been saved successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardState = 0; //No action
                    this.State_MainButtons(true);
                    this.State_ProcessButtons(false);
                    Text_description_pr.Text = "";
                    Text_minimum.Text = "0";
                    Text_maximum.Text = "0";
                    Text_description_pr.ReadOnly = true;
                    Text_minimum.ReadOnly = true;
                    Text_maximum.ReadOnly = true;
                    Text_sale.ReadOnly = true;
                    tabControl1.SelectedIndex = 0;
                    this.Id_pr = 0;
                    Gbx_detail.Visible = false;

                }
                else
                {
                    MessageBox.Show(Rpta, "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            guardState = 0; // cancel
            Gbx_detail.Visible = false;
            this.Id_pr = 0;
            Text_description_pr.Text = "";
            Text_minimum.Text = "0";
            Text_maximum.Text = "0";
            Text_description_pr.ReadOnly = true;
            Text_minimum.ReadOnly = true;
            Text_maximum.ReadOnly = true;
            Text_sale.ReadOnly = true;
            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            guardState = 1; //New Registration
            Gbx_detail.Visible = false;
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            Text_description_pr.Text = "";
            Text_minimum.Text = "0";
            Text_maximum.Text = "0";
            Text_description_pr.ReadOnly = false;
            Text_minimum.ReadOnly = false;
            Text_maximum.ReadOnly = false;
            Text_sale.ReadOnly = false;
            tabControl1.SelectedIndex = 1;
            Text_description_pr.Focus();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            guardState = 2; // Updated Registration
            Gbx_detail.Visible = false;
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Choose_item();
            tabControl1.SelectedIndex = 1;
            Text_description_pr.ReadOnly = false;
            Text_minimum.ReadOnly = false;
            Text_maximum.ReadOnly = false;
            Text_sale.ReadOnly = false;
            Text_description_pr.Focus();
        }

        private void Dgv_major_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item();
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 1;
            this.Listing_stock_action(this.Id_pr);
            Gbx_detail.Visible = true;
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
            this.Id_pr = 0;
            Gbx_detail.Visible = false;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_pr"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Are you sure to delete the selected record?", "System Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string Rpt = "";
                    this.Id_pr = Convert.ToInt32(Dgv_major.CurrentRow.Cells["Id_pr"].Value);
                    Rpt = B_Products.Delete_pr(this.Id_pr);
                    if (Rpt.Equals("OK"))
                    {
                        this.Listing_pr("%");
                        this.Id_pr = 0;
                        MessageBox.Show("Record Deleted", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }



            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_report_Click(object sender, EventArgs e)
        {
            Reports.FormProducts oRpt4 = new Reports.FormProducts();
            oRpt4.text_p1.Text = Text_search.Text;
            oRpt4.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_pr(Text_search.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_brand_Click(object sender, EventArgs e)
        {
            this.pan_List_ma.Location = Btn_brand.Location;
            this.pan_List_ma.Visible = true;
        }

        private void dgv_list_ma_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_ma_pr();
            this.pan_List_ma.Visible = false;

        }

        private void Btn_measur_Click(object sender, EventArgs e)
        {
            this.pan_measure_unit.Location = Btn_measur.Location;
            this.pan_measure_unit.Visible = true;
        }

        private void Dgv_measure_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_mu_pr();
            this.pan_measure_unit.Visible = false;
        }

        private void Dgv_categories_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_ca_pr();
            this.pan_category.Visible = false;
        }

        private void Btn_category_Click(object sender, EventArgs e)
        {
            this.pan_category.Location = Btn_category.Location;
            this.pan_category.Visible = true;
        }

        private void Btn_return3_Click(object sender, EventArgs e)
        {
            pan_category.Visible = false;
        }

        private void Btn_look3_Click(object sender, EventArgs e)
        {
            this.pan_category.Location = Btn_category.Location;
            this.pan_category.Visible = true;
        }

        private void Btn_look1_Click(object sender, EventArgs e)
        {
            this.Listing_ma_pr(Text_look.Text);
        }

        private void Btn_return1_Click(object sender, EventArgs e)
        {
            pan_List_ma.Visible = false;
        }

        private void Btn_look2_Click(object sender, EventArgs e)
        {
            this.Listing_mu_pr(Text_look2.Text);
        }

        private void Btn_return2_Click(object sender, EventArgs e)
        {
            pan_measure_unit.Visible = false;
        }

        private void Text_brand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
