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
    public partial class FormIgrejasRemove : Form
    {
        public FormIgrejasRemove()
        {
            InitializeComponent();
        }

        private void formIgrejasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIgrejasRemove_Load(object sender, EventArgs e)
        {
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
        }

        private void formIgrejasRemoveOkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover a Igreja: " + formIgrejasRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            TesourariaIFV.loginInfo info = new loginInfo();

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("DELETE FROM Igrejas WHERE Nome = @Nome", conn);
                comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = formIgrejasRemoveComboBox.SelectedValue.ToString();
                comm1.ExecuteReader();

                igrejasBindingSource.RemoveAt(formIgrejasRemoveComboBox.SelectedIndex);

                formIgrejasRemoveComboBox.DataSource = null;
                formIgrejasRemoveComboBox.DataSource = igrejasBindingSource;
                formIgrejasRemoveComboBox.DisplayMember = "Nome";
                formIgrejasRemoveComboBox.ValueMember = "Nome";

                formIgrejasRemoveComboBox.Update();
                formIgrejasRemoveComboBox.Refresh();
            }
        }
    }
}
