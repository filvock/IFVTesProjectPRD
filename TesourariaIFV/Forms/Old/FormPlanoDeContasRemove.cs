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
    public partial class FormPlanoDeContasRemove : Form
    {
        public FormPlanoDeContasRemove()
        {
            InitializeComponent();
        }

        private void FormPlanoDeContasRemove_Load(object sender, EventArgs e)
        {
            this.planoDeContasDebitoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasDebito);
            this.planoDeContasCreditoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasCredito);

        }

        private void formPlanoDeContasRemoveEntradaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            formPlanoDeContasRemoveComboBox.DataBindings.Clear();
            formPlanoDeContasRemoveComboBox.DataSource = null;
            
            
            if (formPlanoDeContasRemoveEntradaRadioButton.Checked == true)
            {
                this.formPlanoDeContasRemoveComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planoDeContasCreditoBindingSource, "Codigo", true));
                this.formPlanoDeContasRemoveComboBox.DataSource = this.planoDeContasCreditoBindingSource;
                this.formPlanoDeContasRemoveComboBox.DisplayMember = "Descricao";
                this.formPlanoDeContasRemoveComboBox.ValueMember = "Codigo";

            }
            else
            {
                this.formPlanoDeContasRemoveComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planoDeContasDebitoBindingSource, "Codigo", true));
                this.formPlanoDeContasRemoveComboBox.DataSource = this.planoDeContasDebitoBindingSource;
                this.formPlanoDeContasRemoveComboBox.DisplayMember = "Descricao";
                this.formPlanoDeContasRemoveComboBox.ValueMember = "Codigo";
            
            }
        }

        private void formPlanoDeContasRemoveSaidaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            formPlanoDeContasRemoveComboBox.DataBindings.Clear();
            formPlanoDeContasRemoveComboBox.DataSource = null;

            if (formPlanoDeContasRemoveEntradaRadioButton.Checked == true)
            {
                this.formPlanoDeContasRemoveComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planoDeContasCreditoBindingSource, "Codigo", true));
                this.formPlanoDeContasRemoveComboBox.DataSource = this.planoDeContasCreditoBindingSource;
                this.formPlanoDeContasRemoveComboBox.DisplayMember = "Descricao";
                this.formPlanoDeContasRemoveComboBox.ValueMember = "Codigo";

            }
            else
            {
                this.formPlanoDeContasRemoveComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planoDeContasDebitoBindingSource, "Codigo", true));
                this.formPlanoDeContasRemoveComboBox.DataSource = this.planoDeContasDebitoBindingSource;
                this.formPlanoDeContasRemoveComboBox.DisplayMember = "Descricao";
                this.formPlanoDeContasRemoveComboBox.ValueMember = "Codigo";

            }
        }

        private void formPlanoDeContasRemoveButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.loginInfo info = new loginInfo();
            if (formPlanoDeContasRemoveEntradaRadioButton.Checked == true)
            {
                DialogResult result = MessageBox.Show("Deseja remover o grupo: " + formPlanoDeContasRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 if (result == DialogResult.Yes)
                 {
                     SqlConnection conn = new SqlConnection(info.GetStringConnection());
                     conn.Open();

                     SqlCommand comm1 = new SqlCommand("DELETE FROM PlanoDeContasCredito WHERE Codigo = @Codigo", conn);
                     comm1.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Convert.ToInt16(formPlanoDeContasRemoveComboBox.SelectedValue.ToString());
                     comm1.ExecuteReader();

                     planoDeContasCreditoBindingSource.RemoveAt(formPlanoDeContasRemoveComboBox.SelectedIndex);

                     formPlanoDeContasRemoveComboBox.DataSource = null;
                     formPlanoDeContasRemoveComboBox.DataSource = planoDeContasCreditoBindingSource;
                     formPlanoDeContasRemoveComboBox.DisplayMember = "Descricao";
                     formPlanoDeContasRemoveComboBox.ValueMember = "Codigo";

                     formPlanoDeContasRemoveComboBox.Update();
                     formPlanoDeContasRemoveComboBox.Refresh();
                 }

            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja remover o grupo: " + formPlanoDeContasRemoveComboBox.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(info.GetStringConnection());
                    conn.Open();

                    SqlCommand comm1 = new SqlCommand("DELETE FROM PlanoDeContasDebito WHERE Codigo = @Codigo", conn);
                    comm1.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Convert.ToInt16(formPlanoDeContasRemoveComboBox.SelectedValue.ToString());
                    comm1.ExecuteReader();

                    planoDeContasDebitoBindingSource.RemoveAt(formPlanoDeContasRemoveComboBox.SelectedIndex);

                    formPlanoDeContasRemoveComboBox.DataSource = null;
                    formPlanoDeContasRemoveComboBox.DataSource = planoDeContasDebitoBindingSource;
                    formPlanoDeContasRemoveComboBox.DisplayMember = "Descricao";
                    formPlanoDeContasRemoveComboBox.ValueMember = "Codigo";

                    formPlanoDeContasRemoveComboBox.Update();
                    formPlanoDeContasRemoveComboBox.Refresh();
                }
            }            
        }

        private void formPlanoDeContasRemoveCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
