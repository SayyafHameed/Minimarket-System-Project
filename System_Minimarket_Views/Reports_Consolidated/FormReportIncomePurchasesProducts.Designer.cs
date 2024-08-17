namespace System_Minimarket_Views.Reports_Consolidated
{
    partial class FormReportIncomePurchasesProducts
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
            this.pReportIncomePurchasesProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportsConsolidated = new System_Minimarket_Views.Reports_Consolidated.DataSetReportsConsolidated();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.p_Report_Income_PurchasesProductsTableAdapter = new System_Minimarket_Views.Reports_Consolidated.DataSetReportsConsolidatedTableAdapters.P_Report_Income_PurchasesProductsTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pReportIncomePurchasesProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportsConsolidated)).BeginInit();
            this.SuspendLayout();
            // 
            // pReportIncomePurchasesProductsBindingSource
            // 
            this.pReportIncomePurchasesProductsBindingSource.DataMember = "P_Report_Income_PurchasesProducts";
            this.pReportIncomePurchasesProductsBindingSource.DataSource = this.dataSetReportsConsolidated;
            // 
            // dataSetReportsConsolidated
            // 
            this.dataSetReportsConsolidated.DataSetName = "DataSetReportsConsolidated";
            this.dataSetReportsConsolidated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pReportIncomePurchasesProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System_Minimarket_Views.Reports_Consolidated.RptIncomePurchasesProducts.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1389, 554);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // p_Report_Income_PurchasesProductsTableAdapter
            // 
            this.p_Report_Income_PurchasesProductsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(22, 76);
            this.txt_p2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(132, 22);
            this.txt_p2.TabIndex = 5;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(22, 44);
            this.txt_p1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(132, 22);
            this.txt_p1.TabIndex = 4;
            this.txt_p1.Visible = false;
            // 
            // FormReportIncomePurchasesProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 554);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportIncomePurchasesProducts";
            this.Text = "FormReportIncomePurchasesProducts";
            this.Load += new System.EventHandler(this.FormReportIncomePurchasesProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pReportIncomePurchasesProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportsConsolidated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pReportIncomePurchasesProductsBindingSource;
        private DataSetReportsConsolidated dataSetReportsConsolidated;
        private DataSetReportsConsolidatedTableAdapters.P_Report_Income_PurchasesProductsTableAdapter p_Report_Income_PurchasesProductsTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}