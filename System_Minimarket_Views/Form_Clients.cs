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
    public partial class Form_Clients : Form
    {
        public Form_Clients()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_cl = 0;
        int Id_tdsc = 0;
        int Id_ge = 0;
        int Id_it = 0;
        int Id_di = 0;
        int guardState = 0; //No action
        #endregion

        #region "My Method"
        private void Format_cl()
        {
            Dgv_major.Columns[0].Width = 85;
            Dgv_major.Columns[0].HeaderText = "ID_CLIENTS";
            Dgv_major.Columns[1].Width = 95;
            Dgv_major.Columns[1].HeaderText = "TYPE DOC";
            Dgv_major.Columns[2].Width = 110;
            Dgv_major.Columns[2].HeaderText = "NO DOC";
            Dgv_major.Columns[3].Width = 270;
            Dgv_major.Columns[3].HeaderText = "Company Name";
            Dgv_major.Columns[4].Width = 140;
            Dgv_major.Columns[4].HeaderText = "NUMBERS";
            Dgv_major.Columns[5].Width = 140;
            Dgv_major.Columns[5].HeaderText = "SURNAMES";
            Dgv_major.Columns[6].Width = 150;
            Dgv_major.Columns[6].HeaderText = "Items";
            Dgv_major.Columns[7].Visible = false;
            Dgv_major.Columns[8].Visible = false;
            Dgv_major.Columns[9].Visible = false;
            Dgv_major.Columns[10].Visible = false;
            Dgv_major.Columns[11].Visible = false;
            Dgv_major.Columns[12].Visible = false;
            Dgv_major.Columns[13].Visible = false;
            Dgv_major.Columns[14].Visible = false;
            Dgv_major.Columns[15].Visible = false;
            Dgv_major.Columns[16].Visible = false;
            Dgv_major.Columns[17].Visible = false;
            Dgv_major.Columns[18].Visible = false;
            Dgv_major.Columns[19].Visible = false;

        }

        private void Listing_cl(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Clients.Listing_cl(cText);
                this.Format_cl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_cl"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string District = "";
                this.Id_cl = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_cl"].Value);
                this.Id_tdsc = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_tdsc"].Value);
                Text_description_tdsc.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_tdsc"].Value);
                Text_nodocument_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["noDocument_cl"].Value);
                Text_comanyname_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["companyname_cl"].Value);
                Text_numpers.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["numbers"].Value);
                Text_surname.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["surNames"].Value);
                this.Id_it = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_it"].Value);
                Text_desscription_it.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_it"].Value);
                Text_email_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["email_cl"].Value);
                Text_phone_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["phone_cl"].Value);
                Text_mobile_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["mobile_cl"].Value);
                this.Id_ge = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_ge"].Value);
                Text_gender_ge.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_ge"].Value);
                Text_address_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["address_cl"].Value);
                this.Id_di = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_di"].Value);

                District = Convert.ToString(Dgv_major.CurrentRow.Cells["description_di"].Value).Trim() + " || " +
                           Convert.ToString(Dgv_major.CurrentRow.Cells["description_po"].Value).Trim() + " || " +
                           Convert.ToString(Dgv_major.CurrentRow.Cells["description_de"].Value).Trim();

                Text_district.Text = District;
                Text_observation_su.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["observation_cl"].Value).Trim();
            }

        }

        private void Format_tdsc()
        {
            Dgv_type_tdsc.Columns[0].Width = 200;
            Dgv_type_tdsc.Columns[0].HeaderText = "TYPE DOCUMENT";
            Dgv_type_tdsc.Columns[1].Visible = false;

        }

        private void Listing_tdsc()
        {
            try
            {
                Dgv_type_tdsc.DataSource = B_Clients.Listing_tdsc();
                this.Format_tdsc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_tdsc()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_type_tdsc.CurrentRow.Cells["id_tdsc"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_tdsc = Convert.ToInt32(Dgv_type_tdsc.CurrentRow.Cells["id_tdsc"].Value);
                Text_description_tdsc.Text = Convert.ToString(Dgv_type_tdsc.CurrentRow.Cells["description_tdsc"].Value);
            }
        }

        private void Format_ge()
        {
            Dgv_gender.Columns[0].Width = 200;
            Dgv_gender.Columns[0].HeaderText = "GENDER";
            Dgv_gender.Columns[1].Visible = false;

        }

        private void Listing_ge()
        {
            try
            {
                Dgv_gender.DataSource = B_Clients.Listing_ge();
                this.Format_ge();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_ge()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_gender.CurrentRow.Cells["id_ge"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_ge = Convert.ToInt32(Dgv_gender.CurrentRow.Cells["id_ge"].Value);
                Text_gender_ge.Text = Convert.ToString(Dgv_gender.CurrentRow.Cells["description_ge"].Value);
            }

        }

        private void Format_it()
        {
            Dgv_items.Columns[0].Width = 220;
            Dgv_items.Columns[0].HeaderText = "Items";
            Dgv_items.Columns[1].Visible = false;

        }

        private void Listing_it(string cText)
        {
            try
            {
                Dgv_items.DataSource = B_Clients.Listing_it_cl(cText);
                this.Format_it();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_it()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_items.CurrentRow.Cells["id_it"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_it = Convert.ToInt32(Dgv_items.CurrentRow.Cells["id_it"].Value);
                Text_desscription_it.Text = Convert.ToString(Dgv_items.CurrentRow.Cells["description_it"].Value);
            }
        }

        private void Format_di()
        {
            Dgv_districts.Columns[0].Width = 220;
            Dgv_districts.Columns[0].HeaderText = "DISTRICT";
            Dgv_districts.Columns[1].Width = 220;
            Dgv_districts.Columns[1].HeaderText = "PROVINCE";
            Dgv_districts.Columns[2].Width = 220;
            Dgv_districts.Columns[2].HeaderText = "DEPARTEMENT";
            Dgv_districts.Columns[3].Visible = false;
        }

        private void Listing_di(string cText)
        {
            try
            {
                Dgv_districts.DataSource = B_Clients.Listing_di_cl(cText);
                this.Format_di();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_di()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_districts.CurrentRow.Cells["id_di"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_di = Convert.ToInt32(Dgv_districts.CurrentRow.Cells["id_di"].Value);
                Text_district.Text = Convert.ToString(Dgv_districts.CurrentRow.Cells["description_di"].Value) + " || " +
                                     Convert.ToString(Dgv_districts.CurrentRow.Cells["description_po"].Value) + " || " +
                                     Convert.ToString(Dgv_districts.CurrentRow.Cells["description_de"].Value);
            }

        }

        private void State_text(bool listing)
        {
            Text_nodocument_su.ReadOnly = !listing;
            Text_comanyname_su.ReadOnly = !listing;
            Text_numpers.ReadOnly = !listing;
            Text_surname.ReadOnly = !listing;
            Text_email_su.ReadOnly = !listing;
            Text_phone_su.ReadOnly = !listing;
            Text_mobile_su.ReadOnly = !listing;
            Text_address_su.ReadOnly = !listing;
            Text_observation_su.ReadOnly = !listing;
        }

        private void Clean_text()
        {
            Text_nodocument_su.Text = "";
            Text_comanyname_su.Text = "";
            Text_numpers.Text = "";
            Text_surname.Text = "";
            Text_email_su.Text = "";
            Text_phone_su.Text = "";
            Text_mobile_su.Text = "";
            Text_address_su.Text = "";
            Text_observation_su.Text = "";
        }

        #endregion

        private void Form_Clients_Load(object sender, EventArgs e)
        {
            this.Listing_cl("%");
            this.Listing_tdsc();
            this.Listing_ge();
            this.Listing_it("%");
            this.Listing_di("%");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Text_nodocument_su.Text == String.Empty ||
                Text_description_tdsc.Text == String.Empty ||
                Text_gender_ge.Text == String.Empty ||
                Text_desscription_it.Text == String.Empty ||
                Text_comanyname_su.Text == String.Empty ||
                Text_district.Text == String.Empty ||
                Text_address_su.Text == String.Empty)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                string Rpt = "";
                E_Clients oSu = new E_Clients();

                oSu.Id_cl = this.Id_cl;
                oSu.Id_tdsc = this.Id_tdsc;
                oSu.NoDocument_cl = Text_nodocument_su.Text.Trim();
                oSu.CompanyName_cl = Text_comanyname_su.Text.Trim();
                oSu.Numbers = Text_numpers.Text.Trim();
                oSu.SurNames = Text_surname.Text.Trim();
                oSu.Id_it = this.Id_it;
                oSu.Id_ge = this.Id_ge;
                oSu.Email_cl = Text_email_su.Text.Trim();
                oSu.Phone_cl = Text_phone_su.Text.Trim();
                oSu.Mobile_cl = Text_mobile_su.Text.Trim();
                oSu.Address_cl = Text_address_su.Text.Trim();
                oSu.Id_di = this.Id_di;
                oSu.Observation_cl = Text_observation_su.Text.Trim();

                Rpt = B_Clients.Save_cl(guardState, oSu);
                if (Rpt.Equals("OK"))
                {
                    this.Listing_cl("%");
                    MessageBox.Show("Data has been saved successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardState = 0; //No action
                    this.State_MainButtons(true);
                    this.State_ProcessButtons(false);
                    this.State_text(false);
                    tabControl1.SelectedIndex = 0;
                    this.Id_cl = 0;
                }
                else
                {
                    MessageBox.Show(Rpt, "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            guardState = 0; // cancel

            this.Id_cl = 0;
            this.Id_tdsc = 0;
            this.Id_ge = 0;
            this.Id_it = 0;
            this.Id_di = 0;
            this.State_text(false);
            this.Clean_text();
            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            guardState = 1; //New Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Clean_text();
            this.State_text(true);
            tabControl1.SelectedIndex = 1;
            Text_nodocument_su.Focus();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            guardState = 2; // Updated Registration
            this.Choose_item();
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.State_text(true);
            tabControl1.SelectedIndex = 1;
            Text_nodocument_su.Focus();
        }

        private void Dgv_major_DoubleClick(object sender, EventArgs e)
        {
            this.Choose_item();
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 1;
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_cl"].Value)))
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
                    this.Id_cl = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_cl"].Value);
                    Rpt = B_Clients.Delete_cl(this.Id_cl);
                    if (Rpt.Equals("OK"))
                    {
                        this.Listing_cl("%");
                        this.Id_cl = 0;
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
            Reports.FormClients oRpt4 = new Reports.FormClients();
            oRpt4.text_p1.Text = Text_search.Text;
            oRpt4.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_cl(Text_search.Text.Trim());
        }
                
        private void Btn_return3_Click(object sender, EventArgs e)
        {
            pan_List_it.Visible = false;
        }

        private void Btn_look3_Click(object sender, EventArgs e)
        {
            this.Listing_it(Text_look3.Text);
        }

        private void Btn_return1_Click(object sender, EventArgs e)
        {
            pan_List_tdsc.Visible = false;
        }

        private void Btn_return2_Click(object sender, EventArgs e)
        {
            pan_List_ge.Visible = false;
        }

        private void Btn_return4_Click(object sender, EventArgs e)
        {
            pan_List_di.Visible = false;
        }

        private void Btn_tdsc_Click_1(object sender, EventArgs e)
        {
            this.pan_List_tdsc.Location = Btn_tdsc.Location;
            this.pan_List_tdsc.Visible = true;
        }

        private void Btn_items_Click_1(object sender, EventArgs e)
        {
            this.pan_List_it.Location = Btn_tdsc.Location;
            this.pan_List_it.Visible = true;
        }

        private void Btn_gender_Click_1(object sender, EventArgs e)
        {
            this.pan_List_ge.Location = Btn_tdsc.Location;
            this.pan_List_ge.Visible = true;
        }

        private void Btn_districts_Click_1(object sender, EventArgs e)
        {
            this.pan_List_di.Location = Btn_tdsc.Location;
            this.pan_List_di.Visible = true;
        }

        private void dgv_type_tdsc_DoubleClick_1(object sender, EventArgs e)
        {
            this.Choose_item_tdsc();
            pan_List_tdsc.Visible = false;
            Text_nodocument_su.Focus();
        }

        private void Dgv_items_DoubleClick_1(object sender, EventArgs e)
        {
            this.Choose_item_it();
            this.pan_List_it.Visible = false;
        }

        private void Dgv_districts_DoubleClick_1(object sender, EventArgs e)
        {
            this.Choose_item_di();
            pan_List_di.Visible = false;
        }

        private void Dgv_gender_DoubleClick_1(object sender, EventArgs e)
        {
            this.Choose_item_ge();
            this.pan_List_ge.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pan_List_di.Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_look2_Click(object sender, EventArgs e)
        {
            this.Listing_di(Text_look2.Text);
        }
    }
}
