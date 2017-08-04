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

namespace TesourariaIFV
{
    public partial class FormGrupoPlanoDeContasRemove : Form
    {
        public FormGrupoPlanoDeContasRemove()
        {
            InitializeComponent();
        }

        private void FormGrupoPlanoDeContasRemove_Load(object sender, EventArgs e)
        {
            this.gruposPlanosDeContasTableAdapter.Fill(this.igrejafont11DataSet.GruposPlanosDeContas);

        }

        private void formGrupoRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formGrupoRemoveOkButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja remover o grupo: "+formGrupoRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            TesourariaIFV.loginInfo info = new loginInfo();

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("DELETE FROM GruposPlanosDeContas WHERE Codigo = @Codigo", conn);
                comm1.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Convert.ToInt16(formGrupoRemoveComboBox.SelectedValue.ToString());
                comm1.ExecuteReader();


                gruposPlanosDeContasBindingSource.RemoveAt(formGrupoRemoveComboBox.SelectedIndex);

                formGrupoRemoveComboBox.DataSource = null;
                formGrupoRemoveComboBox.DataSource = gruposPlanosDeContasBindingSource;
                formGrupoRemoveComboBox.DisplayMember = "Descricao";
                formGrupoRemoveComboBox.ValueMember = "Codigo";

                formGrupoRemoveComboBox.Update();
                formGrupoRemoveComboBox.Refresh();
                                
            }
             
        }
    }
}
