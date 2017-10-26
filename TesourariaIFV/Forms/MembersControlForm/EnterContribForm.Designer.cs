namespace TesourariaIFV.Forms.MembersControlForm
{
    partial class EnterContribForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enterContribDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.membrosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.MembrosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.enterContribComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterContribCodeTextBox = new System.Windows.Forms.TextBox();
            this.enterContribNameTextBox = new System.Windows.Forms.TextBox();
            this.enterContribSaveButton = new System.Windows.Forms.Button();
            this.enterContribCancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enterContribDizimoTextBox = new System.Windows.Forms.TextBox();
            this.enterContribPrimiciaTextBox = new System.Windows.Forms.TextBox();
            this.enterContribMissoesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.enterContribDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.enterContribDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enterContribDataGridView
            // 
            this.enterContribDataGridView.AllowUserToAddRows = false;
            this.enterContribDataGridView.AllowUserToDeleteRows = false;
            this.enterContribDataGridView.AllowUserToOrderColumns = true;
            this.enterContribDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enterContribDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.enterContribDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterContribDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nomeDataGridViewTextBoxColumn,
            this.igrejaDataGridViewTextBoxColumn});
            this.enterContribDataGridView.DataSource = this.membrosBindingSource;
            this.enterContribDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.enterContribDataGridView.Location = new System.Drawing.Point(0, 228);
            this.enterContribDataGridView.Name = "enterContribDataGridView";
            this.enterContribDataGridView.Size = new System.Drawing.Size(899, 362);
            this.enterContribDataGridView.TabIndex = 9;
            this.enterContribDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enterContribDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodMembro";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // igrejaDataGridViewTextBoxColumn
            // 
            this.igrejaDataGridViewTextBoxColumn.DataPropertyName = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.HeaderText = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.Name = "igrejaDataGridViewTextBoxColumn";
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
            // enterContribComboBox
            // 
            this.enterContribComboBox.DataSource = this.igrejasBindingSource;
            this.enterContribComboBox.DisplayMember = "Nome";
            this.enterContribComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribComboBox.FormattingEnabled = true;
            this.enterContribComboBox.Location = new System.Drawing.Point(162, 15);
            this.enterContribComboBox.Name = "enterContribComboBox";
            this.enterContribComboBox.Size = new System.Drawing.Size(294, 32);
            this.enterContribComboBox.TabIndex = 0;
            this.enterContribComboBox.ValueMember = "Nome";
            this.enterContribComboBox.SelectedIndexChanged += new System.EventHandler(this.enterContribComboBox_SelectedIndexChanged);
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
            this.label2.Location = new System.Drawing.Point(12, 60);
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
            this.label3.Location = new System.Drawing.Point(299, 60);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // enterContribCodeTextBox
            // 
            this.enterContribCodeTextBox.Enabled = false;
            this.enterContribCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribCodeTextBox.Location = new System.Drawing.Point(166, 60);
            this.enterContribCodeTextBox.Name = "enterContribCodeTextBox";
            this.enterContribCodeTextBox.Size = new System.Drawing.Size(111, 29);
            this.enterContribCodeTextBox.TabIndex = 1;
            // 
            // enterContribNameTextBox
            // 
            this.enterContribNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribNameTextBox.Location = new System.Drawing.Point(367, 60);
            this.enterContribNameTextBox.Name = "enterContribNameTextBox";
            this.enterContribNameTextBox.Size = new System.Drawing.Size(416, 29);
            this.enterContribNameTextBox.TabIndex = 2;
            this.enterContribNameTextBox.TextChanged += new System.EventHandler(this.enterContribNameTextBox_TextChanged);
            // 
            // enterContribSaveButton
            // 
            this.enterContribSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribSaveButton.Location = new System.Drawing.Point(602, 180);
            this.enterContribSaveButton.Name = "enterContribSaveButton";
            this.enterContribSaveButton.Size = new System.Drawing.Size(144, 42);
            this.enterContribSaveButton.TabIndex = 7;
            this.enterContribSaveButton.Text = "Salvar";
            this.enterContribSaveButton.UseVisualStyleBackColor = true;
            this.enterContribSaveButton.Click += new System.EventHandler(this.enterContribSaveButton_Click);
            // 
            // enterContribCancelButton
            // 
            this.enterContribCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribCancelButton.Location = new System.Drawing.Point(752, 180);
            this.enterContribCancelButton.Name = "enterContribCancelButton";
            this.enterContribCancelButton.Size = new System.Drawing.Size(144, 42);
            this.enterContribCancelButton.TabIndex = 8;
            this.enterContribCancelButton.Text = "Cancelar";
            this.enterContribCancelButton.UseVisualStyleBackColor = true;
            this.enterContribCancelButton.Click += new System.EventHandler(this.enterContribCancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dízimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 151);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Primícia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(608, 149);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Missões";
            // 
            // enterContribDizimoTextBox
            // 
            this.enterContribDizimoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribDizimoTextBox.Location = new System.Drawing.Point(80, 144);
            this.enterContribDizimoTextBox.Name = "enterContribDizimoTextBox";
            this.enterContribDizimoTextBox.Size = new System.Drawing.Size(197, 29);
            this.enterContribDizimoTextBox.TabIndex = 4;
            this.enterContribDizimoTextBox.Enter += new System.EventHandler(this.enterContribDizimoTextBox_Enter);
            this.enterContribDizimoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterContribDizimoTextBox_KeyPress);
            this.enterContribDizimoTextBox.Leave += new System.EventHandler(this.enterContribDizimoTextBox_Leave);
            // 
            // enterContribPrimiciaTextBox
            // 
            this.enterContribPrimiciaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribPrimiciaTextBox.Location = new System.Drawing.Point(391, 144);
            this.enterContribPrimiciaTextBox.Name = "enterContribPrimiciaTextBox";
            this.enterContribPrimiciaTextBox.Size = new System.Drawing.Size(197, 29);
            this.enterContribPrimiciaTextBox.TabIndex = 5;
            this.enterContribPrimiciaTextBox.Enter += new System.EventHandler(this.enterContribPrimiciaTextBox_Enter);
            this.enterContribPrimiciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterContribPrimiciaTextBox_KeyPress);
            this.enterContribPrimiciaTextBox.Leave += new System.EventHandler(this.enterContribPrimiciaTextBox_Leave);
            // 
            // enterContribMissoesTextBox
            // 
            this.enterContribMissoesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribMissoesTextBox.Location = new System.Drawing.Point(690, 144);
            this.enterContribMissoesTextBox.Name = "enterContribMissoesTextBox";
            this.enterContribMissoesTextBox.Size = new System.Drawing.Size(197, 29);
            this.enterContribMissoesTextBox.TabIndex = 6;
            this.enterContribMissoesTextBox.Enter += new System.EventHandler(this.enterContribMissoesTextBox_Enter);
            this.enterContribMissoesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterContribMissoesTextBox_KeyPress);
            this.enterContribMissoesTextBox.Leave += new System.EventHandler(this.enterContribMissoesTextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(47, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data";
            // 
            // enterContribDateTimePicker
            // 
            this.enterContribDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterContribDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enterContribDateTimePicker.Location = new System.Drawing.Point(80, 103);
            this.enterContribDateTimePicker.Name = "enterContribDateTimePicker";
            this.enterContribDateTimePicker.Size = new System.Drawing.Size(197, 29);
            this.enterContribDateTimePicker.TabIndex = 3;
            // 
            // EnterContribForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 590);
            this.Controls.Add(this.enterContribDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enterContribMissoesTextBox);
            this.Controls.Add(this.enterContribPrimiciaTextBox);
            this.Controls.Add(this.enterContribDizimoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterContribCancelButton);
            this.Controls.Add(this.enterContribSaveButton);
            this.Controls.Add(this.enterContribNameTextBox);
            this.Controls.Add(this.enterContribCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterContribComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterContribDataGridView);
            this.Name = "EnterContribForm";
            this.Text = "Lançamento de Valores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MembersGeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enterContribDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView enterContribDataGridView;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource membrosBindingSource;
        private igrejafont11DataSetTableAdapters.MembrosTableAdapter membrosTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codMembroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox enterContribComboBox;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enterContribCodeTextBox;
        private System.Windows.Forms.TextBox enterContribNameTextBox;
        private System.Windows.Forms.Button enterContribSaveButton;
        private System.Windows.Forms.Button enterContribCancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enterContribDizimoTextBox;
        private System.Windows.Forms.TextBox enterContribPrimiciaTextBox;
        private System.Windows.Forms.TextBox enterContribMissoesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker enterContribDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
    }
}