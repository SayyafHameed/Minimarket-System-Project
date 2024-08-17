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
    public partial class Form_Exit_Products : Form
    {
        public Form_Exit_Products()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_ep = 0;
        int Id_tdi = 0;
        int Id_cl = 0;

        int guardState = 0; //No action
        DataTable TableDetail = new DataTable();
        #endregion

        #region "My Method"
        private void Format_ep()
        {
            Dgv_major.Columns[0].Width = 85;
            Dgv_major.Columns[0].HeaderText = "ID_EXIT_PRODUCT";
            Dgv_major.Columns[1].Width = 70;
            Dgv_major.Columns[1].HeaderText = "TYPE DOC";
            Dgv_major.Columns[2].Width = 110;
            Dgv_major.Columns[2].HeaderText = "NO DOC";
            Dgv_major.Columns[3].Width = 140;
            Dgv_major.Columns[3].HeaderText = "Date DOC";
            Dgv_major.Columns[4].Width = 270;
            Dgv_major.Columns[4].HeaderText = "NO.DOC.CLIENT";
            Dgv_major.Columns[5].Width = 170;
            Dgv_major.Columns[5].HeaderText = "CLIENT";
            Dgv_major.Columns[6].Width = 150;
            Dgv_major.Columns[6].HeaderText = "TOTAL AMOUNT";
            Dgv_major.Columns[7].Visible = false;
            Dgv_major.Columns[8].Visible = false;
            Dgv_major.Columns[9].Visible = false;
            Dgv_major.Columns[10].Visible = false;
            Dgv_major.Columns[11].Visible = false;

        }

        private void Listing_ep(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Exit_Products.Listing_exp(cText);
                this.Format_ep();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void State_MainButtons(bool IState)
        {
            this.Btn_new.Enabled = IState;
            this.Btn_clear.Enabled = IState;
            this.Btn_report.Enabled = IState;
            this.Btn_exit.Enabled = IState;
        }

        private void State_ProcessButtons(bool lState)
        {
            this.Btn_cancel.Visible = lState;
            this.Btn_save.Visible = lState;
           // this.Btn_return.Visible = !lState;

            this.Btn_add.Visible = lState;
            this.Btn_remove.Visible = lState;

            this.Btn_eye1.Visible = lState;
            this.Btn_eye2.Visible = lState;
        }

        private void Choose_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_op"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_ep = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_op"].Value);
                this.Id_tdi = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_tdi"].Value);
                this.Id_cl = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_cl"].Value);
                Text_description_tdi.Text = Dgv_major.CurrentRow.Cells["description_tdi"].Value.ToString();
                Text_nodocument_ep.Text = Dgv_major.CurrentRow.Cells["noDocument_op"].Value.ToString();
                Dtp_date_ep.Value = Convert.ToDateTime(Dgv_major.CurrentRow.Cells["date_op"].Value);
                Text_companyname_cl.Text = Dgv_major.CurrentRow.Cells["companyname_cl"].Value.ToString();
                Text_observation_ep.Text = Dgv_major.CurrentRow.Cells["observation_op"].Value.ToString();
                Text_subtotal.Text = Dgv_major.CurrentRow.Cells["subtotal"].Value.ToString();
                Text_igv.Text = Dgv_major.CurrentRow.Cells["igv"].Value.ToString();
                Text_total_amount.Text = Dgv_major.CurrentRow.Cells["total_amount"].Value.ToString();

                Dgv_Detail.DataSource = B_Exit_Products.Listing_Detail_exp(this.Id_ep);
                this.Format_detail();
            }

        }

        private void Create_TableDetail()
        {
            this.TableDetail = new DataTable("TableDetail");
            this.TableDetail.Columns.Add("Description_pr", Type.GetType("System.String"));
            this.TableDetail.Columns.Add("Description_ma", Type.GetType("System.String"));
            this.TableDetail.Columns.Add("Description_mu", Type.GetType("System.String"));
            this.TableDetail.Columns.Add("Amount", Type.GetType("System.Decimal"));
            this.TableDetail.Columns.Add("Su_sale", Type.GetType("System.Decimal"));
            this.TableDetail.Columns.Add("Total", Type.GetType("System.Decimal"));
            this.TableDetail.Columns.Add("Id_pr", Type.GetType("System.Int32"));
            this.TableDetail.AcceptChanges();

            Dgv_Detail.DataSource = this.TableDetail;
            this.Format_detail();

        }

        private void Add_item(string cDescription_pr,
                                  string cDescription_ma,
                                  string cDescription_mu,
                                  decimal nAmount,
                                  decimal nSu_buy,
                                  decimal nTotal,
                                  int nId_pr)
        {
            DataRow xFile = TableDetail.NewRow();
            xFile["Description_pr"] = cDescription_pr;
            xFile["Description_ma"] = cDescription_ma;
            xFile["Description_mu"] = cDescription_mu;
            xFile["Amount"] = nAmount;
            xFile["Su_sale"] = nSu_buy;
            xFile["Total"] = nTotal;
            xFile["Id_pr"] = nId_pr;
            this.TableDetail.Rows.Add(xFile);
            TableDetail.AcceptChanges();
        }

        private void Format_detail()
        {
            Dgv_Detail.Columns[0].Width = 270;
            Dgv_Detail.Columns[0].HeaderText = "PRODUCT";
            Dgv_Detail.Columns[1].Width = 160;
            Dgv_Detail.Columns[1].HeaderText = "MARCA";
            Dgv_Detail.Columns[2].Width = 80;
            Dgv_Detail.Columns[2].HeaderText = "U.MEASURED";
            Dgv_Detail.Columns[3].Width = 90;
            Dgv_Detail.Columns[3].HeaderText = "AMOUNT";
            Dgv_Detail.Columns[4].Width = 110;
            Dgv_Detail.Columns[4].HeaderText = "Product Sale";
            Dgv_Detail.Columns[5].Width = 90;
            Dgv_Detail.Columns[5].HeaderText = "TOTAL";
            Dgv_Detail.Columns[6].Visible = false;
            Dgv_Detail.Columns[0].ReadOnly = true;
            Dgv_Detail.Columns[1].ReadOnly = true;
            Dgv_Detail.Columns[2].ReadOnly = true;
            Dgv_Detail.Columns[3].ReadOnly = true;
            Dgv_Detail.Columns[4].ReadOnly = true;
            Dgv_Detail.Columns[5].ReadOnly = true;
        }

        private void Format_tdi()
        {
            dgv_type_tdi.Columns[0].Width = 200;
            dgv_type_tdi.Columns[0].HeaderText = "TYPE DOCUMENT";
            dgv_type_tdi.Columns[1].Visible = false;

        }

        private void Listing_tdi()
        {
            try
            {
                dgv_type_tdi.DataSource = B_Exit_Products.Listing_tdi();
                this.Format_tdi();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_tdi()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_type_tdi.CurrentRow.Cells["id_tdi"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_tdi = Convert.ToInt32(dgv_type_tdi.CurrentRow.Cells["id_tdi"].Value);
                Text_description_tdi.Text = Convert.ToString(dgv_type_tdi.CurrentRow.Cells["description_tdi"].Value);
            }
        }

        private void Format_cl()
        {
            Dgv_items.Columns[0].Width = 220;
            Dgv_items.Columns[0].HeaderText = "Client";
            Dgv_items.Columns[1].Width = 220;
            Dgv_items.Columns[1].HeaderText = "TYPE DOC";
            Dgv_items.Columns[2].Width = 220;
            Dgv_items.Columns[2].HeaderText = "NO. DOC";
            Dgv_items.Columns[3].Visible = false;

        }

        private void Listing_cl(string cText)
        {
            try
            {
                Dgv_items.DataSource = B_Exit_Products.Listing_cl_exp(cText);
                this.Format_cl();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_cl()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_items.CurrentRow.Cells["id_cl"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_cl = Convert.ToInt32(Dgv_items.CurrentRow.Cells["id_cl"].Value);
                Text_nodocument_cl.Text = Convert.ToString(Dgv_items.CurrentRow.Cells["NoDocument_cl"].Value);
                Text_companyname_cl.Text = Convert.ToString(Dgv_items.CurrentRow.Cells["companyname_cl"].Value);
                if (this.Id_cl == 1) 
                {
                    Text_nodocument_cl.ReadOnly = false;
                    Text_companyname_cl.ReadOnly = false;
                    Text_nodocument_cl.Focus();
                }
                else 
                {
                    Text_nodocument_cl.ReadOnly = true;
                    Text_companyname_cl.ReadOnly = true;
                }
            }
        }

        private void Format_pr()
        {
            Dgv_products.Columns[0].Width = 220;
            Dgv_products.Columns[0].HeaderText = "PRODUCT";
            Dgv_products.Columns[1].Width = 160;
            Dgv_products.Columns[1].HeaderText = "MARCA";
            Dgv_products.Columns[2].Width = 90;
            Dgv_products.Columns[2].HeaderText = "MEASURED Unit";
            Dgv_products.Columns[3].Width = 160;
            Dgv_products.Columns[3].HeaderText = "CATEGORY";
            Dgv_products.Columns[4].Width = 100;
            Dgv_products.Columns[4].HeaderText = "Current Stock";
            Dgv_products.Columns[5].Width = 100;
            Dgv_products.Columns[5].HeaderText = "Product Sale";
            Dgv_products.Columns[6].Visible = false;
        }

        private void Listing_pr(string cText)
        {
            try
            {
                Dgv_products.DataSource = B_Exit_Products.Listing_pr_exp(cText);
                this.Format_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_products.CurrentRow.Cells["id_pr"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string xDescription_pr;
                string xDescription_ma;
                string xDescription_um;
                decimal xAmount;
                decimal xSu_buy;
                decimal xTotal;
                int xId_pr;

                bool Add = true;

                xId_pr = Convert.ToInt32(Dgv_products.CurrentRow.Cells["id_pr"].Value);
                foreach (DataRow Filetemp in TableDetail.Rows)
                {
                    if (Convert.ToInt32(Filetemp["id_pr"]) == xId_pr)
                    {
                        Add = false;
                        MessageBox.Show("The Products already finds Added", "System Warning");
                    }
                }

                if (Add == true)
                {
                    xDescription_pr = Convert.ToString(Dgv_products.CurrentRow.Cells["description_pr"].Value);
                    xDescription_ma = Convert.ToString(Dgv_products.CurrentRow.Cells["description_ma"].Value);
                    xDescription_um = Convert.ToString(Dgv_products.CurrentRow.Cells["description_mu"].Value);
                    xAmount = Convert.ToDecimal(Dgv_products.CurrentRow.Cells["current_stock"].Value);
                    xSu_buy = Convert.ToDecimal(Dgv_products.CurrentRow.Cells["Su_sale"].Value);
                    xTotal = decimal.Round(xAmount * xSu_buy, 2);


                    this.Add_item(xDescription_pr,
                                      xDescription_ma,
                                      xDescription_um,
                                      xAmount,
                                      xSu_buy,
                                      xTotal,
                                      xId_pr);
                    this.Calculator_Totals();
                }

            }

        }

        private void State_text(bool listing)
        {
            Text_nodocument_ep.ReadOnly = !listing;
            Text_observation_ep.ReadOnly = !listing;
            Dtp_date_ep.Enabled = listing;
        }

        private void Clean_text()
        {
            Text_nodocument_ep.Text = "";
            Text_observation_ep.Text = "";
            Text_subtotal.Text = "";
            Text_igv.Text = "";
            Text_total_amount.Text = "";
            this.Create_TableDetail();
        }

        private void Calculator_Totals()
        {

            decimal nSubtotal = 0;
            decimal nIgv = 0;
            decimal nTotal_amount = 0;
            if (Dgv_Detail.Rows.Count == 0)
            {
                nSubtotal = 0;
                nIgv = 0;
                nTotal_amount = 0;
            }
            else
            {
                TableDetail.AcceptChanges();
                foreach (DataRow Filetemp in TableDetail.Rows)
                {
                    nTotal_amount += Convert.ToDecimal(Filetemp["total"]);
                }

                nSubtotal = nTotal_amount / (1 + Convert.ToDecimal("0.18"));
                nIgv = (nTotal_amount - nSubtotal);

                Text_subtotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
                Text_igv.Text = decimal.Round(nIgv, 2).ToString("#0.00");
                Text_total_amount.Text = decimal.Round(nTotal_amount, 2).ToString("#0.00");
            }

        }

        #endregion

        private void Form_Exit_Products_Load(object sender, EventArgs e)
        {
            this.Listing_tdi();
            this.Listing_cl("%");
        }

        private void Btn_save_Click_1(object sender, EventArgs e)
        {
            if (Text_description_tdi.Text == String.Empty ||
                Text_nodocument_ep.Text == string.Empty ||
                Text_companyname_cl.Text == String.Empty ||
                Dgv_Detail.Rows.Count == 0)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                string Rpt = "";
                E_Exit_Products oEp = new E_Exit_Products();

                oEp.Id_ep = this.Id_ep;
                oEp.Id_tdi = this.Id_tdi;
                oEp.noDocument_ep = Text_nodocument_ep.Text.Trim();
                oEp.Id_cl = this.Id_cl;
                oEp.NoDocument_cl = Text_nodocument_cl.Text.Trim();
                oEp.CompanyName_cl = Text_companyname_cl.Text.Trim();
                oEp.Data_ep = Dtp_date_ep.Value;
                oEp.Observation = Text_observation_ep.Text.Trim();
                oEp.Subtotal = Convert.ToDecimal(Text_subtotal.Text.Trim());
                oEp.igv = Convert.ToDecimal(Text_igv.Text.Trim());
                oEp.total_amount = Convert.ToDecimal(Text_total_amount.Text.Trim());

                this.TableDetail.AcceptChanges();

                Rpt = B_Exit_Products.Save_exp(oEp, TableDetail);
                if (Rpt != String.Empty)
                {
                    this.Id_ep = Convert.ToInt32(Rpt);
                    MessageBox.Show("Data has been saved successfully # " + this.Id_ep, "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Generating the ticket for the sale
                    Reports.FormRptGeneratedSalePrint oRpt_print = new Reports.FormRptGeneratedSalePrint();
                    oRpt_print.text_p1.Text = Convert.ToString(this.Id_ep);
                    oRpt_print.ShowDialog();
                    // End of the ticket process to print

                    this.State_MainButtons(true);
                    this.State_ProcessButtons(false);
                    this.State_text(false);
                    Dgv_Detail.Columns[3].ReadOnly = true;
                    
                    tabControl1.SelectedIndex = 0;
                    this.Id_ep = 0;
                    this.guardState = 0;
                }
                else
                {
                    MessageBox.Show(Rpt, "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        

        private void Btn_new_Click(object sender, EventArgs e)
        {
            this.guardState = 1; //New Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Clean_text();
            Dgv_Detail.Columns[3].ReadOnly = false;

            this.State_text(true);
            tabControl1.SelectedIndex = 0;
            Text_nodocument_ep.Focus();
        }

        private void Dgv_major_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item();
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_return_Click_1(object sender, EventArgs e)
        {
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_op"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Option;
                Option = MessageBox.Show("Are you sure to delete the selected record?", "System Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Option == DialogResult.Yes)
                {
                    string Rpt = "";
                    this.Id_ep = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_op"].Value);
                    Rpt = B_Exit_Products.Delete_exp(this.Id_ep);
                    if (Rpt.Equals("OK"))
                    {
                        this.Listing_ep("%");
                        this.Clean_text();
                        this.Id_ep = 0;
                        MessageBox.Show("Record Deleted", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tabControl1.SelectedIndex = 1;
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
            Reports.FormRptOutputProducts oRpt4 = new Reports.FormRptOutputProducts();
            oRpt4.text_p1.Text = Text_search.Text;
            oRpt4.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_ep(Text_search.Text.Trim());
        }

        private void Btn_return2_Click(object sender, EventArgs e)
        {
            pnl_list_su.Visible = false;
        }

        private void Dgv_suppliers_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_cl();
            pnl_list_su.Visible = false;
        }


        private void Btn_return3_Click(object sender, EventArgs e)
        {
            pnl_list_pr.Visible = false;
        }      

        private void Btn_eye2_Click(object sender, EventArgs e)
        {
            this.pnl_list_su.Location = Btn_eye1.Location;
            this.pnl_list_su.Visible = true;
        }

        private void Btn_return2_Click_2(object sender, EventArgs e)
        {
            pnl_list_su.Visible = false;
        }

        private void Btn_search2_Click(object sender, EventArgs e)
        {
            this.Listing_cl(Txt_search2.Text);
        }

        private void Dgv_products_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_pr();
            pnl_list_pr.Visible = false;
        }

        private void Btn_return1_Click_1(object sender, EventArgs e)
        {
            pan_List_tdi.Visible = false;
        }

        private void dgv_type_tdi_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_tdi();
            pan_List_tdi.Visible = false;
            Text_nodocument_ep.Focus();
        }

        private void Dgv_Detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.guardState == 1)
            {
                DataRow yFila = (DataRow)TableDetail.Rows[e.RowIndex];
                decimal yAmount = Convert.ToDecimal(yFila["amount"]);
                decimal ySu_buy = Convert.ToDecimal(yFila["su_sale"]);
                yFila["Total"] = decimal.Round(yAmount * ySu_buy, 2).ToString("#0.00");

                this.Calculator_Totals();
            }
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            if (Dgv_Detail.Rows.Count > 0)
            {
                Dgv_Detail.Rows.Remove(Dgv_Detail.CurrentRow);
                Dgv_Detail.Refresh();
                TableDetail.AcceptChanges();
                this.Calculator_Totals();
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            pnl_list_pr.Location = Btn_eye1.Location;
            pnl_list_pr.Visible = true;
            Text_search3.Focus();
        }

        private void return3_Click_2(object sender, EventArgs e)
        {
            pnl_list_pr.Visible = false;
        }

        private void Btn_search3_Click_2(object sender, EventArgs e)
        {
            this.Listing_pr(Text_search3.Text);
        }

        private void Btn_eye1_Click_1(object sender, EventArgs e)
        {
            this.pan_List_tdi.Location = Btn_eye1.Location;
            this.pan_List_tdi.Visible = true;
        }

        private void Btn_return1_Click(object sender, EventArgs e)
        {
            pan_List_tdi.Visible = false;
        }

        private void Btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Id_ep = 0;
            this.Id_tdi = 0;
            this.Id_cl = 0;
            this.guardState = 0; // cancel

            this.State_text(false);
            this.Clean_text();
            Dgv_Detail.Columns[3].ReadOnly = true;

            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Dgv_items_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item_cl();
            pnl_list_su.Visible = false;
        }
    }
}
