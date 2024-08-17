namespace System_Minimarket_Views.Reports
{
    partial class FormReportOutputAccumulatedProducts
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
            this.pReportOutput2AccumulatedxProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_Report_Output2_AccumulatedxProductsTableAdapter = new System_Minimarket_Views.Reports_Consolidated.DataSetReportsConsolidatedTableAdapters.P_Report_Output2_AccumulatedxProductsTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportsConsolidated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReportOutput2AccumulatedxProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pReportOutput2AccumulatedxProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System_Minimarket_Views.Reports_Consolidated.RptOutputAccumulatedProducts.rdlc";
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
            // pReportOutput2AccumulatedxProductsBindingSource
            // 
            this.pReportOutput2AccumulatedxProductsBindingSource.DataMember = "P_Report_Output2_AccumulatedxProducts";
            this.pReportOutput2AccumulatedxProductsBindingSource.DataSource = this.dataSetReportsConsolidated;
            // 
            // p_Report_Output2_AccumulatedxProductsTableAdapter
            // 
            this.p_Report_Output2_AccumulatedxProductsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(27, 76);
            this.txt_p2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(132, 22);
            this.txt_p2.TabIndex = 11;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(27, 44);
            this.txt_p1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(132, 22);
            this.txt_p1.TabIndex = 10;
            this.txt_p1.Visible = false;
            // 
            // FormReportOutputAccumulatedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 554);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportOutputAccumulatedProducts";
            this.Text = "FormReportOutputAccumulatedProducts";
            this.Load += new System.EventHandler(this.FormReportOutputAccumulatedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportsConsolidated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReportOutput2AccumulatedxProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pReportOutput2AccumulatedxProductsBindingSource;
        private Reports_Consolidated.DataSetReportsConsolidated dataSetReportsConsolidated;
        private Reports_Consolidated.DataSetReportsConsolidatedTableAdapters.P_Report_Output2_AccumulatedxProductsTableAdapter p_Report_Output2_AccumulatedxProductsTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}