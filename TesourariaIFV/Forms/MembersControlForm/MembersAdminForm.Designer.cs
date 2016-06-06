namespace TesourariaIFV.Forms.MembersControlForm
{
    partial class MembersAdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.membersListDataGridView = new System.Windows.Forms.DataGridView();
            this.CodMembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.membrosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.MembrosTableAdapter();
            this.membersListAddButton = new System.Windows.Forms.Button();
            this.membersListEditButton = new System.Windows.Forms.Button();
            this.membersListDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.membersListComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.membersListCodeTextBox = new System.Windows.Forms.TextBox();
            this.membersListNameTextBox = new System.Windows.Forms.TextBox();
            this.membersListSaveButton = new System.Windows.Forms.Button();
            this.membersListCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // membersListDataGridView
            // 
            this.membersListDataGridView.AllowUserToAddRows = false;
            this.membersListDataGridView.AllowUserToDeleteRows = false;
            this.membersListDataGridView.AllowUserToOrderColumns = true;
            this.membersListDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.membersListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.membersListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMembro,
            this.nomeDataGridViewTextBoxColumn,
            this.igrejaDataGridViewTextBoxColumn});
            this.membersListDataGridView.DataSource = this.membrosBindingSource;
            this.membersListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.membersListDataGridView.Location = new System.Drawing.Point(0, 228);
            this.membersListDataGridView.MultiSelect = false;
            this.membersListDataGridView.Name = "membersListDataGridView";
            this.membersListDataGridView.ReadOnly = true;
            this.membersListDataGridView.Size = new System.Drawing.Size(899, 402);
            this.membersListDataGridView.TabIndex = 9;
            this.membersListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersListDataGridView_CellClick);
            // 
            // CodMembro
            // 
            this.CodMembro.DataPropertyName = "CodMembro";
            this.CodMembro.HeaderText = "Código";
            this.CodMembro.Name = "CodMembro";
            this.CodMembro.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 350;
            // 
            // igrejaDataGridViewTextBoxColumn
            // 
            this.igrejaDataGridViewTextBoxColumn.DataPropertyName = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.HeaderText = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.Name = "igrejaDataGridViewTextBoxColumn";
            this.igrejaDataGridViewTextBoxColumn.ReadOnly = true;
            this.igrejaDataGridViewTextBoxColumn.Width = 250;
            // 
            // membrosBindingSource
            // 
            this.membrosBindingSource.DataMember = "Membros";
            this.membrosBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membrosTableAdapter
            // 
            this.membrosTableAdapter.ClearBeforeFill = true;
            // 
            // membersListAddButton
            // 
            this.membersListAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListAddButton.Location = new System.Drawing.Point(12, 57);
            this.membersListAddButton.Name = "membersListAddButton";
            this.membersListAddButton.Size = new System.Drawing.Size(144, 42);
            this.membersListAddButton.TabIndex = 2;
            this.membersListAddButton.Text = "Adicionar";
            this.membersListAddButton.UseVisualStyleBackColor = true;
            this.membersListAddButton.Click += new System.EventHandler(this.membersListAddButton_Click);
            // 
            // membersListEditButton
            // 
            this.membersListEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListEditButton.Location = new System.Drawing.Point(162, 57);
            this.membersListEditButton.Name = "membersListEditButton";
            this.membersListEditButton.Size = new System.Drawing.Size(144, 42);
            this.membersListEditButton.TabIndex = 3;
            this.membersListEditButton.Text = "Editar";
            this.membersListEditButton.UseVisualStyleBackColor = true;
            this.membersListEditButton.Click += new System.EventHandler(this.membersListEditButton_Click);
            // 
            // membersListDeleteButton
            // 
            this.membersListDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListDeleteButton.Location = new System.Drawing.Point(312, 57);
            this.membersListDeleteButton.Name = "membersListDeleteButton";
            this.membersListDeleteButton.Size = new System.Drawing.Size(144, 42);
            this.membersListDeleteButton.TabIndex = 4;
            this.membersListDeleteButton.Text = "Deletar";
            this.membersListDeleteButton.UseVisualStyleBackColor = true;
            this.membersListDeleteButton.Click += new System.EventHandler(this.membersListDeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por Igreja";
            // 
            // membersListComboBox
            // 
            this.membersListComboBox.DataSource = this.igrejasBindingSource;
            this.membersListComboBox.DisplayMember = "Nome";
            this.membersListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListComboBox.FormattingEnabled = true;
            this.membersListComboBox.Location = new System.Drawing.Point(162, 15);
            this.membersListComboBox.Name = "membersListComboBox";
            this.membersListComboBox.Size = new System.Drawing.Size(294, 32);
            this.membersListComboBox.TabIndex = 1;
            this.membersListComboBox.ValueMember = "Nome";
            this.membersListComboBox.SelectedIndexChanged += new System.EventHandler(this.membersListComboBox_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código Membro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 170);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // membersListCodeTextBox
            // 
            this.membersListCodeTextBox.Enabled = false;
            this.membersListCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListCodeTextBox.Location = new System.Drawing.Point(170, 133);
            this.membersListCodeTextBox.Name = "membersListCodeTextBox";
            this.membersListCodeTextBox.Size = new System.Drawing.Size(111, 29);
            this.membersListCodeTextBox.TabIndex = 5;
            // 
            // membersListNameTextBox
            // 
            this.membersListNameTextBox.Enabled = false;
            this.membersListNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListNameTextBox.Location = new System.Drawing.Point(170, 165);
            this.membersListNameTextBox.Name = "membersListNameTextBox";
            this.membersListNameTextBox.Size = new System.Drawing.Size(416, 29);
            this.membersListNameTextBox.TabIndex = 6;
            // 
            // membersListSaveButton
            // 
            this.membersListSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListSaveButton.Location = new System.Drawing.Point(602, 180);
            this.membersListSaveButton.Name = "membersListSaveButton";
            this.membersListSaveButton.Size = new System.Drawing.Size(144, 42);
            this.membersListSaveButton.TabIndex = 7;
            this.membersListSaveButton.Text = "Salvar";
            this.membersListSaveButton.UseVisualStyleBackColor = true;
            this.membersListSaveButton.Click += new System.EventHandler(this.membersListSaveButton_Click);
            // 
            // membersListCancelButton
            // 
            this.membersListCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersListCancelButton.Location = new System.Drawing.Point(752, 180);
            this.membersListCancelButton.Name = "membersListCancelButton";
            this.membersListCancelButton.Size = new System.Drawing.Size(144, 42);
            this.membersListCancelButton.TabIndex = 8;
            this.membersListCancelButton.Text = "Cancelar";
            this.membersListCancelButton.UseVisualStyleBackColor = true;
            this.membersListCancelButton.Click += new System.EventHandler(this.membersListCancelButton_Click);
            // 
            // MembersAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 630);
            this.Controls.Add(this.membersListCancelButton);
            this.Controls.Add(this.membersListSaveButton);
            this.Controls.Add(this.membersListNameTextBox);
            this.Controls.Add(this.membersListCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.membersListComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.membersListDeleteButton);
            this.Controls.Add(this.membersListEditButton);
            this.Controls.Add(this.membersListAddButton);
            this.Controls.Add(this.membersListDataGridView);
            this.Name = "MembersAdminForm";
            this.Text = "Lista de Membros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MembersAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView membersListDataGridView;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource membrosBindingSource;
        private igrejafont11DataSetTableAdapters.MembrosTableAdapter membrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMembroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button membersListAddButton;
        private System.Windows.Forms.Button membersListEditButton;
        private System.Windows.Forms.Button membersListDeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox membersListComboBox;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox membersListCodeTextBox;
        private System.Windows.Forms.TextBox membersListNameTextBox;
        private System.Windows.Forms.Button membersListSaveButton;
        private System.Windows.Forms.Button membersListCancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
    }
}