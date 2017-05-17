using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace TesourariaIFV.Forms.Admin_Forms
{
    public partial class FormUserRemove : Form
    {
        public FormUserRemove()
        {
            InitializeComponent();
        }

        private void formIgrejasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUserRemove_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.igrejafont11DataSet.Usuarios);

        }

        private void formIgrejasRemoveOkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover o Usuário: " + formUserRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            TesourariaIFV.loginInfo info = new loginInfo();

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("DELETE FROM Usuarios WHERE Nome = @Nome", conn);
                comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = formUserRemoveComboBox.SelectedValue.ToString();
                comm1.ExecuteReader();

                usuariosBindingSource.RemoveAt(formUserRemoveComboBox.SelectedIndex);

                formUserRemoveComboBox.DataSource = null;
                formUserRemoveComboBox.DataSource = usuariosBindingSource;
                formUserRemoveComboBox.DisplayMember = "Nome";
                formUserRemoveComboBox.ValueMember = "Nome";

                formUserRemoveComboBox.Update();
                formUserRemoveComboBox.Refresh();
            }
        }
    }
}
