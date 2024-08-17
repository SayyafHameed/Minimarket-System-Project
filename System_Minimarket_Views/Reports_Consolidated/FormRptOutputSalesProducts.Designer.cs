namespace System_Minimarket_Views.Reports_Consolidated
{
    partial class FormRptOutputSalesProducts
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
            this.Btn_preview = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_date_en = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dp_date_st = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btn_preview
            // 
            this.Btn_preview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_preview.BackgroundImage = global::System_Minimarket_Views.Properties.Resources.button;
            this.Btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_preview.ForeColor = System.Drawing.Color.White;
            this.Btn_preview.Location = new System.Drawing.Point(315, 42);
            this.Btn_preview.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_preview.Name = "Btn_preview";
            this.Btn_preview.Size = new System.Drawing.Size(129, 36);
            this.Btn_preview.TabIndex = 18;
            this.Btn_preview.Text = "Perview";
            this.Btn_preview.UseVisualStyleBackColor = false;
            this.Btn_preview.Click += new System.EventHandler(this.Btn_preview_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.Salmon;
            this.Btn_exit.BackgroundImage = global::System_Minimarket_Views.Properties.Resources.button_delete1;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.ForeColor = System.Drawing.Color.White;
            this.Btn_exit.Location = new System.Drawing.Point(315, 82);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(129, 36);
            this.Btn_exit.TabIndex = 17;
            this.Btn_exit.Text = "Close";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date end:";
            // 
            // Dp_date_en
            // 
            this.Dp_date_en.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_date_en.Location = new System.Drawing.Point(143, 82);
            this.Dp_date_en.Margin = new System.Windows.Forms.Padding(4);
            this.Dp_date_en.Name = "Dp_date_en";
            this.Dp_date_en.Size = new System.Drawing.Size(120, 22);
            this.Dp_date_en.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date start:";
            // 
            // Dp_date_st
            // 
            this.Dp_date_st.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_date_st.Location = new System.Drawing.Point(143, 50);
            this.Dp_date_st.Margin = new System.Windows.Forms.Padding(4);
            this.Dp_date_st.Name = "Dp_date_st";
            this.Dp_date_st.Size = new System.Drawing.Size(120, 22);
            this.Dp_date_st.TabIndex = 13;
            // 
            // FormRptOutputSalesProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 191);
            this.Controls.Add(this.Btn_preview);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dp_date_en);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dp_date_st);
            this.Name = "FormRptOutputSalesProducts";
            this.Text = "FormRptOutputSalesProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_preview;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_date_en;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dp_date_st;
    }
}