namespace TesourariaIFV.Forms.Reports_Forms
{
    partial class ReportPlanoDeContasDetalhes
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
            this.reportPlanoDeContasComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.reportPlanoDeContasCancelButton = new System.Windows.Forms.Button();
            this.reportPlanoDeContasOkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportPlanoDeContasFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportPlanoDeContasInitialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportPlanoDeContasPeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.reportPlanoDeContasMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.reportPlanoDeContasMonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPlanoDeContasComboBox
            // 
            this.reportPlanoDeContasComboBox.DataSource = this.igrejasBindingSource;
            this.reportPlanoDeContasComboBox.DisplayMember = "Nome";
            this.reportPlanoDeContasComboBox.FormattingEnabled = true;
            this.reportPlanoDeContasComboBox.Location = new System.Drawing.Point(241, 240);
            this.reportPlanoDeContasComboBox.Name = "reportPlanoDeContasComboBox";
            this.reportPlanoDeContasComboBox.Size = new System.Drawing.Size(407, 32);
            this.reportPlanoDeContasComboBox.TabIndex = 5;
            this.reportPlanoDeContasComboBox.ValueMember = "Nome";
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
            this.label4.Location = new System.Drawing.Point(124, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Igreja";
            // 
            // reportPlanoDeContasCancelButton
            // 
            this.reportPlanoDeContasCancelButton.Location = new System.Drawing.Point(668, 378);
            this.reportPlanoDeContasCancelButton.Name = "reportPlanoDeContasCancelButton";
            this.reportPlanoDeContasCancelButton.Size = new System.Drawing.Size(132, 38);
            this.reportPlanoDeContasCancelButton.TabIndex = 7;
            this.reportPlanoDeContasCancelButton.Text = "Cancel";
            this.reportPlanoDeContasCancelButton.UseVisualStyleBackColor = true;
            this.reportPlanoDeContasCancelButton.Click += new System.EventHandler(this.reportPlanoDeContasCancelButton_Click);
            // 
            // reportPlanoDeContasOkButton
            // 
            this.reportPlanoDeContasOkButton.Location = new System.Drawing.Point(530, 378);
            this.reportPlanoDeContasOkButton.Name = "reportPlanoDeContasOkButton";
            this.reportPlanoDeContasOkButton.Size = new System.Drawing.Size(132, 38);
            this.reportPlanoDeContasOkButton.TabIndex = 6;
            this.reportPlanoDeContasOkButton.Text = "Ok";
            this.reportPlanoDeContasOkButton.UseVisualStyleBackColor = true;
            this.reportPlanoDeContasOkButton.Click += new System.EventHandler(this.reportPlanoDeContasOkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "De";
            // 
            // reportPlanoDeContasFinalDateTimePicker
            // 
            this.reportPlanoDeContasFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportPlanoDeContasFinalDateTimePicker.Location = new System.Drawing.Point(491, 176);
            this.reportPlanoDeContasFinalDateTimePicker.Name = "reportPlanoDeContasFinalDateTimePicker";
            this.reportPlanoDeContasFinalDateTimePicker.Size = new System.Drawing.Size(157, 29);
            this.reportPlanoDeContasFinalDateTimePicker.TabIndex = 4;
            // 
            // reportPlanoDeContasInitialDateTimePicker
            // 
            this.reportPlanoDeContasInitialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportPlanoDeContasInitialDateTimePicker.Location = new System.Drawing.Point(280, 177);
            this.reportPlanoDeContasInitialDateTimePicker.Name = "reportPlanoDeContasInitialDateTimePicker";
            this.reportPlanoDeContasInitialDateTimePicker.Size = new System.Drawing.Size(161, 29);
            this.reportPlanoDeContasInitialDateTimePicker.TabIndex = 3;
            // 
            // reportPlanoDeContasPeriodRadioButton
            // 
            this.reportPlanoDeContasPeriodRadioButton.AutoSize = true;
            this.reportPlanoDeContasPeriodRadioButton.Location = new System.Drawing.Point(102, 176);
            this.reportPlanoDeContasPeriodRadioButton.Name = "reportPlanoDeContasPeriodRadioButton";
            this.reportPlanoDeContasPeriodRadioButton.Size = new System.Drawing.Size(94, 28);
            this.reportPlanoDeContasPeriodRadioButton.TabIndex = 2;
            this.reportPlanoDeContasPeriodRadioButton.TabStop = true;
            this.reportPlanoDeContasPeriodRadioButton.Text = "Período";
            this.reportPlanoDeContasPeriodRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportPlanoDeContasMonthRadioButton
            // 
            this.reportPlanoDeContasMonthRadioButton.AutoSize = true;
            this.reportPlanoDeContasMonthRadioButton.Location = new System.Drawing.Point(102, 134);
            this.reportPlanoDeContasMonthRadioButton.Name = "reportPlanoDeContasMonthRadioButton";
            this.reportPlanoDeContasMonthRadioButton.Size = new System.Drawing.Size(114, 28);
            this.reportPlanoDeContasMonthRadioButton.TabIndex = 0;
            this.reportPlanoDeContasMonthRadioButton.TabStop = true;
            this.reportPlanoDeContasMonthRadioButton.Text = "Mês / Ano";
            this.reportPlanoDeContasMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportPlanoDeContasMonthDateTimePicker
            // 
            this.reportPlanoDeContasMonthDateTimePicker.CustomFormat = "MM/yyyy";
            this.reportPlanoDeContasMonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportPlanoDeContasMonthDateTimePicker.Location = new System.Drawing.Point(241, 134);
            this.reportPlanoDeContasMonthDateTimePicker.Name = "reportPlanoDeContasMonthDateTimePicker";
            this.reportPlanoDeContasMonthDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.reportPlanoDeContasMonthDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Defina o Período";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPlanoDeContasDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 428);
            this.Controls.Add(this.reportPlanoDeContasComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportPlanoDeContasCancelButton);
            this.Controls.Add(this.reportPlanoDeContasOkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportPlanoDeContasFinalDateTimePicker);
            this.Controls.Add(this.reportPlanoDeContasInitialDateTimePicker);
            this.Controls.Add(this.reportPlanoDeContasPeriodRadioButton);
            this.Controls.Add(this.reportPlanoDeContasMonthRadioButton);
            this.Controls.Add(this.reportPlanoDeContasMonthDateTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportPlanoDeContasDetalhes";
            this.Text = "Relatório Plano de Contas - Detalhado";
            this.Load += new System.EventHandler(this.ReportPlanoDeContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportPlanoDeContasComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportPlanoDeContasCancelButton;
        private System.Windows.Forms.Button reportPlanoDeContasOkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker reportPlanoDeContasFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker reportPlanoDeContasInitialDateTimePicker;
        private System.Windows.Forms.RadioButton reportPlanoDeContasPeriodRadioButton;
        private System.Windows.Forms.RadioButton reportPlanoDeContasMonthRadioButton;
        private System.Windows.Forms.DateTimePicker reportPlanoDeContasMonthDateTimePicker;
        private System.Windows.Forms.Label label1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
    }
}