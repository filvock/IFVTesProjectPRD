namespace TesourariaIFV.Forms.ReportForms.ManagementReport
{
    partial class ReportCaixaMgnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCaixaMgnt));
            this.label1 = new System.Windows.Forms.Label();
            this.reportCaixaMonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportCaixaMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.reportCaixaPeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.reportCaixaInitialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportCaixaFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportCaixaOkButton = new System.Windows.Forms.Button();
            this.reportCaixaCancelButton = new System.Windows.Forms.Button();
            this.formReportCaixaComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportCaixaCaixaRadioButton = new System.Windows.Forms.RadioButton();
            this.reportCaixaBancoRadioButton = new System.Windows.Forms.RadioButton();
            this.reportCaixaCaixaBancoRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defina o Período";
            // 
            // reportCaixaMonthDateTimePicker
            // 
            this.reportCaixaMonthDateTimePicker.CustomFormat = "MM/yyyy";
            this.reportCaixaMonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportCaixaMonthDateTimePicker.Location = new System.Drawing.Point(263, 142);
            this.reportCaixaMonthDateTimePicker.Name = "reportCaixaMonthDateTimePicker";
            this.reportCaixaMonthDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.reportCaixaMonthDateTimePicker.TabIndex = 5;
            // 
            // reportCaixaMonthRadioButton
            // 
            this.reportCaixaMonthRadioButton.AutoSize = true;
            this.reportCaixaMonthRadioButton.Location = new System.Drawing.Point(124, 142);
            this.reportCaixaMonthRadioButton.Name = "reportCaixaMonthRadioButton";
            this.reportCaixaMonthRadioButton.Size = new System.Drawing.Size(114, 28);
            this.reportCaixaMonthRadioButton.TabIndex = 4;
            this.reportCaixaMonthRadioButton.TabStop = true;
            this.reportCaixaMonthRadioButton.Text = "Mês / Ano";
            this.reportCaixaMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportCaixaPeriodRadioButton
            // 
            this.reportCaixaPeriodRadioButton.AutoSize = true;
            this.reportCaixaPeriodRadioButton.Location = new System.Drawing.Point(124, 184);
            this.reportCaixaPeriodRadioButton.Name = "reportCaixaPeriodRadioButton";
            this.reportCaixaPeriodRadioButton.Size = new System.Drawing.Size(94, 28);
            this.reportCaixaPeriodRadioButton.TabIndex = 6;
            this.reportCaixaPeriodRadioButton.TabStop = true;
            this.reportCaixaPeriodRadioButton.Text = "Período";
            this.reportCaixaPeriodRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportCaixaInitialDateTimePicker
            // 
            this.reportCaixaInitialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportCaixaInitialDateTimePicker.Location = new System.Drawing.Point(302, 185);
            this.reportCaixaInitialDateTimePicker.Name = "reportCaixaInitialDateTimePicker";
            this.reportCaixaInitialDateTimePicker.Size = new System.Drawing.Size(161, 29);
            this.reportCaixaInitialDateTimePicker.TabIndex = 7;
            // 
            // reportCaixaFinalDateTimePicker
            // 
            this.reportCaixaFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportCaixaFinalDateTimePicker.Location = new System.Drawing.Point(513, 184);
            this.reportCaixaFinalDateTimePicker.Name = "reportCaixaFinalDateTimePicker";
            this.reportCaixaFinalDateTimePicker.Size = new System.Drawing.Size(157, 29);
            this.reportCaixaFinalDateTimePicker.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Até";
            // 
            // reportCaixaOkButton
            // 
            this.reportCaixaOkButton.Location = new System.Drawing.Point(612, 412);
            this.reportCaixaOkButton.Name = "reportCaixaOkButton";
            this.reportCaixaOkButton.Size = new System.Drawing.Size(132, 38);
            this.reportCaixaOkButton.TabIndex = 10;
            this.reportCaixaOkButton.Text = "Ok";
            this.reportCaixaOkButton.UseVisualStyleBackColor = true;
            this.reportCaixaOkButton.Click += new System.EventHandler(this.reportCaixaOkButton_Click);
            // 
            // reportCaixaCancelButton
            // 
            this.reportCaixaCancelButton.Location = new System.Drawing.Point(750, 412);
            this.reportCaixaCancelButton.Name = "reportCaixaCancelButton";
            this.reportCaixaCancelButton.Size = new System.Drawing.Size(132, 38);
            this.reportCaixaCancelButton.TabIndex = 11;
            this.reportCaixaCancelButton.Text = "Cancel";
            this.reportCaixaCancelButton.UseVisualStyleBackColor = true;
            this.reportCaixaCancelButton.Click += new System.EventHandler(this.reportCaixaCancelButton_Click);
            // 
            // formReportCaixaComboBox
            // 
            this.formReportCaixaComboBox.DataSource = this.igrejasBindingSource;
            this.formReportCaixaComboBox.DisplayMember = "Nome";
            this.formReportCaixaComboBox.FormattingEnabled = true;
            this.formReportCaixaComboBox.Location = new System.Drawing.Point(266, 344);
            this.formReportCaixaComboBox.Name = "formReportCaixaComboBox";
            this.formReportCaixaComboBox.Size = new System.Drawing.Size(407, 32);
            this.formReportCaixaComboBox.TabIndex = 9;
            this.formReportCaixaComboBox.ValueMember = "Nome";
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
            this.label4.Location = new System.Drawing.Point(149, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Igreja";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Defina o Relatório";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportCaixaCaixaRadioButton);
            this.panel1.Controls.Add(this.reportCaixaBancoRadioButton);
            this.panel1.Controls.Add(this.reportCaixaCaixaBancoRadioButton);
            this.panel1.Location = new System.Drawing.Point(124, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 35);
            this.panel1.TabIndex = 44;
            // 
            // reportCaixaCaixaRadioButton
            // 
            this.reportCaixaCaixaRadioButton.AutoSize = true;
            this.reportCaixaCaixaRadioButton.Checked = true;
            this.reportCaixaCaixaRadioButton.Location = new System.Drawing.Point(0, 3);
            this.reportCaixaCaixaRadioButton.Name = "reportCaixaCaixaRadioButton";
            this.reportCaixaCaixaRadioButton.Size = new System.Drawing.Size(75, 28);
            this.reportCaixaCaixaRadioButton.TabIndex = 1;
            this.reportCaixaCaixaRadioButton.TabStop = true;
            this.reportCaixaCaixaRadioButton.Text = "Caixa";
            this.reportCaixaCaixaRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportCaixaBancoRadioButton
            // 
            this.reportCaixaBancoRadioButton.AutoSize = true;
            this.reportCaixaBancoRadioButton.Location = new System.Drawing.Point(142, 3);
            this.reportCaixaBancoRadioButton.Name = "reportCaixaBancoRadioButton";
            this.reportCaixaBancoRadioButton.Size = new System.Drawing.Size(82, 28);
            this.reportCaixaBancoRadioButton.TabIndex = 2;
            this.reportCaixaBancoRadioButton.Text = "Banco";
            this.reportCaixaBancoRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportCaixaCaixaBancoRadioButton
            // 
            this.reportCaixaCaixaBancoRadioButton.AutoSize = true;
            this.reportCaixaCaixaBancoRadioButton.Location = new System.Drawing.Point(282, 3);
            this.reportCaixaCaixaBancoRadioButton.Name = "reportCaixaCaixaBancoRadioButton";
            this.reportCaixaCaixaBancoRadioButton.Size = new System.Drawing.Size(150, 28);
            this.reportCaixaCaixaBancoRadioButton.TabIndex = 3;
            this.reportCaixaCaixaBancoRadioButton.Text = "Caixa e Banco";
            this.reportCaixaCaixaBancoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Região";
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
            this.comboBox1.Location = new System.Drawing.Point(266, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(407, 32);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.estadosBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(266, 293);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(407, 32);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.ValueMember = "Sigla";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Estado";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(679, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(679, 302);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 50;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(679, 353);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 51;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
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
            // ReportCaixaMgnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 462);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formReportCaixaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportCaixaCancelButton);
            this.Controls.Add(this.reportCaixaOkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportCaixaFinalDateTimePicker);
            this.Controls.Add(this.reportCaixaInitialDateTimePicker);
            this.Controls.Add(this.reportCaixaPeriodRadioButton);
            this.Controls.Add(this.reportCaixaMonthRadioButton);
            this.Controls.Add(this.reportCaixaMonthDateTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportCaixaMgnt";
            this.Text = "Relatório Gerencial de Livro Caixa";
            this.Load += new System.EventHandler(this.ReportCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker reportCaixaMonthDateTimePicker;
        private System.Windows.Forms.RadioButton reportCaixaMonthRadioButton;
        private System.Windows.Forms.RadioButton reportCaixaPeriodRadioButton;
        private System.Windows.Forms.DateTimePicker reportCaixaInitialDateTimePicker;
        private System.Windows.Forms.DateTimePicker reportCaixaFinalDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reportCaixaOkButton;
        private System.Windows.Forms.Button reportCaixaCancelButton;
        private System.Windows.Forms.ComboBox formReportCaixaComboBox;
        private System.Windows.Forms.Label label4;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton reportCaixaCaixaRadioButton;
        private System.Windows.Forms.RadioButton reportCaixaBancoRadioButton;
        private System.Windows.Forms.RadioButton reportCaixaCaixaBancoRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private igrejafont11DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
    }
}