namespace TesourariaIFV.Forms.ReportForms
{
    partial class ReportLivroCaixaBanco
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
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.tesourariaGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesourariaGeralTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tesourariaGeralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TesourariaIFV.Reports.ReportLivroCaixaBanco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(726, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tesourariaGeralBindingSource
            // 
            this.tesourariaGeralBindingSource.DataMember = "TesourariaGeral";
            this.tesourariaGeralBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // tesourariaGeralTableAdapter
            // 
            this.tesourariaGeralTableAdapter.ClearBeforeFill = true;
            // 
            // ReportLivroCaixaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 428);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportLivroCaixaBanco";
            this.Text = "ReportLivroCaixaBanco";
            this.Load += new System.EventHandler(this.ReportLivroCaixaBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource tesourariaGeralBindingSource;
        private igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tesourariaGeralTableAdapter;
    }
}