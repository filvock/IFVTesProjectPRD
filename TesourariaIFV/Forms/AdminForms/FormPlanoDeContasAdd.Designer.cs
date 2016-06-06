namespace TesourariaIFV
{
    partial class FormPlanoDeContasAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanoDeContasAdd));
            this.formPlanoDeContasEntradaRadioButton = new System.Windows.Forms.RadioButton();
            this.formPlanoDeContasSaidaRadioButton = new System.Windows.Forms.RadioButton();
            this.formPlanoDeContasTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formPlanoDeContasComboBox = new System.Windows.Forms.ComboBox();
            this.gruposPlanosDeContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.formPlanoDeContasAddOkButton = new System.Windows.Forms.Button();
            this.formPlanoDeContasAddCancelButton = new System.Windows.Forms.Button();
            this.gruposPlanosDeContasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.GruposPlanosDeContasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gruposPlanosDeContasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formPlanoDeContasEntradaRadioButton
            // 
            this.formPlanoDeContasEntradaRadioButton.AutoSize = true;
            this.formPlanoDeContasEntradaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPlanoDeContasEntradaRadioButton.Location = new System.Drawing.Point(94, 53);
            this.formPlanoDeContasEntradaRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasEntradaRadioButton.Name = "formPlanoDeContasEntradaRadioButton";
            this.formPlanoDeContasEntradaRadioButton.Size = new System.Drawing.Size(93, 28);
            this.formPlanoDeContasEntradaRadioButton.TabIndex = 0;
            this.formPlanoDeContasEntradaRadioButton.TabStop = true;
            this.formPlanoDeContasEntradaRadioButton.Text = "Entrada";
            this.formPlanoDeContasEntradaRadioButton.UseVisualStyleBackColor = true;
            // 
            // formPlanoDeContasSaidaRadioButton
            // 
            this.formPlanoDeContasSaidaRadioButton.AutoSize = true;
            this.formPlanoDeContasSaidaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPlanoDeContasSaidaRadioButton.Location = new System.Drawing.Point(304, 53);
            this.formPlanoDeContasSaidaRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasSaidaRadioButton.Name = "formPlanoDeContasSaidaRadioButton";
            this.formPlanoDeContasSaidaRadioButton.Size = new System.Drawing.Size(75, 28);
            this.formPlanoDeContasSaidaRadioButton.TabIndex = 1;
            this.formPlanoDeContasSaidaRadioButton.TabStop = true;
            this.formPlanoDeContasSaidaRadioButton.Text = "Saída";
            this.formPlanoDeContasSaidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // formPlanoDeContasTextBox
            // 
            this.formPlanoDeContasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPlanoDeContasTextBox.Location = new System.Drawing.Point(304, 124);
            this.formPlanoDeContasTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasTextBox.Name = "formPlanoDeContasTextBox";
            this.formPlanoDeContasTextBox.Size = new System.Drawing.Size(404, 29);
            this.formPlanoDeContasTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // formPlanoDeContasComboBox
            // 
            this.formPlanoDeContasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruposPlanosDeContasBindingSource, "Codigo", true));
            this.formPlanoDeContasComboBox.DataSource = this.gruposPlanosDeContasBindingSource;
            this.formPlanoDeContasComboBox.DisplayMember = "Descricao";
            this.formPlanoDeContasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPlanoDeContasComboBox.FormattingEnabled = true;
            this.formPlanoDeContasComboBox.Location = new System.Drawing.Point(304, 194);
            this.formPlanoDeContasComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.formPlanoDeContasComboBox.Name = "formPlanoDeContasComboBox";
            this.formPlanoDeContasComboBox.Size = new System.Drawing.Size(404, 32);
            this.formPlanoDeContasComboBox.TabIndex = 4;
            this.formPlanoDeContasComboBox.ValueMember = "Codigo";
            // 
            // gruposPlanosDeContasBindingSource
            // 
            this.gruposPlanosDeContasBindingSource.DataMember = "GruposPlanosDeContas";
            this.gruposPlanosDeContasBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupo de contas";
            // 
            // formPlanoDeContasAddOkButton
            // 
            this.formPlanoDeContasAddOkButton.Location = new System.Drawing.Point(467, 366);
            this.formPlanoDeContasAddOkButton.Name = "formPlanoDeContasAddOkButton";
            this.formPlanoDeContasAddOkButton.Size = new System.Drawing.Size(115, 35);
            this.formPlanoDeContasAddOkButton.TabIndex = 6;
            this.formPlanoDeContasAddOkButton.Text = "Ok";
            this.formPlanoDeContasAddOkButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasAddOkButton.Click += new System.EventHandler(this.formPlanoDeContasAddOkButton_Click);
            // 
            // formPlanoDeContasAddCancelButton
            // 
            this.formPlanoDeContasAddCancelButton.Location = new System.Drawing.Point(588, 366);
            this.formPlanoDeContasAddCancelButton.Name = "formPlanoDeContasAddCancelButton";
            this.formPlanoDeContasAddCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formPlanoDeContasAddCancelButton.TabIndex = 7;
            this.formPlanoDeContasAddCancelButton.Text = "Cancel";
            this.formPlanoDeContasAddCancelButton.UseVisualStyleBackColor = true;
            this.formPlanoDeContasAddCancelButton.Click += new System.EventHandler(this.formPlanoDeContasAddCancelButton_Click);
            // 
            // gruposPlanosDeContasTableAdapter
            // 
            this.gruposPlanosDeContasTableAdapter.ClearBeforeFill = true;
            // 
            // FormPlanoDeContasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 428);
            this.Controls.Add(this.formPlanoDeContasAddCancelButton);
            this.Controls.Add(this.formPlanoDeContasAddOkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formPlanoDeContasComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formPlanoDeContasTextBox);
            this.Controls.Add(this.formPlanoDeContasSaidaRadioButton);
            this.Controls.Add(this.formPlanoDeContasEntradaRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPlanoDeContasAdd";
            this.Text = "Adicionar Conta";
            this.Load += new System.EventHandler(this.FormPlanoDeContasAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gruposPlanosDeContasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton formPlanoDeContasEntradaRadioButton;
        private System.Windows.Forms.RadioButton formPlanoDeContasSaidaRadioButton;
        private System.Windows.Forms.TextBox formPlanoDeContasTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formPlanoDeContasComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button formPlanoDeContasAddOkButton;
        private System.Windows.Forms.Button formPlanoDeContasAddCancelButton;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource gruposPlanosDeContasBindingSource;
        private igrejafont11DataSetTableAdapters.GruposPlanosDeContasTableAdapter gruposPlanosDeContasTableAdapter;
    }
}