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
    public partial class IgrejasAdmin : Form
    {
        private int isEdit = 0;
        public IgrejasAdmin()
        {
            InitializeComponent();
            igrejasAdminTextBox.Enabled = false;
            igrejasAdminCidadeComboBox.Enabled = false;
            igrejasAdminEstadoComboBox.Enabled = false;
            igrejasAdminEstadoComboBox.Text = "";
            igrejasAdminTextBox.Text = "";
            igrejasAdminCidadeComboBox.Text = "";
        }

        private void FormIgrejasAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);

        }

        private void igrejasAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void igrejasAdminEditButton_Click(object sender, EventArgs e)
        {
            if (igrejasAdminTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                igrejasAdminTextBox.Enabled = true;
                igrejasAdminCidadeComboBox.Enabled = true;
                //igrejasAdminEstadoComboBox.Enabled = true;
                isEdit = 1;
            }
        }

        private void igrejasAdminAddButton_Click(object sender, EventArgs e)
        {
            igrejasAdminTextBox.Enabled = true;
            igrejasAdminCidadeComboBox.Enabled = true;
            //igrejasAdminEstadoComboBox.Enabled = true;
            igrejasAdminEstadoComboBox.Text = "";
            igrejasAdminTextBox.Text = "";
            igrejasAdminCidadeComboBox.Text = "";
            isEdit = 0;
        }

        private void igrejasAdminRemoveButton_Click(object sender, EventArgs e)
        {
            igrejafont11DataSetTableAdapters.IgrejasTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.IgrejasTableAdapter();

            if (isEdit == 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover a igreja: " + igrejasAdminTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    igrejasAdminDataGridView.Rows.RemoveAt(igrejasAdminDataGridView.CurrentRow.Index);
                    tableAdapter.Update(igrejafont11DataSet.Igrejas);
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;

                }
                else
                {
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Opção de Edição selecionada, por favor cancele edição para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
            cellMembersLabel.Text = igrejasAdminDataGridView.RowCount.ToString();
        }

        private void igrejasAdminSaveButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.IgrejasRow newRow = igrejafont11DataSet.Igrejas.NewIgrejasRow();
            igrejafont11DataSetTableAdapters.IgrejasTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.IgrejasTableAdapter();

            newRow.Cidade = igrejasAdminCidadeComboBox.Text;
            newRow.Estado = igrejasAdminEstadoComboBox.Text;
            newRow.Nome = igrejasAdminTextBox.Text;

            if (isEdit == 0)
            {
                try
                {
                    igrejasBindingSource.EndEdit();
                    igrejafont11DataSet.Igrejas.AddIgrejasRow(newRow);
                    tableAdapter.Update(igrejafont11DataSet.Igrejas);
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;
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
                    igrejasAdminDataGridView.CurrentRow.Cells[0].Value = igrejasAdminTextBox.Text;
                    igrejasAdminDataGridView.CurrentRow.Cells[1].Value = igrejasAdminCidadeComboBox.Text;
                    igrejasAdminDataGridView.CurrentRow.Cells[2].Value = igrejasAdminEstadoComboBox.Text;
                    igrejasBindingSource.EndEdit();
                    tableAdapter.Update(igrejafont11DataSet.Igrejas);
                    igrejasAdminEstadoComboBox.Text = "";
                    igrejasAdminCidadeComboBox.Text = "";
                    igrejasAdminTextBox.Text = "";
                    igrejasAdminTextBox.Enabled = false;
                    igrejasAdminEstadoComboBox.Enabled = false;
                    igrejasAdminCidadeComboBox.Enabled = false;
                    isEdit = 0;
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
            cellMembersLabel.Text = igrejasAdminDataGridView.RowCount.ToString();
        }

        private void igrejasAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            igrejasAdminTextBox.Text = igrejasAdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            igrejasAdminCidadeComboBox.Text = igrejasAdminDataGridView.CurrentRow.Cells[1].Value.ToString();
            igrejasAdminEstadoComboBox.Text = igrejasAdminDataGridView.CurrentRow.Cells[2].Value.ToString();

        }

        private void igrejasAdminCidadeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadosBindingSource.Filter = "sigla ='" + igrejasAdminCidadeComboBox.SelectedValue +"'";
        }
    }
}
