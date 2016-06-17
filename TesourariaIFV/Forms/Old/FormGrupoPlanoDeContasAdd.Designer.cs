namespace TesourariaIFV
{
    partial class FormGrupoPlanoDeContasAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupoPlanoDeContasAdd));
            this.formGrupoAddOkButton = new System.Windows.Forms.Button();
            this.formGrupoAddCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.formGrupoAddTextBox = new System.Windows.Forms.TextBox();
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formGrupoAddOkButton
            // 
            this.formGrupoAddOkButton.Location = new System.Drawing.Point(287, 354);
            this.formGrupoAddOkButton.Name = "formGrupoAddOkButton";
            this.formGrupoAddOkButton.Size = new System.Drawing.Size(115, 38);
            this.formGrupoAddOkButton.TabIndex = 0;
            this.formGrupoAddOkButton.Text = "Ok";
            this.formGrupoAddOkButton.UseVisualStyleBackColor = true;
            this.formGrupoAddOkButton.Click += new System.EventHandler(this.formGrupoAddOkButton_Click);
            // 
            // formGrupoAddCancelButton
            // 
            this.formGrupoAddCancelButton.Location = new System.Drawing.Point(408, 354);
            this.formGrupoAddCancelButton.Name = "formGrupoAddCancelButton";
            this.formGrupoAddCancelButton.Size = new System.Drawing.Size(120, 38);
            this.formGrupoAddCancelButton.TabIndex = 1;
            this.formGrupoAddCancelButton.Text = "Cancel";
            this.formGrupoAddCancelButton.UseVisualStyleBackColor = true;
            this.formGrupoAddCancelButton.Click += new System.EventHandler(this.formGrupoAddCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // formGrupoAddTextBox
            // 
            this.formGrupoAddTextBox.Location = new System.Drawing.Point(152, 119);
            this.formGrupoAddTextBox.Name = "formGrupoAddTextBox";
            this.formGrupoAddTextBox.Size = new System.Drawing.Size(333, 29);
            this.formGrupoAddTextBox.TabIndex = 3;
            // 
            // igrejafont11DataSet
            // 
            this.igrejafont11DataSet.DataSetName = "igrejafont11DataSet";
            this.igrejafont11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormGrupoPlanoDeContasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 425);
            this.Controls.Add(this.formGrupoAddTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formGrupoAddCancelButton);
            this.Controls.Add(this.formGrupoAddOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormGrupoPlanoDeContasAdd";
            this.Text = "Adicionar Grupo para Plano de Contas";
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formGrupoAddOkButton;
        private System.Windows.Forms.Button formGrupoAddCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formGrupoAddTextBox;
        private igrejafont11DataSet igrejafont11DataSet;
    }
}