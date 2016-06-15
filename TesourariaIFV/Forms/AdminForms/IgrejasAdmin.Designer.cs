namespace TesourariaIFV.Forms.Admin_Forms
{
    partial class IgrejasAdmin
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
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.cidadesTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.CidadesTableAdapter();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.EstadosTableAdapter();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.igrejasAdminCidadeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.igrejasAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.igrejasAdminTextBox = new System.Windows.Forms.TextBox();
            this.igrejasAdminEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejasAdminCancelButton = new System.Windows.Forms.Button();
            this.igrejasAdminSaveButton = new System.Windows.Forms.Button();
            this.igrejasAdminRemoveButton = new System.Windows.Forms.Button();
            this.igrejasAdminAddButton = new System.Windows.Forms.Button();
            this.igrejasAdminEditButton = new System.Windows.Forms.Button();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasAdminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(795, 9);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 63;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(566, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 26);
            this.label15.TabIndex = 62;
            this.label15.Text = "Número de Igrejas:";
            // 
            // igrejasAdminCidadeComboBox
            // 
            this.igrejasAdminCidadeComboBox.DataSource = this.cidadesBindingSource;
            this.igrejasAdminCidadeComboBox.DisplayMember = "Nome";
            this.igrejasAdminCidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminCidadeComboBox.FormattingEnabled = true;
            this.igrejasAdminCidadeComboBox.Location = new System.Drawing.Point(445, 115);
            this.igrejasAdminCidadeComboBox.Name = "igrejasAdminCidadeComboBox";
            this.igrejasAdminCidadeComboBox.Size = new System.Drawing.Size(266, 32);
            this.igrejasAdminCidadeComboBox.TabIndex = 61;
            this.igrejasAdminCidadeComboBox.ValueMember = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cidade";
            // 
            // igrejasAdminDataGridView
            // 
            this.igrejasAdminDataGridView.AllowUserToAddRows = false;
            this.igrejasAdminDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.igrejasAdminDataGridView.AutoGenerateColumns = false;
            this.igrejasAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.igrejasAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.igrejasAdminDataGridView.DataSource = this.igrejasBindingSource;
            this.igrejasAdminDataGridView.Location = new System.Drawing.Point(12, 309);
            this.igrejasAdminDataGridView.Name = "igrejasAdminDataGridView";
            this.igrejasAdminDataGridView.ReadOnly = true;
            this.igrejasAdminDataGridView.Size = new System.Drawing.Size(882, 412);
            this.igrejasAdminDataGridView.TabIndex = 59;
            this.igrejasAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.igrejasAdminDataGridView_CellClick);
            // 
            // igrejasAdminTextBox
            // 
            this.igrejasAdminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminTextBox.Location = new System.Drawing.Point(7, 118);
            this.igrejasAdminTextBox.Name = "igrejasAdminTextBox";
            this.igrejasAdminTextBox.Size = new System.Drawing.Size(432, 29);
            this.igrejasAdminTextBox.TabIndex = 58;
            // 
            // igrejasAdminEstadoComboBox
            // 
            this.igrejasAdminEstadoComboBox.DataSource = this.estadosBindingSource;
            this.igrejasAdminEstadoComboBox.DisplayMember = "Sigla";
            this.igrejasAdminEstadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminEstadoComboBox.FormattingEnabled = true;
            this.igrejasAdminEstadoComboBox.Location = new System.Drawing.Point(717, 115);
            this.igrejasAdminEstadoComboBox.Name = "igrejasAdminEstadoComboBox";
            this.igrejasAdminEstadoComboBox.Size = new System.Drawing.Size(113, 32);
            this.igrejasAdminEstadoComboBox.TabIndex = 57;
            this.igrejasAdminEstadoComboBox.ValueMember = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Igreja";
            // 
            // igrejasAdminCancelButton
            // 
            this.igrejasAdminCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminCancelButton.Location = new System.Drawing.Point(705, 237);
            this.igrejasAdminCancelButton.Name = "igrejasAdminCancelButton";
            this.igrejasAdminCancelButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminCancelButton.TabIndex = 54;
            this.igrejasAdminCancelButton.Text = "Cancel";
            this.igrejasAdminCancelButton.UseVisualStyleBackColor = true;
            this.igrejasAdminCancelButton.Click += new System.EventHandler(this.igrejasAdminCancelButton_Click);
            // 
            // igrejasAdminSaveButton
            // 
            this.igrejasAdminSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminSaveButton.Location = new System.Drawing.Point(554, 237);
            this.igrejasAdminSaveButton.Name = "igrejasAdminSaveButton";
            this.igrejasAdminSaveButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminSaveButton.TabIndex = 53;
            this.igrejasAdminSaveButton.Text = "Salvar";
            this.igrejasAdminSaveButton.UseVisualStyleBackColor = true;
            this.igrejasAdminSaveButton.Click += new System.EventHandler(this.igrejasAdminSaveButton_Click);
            // 
            // igrejasAdminRemoveButton
            // 
            this.igrejasAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminRemoveButton.Location = new System.Drawing.Point(309, 9);
            this.igrejasAdminRemoveButton.Name = "igrejasAdminRemoveButton";
            this.igrejasAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminRemoveButton.TabIndex = 52;
            this.igrejasAdminRemoveButton.Text = "Remover";
            this.igrejasAdminRemoveButton.UseVisualStyleBackColor = true;
            this.igrejasAdminRemoveButton.Click += new System.EventHandler(this.igrejasAdminRemoveButton_Click);
            // 
            // igrejasAdminAddButton
            // 
            this.igrejasAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminAddButton.Location = new System.Drawing.Point(158, 9);
            this.igrejasAdminAddButton.Name = "igrejasAdminAddButton";
            this.igrejasAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminAddButton.TabIndex = 51;
            this.igrejasAdminAddButton.Text = "Adicionar";
            this.igrejasAdminAddButton.UseVisualStyleBackColor = true;
            this.igrejasAdminAddButton.Click += new System.EventHandler(this.igrejasAdminAddButton_Click);
            // 
            // igrejasAdminEditButton
            // 
            this.igrejasAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminEditButton.Location = new System.Drawing.Point(7, 9);
            this.igrejasAdminEditButton.Name = "igrejasAdminEditButton";
            this.igrejasAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminEditButton.TabIndex = 50;
            this.igrejasAdminEditButton.Text = "Editar";
            this.igrejasAdminEditButton.UseVisualStyleBackColor = true;
            this.igrejasAdminEditButton.Click += new System.EventHandler(this.igrejasAdminEditButton_Click);
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IgrejasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 733);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.igrejasAdminCidadeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.igrejasAdminDataGridView);
            this.Controls.Add(this.igrejasAdminTextBox);
            this.Controls.Add(this.igrejasAdminEstadoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.igrejasAdminCancelButton);
            this.Controls.Add(this.igrejasAdminSaveButton);
            this.Controls.Add(this.igrejasAdminRemoveButton);
            this.Controls.Add(this.igrejasAdminAddButton);
            this.Controls.Add(this.igrejasAdminEditButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "IgrejasAdmin";
            this.Text = "FormIgrejasAdd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormIgrejasAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasAdminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private igrejafont11DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private igrejafont11DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox igrejasAdminCidadeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView igrejasAdminDataGridView;
        private System.Windows.Forms.TextBox igrejasAdminTextBox;
        private System.Windows.Forms.ComboBox igrejasAdminEstadoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button igrejasAdminCancelButton;
        private System.Windows.Forms.Button igrejasAdminSaveButton;
        private System.Windows.Forms.Button igrejasAdminRemoveButton;
        private System.Windows.Forms.Button igrejasAdminAddButton;
        private System.Windows.Forms.Button igrejasAdminEditButton;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}