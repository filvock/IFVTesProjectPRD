using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.MembersControlForm
{
    public partial class MembersAdminForm : Form
    {
        public MembersAdminForm()
        {
            InitializeComponent();

            membersListDataGridView.DefaultCellStyle.Font = new Font("Arial", 14);

            
        }

        private void FillIgrejasDropDown()
        {
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Presidente Estadual")
            {
                igrejasBindingSource.Filter = "Estado = '" + info.GetEstado() + "'";
            }
            else if (info.GetRole() == "Presidente Regional")
            {
                igrejasBindingSource.Filter = "Regiao = '" + info.GetRegiao() + "'";
            }
        }

        private void MembersAdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Membros' table. You can move, or remove it, as needed.
            this.membrosTableAdapter.Fill(this.igrejafont11DataSet.Membros);

            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                membersListComboBox.Visible = false;
                label1.Visible = false;
                membrosBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";

            }
            else
            {
                FillIgrejasDropDown();
                membrosBindingSource.Filter = "Igreja = '" + membersListComboBox.SelectedValue.ToString() + "'";
            }
            

        }

        private void membersListAddButton_Click(object sender, EventArgs e)
        {
            membersListNameTextBox.Enabled = true;

            membersListCodeTextBox.Text = "";
            membersListNameTextBox.Text = "";

        }

        private void membersListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            membersListCodeTextBox.Text = membersListDataGridView.CurrentRow.Cells[0].Value.ToString();
            membersListNameTextBox.Text = membersListDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void membersListEditButton_Click(object sender, EventArgs e)
        {
            if (membersListNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione um Membro da lista", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                membersListNameTextBox.Enabled = true;
            }

        }

        private void membersListCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void membersListSaveButton_Click(object sender, EventArgs e)
        {
            igrejafont11DataSetTableAdapters.MembrosTableAdapter adapter = new igrejafont11DataSetTableAdapters.MembrosTableAdapter();
            loginInfo info = new loginInfo();

            if (membersListCodeTextBox.Text.Equals(""))
            {
                TesourariaIFV.igrejafont11DataSet.MembrosRow newRow = igrejafont11DataSet.Membros.NewMembrosRow();

                newRow.Nome = membersListNameTextBox.Text;

                if (membersListComboBox.Visible) newRow.Igreja = membersListComboBox.Text;
                else newRow.Igreja = info.GetIgreja();

                try
                {
                    membrosBindingSource.EndEdit();
                    igrejafont11DataSet.Membros.AddMembrosRow(newRow);
                    adapter.Update(igrejafont11DataSet.Membros);

                    membersListCodeTextBox.Enabled = false;
                    membersListNameTextBox.Enabled = false;

                    membersListCodeTextBox.Text = "";
                    membersListNameTextBox.Text = "";
                }
                catch { MessageBox.Show("Adição Falhou!"); }

            }
            else
            {
                try
                {
                    membersListDataGridView.CurrentRow.Cells[1].Value = membersListNameTextBox.Text;
                    membrosBindingSource.EndEdit();
                    adapter.Update(igrejafont11DataSet.Membros);

                    membersListCodeTextBox.Enabled = false;
                    membersListNameTextBox.Enabled = false;

                    membersListCodeTextBox.Text = "";
                    membersListNameTextBox.Text = "";

                }
                catch { MessageBox.Show("Edição Falhou!"); }
            }
        }

        private void membersListDeleteButton_Click(object sender, EventArgs e)
        {
            igrejafont11DataSetTableAdapters.MembrosTableAdapter adapter = new igrejafont11DataSetTableAdapters.MembrosTableAdapter();

            DialogResult result = MessageBox.Show("Deseja remover o membro: " + membersListNameTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    membersListDataGridView.Rows.RemoveAt(membersListDataGridView.CurrentRow.Index);
                    adapter.Update(igrejafont11DataSet.Membros);
                    membersListCodeTextBox.Enabled = false;
                    membersListNameTextBox.Enabled = false;

                    membersListCodeTextBox.Text = "";
                    membersListNameTextBox.Text = "";

                    MessageBox.Show("Membro removido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { MessageBox.Show("Remoção falhou!"); }


            }
            else
            {
                membersListCodeTextBox.Enabled = false;
                membersListNameTextBox.Enabled = false;

                membersListCodeTextBox.Text = "";
                membersListNameTextBox.Text = "";

            }
        }

        private void membersListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (membersListComboBox.SelectedValue != null)
                membrosBindingSource.Filter = "Igreja = '" + membersListComboBox.SelectedValue.ToString() + "'";
        }
    }
}
