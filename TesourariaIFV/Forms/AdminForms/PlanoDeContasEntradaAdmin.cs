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
    public partial class PlanoDeContasEntradaAdmin : Form
    {
        private int isEdit = 0;
        public PlanoDeContasEntradaAdmin()
        {
            InitializeComponent();
            formPlanoDeContasTextBox.Enabled = false;
            formPlanoDeContasTextBox.Text = "";
        }

        private void FormPlanoDeContasAdd_Load(object sender, EventArgs e)
        {            
            this.planoDeContasCreditoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasCredito);

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
        }

        private void formPlanoDeContasAddOkButton_Click(object sender, EventArgs e)
        {
            if (isEdit == 0)
            {
                TesourariaIFV.igrejafont11DataSet.PlanoDeContasCreditoRow newPlanoDeContasRow = igrejafont11DataSet.PlanoDeContasCredito.NewPlanoDeContasCreditoRow();

                newPlanoDeContasRow.Descricao = formPlanoDeContasTextBox.Text;
                newPlanoDeContasRow.Grupo = "Diversos";

                igrejafont11DataSet.PlanoDeContasCredito.Rows.Add(newPlanoDeContasRow);
                planoDeContasCreditoBindingSource.EndEdit();
                planoDeContasCreditoTableAdapter.Update(igrejafont11DataSet.PlanoDeContasCredito);
                this.planoDeContasCreditoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasCredito);
                formPlanoDeContasTextBox.Text = "";
                formPlanoDeContasTextBox.Enabled = false;

            }
            else
            {
                contasDataGridView.CurrentRow.Cells[1].Value = formPlanoDeContasTextBox.Text;
                planoDeContasCreditoBindingSource.EndEdit();
                planoDeContasCreditoTableAdapter.Update(igrejafont11DataSet.PlanoDeContasCredito);
                this.planoDeContasCreditoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasCredito);
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
                planoDeContasCreditoTableAdapter.Update(igrejafont11DataSet.PlanoDeContasCredito);
                formPlanoDeContasTextBox.Enabled = false;
                formPlanoDeContasTextBox.Text = "";
                
            }
            this.planoDeContasCreditoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasCredito);
        }
    }
}
