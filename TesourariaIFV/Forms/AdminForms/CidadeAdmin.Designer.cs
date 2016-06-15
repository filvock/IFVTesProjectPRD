namespace TesourariaIFV.Forms.Admin_Forms
{
    partial class CidadeAdmin
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
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.estadosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.EstadosTableAdapter();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cidadesAdminTextBox = new System.Windows.Forms.TextBox();
            this.cidadesAdminComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cidadesAdminCancelButton = new System.Windows.Forms.Button();
            this.cidadesAdminSaveButton = new System.Windows.Forms.Button();
            this.cidadesAdminRemoveButton = new System.Windows.Forms.Button();
            this.cidadesAdminAddButton = new System.Windows.Forms.Button();
            this.cidadesAdminEditButton = new System.Windows.Forms.Button();
            this.cidadesAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.CidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesAdminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cellMembersLabel.Location = new System.Drawing.Point(812, 12);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 58;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(583, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 26);
            this.label15.TabIndex = 57;
            this.label15.Text = "Número de Cidades:";
            // 
            // cidadesAdminTextBox
            // 
            this.cidadesAdminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminTextBox.Location = new System.Drawing.Point(6, 118);
            this.cidadesAdminTextBox.Name = "cidadesAdminTextBox";
            this.cidadesAdminTextBox.Size = new System.Drawing.Size(432, 29);
            this.cidadesAdminTextBox.TabIndex = 56;
            // 
            // cidadesAdminComboBox
            // 
            this.cidadesAdminComboBox.DataSource = this.estadosBindingSource;
            this.cidadesAdminComboBox.DisplayMember = "Sigla";
            this.cidadesAdminComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminComboBox.FormattingEnabled = true;
            this.cidadesAdminComboBox.Location = new System.Drawing.Point(444, 115);
            this.cidadesAdminComboBox.Name = "cidadesAdminComboBox";
            this.cidadesAdminComboBox.Size = new System.Drawing.Size(113, 32);
            this.cidadesAdminComboBox.TabIndex = 55;
            this.cidadesAdminComboBox.ValueMember = "Sigla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Estados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cidade";
            // 
            // cidadesAdminCancelButton
            // 
            this.cidadesAdminCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminCancelButton.Location = new System.Drawing.Point(737, 205);
            this.cidadesAdminCancelButton.Name = "cidadesAdminCancelButton";
            this.cidadesAdminCancelButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminCancelButton.TabIndex = 52;
            this.cidadesAdminCancelButton.Text = "Cancel";
            this.cidadesAdminCancelButton.UseVisualStyleBackColor = true;
            this.cidadesAdminCancelButton.Click += new System.EventHandler(this.cidadesAdminCancelButton_Click);
            // 
            // cidadesAdminSaveButton
            // 
            this.cidadesAdminSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminSaveButton.Location = new System.Drawing.Point(586, 205);
            this.cidadesAdminSaveButton.Name = "cidadesAdminSaveButton";
            this.cidadesAdminSaveButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminSaveButton.TabIndex = 51;
            this.cidadesAdminSaveButton.Text = "Salvar";
            this.cidadesAdminSaveButton.UseVisualStyleBackColor = true;
            this.cidadesAdminSaveButton.Click += new System.EventHandler(this.cidadesAdminSaveButton_Click);
            // 
            // cidadesAdminRemoveButton
            // 
            this.cidadesAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminRemoveButton.Location = new System.Drawing.Point(308, 12);
            this.cidadesAdminRemoveButton.Name = "cidadesAdminRemoveButton";
            this.cidadesAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminRemoveButton.TabIndex = 50;
            this.cidadesAdminRemoveButton.Text = "Remover";
            this.cidadesAdminRemoveButton.UseVisualStyleBackColor = true;
            this.cidadesAdminRemoveButton.Click += new System.EventHandler(this.cidadesAdminRemoveButton_Click);
            // 
            // cidadesAdminAddButton
            // 
            this.cidadesAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminAddButton.Location = new System.Drawing.Point(157, 12);
            this.cidadesAdminAddButton.Name = "cidadesAdminAddButton";
            this.cidadesAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminAddButton.TabIndex = 49;
            this.cidadesAdminAddButton.Text = "Adicionar";
            this.cidadesAdminAddButton.UseVisualStyleBackColor = true;
            this.cidadesAdminAddButton.Click += new System.EventHandler(this.cidadesAdminAddButton_Click);
            // 
            // cidadesAdminEditButton
            // 
            this.cidadesAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminEditButton.Location = new System.Drawing.Point(6, 12);
            this.cidadesAdminEditButton.Name = "cidadesAdminEditButton";
            this.cidadesAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminEditButton.TabIndex = 48;
            this.cidadesAdminEditButton.Text = "Editar";
            this.cidadesAdminEditButton.UseVisualStyleBackColor = true;
            this.cidadesAdminEditButton.Click += new System.EventHandler(this.cidadesAdminEditButton_Click);
            // 
            // cidadesAdminDataGridView
            // 
            this.cidadesAdminDataGridView.AllowUserToAddRows = false;
            this.cidadesAdminDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadesAdminDataGridView.AutoGenerateColumns = false;
            this.cidadesAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cidadesAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.cidadesAdminDataGridView.DataSource = this.cidadesBindingSource;
            this.cidadesAdminDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cidadesAdminDataGridView.Location = new System.Drawing.Point(14, 290);
            this.cidadesAdminDataGridView.Name = "cidadesAdminDataGridView";
            this.cidadesAdminDataGridView.ReadOnly = true;
            this.cidadesAdminDataGridView.Size = new System.Drawing.Size(868, 390);
            this.cidadesAdminDataGridView.TabIndex = 59;
            this.cidadesAdminDataGridView.VirtualMode = true;
            this.cidadesAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cidadesAdminDataGridView_CellClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // CidadeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 733);
            this.Controls.Add(this.cidadesAdminDataGridView);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cidadesAdminTextBox);
            this.Controls.Add(this.cidadesAdminComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cidadesAdminCancelButton);
            this.Controls.Add(this.cidadesAdminSaveButton);
            this.Controls.Add(this.cidadesAdminRemoveButton);
            this.Controls.Add(this.cidadesAdminAddButton);
            this.Controls.Add(this.cidadesAdminEditButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CidadeAdmin";
            this.Text = "Adicionar Cidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCidadeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesAdminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private igrejafont11DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cidadesAdminTextBox;
        private System.Windows.Forms.ComboBox cidadesAdminComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cidadesAdminCancelButton;
        private System.Windows.Forms.Button cidadesAdminSaveButton;
        private System.Windows.Forms.Button cidadesAdminRemoveButton;
        private System.Windows.Forms.Button cidadesAdminAddButton;
        private System.Windows.Forms.Button cidadesAdminEditButton;
        private System.Windows.Forms.DataGridView cidadesAdminDataGridView;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private igrejafont11DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}