namespace TesourariaIFV.Forms
{
    partial class FinControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinControlForm));
            this.finControlFormDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finControlFormDocNumberTextBox = new System.Windows.Forms.TextBox();
            this.finControlFormDescTextBox = new System.Windows.Forms.TextBox();
            this.finControlFormBankTextBox = new System.Windows.Forms.TextBox();
            this.finControlFormCaixaTextBox = new System.Windows.Forms.TextBox();
            this.finControlFormObsTextBox = new System.Windows.Forms.TextBox();
            this.finControlFormObsTextBox.MaxLength = 50;
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.finControlFormOkButton = new System.Windows.Forms.Button();
            this.finControlFormCancelButton = new System.Windows.Forms.Button();
            this.finControlFormInRadioButton = new System.Windows.Forms.RadioButton();
            this.finControlFormOutRadioButton = new System.Windows.Forms.RadioButton();
            this.finControlFormComboBox = new System.Windows.Forms.ComboBox();
            this.planoDeContasDebitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.planoDeContasCreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoDeContasCreditoTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.PlanoDeContasCreditoTableAdapter();
            this.planoDeContasDebitoTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter();
            this.codeContaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasDebitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasCreditoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // finControlFormDateTimePicker
            // 
            this.finControlFormDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finControlFormDateTimePicker.Location = new System.Drawing.Point(360, 116);
            this.finControlFormDateTimePicker.Name = "finControlFormDateTimePicker";
            this.finControlFormDateTimePicker.Size = new System.Drawing.Size(146, 29);
            this.finControlFormDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lançamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data da Emissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número do Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fornecedor - Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plano de Contas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Obs.";
            // 
            // finControlFormDocNumberTextBox
            // 
            this.finControlFormDocNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormDocNumberTextBox.Location = new System.Drawing.Point(360, 163);
            this.finControlFormDocNumberTextBox.Name = "finControlFormDocNumberTextBox";
            this.finControlFormDocNumberTextBox.Size = new System.Drawing.Size(146, 29);
            this.finControlFormDocNumberTextBox.TabIndex = 3;
            // 
            // finControlFormDescTextBox
            // 
            this.finControlFormDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormDescTextBox.Location = new System.Drawing.Point(360, 204);
            this.finControlFormDescTextBox.Name = "finControlFormDescTextBox";
            this.finControlFormDescTextBox.Size = new System.Drawing.Size(503, 29);
            this.finControlFormDescTextBox.TabIndex = 4;
            // 
            // finControlFormBankTextBox
            // 
            this.finControlFormBankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormBankTextBox.Location = new System.Drawing.Point(454, 324);
            this.finControlFormBankTextBox.Name = "finControlFormBankTextBox";
            this.finControlFormBankTextBox.Size = new System.Drawing.Size(155, 29);
            this.finControlFormBankTextBox.TabIndex = 8;
            this.finControlFormBankTextBox.Enter += new System.EventHandler(this.finControlFormBankTextBox_Enter);
            this.finControlFormBankTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.finControlFormCaixaTextBox_KeyPress);
            this.finControlFormBankTextBox.Leave += new System.EventHandler(this.finControlFormBankTextBox_Leave);
            // 
            // finControlFormCaixaTextBox
            // 
            this.finControlFormCaixaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormCaixaTextBox.Location = new System.Drawing.Point(223, 324);
            this.finControlFormCaixaTextBox.Name = "finControlFormCaixaTextBox";
            this.finControlFormCaixaTextBox.Size = new System.Drawing.Size(146, 29);
            this.finControlFormCaixaTextBox.TabIndex = 7;
            this.finControlFormCaixaTextBox.Enter += new System.EventHandler(this.finControlFormCaixaTextBox_Enter);
            this.finControlFormCaixaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.finControlFormCaixaTextBox_KeyPress);
            this.finControlFormCaixaTextBox.Leave += new System.EventHandler(this.finControlFormCaixaTextBox_Leave);
            // 
            // finControlFormObsTextBox
            // 
            this.finControlFormObsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormObsTextBox.Location = new System.Drawing.Point(223, 368);
            this.finControlFormObsTextBox.Name = "finControlFormObsTextBox";
            this.finControlFormObsTextBox.Size = new System.Drawing.Size(403, 29);
            this.finControlFormObsTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Caixa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Banco";
            // 
            // finControlFormOkButton
            // 
            this.finControlFormOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormOkButton.Location = new System.Drawing.Point(610, 446);
            this.finControlFormOkButton.Name = "finControlFormOkButton";
            this.finControlFormOkButton.Size = new System.Drawing.Size(113, 36);
            this.finControlFormOkButton.TabIndex = 10;
            this.finControlFormOkButton.Text = "Ok";
            this.finControlFormOkButton.UseVisualStyleBackColor = true;
            this.finControlFormOkButton.Click += new System.EventHandler(this.finControlFormOkButton_Click);
            // 
            // finControlFormCancelButton
            // 
            this.finControlFormCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormCancelButton.Location = new System.Drawing.Point(750, 446);
            this.finControlFormCancelButton.Name = "finControlFormCancelButton";
            this.finControlFormCancelButton.Size = new System.Drawing.Size(113, 36);
            this.finControlFormCancelButton.TabIndex = 11;
            this.finControlFormCancelButton.Text = "Cancel";
            this.finControlFormCancelButton.UseVisualStyleBackColor = true;
            this.finControlFormCancelButton.Click += new System.EventHandler(this.finControlFormCancelButton_Click);
            // 
            // finControlFormInRadioButton
            // 
            this.finControlFormInRadioButton.AutoSize = true;
            this.finControlFormInRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormInRadioButton.Location = new System.Drawing.Point(151, 70);
            this.finControlFormInRadioButton.Name = "finControlFormInRadioButton";
            this.finControlFormInRadioButton.Size = new System.Drawing.Size(93, 28);
            this.finControlFormInRadioButton.TabIndex = 0;
            this.finControlFormInRadioButton.TabStop = true;
            this.finControlFormInRadioButton.Text = "Entrada";
            this.finControlFormInRadioButton.UseVisualStyleBackColor = true;
            this.finControlFormInRadioButton.CheckedChanged += new System.EventHandler(this.finControlFormInRadioButton_CheckedChanged);
            // 
            // finControlFormOutRadioButton
            // 
            this.finControlFormOutRadioButton.AutoSize = true;
            this.finControlFormOutRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormOutRadioButton.Location = new System.Drawing.Point(315, 70);
            this.finControlFormOutRadioButton.Name = "finControlFormOutRadioButton";
            this.finControlFormOutRadioButton.Size = new System.Drawing.Size(75, 28);
            this.finControlFormOutRadioButton.TabIndex = 1;
            this.finControlFormOutRadioButton.TabStop = true;
            this.finControlFormOutRadioButton.Text = "Saída";
            this.finControlFormOutRadioButton.UseVisualStyleBackColor = true;
            // 
            // finControlFormComboBox
            // 
            this.finControlFormComboBox.DataSource = this.planoDeContasDebitoBindingSource;
            this.finControlFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finControlFormComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finControlFormComboBox.FormattingEnabled = true;
            this.finControlFormComboBox.Location = new System.Drawing.Point(388, 245);
            this.finControlFormComboBox.Name = "finControlFormComboBox";
            this.finControlFormComboBox.Size = new System.Drawing.Size(475, 32);
            this.finControlFormComboBox.TabIndex = 6;
            this.finControlFormComboBox.SelectedIndexChanged += new System.EventHandler(this.finControlFormComboBox_SelectedIndexChanged);
            // 
            // planoDeContasDebitoBindingSource
            // 
            this.planoDeContasDebitoBindingSource.DataMember = "PlanoDeContasDebito";
            this.planoDeContasDebitoBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planoDeContasCreditoBindingSource
            // 
            this.planoDeContasCreditoBindingSource.DataMember = "PlanoDeContasCredito";
            this.planoDeContasCreditoBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // planoDeContasCreditoTableAdapter
            // 
            this.planoDeContasCreditoTableAdapter.ClearBeforeFill = true;
            // 
            // planoDeContasDebitoTableAdapter
            // 
            this.planoDeContasDebitoTableAdapter.ClearBeforeFill = true;
            // 
            // codeContaTextBox
            // 
            this.codeContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeContaTextBox.Location = new System.Drawing.Point(301, 248);
            this.codeContaTextBox.Name = "codeContaTextBox";
            this.codeContaTextBox.Size = new System.Drawing.Size(81, 29);
            this.codeContaTextBox.TabIndex = 5;
            this.codeContaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeContaTextBox_KeyDown);
            this.codeContaTextBox.Leave += new System.EventHandler(this.codeContaTextBox_Leave);
            // 
            // FinControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 502);
            this.Controls.Add(this.codeContaTextBox);
            this.Controls.Add(this.finControlFormComboBox);
            this.Controls.Add(this.finControlFormOutRadioButton);
            this.Controls.Add(this.finControlFormInRadioButton);
            this.Controls.Add(this.finControlFormCancelButton);
            this.Controls.Add(this.finControlFormOkButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.finControlFormObsTextBox);
            this.Controls.Add(this.finControlFormCaixaTextBox);
            this.Controls.Add(this.finControlFormBankTextBox);
            this.Controls.Add(this.finControlFormDescTextBox);
            this.Controls.Add(this.finControlFormDocNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finControlFormDateTimePicker);
            this.Name = "FinControlForm";
            this.Text = "Controle Financeiro - Entradas e Saídas";
            this.Load += new System.EventHandler(this.FinControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasDebitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasCreditoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker finControlFormDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox finControlFormDocNumberTextBox;
        private System.Windows.Forms.TextBox finControlFormDescTextBox;
        private System.Windows.Forms.TextBox finControlFormBankTextBox;
        private System.Windows.Forms.TextBox finControlFormCaixaTextBox;
        private System.Windows.Forms.TextBox finControlFormObsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button finControlFormOkButton;
        private System.Windows.Forms.Button finControlFormCancelButton;
        private System.Windows.Forms.RadioButton finControlFormInRadioButton;
        private System.Windows.Forms.RadioButton finControlFormOutRadioButton;
        private System.Windows.Forms.ComboBox finControlFormComboBox;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource planoDeContasCreditoBindingSource;
        private igrejafont11DataSetTableAdapters.PlanoDeContasCreditoTableAdapter planoDeContasCreditoTableAdapter;
        private System.Windows.Forms.BindingSource planoDeContasDebitoBindingSource;
        private igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter planoDeContasDebitoTableAdapter;
        private System.Windows.Forms.TextBox codeContaTextBox;
    }
}