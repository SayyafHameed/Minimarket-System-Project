﻿namespace System_Minimarket_Views.Reports
{
    partial class FormRptSuppliers
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
            this.dataSet_MiniMarket = new System_Minimarket_Views.Reports.DataSet_MiniMarket();
            this.pListingsuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_Listing_suTableAdapter = new System_Minimarket_Views.Reports.DataSet_MiniMarketTableAdapters.P_Listing_suTableAdapter();
            this.text_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pListingsuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pListingsuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System_Minimarket_Views.Reports.Rpt_Suppliers.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSet_MiniMarket
            // 
            this.dataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.dataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pListingsuBindingSource
            // 
            this.pListingsuBindingSource.DataMember = "P_Listing_su";
            this.pListingsuBindingSource.DataSource = this.dataSet_MiniMarket;
            // 
            // p_Listing_suTableAdapter
            // 
            this.p_Listing_suTableAdapter.ClearBeforeFill = true;
            // 
            // text_p1
            // 
            this.text_p1.Location = new System.Drawing.Point(21, 49);
            this.text_p1.Name = "text_p1";
            this.text_p1.Size = new System.Drawing.Size(151, 22);
            this.text_p1.TabIndex = 6;
            this.text_p1.Visible = false;
            // 
            // FormRptSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRptSuppliers";
            this.Text = "FormRptSuppliers";
            this.Load += new System.EventHandler(this.FormRptSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pListingsuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pListingsuBindingSource;
        private DataSet_MiniMarket dataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.P_Listing_suTableAdapter p_Listing_suTableAdapter;
        public System.Windows.Forms.TextBox text_p1;
    }
}