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
    public partial class FormUserAdd : Form
    {
        public FormUserAdd()
        {
            InitializeComponent();
        }

        private void formIgrejasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);

        }

        private void formIgrejasRemoveOkButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.UsuariosRow newUser = igrejafont11DataSet.Usuarios.NewUsuariosRow();
            igrejafont11DataSetTableAdapters.UsuariosTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.UsuariosTableAdapter();

            newUser.Nome = formUserAddNomeTextBox.Text;
            newUser.Senha = formUserAddSenhaTextBox.Text;
            newUser.Igreja = formUserAddIgrejaComboBox.SelectedValue.ToString();
            newUser.Role = formUserAddRoleComboBox.Text;
            newUser.IsLogged = "No";
            newUser.FirstLogin = "yes";
            newUser.Cidade = formUserAddCidadeComboBox.SelectedValue.ToString();
            newUser.Estado = formUserAddEstadoComboBox.SelectedValue.ToString();

            igrejafont11DataSet.Usuarios.Rows.Add(newUser);
            tableAdapter.Update(igrejafont11DataSet.Usuarios);

            formUserAddNomeTextBox.Clear();
            formUserAddSenhaTextBox.Clear();
        }


    }
}
