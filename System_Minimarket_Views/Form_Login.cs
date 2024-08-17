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

namespace System_Minimarket_Views
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        #region "My Method"
        private void Login_us(string cLogin, string cPassword)
        {
            try
            {
                DataTable data_login = new DataTable();
                data_login = B_Users.Login_us(cLogin, cPassword);
                if (data_login.Rows.Count > 0)
                {
                    string cNames = "";
                    string cLocation = "";
                    bool bAdmin = false;

                    cNames = Convert.ToString(data_login.Rows[0][3]);
                    cLocation = Convert.ToString(data_login.Rows[0][4]);
                    bAdmin = Convert.ToBoolean(data_login.Rows[0][5]);

                    Form_DashBoard oDashBoard = new Form_DashBoard();
                    oDashBoard.Lbl_names_us.Text = "Names: " + cNames;
                    oDashBoard.Lbl_position.Text = "Position: " + cLocation;
                    oDashBoard.Chk_admin.Checked = bAdmin;

                    if (bAdmin == true) //Administrator
                    {
                        oDashBoard.Btn_proccess.Enabled = true;
                        oDashBoard.Btn_reports.Enabled = true;
                        oDashBoard.Btn_masterData.Enabled = true;
                        oDashBoard.Btn_system.Enabled = true;
                    }
                    else // Users
                    {
                        oDashBoard.Btn_proccess.Enabled = true;
                        oDashBoard.Btn_reports.Enabled = true;
                        oDashBoard.Btn_masterData.Enabled = false;
                        oDashBoard.Btn_system.Enabled = false;
                    }

                    oDashBoard.Show();
                    oDashBoard.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong access", "System Notice");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            this.Show();
            Txt_login_us.Focus();
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Login_us(Txt_login_us.Text, Txt_password_us.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
