﻿using System;
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
    public partial class Form_Districts : Form
    {
        public Form_Districts()
        {
            InitializeComponent();
        }

        #region "My Variables"
        int Id_di = 0;
        int Id_po = 0;
        int guardState = 0; //No action
        #endregion

        #region "My Method"
        private void Format_di()
        {
            Dgv_major.Columns[0].Width = 100;
            Dgv_major.Columns[0].HeaderText = "ID_DI";
            Dgv_major.Columns[1].Width = 270;
            Dgv_major.Columns[1].HeaderText = "District";
            Dgv_major.Columns[2].Width = 270;
            Dgv_major.Columns[2].HeaderText = "Province";
            Dgv_major.Columns[3].Width = 270;
            Dgv_major.Columns[3].HeaderText = "Apartments";
            Dgv_major.Columns[4].Visible = false;
        }

        private void Listing_di(string cText)
        {
            try
            {
                Dgv_major.DataSource = B_Districts.Listing_di(cText);
                this.Format_di();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_di"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_po = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_po"].Value);
                Text_description_po.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_po"].Value).Trim();

                this.Id_di = Convert.ToInt32(Dgv_major.CurrentRow.Cells["id_di"].Value);
                Text_description_di.Text = Convert.ToString(Dgv_major.CurrentRow.Cells["description_di"].Value).Trim();
            }

        }

        private void Format_po_personalized()
        {
            Dgv_provinces.Columns[0].Width = 300;
            Dgv_provinces.Columns[0].HeaderText = "Provinces";
            Dgv_provinces.Columns[1].Width = 300;
            Dgv_provinces.Columns[1].HeaderText = "Apartments";
            Dgv_provinces.Columns[2].Visible = false;
        }

        private void Listing_po_personalized(string cText)
        {
            try
            {
                Dgv_provinces.DataSource = B_Districts.Listing_po_personalized(cText);
                this.Format_po_personalized();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Choose_item_po_personalized()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_provinces.CurrentRow.Cells["id_po"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Id_po = Convert.ToInt32(Dgv_provinces.CurrentRow.Cells["id_po"].Value);
                Text_description_po.Text = Convert.ToString(Dgv_provinces.CurrentRow.Cells["description_po"].Value);
            }

        }

        #endregion

        private void Form_Districts_Load(object sender, EventArgs e)
        {
            this.Listing_di("%");
            this.Listing_po_personalized("%");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Text_description_po.Text == String.Empty ||
                Text_description_di.Text == String.Empty)
            {
                MessageBox.Show("Failure to enter required data (*)", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // The information would be recorded
            {
                E_Districts oCa = new E_Districts();
                string Rpta = "";
                oCa.Id_di = this.Id_di;
                oCa.Description_di = Text_description_di.Text.Trim();
                oCa.Id_po = this.Id_po;
                Rpta = B_Districts.Save_di(guardState, oCa);
                if (Rpta == "OK")
                {
                    this.Listing_di("%");
                    MessageBox.Show("Data has been saved successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardState = 0; //No action
                    this.State_MainButtons(true);
                    this.State_ProcessButtons(false);
                    Text_description_di.Text = "";
                    Text_description_di.ReadOnly = true;
                    tabControl1.SelectedIndex = 0;
                    this.Id_di = 0;

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
            this.Id_di = 0;
            Text_description_di.Text = "";
            Text_description_di.ReadOnly = true;
            this.State_MainButtons(true);
            this.State_ProcessButtons(false);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            guardState = 1; //New Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            Text_description_di.Text = "";
            Text_description_di.ReadOnly = false;
            tabControl1.SelectedIndex = 1;
            Text_description_di.Focus();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            guardState = 2; // Updated Registration
            this.State_MainButtons(false);
            this.State_ProcessButtons(true);
            this.Choose_item();
            tabControl1.SelectedIndex = 1;
            Text_description_di.ReadOnly = false;
            Text_description_di.Focus();
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
            this.Id_di = 0;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_major.CurrentRow.Cells["id_di"].Value)))
            {
                MessageBox.Show("There is no information to View", "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Are you sure to delete the selected record?", "System Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Id_di = Convert.ToInt32(Dgv_major.CurrentRow.Cells["Id_di"].Value);
                    Rpta = B_Provinces.Delete_po(this.Id_po);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listing_di("%");
                        this.Id_di = 0;
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
            Reports.FormRptDistricts oRpt1 = new Reports.FormRptDistricts();
            oRpt1.text_p1.Text = Text_search.Text;
            oRpt1.ShowDialog();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            this.Listing_di(Text_search.Text.Trim());
        }

        private void Btn_departement_Click(object sender, EventArgs e)
        {
            pan_List_po.Location = Btn_departement.Location;
            pan_List_po.Visible = true;
        }

        private void Btn_return1_Click(object sender, EventArgs e)
        {
            pan_List_po.Visible = false;
        }

        private void Dgv_provinces_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Choose_item_po_personalized();
            pan_List_po.Visible = false;
            Text_description_di.Focus();
        }

        private void Btn_look1_Click(object sender, EventArgs e)
        {
            this.Listing_po_personalized(Text_look.Text);
        }
    }
}
