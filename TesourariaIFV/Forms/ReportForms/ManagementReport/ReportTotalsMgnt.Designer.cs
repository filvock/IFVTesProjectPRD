namespace TesourariaIFV.Forms.ReportForms.ManagementReport
{
    partial class ReportTotalsMgnt
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
            this.reportTotalsComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.reportTotalsCancelButton = new System.Windows.Forms.Button();
            this.reportTotalsOkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportTotalsFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportTotalsInitialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportTotalsPeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.reportTotalsMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.reportTotalsMonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTotalsComboBox
            // 
            this.reportTotalsComboBox.DataSource = this.igrejasBindingSource;
            this.reportTotalsComboBox.DisplayMember = "Nome";
            this.reportTotalsComboBox.FormattingEnabled = true;
            this.reportTotalsComboBox.Location = new System.Drawing.Point(188, 411);
            this.reportTotalsComboBox.Name = "reportTotalsComboBox";
            this.reportTotalsComboBox.Size = new System.Drawing.Size(407, 32);
            this.reportTotalsComboBox.TabIndex = 5;
            this.reportTotalsComboBox.ValueMember = "Nome";
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
            this.label4.Location = new System.Drawing.Point(71, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Igreja";
            // 
            // reportTotalsCancelButton
            // 
            this.reportTotalsCancelButton.Location = new System.Drawing.Point(678, 464);
            this.reportTotalsCancelButton.Name = "reportTotalsCancelButton";
            this.reportTotalsCancelButton.Size = new System.Drawing.Size(132, 38);
            this.reportTotalsCancelButton.TabIndex = 7;
            this.reportTotalsCancelButton.Text = "Cancel";
            this.reportTotalsCancelButton.UseVisualStyleBackColor = true;
            this.reportTotalsCancelButton.Click += new System.EventHandler(this.reportTotalsCancelButton_Click);
            // 
            // reportTotalsOkButton
            // 
            this.reportTotalsOkButton.Location = new System.Drawing.Point(540, 464);
            this.reportTotalsOkButton.Name = "reportTotalsOkButton";
            this.reportTotalsOkButton.Size = new System.Drawing.Size(132, 38);
            this.reportTotalsOkButton.TabIndex = 6;
            this.reportTotalsOkButton.Text = "Ok";
            this.reportTotalsOkButton.UseVisualStyleBackColor = true;
            this.reportTotalsOkButton.Click += new System.EventHandler(this.reportTotalsOkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "De";
            // 
            // reportTotalsFinalDateTimePicker
            // 
            this.reportTotalsFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportTotalsFinalDateTimePicker.Location = new System.Drawing.Point(438, 206);
            this.reportTotalsFinalDateTimePicker.Name = "reportTotalsFinalDateTimePicker";
            this.reportTotalsFinalDateTimePicker.Size = new System.Drawing.Size(157, 29);
            this.reportTotalsFinalDateTimePicker.TabIndex = 4;
            // 
            // reportTotalsInitialDateTimePicker
            // 
            this.reportTotalsInitialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportTotalsInitialDateTimePicker.Location = new System.Drawing.Point(227, 207);
            this.reportTotalsInitialDateTimePicker.Name = "reportTotalsInitialDateTimePicker";
            this.reportTotalsInitialDateTimePicker.Size = new System.Drawing.Size(161, 29);
            this.reportTotalsInitialDateTimePicker.TabIndex = 3;
            // 
            // reportTotalsPeriodRadioButton
            // 
            this.reportTotalsPeriodRadioButton.AutoSize = true;
            this.reportTotalsPeriodRadioButton.Location = new System.Drawing.Point(49, 206);
            this.reportTotalsPeriodRadioButton.Name = "reportTotalsPeriodRadioButton";
            this.reportTotalsPeriodRadioButton.Size = new System.Drawing.Size(94, 28);
            this.reportTotalsPeriodRadioButton.TabIndex = 2;
            this.reportTotalsPeriodRadioButton.TabStop = true;
            this.reportTotalsPeriodRadioButton.Text = "Período";
            this.reportTotalsPeriodRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportTotalsMonthRadioButton
            // 
            this.reportTotalsMonthRadioButton.AutoSize = true;
            this.reportTotalsMonthRadioButton.Location = new System.Drawing.Point(49, 164);
            this.reportTotalsMonthRadioButton.Name = "reportTotalsMonthRadioButton";
            this.reportTotalsMonthRadioButton.Size = new System.Drawing.Size(114, 28);
            this.reportTotalsMonthRadioButton.TabIndex = 0;
            this.reportTotalsMonthRadioButton.TabStop = true;
            this.reportTotalsMonthRadioButton.Text = "Mês / Ano";
            this.reportTotalsMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportTotalsMonthDateTimePicker
            // 
            this.reportTotalsMonthDateTimePicker.CustomFormat = "MM/yyyy";
            this.reportTotalsMonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportTotalsMonthDateTimePicker.Location = new System.Drawing.Point(188, 164);
            this.reportTotalsMonthDateTimePicker.Name = "reportTotalsMonthDateTimePicker";
            this.reportTotalsMonthDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.reportTotalsMonthDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Defina o Período";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(601, 420);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 65;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(601, 369);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 64;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(601, 317);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.estadosBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 360);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(407, 32);
            this.comboBox2.TabIndex = 62;
            this.comboBox2.ValueMember = "Sigla";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Centro-Oeste",
            "Nordeste",
            "Norte",
            "Sudeste",
            "Sul"});
            this.comboBox1.Location = new System.Drawing.Point(188, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(407, 32);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Região";
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
            // ReportTotalsMgnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 514);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportTotalsComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportTotalsCancelButton);
            this.Controls.Add(this.reportTotalsOkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportTotalsFinalDateTimePicker);
            this.Controls.Add(this.reportTotalsInitialDateTimePicker);
            this.Controls.Add(this.reportTotalsPeriodRadioButton);
            this.Controls.Add(this.reportTotalsMonthRadioButton);
            this.Controls.Add(this.reportTotalsMonthDateTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportTotalsMgnt";
            this.Text = "Relatório de Totais";
            this.Load += new System.EventHandler(this.ReportTotals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportTotalsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportTotalsCancelButton;
        private System.Windows.Forms.Button reportTotalsOkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker reportTotalsFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker reportTotalsInitialDateTimePicker;
        private System.Windows.Forms.RadioButton reportTotalsPeriodRadioButton;
        private System.Windows.Forms.RadioButton reportTotalsMonthRadioButton;
        private System.Windows.Forms.DateTimePicker reportTotalsMonthDateTimePicker;
        private System.Windows.Forms.Label label1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private igrejafont11DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
    }
}