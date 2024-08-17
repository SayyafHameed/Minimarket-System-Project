namespace System_Minimarket_Views.Reports_Consolidated
{
    partial class FormReportIncomeAccumulatedProducts
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
            this.dataSetReportsConsolidated = new System_Minimarket_Views.Reports_Consolidated.DataSetReportsConsolidated();
            this.pReportOutputAccumulatedProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_Report_Output_AccumulatedProductsTableAdapter = new System_Minimarket_Views.Reports_Consolidated.DataSetReportsConsolidatedTableAdapters.P_Report_Output_AccumulatedProductsTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportsConsolidated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReportOutputAccumulatedProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pReportOutputAccumulatedProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System_Minimarket_Views.Reports_Consolidated.RptIncomeAccumulatedProducts.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1288, 554);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetReportsConsolidated
            // 
            this.dataSetReportsConsolidated.DataSetName = "DataSetReportsConsolidated";
            this.dataSetReportsConsolidated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pReportOutputAccumulatedProductsBindingSource
            // 
            this.pReportOutputAccumulatedProductsBindingSource.DataMember = "P_Report_Output_AccumulatedProducts";
            this.pReportOutputAccumulatedProductsBindingSource.DataSource = this.dataSetReportsConsolidated;
            // 
            // p_Report_Output_AccumulatedProductsTableAdapter
            // 
            this.p_Report_Output_AccumulatedProductsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(29, 79);
            this.txt_p2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(132, 22);
            this.txt_p2.TabIndex = 9;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(29, 47);
            this.txt_p1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(132, 22);
            this.txt_p1.TabIndex = 8;
            this.txt_p1.Visible = false;
            // 
            // FormReportIncomeAccumulatedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 554);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportIncomeAccumulatedProducts";
            this.Text = "FormReportIncomeAccumulatedProducts";
            this.Load += new System.EventHandler(this.FormReportIncomeAccumulatedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportsConsolidated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReportOutputAccumulatedProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pReportOutputAccumulatedProductsBindingSource;
        private DataSetReportsConsolidated dataSetReportsConsolidated;
        private DataSetReportsConsolidatedTableAdapters.P_Report_Output_AccumulatedProductsTableAdapter p_Report_Output_AccumulatedProductsTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}