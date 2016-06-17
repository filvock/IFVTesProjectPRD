using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.Admin_Forms
{
    public partial class PlanoDeContasSaidaAdmin : Form
    {
        private int isEdit = 0;
        public PlanoDeContasSaidaAdmin()
        {
            InitializeComponent();
            formPlanoDeContasTextBox.Enabled = false;
            formPlanoDeContasTextBox.Text = "";
        }

        private void FormPlanoDeContasAdd_Load(object sender, EventArgs e)
        {            
            this.planoDeContasDebitoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasDebito);            
        }

        private void formPlanoDeContasAddOkButton_Click(object sender, EventArgs e)
        {
            if (isEdit == 0)
            {
                TesourariaIFV.igrejafont11DataSet.PlanoDeContasDebitoRow newPlanoDeContasRow = igrejafont11DataSet.PlanoDeContasDebito.NewPlanoDeContasDebitoRow();

                newPlanoDeContasRow.Descricao = formPlanoDeContasTextBox.Text;
                newPlanoDeContasRow.Grupo = "Diversos";

                igrejafont11DataSet.PlanoDeContasDebito.Rows.Add(newPlanoDeContasRow);
                planoDeContasDebitoBindingSource.EndEdit();
                planoDeContasDebitoTableAdapter.Update(igrejafont11DataSet.PlanoDeContasDebito);
                this.planoDeContasDebitoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasDebito);
                formPlanoDeContasTextBox.Text = "";
                formPlanoDeContasTextBox.Enabled = false;
            }
            else
            {
                contasDataGridView.CurrentRow.Cells[1].Value = formPlanoDeContasTextBox.Text;
                planoDeContasDebitoBindingSource.EndEdit();
                planoDeContasDebitoTableAdapter.Update(igrejafont11DataSet.PlanoDeContasDebito);
                this.planoDeContasDebitoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasDebito);
                isEdit = 0;
                formPlanoDeContasTextBox.Text = "";
                formPlanoDeContasTextBox.Enabled = false;

            }
        }

        private void formPlanoDeContasAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersAdminEditButton_Click(object sender, EventArgs e)
        {
            if (formPlanoDeContasTextBox.Text.Length != 0)
            {
                formPlanoDeContasTextBox.Enabled = true;
                isEdit = 1;
            }
        }

        private void usersAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formPlanoDeContasTextBox.Text = contasDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void usersAdminAddButton_Click(object sender, EventArgs e)
        {
            formPlanoDeContasTextBox.Enabled = true;
            formPlanoDeContasTextBox.Text = "";
        }

        private void usersAdminRemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover a conta: " + formPlanoDeContasTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                contasDataGridView.Rows.RemoveAt(contasDataGridView.CurrentRow.Index);
                planoDeContasDebitoTableAdapter.Update(igrejafont11DataSet.PlanoDeContasDebito);
                formPlanoDeContasTextBox.Enabled = false;
                formPlanoDeContasTextBox.Text = "";
                
            }
            this.planoDeContasDebitoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasDebito);
        }
    }
}
