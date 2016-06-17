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
    public partial class UserAdmin : Form
    {
        private int isEdit = 0;

        public UserAdmin()
        {
            InitializeComponent();
            usersAdminLoginTextBox.Enabled = false;
            usersAdminSenhaTextBox.Enabled = false;
            usersAdminCidadeComboBox.Enabled = false;
            usersAdminEstadoComboBox.Enabled = false;
            usersAdminIgrejaComboBox.Enabled = false;
            usersAdminRoleComboBox.Enabled = false;
            usersAdminIgrejaComboBox.Text = "";
            usersAdminCidadeComboBox.Text = "";
            usersAdminEstadoComboBox.Text = "";
            usersAdminRoleComboBox.Text = "";
            usersAdminLoginTextBox.Text = "";
            usersAdminSenhaTextBox.Text = "";
        }


        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
            this.usuariosTableAdapter.Fill(this.igrejafont11DataSet.Usuarios);
            cellMembersLabel.Text = usersAdminDataGridView.RowCount.ToString();

        }

        private void usersAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usersAdminLoginTextBox.Text = usersAdminDataGridView.CurrentRow.Cells[0].Value.ToString();
            usersAdminIgrejaComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[1].Value.ToString();
            usersAdminRoleComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[2].Value.ToString();
            usersAdminCidadeComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[3].Value.ToString();
            usersAdminEstadoComboBox.Text = usersAdminDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void usersAdminEditButton_Click(object sender, EventArgs e)
        {
            if (usersAdminLoginTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma cidade da lista para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usersAdminLoginTextBox.Enabled = true;
                usersAdminSenhaTextBox.Enabled = true;
                //usersAdminCidadeComboBox.Enabled = true;
                //usersAdminEstadoComboBox.Enabled = true;
                usersAdminIgrejaComboBox.Enabled = true;
                usersAdminRoleComboBox.Enabled = true;
                isEdit = 1;
            }
        }

        private void usersAdminAddButton_Click(object sender, EventArgs e)
        {
            usersAdminLoginTextBox.Enabled = true;
            usersAdminSenhaTextBox.Enabled = true;
            //usersAdminCidadeComboBox.Enabled = true;
            //usersAdminEstadoComboBox.Enabled = true;
            usersAdminIgrejaComboBox.Enabled = true;
            usersAdminRoleComboBox.Enabled = true;
            usersAdminIgrejaComboBox.Text = "";
            usersAdminCidadeComboBox.Text = "";
            usersAdminEstadoComboBox.Text = "";
            usersAdminRoleComboBox.Text = "";
            usersAdminLoginTextBox.Text = "";
            usersAdminSenhaTextBox.Text = "";
            isEdit = 0;
        }

        private void usersAdminRemoveButton_Click(object sender, EventArgs e)
        {
            igrejafont11DataSetTableAdapters.UsuariosTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.UsuariosTableAdapter();

            if (isEdit == 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover o usuário: " + usersAdminLoginTextBox.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usersAdminDataGridView.Rows.RemoveAt(usersAdminDataGridView.CurrentRow.Index);
                    tableAdapter.Update(igrejafont11DataSet.Usuarios);
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";

                }
                else
                {
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Opção de Edição selecionada, por favor cancele edição para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.usuariosTableAdapter.Fill(this.igrejafont11DataSet.Usuarios);
            cellMembersLabel.Text = usersAdminDataGridView.RowCount.ToString();
        }

        private void usersAdminSaveButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.UsuariosRow newRow = igrejafont11DataSet.Usuarios.NewUsuariosRow();
            
            if (isEdit == 0)
            {
                newRow.Nome = usersAdminLoginTextBox.Text;
                newRow.Senha = usersAdminSenhaTextBox.Text;
                newRow.Igreja = usersAdminIgrejaComboBox.Text;
                newRow.Role = usersAdminRoleComboBox.Text;
                newRow.Cidade = usersAdminCidadeComboBox.Text;
                newRow.Estado = usersAdminEstadoComboBox.Text;
                newRow.IsLogged = "No";
                newRow.FirstLogin = "yes";

                try
                {
                    usuariosBindingSource1.EndEdit();
                    igrejafont11DataSet.Usuarios.AddUsuariosRow(newRow);
                    usuariosTableAdapter.Update(igrejafont11DataSet.Usuarios);
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";
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
                    usersAdminDataGridView.CurrentRow.Cells[0].Value = usersAdminLoginTextBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[1].Value = usersAdminIgrejaComboBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[2].Value = usersAdminRoleComboBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[3].Value = usersAdminCidadeComboBox.Text;
                    usersAdminDataGridView.CurrentRow.Cells[4].Value = usersAdminEstadoComboBox.Text;

                    if (usersAdminSenhaTextBox.Text.Length != 0) usersAdminDataGridView.CurrentRow.Cells[5].Value = usersAdminSenhaTextBox.Text;

                    usuariosBindingSource1.EndEdit();
                    usuariosTableAdapter.Update(igrejafont11DataSet.Usuarios);
                    usersAdminLoginTextBox.Enabled = false;
                    usersAdminSenhaTextBox.Enabled = false;
                    usersAdminCidadeComboBox.Enabled = false;
                    usersAdminEstadoComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Enabled = false;
                    usersAdminRoleComboBox.Enabled = false;
                    usersAdminIgrejaComboBox.Text = "";
                    usersAdminCidadeComboBox.Text = "";
                    usersAdminEstadoComboBox.Text = "";
                    usersAdminRoleComboBox.Text = "";
                    usersAdminLoginTextBox.Text = "";
                    usersAdminSenhaTextBox.Text = "";
                    isEdit = 0;
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }

            }
            this.usuariosTableAdapter.Fill(this.igrejafont11DataSet.Usuarios);
            cellMembersLabel.Text = usersAdminDataGridView.RowCount.ToString();

        }

        private void usersAdminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void usersAdminIgrejaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidadesBindingSource.Filter = "Nome ='" + usersAdminIgrejaComboBox.SelectedValue + "'";
            estadosBindingSource.Filter = "sigla ='" + usersAdminCidadeComboBox.SelectedValue + "'"; 
        }
    }
}
