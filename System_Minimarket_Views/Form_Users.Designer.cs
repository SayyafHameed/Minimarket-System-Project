namespace System_Minimarket_Views
{
    partial class Form_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Users));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_major = new System.Windows.Forms.DataGridView();
            this.Btn_search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Text_search = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Chk_admin = new System.Windows.Forms.CheckBox();
            this.Txt_location_us = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_names_us = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_password_us = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_return = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Text_login_us = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_report = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_update = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_major)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.Dgv_major);
            this.tabPage1.Controls.Add(this.Btn_search);
            this.tabPage1.Controls.Add(this.Text_search);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List";
            // 
            // Dgv_major
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.Dgv_major.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_major.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_major.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_major.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_major.ColumnHeadersHeight = 30;
            this.Dgv_major.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_major.EnableHeadersVisualStyles = false;
            this.Dgv_major.Location = new System.Drawing.Point(36, 56);
            this.Dgv_major.Name = "Dgv_major";
            this.Dgv_major.RowHeadersWidth = 51;
            this.Dgv_major.RowTemplate.Height = 24;
            this.Dgv_major.Size = new System.Drawing.Size(834, 159);
            this.Dgv_major.TabIndex = 3;
            this.Dgv_major.DoubleClick += new System.EventHandler(this.Dgv_major_DoubleClick);
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_search.ImageKey = "lupa.png";
            this.Btn_search.ImageList = this.imageList1;
            this.Btn_search.Location = new System.Drawing.Point(360, 26);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(88, 26);
            this.Btn_search.TabIndex = 2;
            this.Btn_search.Text = "Search";
            this.Btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "lupa.png");
            // 
            // Text_search
            // 
            this.Text_search.Location = new System.Drawing.Point(101, 28);
            this.Text_search.Name = "Text_search";
            this.Text_search.Size = new System.Drawing.Size(241, 22);
            this.Text_search.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(38, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Search";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.tabPage2.Controls.Add(this.Chk_admin);
            this.tabPage2.Controls.Add(this.Txt_location_us);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Txt_names_us);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Txt_password_us);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Btn_return);
            this.tabPage2.Controls.Add(this.Btn_cancel);
            this.tabPage2.Controls.Add(this.Text_login_us);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Btn_save);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maintenance";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Chk_admin
            // 
            this.Chk_admin.AutoSize = true;
            this.Chk_admin.Location = new System.Drawing.Point(166, 158);
            this.Chk_admin.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_admin.Name = "Chk_admin";
            this.Chk_admin.Size = new System.Drawing.Size(120, 20);
            this.Chk_admin.TabIndex = 17;
            this.Chk_admin.Text = "Administrator";
            this.Chk_admin.UseVisualStyleBackColor = true;
            // 
            // Txt_location_us
            // 
            this.Txt_location_us.Location = new System.Drawing.Point(166, 125);
            this.Txt_location_us.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_location_us.MaxLength = 50;
            this.Txt_location_us.Name = "Txt_location_us";
            this.Txt_location_us.ReadOnly = true;
            this.Txt_location_us.Size = new System.Drawing.Size(293, 22);
            this.Txt_location_us.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location";
            // 
            // Txt_names_us
            // 
            this.Txt_names_us.Location = new System.Drawing.Point(166, 55);
            this.Txt_names_us.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_names_us.MaxLength = 100;
            this.Txt_names_us.Name = "Txt_names_us";
            this.Txt_names_us.ReadOnly = true;
            this.Txt_names_us.Size = new System.Drawing.Size(359, 22);
            this.Txt_names_us.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Names";
            // 
            // Txt_password_us
            // 
            this.Txt_password_us.Location = new System.Drawing.Point(166, 89);
            this.Txt_password_us.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_password_us.MaxLength = 20;
            this.Txt_password_us.Name = "Txt_password_us";
            this.Txt_password_us.PasswordChar = '*';
            this.Txt_password_us.ReadOnly = true;
            this.Txt_password_us.Size = new System.Drawing.Size(275, 22);
            this.Txt_password_us.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // Btn_return
            // 
            this.Btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.Btn_return.BackgroundImage = global::System_Minimarket_Views.Properties.Resources.button_disabled;
            this.Btn_return.FlatAppearance.BorderSize = 0;
            this.Btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_return.ForeColor = System.Drawing.Color.White;
            this.Btn_return.Location = new System.Drawing.Point(402, 193);
            this.Btn_return.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.Size = new System.Drawing.Size(113, 33);
            this.Btn_return.TabIndex = 4;
            this.Btn_return.Text = "Return";
            this.Btn_return.UseVisualStyleBackColor = true;
            this.Btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.Btn_cancel.BackgroundImage = global::System_Minimarket_Views.Properties.Resources.button_delete1;
            this.Btn_cancel.FlatAppearance.BorderSize = 0;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_cancel.Location = new System.Drawing.Point(166, 193);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(113, 33);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Text_login_us
            // 
            this.Text_login_us.Location = new System.Drawing.Point(166, 21);
            this.Text_login_us.MaxLength = 50;
            this.Text_login_us.Name = "Text_login_us";
            this.Text_login_us.ReadOnly = true;
            this.Text_login_us.Size = new System.Drawing.Size(275, 22);
            this.Text_login_us.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.Btn_save.BackgroundImage = global::System_Minimarket_Views.Properties.Resources.button;
            this.Btn_save.FlatAppearance.BorderSize = 0;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.ForeColor = System.Drawing.Color.White;
            this.Btn_save.Location = new System.Drawing.Point(284, 193);
            this.Btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(113, 33);
            this.Btn_save.TabIndex = 0;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_exit.ImageKey = "salir.png";
            this.Btn_exit.ImageList = this.imageList1;
            this.Btn_exit.Location = new System.Drawing.Point(393, 290);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(84, 60);
            this.Btn_exit.TabIndex = 5;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_report
            // 
            this.Btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_report.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_report.ImageKey = "reporte.png";
            this.Btn_report.ImageList = this.imageList1;
            this.Btn_report.Location = new System.Drawing.Point(302, 290);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.Size = new System.Drawing.Size(84, 60);
            this.Btn_report.TabIndex = 4;
            this.Btn_report.Text = "Report";
            this.Btn_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_report.UseVisualStyleBackColor = false;
            this.Btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_clear.ImageKey = "eliminar.png";
            this.Btn_clear.ImageList = this.imageList1;
            this.Btn_clear.Location = new System.Drawing.Point(210, 290);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(84, 60);
            this.Btn_clear.TabIndex = 3;
            this.Btn_clear.Text = "Delete";
            this.Btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_update.ImageKey = "actualizar.png";
            this.Btn_update.ImageList = this.imageList1;
            this.Btn_update.Location = new System.Drawing.Point(119, 290);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(84, 60);
            this.Btn_update.TabIndex = 2;
            this.Btn_update.Text = "Update";
            this.Btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_new.ImageKey = "nuevo.png";
            this.Btn_new.ImageList = this.imageList1;
            this.Btn_new.Location = new System.Drawing.Point(28, 290);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(84, 60);
            this.Btn_new.TabIndex = 1;
            this.Btn_new.Text = "New";
            this.Btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Form_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 362);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_report);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Form_Users_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_major)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.TextBox Text_search;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView Dgv_major;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.TextBox Text_login_us;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_report;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_return;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox Chk_admin;
        private System.Windows.Forms.TextBox Txt_location_us;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_names_us;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_password_us;
        private System.Windows.Forms.Label label2;
    }
}