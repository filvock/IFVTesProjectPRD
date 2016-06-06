namespace TesourariaIFV.Forms.MembersControlForm
{
    partial class EditContrib
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.controleIndividual1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.membersListComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.membersListSaveButton = new System.Windows.Forms.Button();
            this.membersListCancelButton = new System.Windows.Forms.Button();
            this.controleIndividualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleIndividual1TableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.ControleIndividual1TableAdapter();
            this.controleIndividualTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.ControleIndividualTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dizimoTextBox = new System.Windows.Forms.TextBox();
            this.primiciaTextBox = new System.Windows.Forms.TextBox();
            this.missoesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codMembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dizimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Missoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleIndividual1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleIndividualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMembro,
            this.Nome,
            this.Data,
            this.Dizimo,
            this.Primicia,
            this.Missoes,
            this.codLancamento});
            this.dataGridView.DataSource = this.controleIndividual1BindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 228);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(899, 402);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersListDataGridView_CellClick);
            // 
            // controleIndividual1BindingSource
            // 
            this.controleIndividual1BindingSource.DataMember = "ControleIndividual1";
            this.controleIndividual1BindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 66);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(93, 63);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(111, 29);
            this.codeTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(292, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(416, 29);
            this.nameTextBox.TabIndex = 6;
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
            // controleIndividualBindingSource
            // 
            this.controleIndividualBindingSource.DataMember = "ControleIndividual";
            this.controleIndividualBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // controleIndividual1TableAdapter
            // 
            this.controleIndividual1TableAdapter.ClearBeforeFill = true;
            // 
            // controleIndividualTableAdapter
            // 
            this.controleIndividualTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dízimo";
            // 
            // dizimoTextBox
            // 
            this.dizimoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dizimoTextBox.Location = new System.Drawing.Point(93, 146);
            this.dizimoTextBox.Name = "dizimoTextBox";
            this.dizimoTextBox.Size = new System.Drawing.Size(111, 29);
            this.dizimoTextBox.TabIndex = 12;
            this.dizimoTextBox.Enter += new System.EventHandler(this.enterContribDizimoTextBox_Enter);
            this.dizimoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterContribDizimoTextBox_KeyPress);
            this.dizimoTextBox.Leave += new System.EventHandler(this.enterContribDizimoTextBox_Leave);
            // 
            // primiciaTextBox
            // 
            this.primiciaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primiciaTextBox.Location = new System.Drawing.Point(292, 146);
            this.primiciaTextBox.Name = "primiciaTextBox";
            this.primiciaTextBox.Size = new System.Drawing.Size(111, 29);
            this.primiciaTextBox.TabIndex = 13;
            this.primiciaTextBox.Enter += new System.EventHandler(this.enterContribPrimiciaTextBox_Enter);
            this.primiciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterContribPrimiciaTextBox_KeyPress);
            this.primiciaTextBox.Leave += new System.EventHandler(this.enterContribPrimiciaTextBox_Leave);
            // 
            // missoesTextBox
            // 
            this.missoesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missoesTextBox.Location = new System.Drawing.Point(494, 147);
            this.missoesTextBox.Name = "missoesTextBox";
            this.missoesTextBox.Size = new System.Drawing.Size(111, 29);
            this.missoesTextBox.TabIndex = 14;
            this.missoesTextBox.Enter += new System.EventHandler(this.enterContribMissoesTextBox_Enter);
            this.missoesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterContribMissoesTextBox_KeyPress);
            this.missoesTextBox.Leave += new System.EventHandler(this.enterContribMissoesTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 150);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Primícia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 150);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Missões";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(93, 104);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 29);
            this.dateTimePicker.TabIndex = 17;
            // 
            // codMembro
            // 
            this.codMembro.DataPropertyName = "codMembro";
            this.codMembro.HeaderText = "Cod";
            this.codMembro.Name = "codMembro";
            this.codMembro.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 150;
            // 
            // Dizimo
            // 
            this.Dizimo.DataPropertyName = "Dizimo";
            this.Dizimo.HeaderText = "Dizimo";
            this.Dizimo.Name = "Dizimo";
            this.Dizimo.ReadOnly = true;
            // 
            // Primicia
            // 
            this.Primicia.DataPropertyName = "Primicia";
            this.Primicia.HeaderText = "Primicia";
            this.Primicia.Name = "Primicia";
            this.Primicia.ReadOnly = true;
            // 
            // Missoes
            // 
            this.Missoes.DataPropertyName = "Missoes";
            this.Missoes.HeaderText = "Missoes";
            this.Missoes.Name = "Missoes";
            this.Missoes.ReadOnly = true;
            // 
            // codLancamento
            // 
            this.codLancamento.DataPropertyName = "codLancamento";
            this.codLancamento.HeaderText = "codLancamento";
            this.codLancamento.Name = "codLancamento";
            this.codLancamento.ReadOnly = true;
            this.codLancamento.Visible = false;
            // 
            // EditContrib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 630);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.missoesTextBox);
            this.Controls.Add(this.primiciaTextBox);
            this.Controls.Add(this.dizimoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.membersListCancelButton);
            this.Controls.Add(this.membersListSaveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.membersListComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "EditContrib";
            this.Text = "Lista de Membros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MembersAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleIndividual1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleIndividualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox membersListComboBox;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button membersListSaveButton;
        private System.Windows.Forms.Button membersListCancelButton;
        private System.Windows.Forms.BindingSource controleIndividual1BindingSource;
        private igrejafont11DataSetTableAdapters.ControleIndividual1TableAdapter controleIndividual1TableAdapter;
        private System.Windows.Forms.BindingSource controleIndividualBindingSource;
        private igrejafont11DataSetTableAdapters.ControleIndividualTableAdapter controleIndividualTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dizimoTextBox;
        private System.Windows.Forms.TextBox primiciaTextBox;
        private System.Windows.Forms.TextBox missoesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dizimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Missoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLancamento;
    }
}