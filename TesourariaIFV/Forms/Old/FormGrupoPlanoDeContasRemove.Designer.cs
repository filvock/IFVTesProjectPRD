namespace TesourariaIFV
{
    partial class FormGrupoPlanoDeContasRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupoPlanoDeContasRemove));
            this.formGrupoRemoveOkButton = new System.Windows.Forms.Button();
            this.formGrupoRemoveCancelButton = new System.Windows.Forms.Button();
            this.formGrupoRemoveComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.gruposPlanosDeContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposPlanosDeContasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.GruposPlanosDeContasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposPlanosDeContasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formGrupoRemoveOkButton
            // 
            this.formGrupoRemoveOkButton.Location = new System.Drawing.Point(385, 352);
            this.formGrupoRemoveOkButton.Name = "formGrupoRemoveOkButton";
            this.formGrupoRemoveOkButton.Size = new System.Drawing.Size(117, 41);
            this.formGrupoRemoveOkButton.TabIndex = 0;
            this.formGrupoRemoveOkButton.Text = "Ok";
            this.formGrupoRemoveOkButton.UseVisualStyleBackColor = true;
            this.formGrupoRemoveOkButton.Click += new System.EventHandler(this.formGrupoRemoveOkButton_Click);
            // 
            // formGrupoRemoveCancelButton
            // 
            this.formGrupoRemoveCancelButton.Location = new System.Drawing.Point(519, 352);
            this.formGrupoRemoveCancelButton.Name = "formGrupoRemoveCancelButton";
            this.formGrupoRemoveCancelButton.Size = new System.Drawing.Size(117, 41);
            this.formGrupoRemoveCancelButton.TabIndex = 1;
            this.formGrupoRemoveCancelButton.Text = "Cancel";
            this.formGrupoRemoveCancelButton.UseVisualStyleBackColor = true;
            this.formGrupoRemoveCancelButton.Click += new System.EventHandler(this.formGrupoRemoveCancelButton_Click);
            // 
            // formGrupoRemoveComboBox
            // 
            this.formGrupoRemoveComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruposPlanosDeContasBindingSource, "Codigo", true));
            this.formGrupoRemoveComboBox.DataSource = this.gruposPlanosDeContasBindingSource;
            this.formGrupoRemoveComboBox.DisplayMember = "Descricao";
            this.formGrupoRemoveComboBox.FormattingEnabled = true;
            this.formGrupoRemoveComboBox.Location = new System.Drawing.Point(301, 154);
            this.formGrupoRemoveComboBox.Name = "formGrupoRemoveComboBox";
            this.formGrupoRemoveComboBox.Size = new System.Drawing.Size(319, 32);
            this.formGrupoRemoveComboBox.TabIndex = 2;
            this.formGrupoRemoveComboBox.ValueMember = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione Grupo a ser removido";
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposPlanosDeContasBindingSource
            // 
            this.gruposPlanosDeContasBindingSource.DataMember = "GruposPlanosDeContas";
            this.gruposPlanosDeContasBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // gruposPlanosDeContasTableAdapter
            // 
            this.gruposPlanosDeContasTableAdapter.ClearBeforeFill = true;
            // 
            // FormGrupoPlanoDeContasRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formGrupoRemoveComboBox);
            this.Controls.Add(this.formGrupoRemoveCancelButton);
            this.Controls.Add(this.formGrupoRemoveOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormGrupoPlanoDeContasRemove";
            this.Text = "Remover Grupo de Plano de Contas";
            this.Load += new System.EventHandler(this.FormGrupoPlanoDeContasRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposPlanosDeContasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formGrupoRemoveOkButton;
        private System.Windows.Forms.Button formGrupoRemoveCancelButton;
        private System.Windows.Forms.ComboBox formGrupoRemoveComboBox;
        private System.Windows.Forms.Label label1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource gruposPlanosDeContasBindingSource;
        private igrejafont11DataSetTableAdapters.GruposPlanosDeContasTableAdapter gruposPlanosDeContasTableAdapter;
    }
}