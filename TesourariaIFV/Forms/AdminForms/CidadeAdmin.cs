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
    public partial class CidadeAdmin : Form
    {
        private int isEdit = 0;
        public CidadeAdmin()
        {
            InitializeComponent();
            cidadesAdminTextBox.Enabled = false;
            cidadesAdminComboBox.Enabled = false;
            cidadesAdminComboBox.Text = "";
            cidadesAdminTextBox.Text = "";
        }

        private void FormCidadeAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            cellMembersLabel.Text = cidadesAdminDataGridView.RowCount.ToString();
        }

        private void formCidadesAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCidadesAddOkButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.CidadesRow newCidadeRow = igrejafont11DataSet.Cidades.NewCidadesRow();
            igrejafont11DataSetTableAdapters.CidadesTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.CidadesTableAdapter();

            newCidadeRow.Estado = cidadesAdminComboBox.SelectedValue.ToString();
            newCidadeRow.Nome = cidadesAdminTextBox.Text;

            igrejafont11DataSet.Cidades.Rows.Add(newCidadeRow);
            tableAdapter.Update(igrejafont11DataSet.Cidades);

            cidadesAdminTextBox.Clear();
            
        }

        private void cidadesAdminEditButton_Click(object sender, EventArgs e)
        {
            if (cidadesAdminTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cidadesAdminTextBox.Enabled = true;
                cidadesAdminComboBox.Enabled = true;
                isEdit = 1;
            }
        }

        private void cidadesAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cidadesAdminTextBox.Text = cidadesAdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            cidadesAdminComboBox.Text = cidadesAdminDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void cidadesAdminAddButton_Click(object sender, EventArgs e)
        {
            cidadesAdminTextBox.Enabled = true;
            cidadesAdminComboBox.Enabled = true;
            cidadesAdminComboBox.Text = "";
            cidadesAdminTextBox.Text = "";
            isEdit = 0;
        }

        private void cidadesAdminRemoveButton_Click(object sender, EventArgs e)
        {
            igrejafont11DataSetTableAdapters.CidadesTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.CidadesTableAdapter();

            if (isEdit == 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover a cidade: " + cidadesAdminTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cidadesAdminDataGridView.Rows.RemoveAt(cidadesAdminDataGridView.CurrentRow.Index);
                    tableAdapter.Update(igrejafont11DataSet.Cidades);
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;

                }
                else
                {
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Opção de Edição selecionada, por favor cancele edição para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);
            cellMembersLabel.Text = cidadesAdminDataGridView.RowCount.ToString();
        }

        private void cidadesAdminSaveButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.CidadesRow newRow = igrejafont11DataSet.Cidades.NewCidadesRow();
            igrejafont11DataSetTableAdapters.CidadesTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.CidadesTableAdapter();

            newRow.Estado = cidadesAdminComboBox.Text;
            newRow.Nome = cidadesAdminTextBox.Text;

            if (isEdit == 0)
            {
                try
                {
                    cidadesBindingSource.EndEdit();
                    igrejafont11DataSet.Cidades.AddCidadesRow(newRow);
                    tableAdapter.Update(igrejafont11DataSet.Cidades);
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }
            else
            {
                try
                {

                    cidadesAdminDataGridView.CurrentRow.Cells[0].Value = cidadesAdminTextBox.Text;
                    cidadesAdminDataGridView.CurrentRow.Cells[1].Value = cidadesAdminComboBox.Text;

                    cidadesBindingSource.EndEdit();
                    tableAdapter.Update(igrejafont11DataSet.Cidades);
                    cidadesAdminComboBox.Text = "";
                    cidadesAdminTextBox.Text = "";
                    cidadesAdminTextBox.Enabled = false;
                    cidadesAdminComboBox.Enabled = false;
                    isEdit = 0;

                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }
            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);
            cellMembersLabel.Text = cidadesAdminDataGridView.RowCount.ToString();
        }

        private void cidadesAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
