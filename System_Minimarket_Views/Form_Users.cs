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
    public partial class Form_Users : Form
    {
        public Form_Users()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_us = 0;
        int guardState = 0; //No action
        #endregion

        #region "My Method"
        private void Format_us()
        {
            Dgv_major.Columns[0].Width = 100;
            Dgv_major.Columns[0].HeaderText = "ID_USER";
            Dgv_major.Columns[1].Width = 200;
            Dgv_major.Columns[1].HeaderText = "EMAIL";
            Dgv_major.Columns[2].Width = 300;
            Dgv_major.Columns[2].HeaderText = "NAMES";
            Dgv_major.Columns[3].Width = 200;
            Dgv_major.Columns[3].HeaderText = "LOCATION";
            Dgv_major.Columns[4].Visible = false;
        }

        private void Listing_us(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Users.Listing_us(cText);
                this.Format_us();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_us"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_us = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_us"].Value);
                Text_login_us.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["login_us"].Value);
                Txt_password_us.Text = "";
                Txt_names_us.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["names_us"].Value);
                Txt_location_us.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["Location_us"].Value);
                Chk_admin.Checked = Convert.ToBoolean(Dgv_major.CurrentRow.Cells["admin"].Value);
            }

        }

        #endregion

        private void Form_Users_Load(object sender, EventArgs e)
        {
            this.Listing_us("%");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Txt_password_us.Text == String.Empty && this.guardState == 1)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                if (Text_login_us.Text == String.Empty ||
                        Txt_names_us.Text == String.Empty)
                {
                    MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    E_Users oUs = new E_Users();
                    string Rpt = "";
                    oUs.Id_us = this.Id_us;
                    oUs.Login_us = Text_login_us.Text.Trim();
                    oUs.Password_us = Txt_password_us.Text.Trim();
                    oUs.Names_us = Txt_names_us.Text.Trim();
                    oUs.Location_us = Txt_location_us.Text.Trim();
                    oUs.Admin = Chk_admin.Checked;

                    Rpt = B_Users.Save_us(guardState, oUs);
                    if (Rpt == "OK")
                    {
                        this.Listing_us("%");
                        MessageBox.Show("Data has been saved successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardState = 0; 
                        this.State_MainButtons(true);
                        this.State_ProcessButtons(false);
                        Text_login_us.Text = "";
                        Txt_password_us.Text = "";
                        Txt_names_us.Text = "";
                        Txt_location_us.Text = "";
                        Chk_admin.Checked = false;

                        Text_login_us.ReadOnly = true;
                        Txt_password_us.ReadOnly = true;
                        Txt_names_us.ReadOnly = true;
                        Txt_location_us.ReadOnly = true;
                        Chk_admin.Enabled = false;
                        tabControl1.SelectedIndex = 0;
                        this.Id_us = 0;

                    }
                    else
                    {
                        MessageBox.Show(Rpt, "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            guardState = 0; // cancel
            this.Id_us = 0;

            Text_login_us.Text = "";
            Txt_password_us.Text = "";
            Txt_names_us.Text = "";
            Txt_location_us.Text = "";
            Chk_admin.Checked = false;

            Text_login_us.ReadOnly = true;
            Txt_password_us.ReadOnly = true;
            Txt_names_us.ReadOnly = true;
            Txt_location_us.ReadOnly = true;
            Chk_admin.Enabled = false;

            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            guardState = 1; //New Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            Text_login_us.Text = "";
            Txt_password_us.Text = "";
            Txt_names_us.Text = "";
            Txt_location_us.Text = "";
            Chk_admin.Checked = false;

            Text_login_us.ReadOnly = false;
            Txt_password_us.ReadOnly = false;
            Txt_names_us.ReadOnly = false;
            Txt_location_us.ReadOnly = false;
            Chk_admin.Enabled = true;

            tabControl1.SelectedIndex = 1;
            Text_login_us.Focus();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            guardState = 2; // Updated Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Choose_item();
            tabControl1.SelectedIndex = 1;

            Txt_password_us.ReadOnly = false;
            Txt_names_us.ReadOnly = false;
            Txt_location_us.ReadOnly = false;
            Chk_admin.Enabled = true;
            Text_login_us.Focus();
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
            this.Id_us = 0;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_us"].Value)))
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
                    this.Id_us = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_us"].Value);
                    Rpt = B_Users.Delete_us(this.Id_us);
                    if (Rpt.Equals("OK"))
                    {
                        this.Listing_us("%");
                        this.Id_us = 0;
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
            //Reports.FormRptBrands oRpt2 = new Reports.FormRptBrands();
            //oRpt2.text_p1.Text = Text_search.Text;
            //oRpt2.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_us(Text_search.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
