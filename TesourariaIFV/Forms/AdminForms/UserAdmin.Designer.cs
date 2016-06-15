namespace TesourariaIFV.Forms.Admin_Forms
{
    partial class UserAdmin
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
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersAdminIgrejaComboBox = new System.Windows.Forms.ComboBox();
            this.usersAdminRoleComboBox = new System.Windows.Forms.ComboBox();
            this.usersAdminSenhaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersAdminCidadeComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.usersAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.usersAdminLoginTextBox = new System.Windows.Forms.TextBox();
            this.usersAdminEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersAdminCancelButton = new System.Windows.Forms.Button();
            this.usersAdminSaveButton = new System.Windows.Forms.Button();
            this.usersAdminRemoveButton = new System.Windows.Forms.Button();
            this.usersAdminAddButton = new System.Windows.Forms.Button();
            this.usersAdminEditButton = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAdminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(578, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 26);
            this.label15.TabIndex = 70;
            this.label15.Text = "Número de Usuários";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Igreja";
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            // 
            // usersAdminIgrejaComboBox
            // 
            this.usersAdminIgrejaComboBox.DataSource = this.igrejasBindingSource;
            this.usersAdminIgrejaComboBox.DisplayMember = "Nome";
            this.usersAdminIgrejaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminIgrejaComboBox.FormattingEnabled = true;
            this.usersAdminIgrejaComboBox.Location = new System.Drawing.Point(454, 113);
            this.usersAdminIgrejaComboBox.Name = "usersAdminIgrejaComboBox";
            this.usersAdminIgrejaComboBox.Size = new System.Drawing.Size(408, 32);
            this.usersAdminIgrejaComboBox.TabIndex = 69;
            this.usersAdminIgrejaComboBox.ValueMember = "Nome";
            // 
            // usersAdminRoleComboBox
            // 
            this.usersAdminRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminRoleComboBox.FormattingEnabled = true;
            this.usersAdminRoleComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Presidente Nacional",
            "Presidente Regional",
            "Presidente Estadual",
            "Igreja Local"});
            this.usersAdminRoleComboBox.Location = new System.Drawing.Point(583, 172);
            this.usersAdminRoleComboBox.Name = "usersAdminRoleComboBox";
            this.usersAdminRoleComboBox.Size = new System.Drawing.Size(279, 32);
            this.usersAdminRoleComboBox.TabIndex = 67;
            // 
            // usersAdminSenhaTextBox
            // 
            this.usersAdminSenhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminSenhaTextBox.Location = new System.Drawing.Point(12, 234);
            this.usersAdminSenhaTextBox.Name = "usersAdminSenhaTextBox";
            this.usersAdminSenhaTextBox.Size = new System.Drawing.Size(338, 29);
            this.usersAdminSenhaTextBox.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 65;
            this.label4.Text = "Função";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Senha Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Cidade";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            // 
            // usersAdminCidadeComboBox
            // 
            this.usersAdminCidadeComboBox.DataSource = this.cidadesBindingSource;
            this.usersAdminCidadeComboBox.DisplayMember = "Nome";
            this.usersAdminCidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminCidadeComboBox.FormattingEnabled = true;
            this.usersAdminCidadeComboBox.Location = new System.Drawing.Point(11, 172);
            this.usersAdminCidadeComboBox.Name = "usersAdminCidadeComboBox";
            this.usersAdminCidadeComboBox.Size = new System.Drawing.Size(433, 32);
            this.usersAdminCidadeComboBox.TabIndex = 63;
            this.usersAdminCidadeComboBox.ValueMember = "Nome";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(807, 6);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 71;
            this.cellMembersLabel.Text = "0";
            // 
            // usersAdminDataGridView
            // 
            this.usersAdminDataGridView.AllowUserToAddRows = false;
            this.usersAdminDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersAdminDataGridView.AutoGenerateColumns = false;
            this.usersAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.igrejaDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.usersAdminDataGridView.DataSource = this.usuariosBindingSource1;
            this.usersAdminDataGridView.Location = new System.Drawing.Point(12, 297);
            this.usersAdminDataGridView.Name = "usersAdminDataGridView";
            this.usersAdminDataGridView.ReadOnly = true;
            this.usersAdminDataGridView.Size = new System.Drawing.Size(868, 392);
            this.usersAdminDataGridView.TabIndex = 61;
            this.usersAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersAdminDataGridView_CellClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // igrejaDataGridViewTextBoxColumn
            // 
            this.igrejaDataGridViewTextBoxColumn.DataPropertyName = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.HeaderText = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.Name = "igrejaDataGridViewTextBoxColumn";
            this.igrejaDataGridViewTextBoxColumn.ReadOnly = true;
            this.igrejaDataGridViewTextBoxColumn.Width = 300;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Função";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 300;
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
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersAdminLoginTextBox
            // 
            this.usersAdminLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminLoginTextBox.Location = new System.Drawing.Point(12, 116);
            this.usersAdminLoginTextBox.Name = "usersAdminLoginTextBox";
            this.usersAdminLoginTextBox.Size = new System.Drawing.Size(432, 29);
            this.usersAdminLoginTextBox.TabIndex = 60;
            // 
            // usersAdminEstadoComboBox
            // 
            this.usersAdminEstadoComboBox.DataSource = this.estadosBindingSource;
            this.usersAdminEstadoComboBox.DisplayMember = "Sigla";
            this.usersAdminEstadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminEstadoComboBox.FormattingEnabled = true;
            this.usersAdminEstadoComboBox.Location = new System.Drawing.Point(454, 172);
            this.usersAdminEstadoComboBox.Name = "usersAdminEstadoComboBox";
            this.usersAdminEstadoComboBox.Size = new System.Drawing.Size(113, 32);
            this.usersAdminEstadoComboBox.TabIndex = 59;
            this.usersAdminEstadoComboBox.ValueMember = "Sigla";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "login";
            // 
            // usersAdminCancelButton
            // 
            this.usersAdminCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminCancelButton.Location = new System.Drawing.Point(717, 238);
            this.usersAdminCancelButton.Name = "usersAdminCancelButton";
            this.usersAdminCancelButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminCancelButton.TabIndex = 56;
            this.usersAdminCancelButton.Text = "Cancel";
            this.usersAdminCancelButton.UseVisualStyleBackColor = true;
            this.usersAdminCancelButton.Click += new System.EventHandler(this.usersAdminCancelButton_Click);
            // 
            // usersAdminSaveButton
            // 
            this.usersAdminSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminSaveButton.Location = new System.Drawing.Point(566, 238);
            this.usersAdminSaveButton.Name = "usersAdminSaveButton";
            this.usersAdminSaveButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminSaveButton.TabIndex = 55;
            this.usersAdminSaveButton.Text = "Salvar";
            this.usersAdminSaveButton.UseVisualStyleBackColor = true;
            this.usersAdminSaveButton.Click += new System.EventHandler(this.usersAdminSaveButton_Click);
            // 
            // usersAdminRemoveButton
            // 
            this.usersAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminRemoveButton.Location = new System.Drawing.Point(314, 10);
            this.usersAdminRemoveButton.Name = "usersAdminRemoveButton";
            this.usersAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminRemoveButton.TabIndex = 54;
            this.usersAdminRemoveButton.Text = "Remover";
            this.usersAdminRemoveButton.UseVisualStyleBackColor = true;
            this.usersAdminRemoveButton.Click += new System.EventHandler(this.usersAdminRemoveButton_Click);
            // 
            // usersAdminAddButton
            // 
            this.usersAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminAddButton.Location = new System.Drawing.Point(163, 10);
            this.usersAdminAddButton.Name = "usersAdminAddButton";
            this.usersAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminAddButton.TabIndex = 53;
            this.usersAdminAddButton.Text = "Adicionar";
            this.usersAdminAddButton.UseVisualStyleBackColor = true;
            this.usersAdminAddButton.Click += new System.EventHandler(this.usersAdminAddButton_Click);
            // 
            // usersAdminEditButton
            // 
            this.usersAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminEditButton.Location = new System.Drawing.Point(12, 10);
            this.usersAdminEditButton.Name = "usersAdminEditButton";
            this.usersAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminEditButton.TabIndex = 52;
            this.usersAdminEditButton.Text = "Editar";
            this.usersAdminEditButton.UseVisualStyleBackColor = true;
            this.usersAdminEditButton.Click += new System.EventHandler(this.usersAdminEditButton_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 701);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usersAdminIgrejaComboBox);
            this.Controls.Add(this.usersAdminRoleComboBox);
            this.Controls.Add(this.usersAdminSenhaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usersAdminCidadeComboBox);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.usersAdminDataGridView);
            this.Controls.Add(this.usersAdminLoginTextBox);
            this.Controls.Add(this.usersAdminEstadoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersAdminCancelButton);
            this.Controls.Add(this.usersAdminSaveButton);
            this.Controls.Add(this.usersAdminRemoveButton);
            this.Controls.Add(this.usersAdminAddButton);
            this.Controls.Add(this.usersAdminEditButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserAdmin";
            this.Text = "Adicionar Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAdminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private System.Windows.Forms.ComboBox usersAdminIgrejaComboBox;
        private System.Windows.Forms.ComboBox usersAdminRoleComboBox;
        private System.Windows.Forms.TextBox usersAdminSenhaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.ComboBox usersAdminCidadeComboBox;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.DataGridView usersAdminDataGridView;
        private System.Windows.Forms.TextBox usersAdminLoginTextBox;
        private System.Windows.Forms.ComboBox usersAdminEstadoComboBox;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usersAdminCancelButton;
        private System.Windows.Forms.Button usersAdminSaveButton;
        private System.Windows.Forms.Button usersAdminRemoveButton;
        private System.Windows.Forms.Button usersAdminAddButton;
        private System.Windows.Forms.Button usersAdminEditButton;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private igrejafont11DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}