﻿namespace System_Minimarket_Views.Reports
{
    partial class FormRptDistricts
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
            this.dataSet_MiniMarket = new System_Minimarket_Views.Reports.DataSet_MiniMarket();
            this.pListingdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_Listing_diTableAdapter = new System_Minimarket_Views.Reports.DataSet_MiniMarketTableAdapters.P_Listing_diTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pListingdiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pListingdiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System_Minimarket_Views.Reports.Rpt_Districts.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // text_p1
            // 
            this.text_p1.Location = new System.Drawing.Point(24, 44);
            this.text_p1.Name = "text_p1";
            this.text_p1.Size = new System.Drawing.Size(151, 22);
            this.text_p1.TabIndex = 5;
            this.text_p1.Visible = false;
            // 
            // dataSet_MiniMarket
            // 
            this.dataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.dataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pListingdiBindingSource
            // 
            this.pListingdiBindingSource.DataMember = "P_Listing_di";
            this.pListingdiBindingSource.DataSource = this.dataSet_MiniMarket;
            // 
            // p_Listing_diTableAdapter
            // 
            this.p_Listing_diTableAdapter.ClearBeforeFill = true;
            // 
            // FormRptDistricts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRptDistricts";
            this.Text = "FormRptDistricts";
            this.Load += new System.EventHandler(this.FormRptDistricts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pListingdiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox text_p1;
        private System.Windows.Forms.BindingSource pListingdiBindingSource;
        private DataSet_MiniMarket dataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.P_Listing_diTableAdapter p_Listing_diTableAdapter;
    }
}