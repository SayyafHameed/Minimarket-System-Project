﻿namespace System_Minimarket_Views
{
    partial class Form_Provinces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Provinces));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_major = new System.Windows.Forms.DataGridView();
            this.Btn_search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Text_search = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_departement = new System.Windows.Forms.Button();
            this.Text_description_de = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_List_de = new System.Windows.Forms.Panel();
            this.Btn_look1 = new System.Windows.Forms.Button();
            this.Btn_return1 = new System.Windows.Forms.Button();
            this.Text_look = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dgv_departement = new System.Windows.Forms.DataGridView();
            this.Btn_return = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Text_description_po = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.Btn_update = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_report = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_major)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pan_List_de.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_departement)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 260);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_major);
            this.tabPage1.Controls.Add(this.Btn_search);
            this.tabPage1.Controls.Add(this.Text_search);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.Dgv_major.Size = new System.Drawing.Size(684, 128);
            this.Dgv_major.TabIndex = 3;
            this.Dgv_major.DoubleClick += new System.EventHandler(this.Dgv_major_DoubleClick);
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_search.ImageKey = "lupa.png";
            this.Btn_search.ImageList = this.imageList1;
            this.Btn_search.Location = new System.Drawing.Point(350, 26);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(99, 26);
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
            this.imageList1.Images.SetKeyName(6, "lupa.png");
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
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(38, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Search";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_departement);
            this.tabPage2.Controls.Add(this.Text_description_de);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pan_List_de);
            this.tabPage2.Controls.Add(this.Btn_return);
            this.tabPage2.Controls.Add(this.Btn_cancel);
            this.tabPage2.Controls.Add(this.Text_description_po);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Btn_save);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maintenance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_departement
            // 
            this.Btn_departement.ImageKey = "lupa.png";
            this.Btn_departement.ImageList = this.imageList1;
            this.Btn_departement.Location = new System.Drawing.Point(392, 75);
            this.Btn_departement.Name = "Btn_departement";
            this.Btn_departement.Size = new System.Drawing.Size(41, 23);
            this.Btn_departement.TabIndex = 22;
            this.Btn_departement.UseVisualStyleBackColor = true;
            this.Btn_departement.Click += new System.EventHandler(this.Btn_departement_Click);
            // 
            // Text_description_de
            // 
            this.Text_description_de.Location = new System.Drawing.Point(132, 75);
            this.Text_description_de.MaxLength = 100;
            this.Text_description_de.Name = "Text_description_de";
            this.Text_description_de.Size = new System.Drawing.Size(254, 22);
            this.Text_description_de.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Departement";
            // 
            // pan_List_de
            // 
            this.pan_List_de.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.pan_List_de.Controls.Add(this.Btn_look1);
            this.pan_List_de.Controls.Add(this.Btn_return1);
            this.pan_List_de.Controls.Add(this.Text_look);
            this.pan_List_de.Controls.Add(this.label8);
            this.pan_List_de.Controls.Add(this.label7);
            this.pan_List_de.Controls.Add(this.Dgv_departement);
            this.pan_List_de.Location = new System.Drawing.Point(518, 15);
            this.pan_List_de.Name = "pan_List_de";
            this.pan_List_de.Size = new System.Drawing.Size(260, 213);
            this.pan_List_de.TabIndex = 19;
            this.pan_List_de.Visible = false;
            // 
            // Btn_look1
            // 
            this.Btn_look1.ImageKey = "lupa.png";
            this.Btn_look1.ImageList = this.imageList1;
            this.Btn_look1.Location = new System.Drawing.Point(177, 29);
            this.Btn_look1.Name = "Btn_look1";
            this.Btn_look1.Size = new System.Drawing.Size(39, 23);
            this.Btn_look1.TabIndex = 25;
            this.Btn_look1.UseVisualStyleBackColor = true;
            this.Btn_look1.Click += new System.EventHandler(this.Btn_look1_Click);
            // 
            // Btn_return1
            // 
            this.Btn_return1.Location = new System.Drawing.Point(219, 29);
            this.Btn_return1.Name = "Btn_return1";
            this.Btn_return1.Size = new System.Drawing.Size(38, 23);
            this.Btn_return1.TabIndex = 24;
            this.Btn_return1.Text = "<-|";
            this.Btn_return1.UseVisualStyleBackColor = true;
            this.Btn_return1.Click += new System.EventHandler(this.Btn_return1_Click);
            // 
            // Text_look
            // 
            this.Text_look.Location = new System.Drawing.Point(71, 29);
            this.Text_look.Name = "Text_look";
            this.Text_look.Size = new System.Drawing.Size(103, 22);
            this.Text_look.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Look for";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "List of Departements";
            // 
            // Dgv_departement
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            this.Dgv_departement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_departement.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_departement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_departement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_departement.ColumnHeadersHeight = 30;
            this.Dgv_departement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_departement.EnableHeadersVisualStyles = false;
            this.Dgv_departement.Location = new System.Drawing.Point(3, 57);
            this.Dgv_departement.Name = "Dgv_departement";
            this.Dgv_departement.RowHeadersWidth = 51;
            this.Dgv_departement.RowTemplate.Height = 24;
            this.Dgv_departement.Size = new System.Drawing.Size(254, 153);
            this.Dgv_departement.TabIndex = 20;
            this.Dgv_departement.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_departement_CellDoubleClick);
            // 
            // Btn_return
            // 
            this.Btn_return.BackColor = System.Drawing.Color.Peru;
            this.Btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_return.Location = new System.Drawing.Point(377, 134);
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.Size = new System.Drawing.Size(76, 26);
            this.Btn_return.TabIndex = 4;
            this.Btn_return.Text = "Return";
            this.Btn_return.UseVisualStyleBackColor = false;
            this.Btn_return.Visible = false;
            this.Btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.Location = new System.Drawing.Point(141, 134);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(76, 26);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Visible = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Text_description_po
            // 
            this.Text_description_po.Location = new System.Drawing.Point(132, 33);
            this.Text_description_po.MaxLength = 100;
            this.Text_description_po.Name = "Text_description_po";
            this.Text_description_po.Size = new System.Drawing.Size(254, 22);
            this.Text_description_po.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Province";
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.Location = new System.Drawing.Point(259, 134);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(76, 26);
            this.Btn_save.TabIndex = 0;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Visible = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_new.ImageKey = "nuevo.png";
            this.Btn_new.ImageList = this.imageList1;
            this.Btn_new.Location = new System.Drawing.Point(28, 281);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(84, 60);
            this.Btn_new.TabIndex = 1;
            this.Btn_new.Text = "New";
            this.Btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_update.ImageKey = "actualizar.png";
            this.Btn_update.ImageList = this.imageList1;
            this.Btn_update.Location = new System.Drawing.Point(119, 281);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(84, 60);
            this.Btn_update.TabIndex = 2;
            this.Btn_update.Text = "Update";
            this.Btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_clear.ImageKey = "eliminar.png";
            this.Btn_clear.ImageList = this.imageList1;
            this.Btn_clear.Location = new System.Drawing.Point(210, 281);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(84, 60);
            this.Btn_clear.TabIndex = 3;
            this.Btn_clear.Text = "Delete";
            this.Btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_report
            // 
            this.Btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_report.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_report.ImageKey = "reporte.png";
            this.Btn_report.ImageList = this.imageList1;
            this.Btn_report.Location = new System.Drawing.Point(302, 281);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.Size = new System.Drawing.Size(84, 60);
            this.Btn_report.TabIndex = 4;
            this.Btn_report.Text = "Report";
            this.Btn_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_report.UseVisualStyleBackColor = false;
            this.Btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_exit.ImageKey = "salir.png";
            this.Btn_exit.ImageList = this.imageList1;
            this.Btn_exit.Location = new System.Drawing.Point(393, 281);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(84, 60);
            this.Btn_exit.TabIndex = 5;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Form_Provinces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 353);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_report);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Provinces";
            this.Text = "Provinces";
            this.Load += new System.EventHandler(this.Form_Provinces_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_major)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pan_List_de.ResumeLayout(false);
            this.pan_List_de.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_departement)).EndInit();
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
        private System.Windows.Forms.TextBox Text_description_po;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_report;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_return;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Text_description_de;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pan_List_de;
        private System.Windows.Forms.Button Btn_look1;
        private System.Windows.Forms.Button Btn_return1;
        private System.Windows.Forms.TextBox Text_look;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Dgv_departement;
        private System.Windows.Forms.Button Btn_departement;
    }
}