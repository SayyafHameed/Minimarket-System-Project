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
    public partial class Form_Measured_Units : Form
    {
        public Form_Measured_Units()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_mu = 0;
        int guardState = 0; //No action
        #endregion

        #region "My Method"
        private void Format_mu()
        {
            Dgv_major.Columns[0].Width = 100;
            Dgv_major.Columns[0].HeaderText = "ID_MU";
            Dgv_major.Columns[1].Width = 100;
            Dgv_major.Columns[1].HeaderText = "ABBRVIATION";
            Dgv_major.Columns[2].Width = 300;
            Dgv_major.Columns[2].HeaderText = "MEASURED";
        }

        private void Listing_mu(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Measured_Units.Listing_mu(cText);
                this.Format_mu();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_mu"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_mu = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_mu"].Value);
                Text_abbreviation_mu.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["abbreviation_mu"].Value);
                Text_description_mu.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_mu"].Value);
            }

        }

        #endregion

        private void Form_Measured_Units_Load(object sender, EventArgs e)
        {
            this.Listing_mu("%");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Text_abbreviation_mu.Text == String.Empty || Text_description_mu.Text == String.Empty)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                E_Measured_Units oMu = new E_Measured_Units();
                string Rpta = "";
                oMu.Id_mu = this.Id_mu;
                oMu.Abbreviation_mu = Text_abbreviation_mu.Text.Trim();
                oMu.Description_mu = Text_description_mu.Text.Trim();
                Rpta = B_Measured_Units.Save_mu(guardState, oMu);
                if (Rpta == "OK")
                {
                    this.Listing_mu("%");
                    MessageBox.Show("Data has been saved successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardState = 0; //No action
                    this.State_MainButtons(true);
                    this.State_ProcessButtons(false);
                    Text_abbreviation_mu.Text = "";
                    Text_abbreviation_mu.ReadOnly = true;
                    Text_description_mu.Text = "";
                    Text_description_mu.ReadOnly = true;                    
                    tabControl1.SelectedIndex = 0;
                    this.Id_mu = 0;

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
            this.Id_mu = 0;
            Text_abbreviation_mu.Text = "";
            Text_abbreviation_mu.ReadOnly = true;
            Text_description_mu.Text = "";
            Text_description_mu.ReadOnly = true;
            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            guardState = 1; //New Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            Text_abbreviation_mu.Text = "";
            Text_abbreviation_mu.ReadOnly = false;
            Text_description_mu.Text = "";
            Text_description_mu.ReadOnly = false;
            tabControl1.SelectedIndex = 1;
            Text_description_mu.Focus();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            guardState = 2; // Updated Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Choose_item();
            tabControl1.SelectedIndex = 1;
            Text_abbreviation_mu.ReadOnly = false;
            Text_description_mu.ReadOnly = false;
            Text_description_mu.Focus();
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
            this.Id_mu = 0;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_mu"].Value)))
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
                    this.Id_mu = Convert.ToInt32(Dgv_major.CurrentRow.Cells["Id_mu"].Value);
                    Rpt = B_Measured_Units.Delete_mu(this.Id_mu);
                    if (Rpt.Equals("OK"))
                    {
                        this.Listing_mu("%");
                        this.Id_mu = 0;
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
            Reports.FormMeasuredUnits oRpt1 = new Reports.FormMeasuredUnits();
            oRpt1.text_p1.Text = Text_search.Text;
            oRpt1.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_mu(Text_search.Text.Trim());
        }
    }
}
