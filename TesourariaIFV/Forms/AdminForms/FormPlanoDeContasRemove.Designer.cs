namespace TesourariaIFV
{
    partial class FormPlanoDeContasRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanoDeContasRemove));
            this.formPlanoDeContasRemoveEntradaRadioButton = new System.Windows.Forms.RadioButton();
            this.formPlanoDeContasRemoveSaidaRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.formPlanoDeContasRemoveComboBox = new System.Windows.Forms.ComboBox();
            this.planoDeContasCreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.formPlanoDeContasRemoveButton = new System.Windows.Forms.Button();
            this.formPlanoDeContasRemoveCancelButton = new System.Windows.Forms.Button();
            this.planoDeContasCreditoTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.PlanoDeContasCreditoTableAdapter();
            this.planoDeContasDebitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoDeContasDebitoTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasCreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasDebitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formPlanoDeContasRemoveEntradaRadioButton
            // 
            this.formPlanoDeContasRemoveEntradaRadioButton.AutoSize = true;
            this.formPlanoDeContasRemoveEntradaRadioButton.Location = new System.Drawing.Point(16, 78);
            this.formPlanoDeContasRemoveEntradaRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasRemoveEntradaRadioButton.Name = "formPlanoDeContasRemoveEntradaRadioButton";
            this.formPlanoDeContasRemoveEntradaRadioButton.Size = new System.Drawing.Size(93, 28);
            this.formPlanoDeContasRemoveEntradaRadioButton.TabIndex = 0;
            this.formPlanoDeContasRemoveEntradaRadioButton.TabStop = true;
            this.formPlanoDeContasRemoveEntradaRadioButton.Text = "Entrada";
            this.formPlanoDeContasRemoveEntradaRadioButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasRemoveEntradaRadioButton.CheckedChanged += new System.EventHandler(this.formPlanoDeContasRemoveEntradaRadioButton_CheckedChanged);
            // 
            // formPlanoDeContasRemoveSaidaRadioButton
            // 
            this.formPlanoDeContasRemoveSaidaRadioButton.AutoSize = true;
            this.formPlanoDeContasRemoveSaidaRadioButton.Location = new System.Drawing.Point(215, 78);
            this.formPlanoDeContasRemoveSaidaRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasRemoveSaidaRadioButton.Name = "formPlanoDeContasRemoveSaidaRadioButton";
            this.formPlanoDeContasRemoveSaidaRadioButton.Size = new System.Drawing.Size(75, 28);
            this.formPlanoDeContasRemoveSaidaRadioButton.TabIndex = 1;
            this.formPlanoDeContasRemoveSaidaRadioButton.TabStop = true;
            this.formPlanoDeContasRemoveSaidaRadioButton.Text = "Saída";
            this.formPlanoDeContasRemoveSaidaRadioButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasRemoveSaidaRadioButton.CheckedChanged += new System.EventHandler(this.formPlanoDeContasRemoveSaidaRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione Conta a ser removida";
            // 
            // formPlanoDeContasRemoveComboBox
            // 
            this.formPlanoDeContasRemoveComboBox.FormattingEnabled = true;
            this.formPlanoDeContasRemoveComboBox.Location = new System.Drawing.Point(296, 172);
            this.formPlanoDeContasRemoveComboBox.Name = "formPlanoDeContasRemoveComboBox";
            this.formPlanoDeContasRemoveComboBox.Size = new System.Drawing.Size(376, 32);
            this.formPlanoDeContasRemoveComboBox.TabIndex = 3;
            // 
            // planoDeContasCreditoBindingSource
            // 
            this.planoDeContasCreditoBindingSource.DataMember = "PlanoDeContasCredito";
            this.planoDeContasCreditoBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formPlanoDeContasRemoveButton
            // 
            this.formPlanoDeContasRemoveButton.Location = new System.Drawing.Point(429, 362);
            this.formPlanoDeContasRemoveButton.Name = "formPlanoDeContasRemoveButton";
            this.formPlanoDeContasRemoveButton.Size = new System.Drawing.Size(119, 42);
            this.formPlanoDeContasRemoveButton.TabIndex = 4;
            this.formPlanoDeContasRemoveButton.Text = "Ok";
            this.formPlanoDeContasRemoveButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasRemoveButton.Click += new System.EventHandler(this.formPlanoDeContasRemoveButton_Click);
            // 
            // formPlanoDeContasRemoveCancelButton
            // 
            this.formPlanoDeContasRemoveCancelButton.Location = new System.Drawing.Point(555, 362);
            this.formPlanoDeContasRemoveCancelButton.Name = "formPlanoDeContasRemoveCancelButton";
            this.formPlanoDeContasRemoveCancelButton.Size = new System.Drawing.Size(119, 42);
            this.formPlanoDeContasRemoveCancelButton.TabIndex = 5;
            this.formPlanoDeContasRemoveCancelButton.Text = "Cancel";
            this.formPlanoDeContasRemoveCancelButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasRemoveCancelButton.Click += new System.EventHandler(this.formPlanoDeContasRemoveCancelButton_Click);
            // 
            // planoDeContasCreditoTableAdapter
            // 
            this.planoDeContasCreditoTableAdapter.ClearBeforeFill = true;
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
            // FormPlanoDeContasRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 416);
            this.Controls.Add(this.formPlanoDeContasRemoveCancelButton);
            this.Controls.Add(this.formPlanoDeContasRemoveButton);
            this.Controls.Add(this.formPlanoDeContasRemoveComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formPlanoDeContasRemoveSaidaRadioButton);
            this.Controls.Add(this.formPlanoDeContasRemoveEntradaRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPlanoDeContasRemove";
            this.Text = "FormPlanoDeContasRemove";
            this.Load += new System.EventHandler(this.FormPlanoDeContasRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasCreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeContasDebitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton formPlanoDeContasRemoveEntradaRadioButton;
        private System.Windows.Forms.RadioButton formPlanoDeContasRemoveSaidaRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formPlanoDeContasRemoveComboBox;
        private System.Windows.Forms.Button formPlanoDeContasRemoveButton;
        private System.Windows.Forms.Button formPlanoDeContasRemoveCancelButton;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource planoDeContasCreditoBindingSource;
        private igrejafont11DataSetTableAdapters.PlanoDeContasCreditoTableAdapter planoDeContasCreditoTableAdapter;
        private System.Windows.Forms.BindingSource planoDeContasDebitoBindingSource;
        private igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter planoDeContasDebitoTableAdapter;
    }
}