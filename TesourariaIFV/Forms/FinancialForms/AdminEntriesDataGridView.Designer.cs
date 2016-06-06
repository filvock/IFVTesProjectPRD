namespace TesourariaIFV.Forms
{
    partial class AdminEntriesDataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminEntriesCancelButton = new System.Windows.Forms.Button();
            this.adminEntriesOkButton = new System.Windows.Forms.Button();
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.tesourariaGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesourariaGeralTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.numDocumentoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.contaDataGridViewTextBoxColumn,
            this.igrejaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.codLancamentoDataGridViewTextBoxColumn,
            this.origemDataGridViewTextBoxColumn,
            this.naturezaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tesourariaGeralBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 482);
            this.dataGridView1.TabIndex = 60;
            // 
            // adminEntriesCancelButton
            // 
            this.adminEntriesCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminEntriesCancelButton.Location = new System.Drawing.Point(377, 433);
            this.adminEntriesCancelButton.Name = "adminEntriesCancelButton";
            this.adminEntriesCancelButton.Size = new System.Drawing.Size(132, 38);
            this.adminEntriesCancelButton.TabIndex = 62;
            this.adminEntriesCancelButton.Text = "Cancel";
            this.adminEntriesCancelButton.UseVisualStyleBackColor = true;
            this.adminEntriesCancelButton.Click += new System.EventHandler(this.adminEntriesCancelButton_Click);
            // 
            // adminEntriesOkButton
            // 
            this.adminEntriesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminEntriesOkButton.Location = new System.Drawing.Point(240, 433);
            this.adminEntriesOkButton.Name = "adminEntriesOkButton";
            this.adminEntriesOkButton.Size = new System.Drawing.Size(132, 38);
            this.adminEntriesOkButton.TabIndex = 61;
            this.adminEntriesOkButton.Text = "Ok";
            this.adminEntriesOkButton.UseVisualStyleBackColor = true;
            this.adminEntriesOkButton.Click += new System.EventHandler(this.adminEntriesOkButton_Click);
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
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // numDocumentoDataGridViewTextBoxColumn
            // 
            this.numDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.HeaderText = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.Name = "numDocumentoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // contaDataGridViewTextBoxColumn
            // 
            this.contaDataGridViewTextBoxColumn.DataPropertyName = "Conta";
            this.contaDataGridViewTextBoxColumn.HeaderText = "Conta";
            this.contaDataGridViewTextBoxColumn.Name = "contaDataGridViewTextBoxColumn";
            // 
            // igrejaDataGridViewTextBoxColumn
            // 
            this.igrejaDataGridViewTextBoxColumn.DataPropertyName = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.HeaderText = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.Name = "igrejaDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            // 
            // codLancamentoDataGridViewTextBoxColumn
            // 
            this.codLancamentoDataGridViewTextBoxColumn.DataPropertyName = "CodLancamento";
            this.codLancamentoDataGridViewTextBoxColumn.HeaderText = "CodLancamento";
            this.codLancamentoDataGridViewTextBoxColumn.Name = "codLancamentoDataGridViewTextBoxColumn";
            this.codLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origemDataGridViewTextBoxColumn
            // 
            this.origemDataGridViewTextBoxColumn.DataPropertyName = "Origem";
            this.origemDataGridViewTextBoxColumn.HeaderText = "Origem";
            this.origemDataGridViewTextBoxColumn.Name = "origemDataGridViewTextBoxColumn";
            // 
            // naturezaDataGridViewTextBoxColumn
            // 
            this.naturezaDataGridViewTextBoxColumn.DataPropertyName = "Natureza";
            this.naturezaDataGridViewTextBoxColumn.HeaderText = "Natureza";
            this.naturezaDataGridViewTextBoxColumn.Name = "naturezaDataGridViewTextBoxColumn";
            // 
            // AdminEntriesDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.adminEntriesCancelButton);
            this.Controls.Add(this.adminEntriesOkButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminEntriesDataGridView";
            this.Text = "AdminEntriesDataGridView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminEntriesDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adminEntriesCancelButton;
        private System.Windows.Forms.Button adminEntriesOkButton;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource tesourariaGeralBindingSource;
        private igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tesourariaGeralTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturezaDataGridViewTextBoxColumn;
    }
}