namespace TesourariaIFV.Forms.Admin_Forms
{
    partial class PlanoDeContasSaidaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanoDeContasSaidaAdmin));
            this.formPlanoDeContasTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.formPlanoDeContasAddOkButton = new System.Windows.Forms.Button();
            this.formPlanoDeContasAddCancelButton = new System.Windows.Forms.Button();
            this.usersAdminRemoveButton = new System.Windows.Forms.Button();
            this.usersAdminAddButton = new System.Windows.Forms.Button();
            this.usersAdminEditButton = new System.Windows.Forms.Button();
            this.contasDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoDeContasDebitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoDeContasDebitoTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasDebitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formPlanoDeContasTextBox
            // 
            this.formPlanoDeContasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPlanoDeContasTextBox.Location = new System.Drawing.Point(123, 167);
            this.formPlanoDeContasTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasTextBox.Name = "formPlanoDeContasTextBox";
            this.formPlanoDeContasTextBox.Size = new System.Drawing.Size(404, 29);
            this.formPlanoDeContasTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formPlanoDeContasAddOkButton
            // 
            this.formPlanoDeContasAddOkButton.Location = new System.Drawing.Point(648, 220);
            this.formPlanoDeContasAddOkButton.Name = "formPlanoDeContasAddOkButton";
            this.formPlanoDeContasAddOkButton.Size = new System.Drawing.Size(115, 35);
            this.formPlanoDeContasAddOkButton.TabIndex = 6;
            this.formPlanoDeContasAddOkButton.Text = "Salvar";
            this.formPlanoDeContasAddOkButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasAddOkButton.Click += new System.EventHandler(this.formPlanoDeContasAddOkButton_Click);
            // 
            // formPlanoDeContasAddCancelButton
            // 
            this.formPlanoDeContasAddCancelButton.Location = new System.Drawing.Point(769, 220);
            this.formPlanoDeContasAddCancelButton.Name = "formPlanoDeContasAddCancelButton";
            this.formPlanoDeContasAddCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formPlanoDeContasAddCancelButton.TabIndex = 7;
            this.formPlanoDeContasAddCancelButton.Text = "Cancel";
            this.formPlanoDeContasAddCancelButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasAddCancelButton.Click += new System.EventHandler(this.formPlanoDeContasAddCancelButton_Click);
            // 
            // usersAdminRemoveButton
            // 
            this.usersAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminRemoveButton.Location = new System.Drawing.Point(314, 12);
            this.usersAdminRemoveButton.Name = "usersAdminRemoveButton";
            this.usersAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminRemoveButton.TabIndex = 57;
            this.usersAdminRemoveButton.Text = "Remover";
            this.usersAdminRemoveButton.UseVisualStyleBackColor = true;
            this.usersAdminRemoveButton.Click += new System.EventHandler(this.usersAdminRemoveButton_Click);
            // 
            // usersAdminAddButton
            // 
            this.usersAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminAddButton.Location = new System.Drawing.Point(163, 12);
            this.usersAdminAddButton.Name = "usersAdminAddButton";
            this.usersAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminAddButton.TabIndex = 56;
            this.usersAdminAddButton.Text = "Adicionar";
            this.usersAdminAddButton.UseVisualStyleBackColor = true;
            this.usersAdminAddButton.Click += new System.EventHandler(this.usersAdminAddButton_Click);
            // 
            // usersAdminEditButton
            // 
            this.usersAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminEditButton.Location = new System.Drawing.Point(12, 12);
            this.usersAdminEditButton.Name = "usersAdminEditButton";
            this.usersAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminEditButton.TabIndex = 55;
            this.usersAdminEditButton.Text = "Editar";
            this.usersAdminEditButton.UseVisualStyleBackColor = true;
            this.usersAdminEditButton.Click += new System.EventHandler(this.usersAdminEditButton_Click);
            // 
            // contasDataGridView
            // 
            this.contasDataGridView.AllowUserToAddRows = false;
            this.contasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contasDataGridView.AutoGenerateColumns = false;
            this.contasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.contasDataGridView.DataSource = this.planoDeContasDebitoBindingSource;
            this.contasDataGridView.Location = new System.Drawing.Point(12, 283);
            this.contasDataGridView.Name = "contasDataGridView";
            this.contasDataGridView.ReadOnly = true;
            this.contasDataGridView.Size = new System.Drawing.Size(884, 436);
            this.contasDataGridView.TabIndex = 62;
            this.contasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersAdminDataGridView_CellClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 400;
            // 
            // planoDeContasDebitoBindingSource
            // 
            this.planoDeContasDebitoBindingSource.DataMember = "PlanoDeContasDebito";
            this.planoDeContasDebitoBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // planoDeContasDebitoTableAdapter
            // 
            this.planoDeContasDebitoTableAdapter.ClearBeforeFill = true;
            // 
            // PlanoDeContasSaidaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 733);
            this.Controls.Add(this.contasDataGridView);
            this.Controls.Add(this.usersAdminRemoveButton);
            this.Controls.Add(this.usersAdminAddButton);
            this.Controls.Add(this.usersAdminEditButton);
            this.Controls.Add(this.formPlanoDeContasAddCancelButton);
            this.Controls.Add(this.formPlanoDeContasAddOkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formPlanoDeContasTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlanoDeContasSaidaAdmin";
            this.Text = "Adicionar Conta Crédito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPlanoDeContasAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasDebitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox formPlanoDeContasTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button formPlanoDeContasAddOkButton;
        private System.Windows.Forms.Button formPlanoDeContasAddCancelButton;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.Button usersAdminRemoveButton;
        private System.Windows.Forms.Button usersAdminAddButton;
        private System.Windows.Forms.Button usersAdminEditButton;
        private System.Windows.Forms.DataGridView contasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource planoDeContasDebitoBindingSource;
        private igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter planoDeContasDebitoTableAdapter;
    }
}