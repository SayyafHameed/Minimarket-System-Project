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
    public partial class Form_Items : Form
    {
        public Form_Items()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_it = 0;
        int guardState = 0; //No action
        #endregion

        #region "My Method"
        private void Format_it()
        {
            Dgv_major.Columns[0].Width = 100;
            Dgv_major.Columns[0].HeaderText = "ID";
            Dgv_major.Columns[1].Width = 300;
            Dgv_major.Columns[1].HeaderText = "Items";
        }

        private void Listing_it(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Items.Listing_it(cText);
                this.Format_it();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_it"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_it = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_it"].Value);
                Text_description_it.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_it"].Value);
            }

        }

        #endregion

        private void Form_Items_Load(object sender, EventArgs e)
        {
            this.Listing_it("%");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Text_description_it.Text == String.Empty)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                E_Items oPr = new E_Items();
                string Rpta = "";
                oPr.Id_it = this.Id_it;
                oPr.Description_it = Text_description_it.Text.Trim();
                Rpta = B_Items.Save_it(guardState, oPr);
                if (Rpta == "OK")
                {
                    this.Listing_it("%");
                    MessageBox.Show("Data has been saved successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardState = 0; //No action
                    this.State_MainButtons(true);
                    this.State_ProcessButtons(false);
                    Text_description_it.Text = "";
                    Text_description_it.ReadOnly = true;
                    tabControl1.SelectedIndex = 0;
                    this.Id_it = 0;

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
            this.Id_it = 0;
            Text_description_it.Text = "";
            Text_description_it.ReadOnly = true;
            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            guardState = 1; //New Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            Text_description_it.Text = "";
            Text_description_it.ReadOnly = false;
            tabControl1.SelectedIndex = 1;
            Text_description_it.Focus();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            guardState = 2; // Updated Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Choose_item();
            tabControl1.SelectedIndex = 1;
            Text_description_it.ReadOnly = false;
            Text_description_it.Focus();
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
            this.Id_it = 0;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_it"].Value)))
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
                    this.Id_it = Convert.ToInt32(Dgv_major.CurrentRow.Cells["Id_it"].Value);
                    Rpt = B_Items.Delete_it(this.Id_it);
                    if (Rpt.Equals("OK"))
                    {
                        this.Listing_it("%");
                        this.Id_it = 0;
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
            Reports.FormRptItems oRpt2 = new Reports.FormRptItems();
            oRpt2.text_p1.Text = Text_search.Text;
            oRpt2.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_it(Text_search.Text.Trim());
        }
    }
}
