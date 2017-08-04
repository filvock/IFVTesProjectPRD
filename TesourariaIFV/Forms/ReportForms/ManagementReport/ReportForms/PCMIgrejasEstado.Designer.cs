namespace TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms
{
    partial class PCMIgrejasEstado
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
            this.tesourariaGeral1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tesourariaGeral1TableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.TesourariaGeral1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeral1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tesourariaGeral1BindingSource
            // 
            this.tesourariaGeral1BindingSource.DataMember = "TesourariaGeral1";
            this.tesourariaGeral1BindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tesourariaGeral1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TesourariaIFV.Reports.MgntReports.PCIgrejasEstado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(818, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // tesourariaGeral1TableAdapter
            // 
            this.tesourariaGeral1TableAdapter.ClearBeforeFill = true;
            // 
            // PCMIgrejasEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 280);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PCMIgrejasEstado";
            this.Text = "Relatório Plano de Contas - Detalhado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportPlanodeContasFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeral1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource tesourariaGeral1BindingSource;
        private igrejafont11DataSetTableAdapters.TesourariaGeral1TableAdapter tesourariaGeral1TableAdapter;






    }
}