namespace System_Minimarket_Views.Reports
{
    partial class FormRptItems
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.text_p1 = new System.Windows.Forms.TextBox();
            this.pListingitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_MiniMarket = new System_Minimarket_Views.Reports.DataSet_MiniMarket();
            this.p_Listing_itTableAdapter = new System_Minimarket_Views.Reports.DataSet_MiniMarketTableAdapters.P_Listing_itTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pListingitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pListingitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System_Minimarket_Views.Reports.Rpt_Items.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // text_p1
            // 
            this.text_p1.Location = new System.Drawing.Point(23, 45);
            this.text_p1.Name = "text_p1";
            this.text_p1.Size = new System.Drawing.Size(151, 22);
            this.text_p1.TabIndex = 2;
            this.text_p1.Visible = false;
            // 
            // pListingitBindingSource
            // 
            this.pListingitBindingSource.DataMember = "P_Listing_it";
            this.pListingitBindingSource.DataSource = this.dataSet_MiniMarket;
            // 
            // dataSet_MiniMarket
            // 
            this.dataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.dataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_Listing_itTableAdapter
            // 
            this.p_Listing_itTableAdapter.ClearBeforeFill = true;
            // 
            // FormRptItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRptItems";
            this.Text = "FormRptItems";
            this.Load += new System.EventHandler(this.FormRptItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pListingitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pListingitBindingSource;
        private DataSet_MiniMarket dataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.P_Listing_itTableAdapter p_Listing_itTableAdapter;
        public System.Windows.Forms.TextBox text_p1;
    }
}