using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV
{
    public partial class FormPlanoDeContasAdd : Form
    {
        public FormPlanoDeContasAdd()
        {
            InitializeComponent();
        }

        private void FormPlanoDeContasAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.GruposPlanosDeContas' table. You can move, or remove it, as needed.
            this.gruposPlanosDeContasTableAdapter.Fill(this.igrejafont11DataSet.GruposPlanosDeContas);
            formPlanoDeContasEntradaRadioButton.Checked = true;

        }

        private void formPlanoDeContasAddOkButton_Click(object sender, EventArgs e)
        {
            if (formPlanoDeContasEntradaRadioButton.Checked == true)
            {
                TesourariaIFV.igrejafont11DataSet.PlanoDeContasCreditoRow newPlanoDeContasRow = igrejafont11DataSet.PlanoDeContasCredito.NewPlanoDeContasCreditoRow();
                igrejafont11DataSetTableAdapters.PlanoDeContasCreditoTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.PlanoDeContasCreditoTableAdapter();

                newPlanoDeContasRow.Descricao = formPlanoDeContasTextBox.Text;
                newPlanoDeContasRow.Grupo = formPlanoDeContasComboBox.Text;

                igrejafont11DataSet.PlanoDeContasCredito.Rows.Add(newPlanoDeContasRow);
                tableAdapter.Update(igrejafont11DataSet.PlanoDeContasCredito);

            }
            else
            {
                TesourariaIFV.igrejafont11DataSet.PlanoDeContasDebitoRow newPlanoDeContasRow = igrejafont11DataSet.PlanoDeContasDebito.NewPlanoDeContasDebitoRow();
                igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.PlanoDeContasDebitoTableAdapter();

                newPlanoDeContasRow.Descricao = formPlanoDeContasTextBox.Text;
                newPlanoDeContasRow.Grupo = formPlanoDeContasComboBox.Text;

                igrejafont11DataSet.PlanoDeContasDebito.Rows.Add(newPlanoDeContasRow);
                tableAdapter.Update(igrejafont11DataSet.PlanoDeContasDebito);
            }

            formPlanoDeContasTextBox.Clear();
            

        }

        private void formPlanoDeContasAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


    }
}
