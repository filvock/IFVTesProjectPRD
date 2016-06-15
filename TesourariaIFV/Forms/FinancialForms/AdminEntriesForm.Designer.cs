namespace TesourariaIFV.Forms
{
    partial class AdminEntriesForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminEntriesCaixaRadioButton = new System.Windows.Forms.RadioButton();
            this.adminEntriesBancoRadioButton = new System.Windows.Forms.RadioButton();
            this.adminEntriesCaixaBancoRadioButton = new System.Windows.Forms.RadioButton();
            this.adminEntriesComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.adminEntriesCancelButton = new System.Windows.Forms.Button();
            this.adminEntriesOkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminEntriesFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adminEntriesInitialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adminEntriesPeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.adminEntriesMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.adminEntriesMonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tesourariaGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesourariaGeralTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Defina o Relatório";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminEntriesCaixaRadioButton);
            this.panel1.Controls.Add(this.adminEntriesBancoRadioButton);
            this.panel1.Controls.Add(this.adminEntriesCaixaBancoRadioButton);
            this.panel1.Location = new System.Drawing.Point(58, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 35);
            this.panel1.TabIndex = 58;
            // 
            // adminEntriesCaixaRadioButton
            // 
            this.adminEntriesCaixaRadioButton.AutoSize = true;
            this.adminEntriesCaixaRadioButton.Checked = true;
            this.adminEntriesCaixaRadioButton.Location = new System.Drawing.Point(0, 3);
            this.adminEntriesCaixaRadioButton.Name = "adminEntriesCaixaRadioButton";
            this.adminEntriesCaixaRadioButton.Size = new System.Drawing.Size(75, 28);
            this.adminEntriesCaixaRadioButton.TabIndex = 1;
            this.adminEntriesCaixaRadioButton.TabStop = true;
            this.adminEntriesCaixaRadioButton.Text = "Caixa";
            this.adminEntriesCaixaRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminEntriesBancoRadioButton
            // 
            this.adminEntriesBancoRadioButton.AutoSize = true;
            this.adminEntriesBancoRadioButton.Location = new System.Drawing.Point(142, 3);
            this.adminEntriesBancoRadioButton.Name = "adminEntriesBancoRadioButton";
            this.adminEntriesBancoRadioButton.Size = new System.Drawing.Size(82, 28);
            this.adminEntriesBancoRadioButton.TabIndex = 2;
            this.adminEntriesBancoRadioButton.Text = "Banco";
            this.adminEntriesBancoRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminEntriesCaixaBancoRadioButton
            // 
            this.adminEntriesCaixaBancoRadioButton.AutoSize = true;
            this.adminEntriesCaixaBancoRadioButton.Location = new System.Drawing.Point(282, 3);
            this.adminEntriesCaixaBancoRadioButton.Name = "adminEntriesCaixaBancoRadioButton";
            this.adminEntriesCaixaBancoRadioButton.Size = new System.Drawing.Size(150, 28);
            this.adminEntriesCaixaBancoRadioButton.TabIndex = 3;
            this.adminEntriesCaixaBancoRadioButton.Text = "Caixa e Banco";
            this.adminEntriesCaixaBancoRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminEntriesComboBox
            // 
            this.adminEntriesComboBox.DataSource = this.igrejasBindingSource;
            this.adminEntriesComboBox.DisplayMember = "Nome";
            this.adminEntriesComboBox.FormattingEnabled = true;
            this.adminEntriesComboBox.Location = new System.Drawing.Point(197, 291);
            this.adminEntriesComboBox.Name = "adminEntriesComboBox";
            this.adminEntriesComboBox.Size = new System.Drawing.Size(407, 32);
            this.adminEntriesComboBox.TabIndex = 9;
            this.adminEntriesComboBox.ValueMember = "Nome";
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Igreja";
            // 
            // adminEntriesCancelButton
            // 
            this.adminEntriesCancelButton.Location = new System.Drawing.Point(696, 349);
            this.adminEntriesCancelButton.Name = "adminEntriesCancelButton";
            this.adminEntriesCancelButton.Size = new System.Drawing.Size(132, 38);
            this.adminEntriesCancelButton.TabIndex = 11;
            this.adminEntriesCancelButton.Text = "Cancel";
            this.adminEntriesCancelButton.UseVisualStyleBackColor = true;
            this.adminEntriesCancelButton.Click += new System.EventHandler(this.adminEntriesCancelButton_Click);
            // 
            // adminEntriesOkButton
            // 
            this.adminEntriesOkButton.Location = new System.Drawing.Point(559, 349);
            this.adminEntriesOkButton.Name = "adminEntriesOkButton";
            this.adminEntriesOkButton.Size = new System.Drawing.Size(132, 38);
            this.adminEntriesOkButton.TabIndex = 10;
            this.adminEntriesOkButton.Text = "Ok";
            this.adminEntriesOkButton.UseVisualStyleBackColor = true;
            this.adminEntriesOkButton.Click += new System.EventHandler(this.adminEntriesOkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "De";
            // 
            // adminEntriesFinalDateTimePicker
            // 
            this.adminEntriesFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adminEntriesFinalDateTimePicker.Location = new System.Drawing.Point(447, 227);
            this.adminEntriesFinalDateTimePicker.Name = "adminEntriesFinalDateTimePicker";
            this.adminEntriesFinalDateTimePicker.Size = new System.Drawing.Size(157, 29);
            this.adminEntriesFinalDateTimePicker.TabIndex = 8;
            // 
            // adminEntriesInitialDateTimePicker
            // 
            this.adminEntriesInitialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adminEntriesInitialDateTimePicker.Location = new System.Drawing.Point(236, 228);
            this.adminEntriesInitialDateTimePicker.Name = "adminEntriesInitialDateTimePicker";
            this.adminEntriesInitialDateTimePicker.Size = new System.Drawing.Size(161, 29);
            this.adminEntriesInitialDateTimePicker.TabIndex = 7;
            // 
            // adminEntriesPeriodRadioButton
            // 
            this.adminEntriesPeriodRadioButton.AutoSize = true;
            this.adminEntriesPeriodRadioButton.Location = new System.Drawing.Point(58, 227);
            this.adminEntriesPeriodRadioButton.Name = "adminEntriesPeriodRadioButton";
            this.adminEntriesPeriodRadioButton.Size = new System.Drawing.Size(94, 28);
            this.adminEntriesPeriodRadioButton.TabIndex = 6;
            this.adminEntriesPeriodRadioButton.TabStop = true;
            this.adminEntriesPeriodRadioButton.Text = "Período";
            this.adminEntriesPeriodRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminEntriesMonthRadioButton
            // 
            this.adminEntriesMonthRadioButton.AutoSize = true;
            this.adminEntriesMonthRadioButton.Location = new System.Drawing.Point(58, 185);
            this.adminEntriesMonthRadioButton.Name = "adminEntriesMonthRadioButton";
            this.adminEntriesMonthRadioButton.Size = new System.Drawing.Size(114, 28);
            this.adminEntriesMonthRadioButton.TabIndex = 4;
            this.adminEntriesMonthRadioButton.TabStop = true;
            this.adminEntriesMonthRadioButton.Text = "Mês / Ano";
            this.adminEntriesMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminEntriesMonthDateTimePicker
            // 
            this.adminEntriesMonthDateTimePicker.CustomFormat = "MM/yyyy";
            this.adminEntriesMonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.adminEntriesMonthDateTimePicker.Location = new System.Drawing.Point(197, 185);
            this.adminEntriesMonthDateTimePicker.Name = "adminEntriesMonthDateTimePicker";
            this.adminEntriesMonthDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.adminEntriesMonthDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Defina o Período";
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
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // AdminEntriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 733);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminEntriesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminEntriesCancelButton);
            this.Controls.Add(this.adminEntriesOkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminEntriesFinalDateTimePicker);
            this.Controls.Add(this.adminEntriesInitialDateTimePicker);
            this.Controls.Add(this.adminEntriesPeriodRadioButton);
            this.Controls.Add(this.adminEntriesMonthRadioButton);
            this.Controls.Add(this.adminEntriesMonthDateTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminEntriesForm";
            this.Text = "Excluir Entradas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminEntriesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesourariaGeralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton adminEntriesCaixaRadioButton;
        private System.Windows.Forms.RadioButton adminEntriesBancoRadioButton;
        private System.Windows.Forms.RadioButton adminEntriesCaixaBancoRadioButton;
        private System.Windows.Forms.ComboBox adminEntriesComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adminEntriesCancelButton;
        private System.Windows.Forms.Button adminEntriesOkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker adminEntriesFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker adminEntriesInitialDateTimePicker;
        private System.Windows.Forms.RadioButton adminEntriesPeriodRadioButton;
        private System.Windows.Forms.RadioButton adminEntriesMonthRadioButton;
        private System.Windows.Forms.DateTimePicker adminEntriesMonthDateTimePicker;
        private System.Windows.Forms.Label label1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource tesourariaGeralBindingSource;
        private igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tesourariaGeralTableAdapter;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
    }
}