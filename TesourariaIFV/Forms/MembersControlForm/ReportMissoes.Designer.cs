namespace TesourariaIFV.Forms.MembersControlForm
{
    partial class ReportMissoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportDizimoComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont11DataSet = new TesourariaIFV.igrejafont11DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.IgrejasTableAdapter();
            this.reportDizimosDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Janeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fevereiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Junho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Julho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dezembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleIndividualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleIndividualTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.ControleIndividualTableAdapter();
            this.membrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membrosTableAdapter = new TesourariaIFV.igrejafont11DataSetTableAdapters.MembrosTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDizimosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleIndividualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDizimoComboBox
            // 
            this.reportDizimoComboBox.DataSource = this.igrejasBindingSource;
            this.reportDizimoComboBox.DisplayMember = "Nome";
            this.reportDizimoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDizimoComboBox.FormattingEnabled = true;
            this.reportDizimoComboBox.Location = new System.Drawing.Point(158, 6);
            this.reportDizimoComboBox.Name = "reportDizimoComboBox";
            this.reportDizimoComboBox.Size = new System.Drawing.Size(294, 32);
            this.reportDizimoComboBox.TabIndex = 5;
            this.reportDizimoComboBox.ValueMember = "Nome";
            this.reportDizimoComboBox.SelectedIndexChanged += new System.EventHandler(this.reportDizimoComboBox_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar por Igreja";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // reportDizimosDataGridView
            // 
            this.reportDizimosDataGridView.AllowUserToAddRows = false;
            this.reportDizimosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDizimosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reportDizimosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDizimosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nome,
            this.Janeiro,
            this.Fevereiro,
            this.Marco,
            this.Abril,
            this.Maio,
            this.Junho,
            this.Julho,
            this.Agosto,
            this.Setembro,
            this.Outubro,
            this.Novembro,
            this.Dezembro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportDizimosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.reportDizimosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportDizimosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.reportDizimosDataGridView.Location = new System.Drawing.Point(0, 44);
            this.reportDizimosDataGridView.Name = "reportDizimosDataGridView";
            this.reportDizimosDataGridView.ReadOnly = true;
            this.reportDizimosDataGridView.Size = new System.Drawing.Size(873, 596);
            this.reportDizimosDataGridView.TabIndex = 7;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "DataColumn1";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // Janeiro
            // 
            this.Janeiro.HeaderText = "Janeiro";
            this.Janeiro.Name = "Janeiro";
            this.Janeiro.ReadOnly = true;
            // 
            // Fevereiro
            // 
            this.Fevereiro.HeaderText = "Fevereiro";
            this.Fevereiro.Name = "Fevereiro";
            this.Fevereiro.ReadOnly = true;
            // 
            // Marco
            // 
            this.Marco.HeaderText = "Março";
            this.Marco.Name = "Marco";
            this.Marco.ReadOnly = true;
            // 
            // Abril
            // 
            this.Abril.HeaderText = "Abril";
            this.Abril.Name = "Abril";
            this.Abril.ReadOnly = true;
            // 
            // Maio
            // 
            this.Maio.HeaderText = "Maio";
            this.Maio.Name = "Maio";
            this.Maio.ReadOnly = true;
            // 
            // Junho
            // 
            this.Junho.HeaderText = "Junho";
            this.Junho.Name = "Junho";
            this.Junho.ReadOnly = true;
            // 
            // Julho
            // 
            this.Julho.HeaderText = "Julho";
            this.Julho.Name = "Julho";
            this.Julho.ReadOnly = true;
            // 
            // Agosto
            // 
            this.Agosto.HeaderText = "Agosto";
            this.Agosto.Name = "Agosto";
            this.Agosto.ReadOnly = true;
            // 
            // Setembro
            // 
            this.Setembro.HeaderText = "Setembro";
            this.Setembro.Name = "Setembro";
            this.Setembro.ReadOnly = true;
            // 
            // Outubro
            // 
            this.Outubro.HeaderText = "Outubro";
            this.Outubro.Name = "Outubro";
            this.Outubro.ReadOnly = true;
            // 
            // Novembro
            // 
            this.Novembro.HeaderText = "Novembro";
            this.Novembro.Name = "Novembro";
            this.Novembro.ReadOnly = true;
            // 
            // Dezembro
            // 
            this.Dezembro.HeaderText = "Dezembro";
            this.Dezembro.Name = "Dezembro";
            this.Dezembro.ReadOnly = true;
            // 
            // controleIndividualBindingSource
            // 
            this.controleIndividualBindingSource.DataMember = "ControleIndividual";
            this.controleIndividualBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // controleIndividualTableAdapter
            // 
            this.controleIndividualTableAdapter.ClearBeforeFill = true;
            // 
            // membrosBindingSource
            // 
            this.membrosBindingSource.DataMember = "Membros";
            this.membrosBindingSource.DataSource = this.igrejafont11DataSet;
            // 
            // membrosTableAdapter
            // 
            this.membrosTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ano";
            // 
            // ReportMissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesourariaIFV.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 640);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportDizimosDataGridView);
            this.Controls.Add(this.reportDizimoComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ReportMissoes";
            this.Text = "Controle Individual de Dízimos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportDizimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDizimosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleIndividualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportDizimoComboBox;
        private System.Windows.Forms.Label label1;
        private igrejafont11DataSet igrejafont11DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private igrejafont11DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.DataGridView reportDizimosDataGridView;
        private System.Windows.Forms.BindingSource controleIndividualBindingSource;
        private igrejafont11DataSetTableAdapters.ControleIndividualTableAdapter controleIndividualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Janeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fevereiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abril;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Junho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Julho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Novembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dezembro;
        private System.Windows.Forms.BindingSource membrosBindingSource;
        private igrejafont11DataSetTableAdapters.MembrosTableAdapter membrosTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}