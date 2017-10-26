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
    public partial class EnterContribForm : Form
    {
        public EnterContribForm()
        {
            InitializeComponent();

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }

            enterContribDataGridView.DefaultCellStyle.Font = new Font("Arial", 14);
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

        private void MembersGeneralForm_Load(object sender, EventArgs e)
        {
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);
            this.membrosTableAdapter.Fill(this.igrejafont11DataSet.Membros);

            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                enterContribComboBox.Visible = false;
                label1.Visible = false;
                membrosBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
            }
            else
            {
                FillIgrejasDropDown();
                membrosBindingSource.Filter = "Igreja = '" + enterContribComboBox.SelectedValue.ToString() + "'";
            }


        }



        private void enterContribDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enterContribCodeTextBox.Text = enterContribDataGridView.CurrentRow.Cells[0].Value.ToString();
            enterContribNameTextBox.Text = enterContribDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void enterContribCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterContribSaveButton_Click(object sender, EventArgs e)
        {
            igrejafont11DataSetTableAdapters.ControleIndividualTableAdapter adapter = new igrejafont11DataSetTableAdapters.ControleIndividualTableAdapter();
            loginInfo info = new loginInfo();

            if (!enterContribCodeTextBox.Text.Equals(""))
            {
                TesourariaIFV.igrejafont11DataSet.ControleIndividualRow newRow = igrejafont11DataSet.ControleIndividual.NewControleIndividualRow();

                newRow.codMembro = Convert.ToInt32(enterContribCodeTextBox.Text);
                newRow.Data = enterContribDateTimePicker.Value;
                if (!enterContribDizimoTextBox.Text.Equals("")) newRow.Dizimo = GetValue(enterContribDizimoTextBox.Text);
                if (!enterContribPrimiciaTextBox.Text.Equals("")) newRow.Primicia = GetValue(enterContribPrimiciaTextBox.Text);
                if (!enterContribMissoesTextBox.Text.Equals("")) newRow.Missoes = GetValue(enterContribMissoesTextBox.Text);


                try
                {
                    igrejafont11DataSet.ControleIndividual.AddControleIndividualRow(newRow);
                    adapter.Update(igrejafont11DataSet.ControleIndividual);
                    MessageBox.Show("Valores adicionados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enterContribDizimoTextBox.Text = "";
                    enterContribPrimiciaTextBox.Text = "";
                    enterContribMissoesTextBox.Text = "";
                }
                catch { MessageBox.Show("Adição Falhou! Tente Novamente!"); }

            }
            else
            {
                MessageBox.Show("Por Favor escolha um membro da lista.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private float GetValue(String valueStr)
        {
            String temp = valueStr.Substring(3, valueStr.Length - 3);
            float temp1 = Convert.ToSingle(temp);
            return temp1;
        }

        private void enterContribDizimoTextBox_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= enterContribDizimoTextBox.Text.Length - 1; i++)
            {
                if ((enterContribDizimoTextBox.Text[i] >= '0' &&
                    enterContribDizimoTextBox.Text[i] <= '9') ||
                    enterContribDizimoTextBox.Text[i] == ',')
                {
                    x += enterContribDizimoTextBox.Text[i];
                }
            }
            enterContribDizimoTextBox.Text = x;
            enterContribDizimoTextBox.SelectAll();
        }

        private void enterContribPrimiciaTextBox_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= enterContribPrimiciaTextBox.Text.Length - 1; i++)
            {
                if ((enterContribPrimiciaTextBox.Text[i] >= '0' &&
                    enterContribPrimiciaTextBox.Text[i] <= '9') ||
                    enterContribPrimiciaTextBox.Text[i] == ',')
                {
                    x += enterContribPrimiciaTextBox.Text[i];
                }
            }
            enterContribPrimiciaTextBox.Text = x;
            enterContribPrimiciaTextBox.SelectAll();
        }

        private void enterContribMissoesTextBox_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= enterContribMissoesTextBox.Text.Length - 1; i++)
            {
                if ((enterContribMissoesTextBox.Text[i] >= '0' &&
                    enterContribMissoesTextBox.Text[i] <= '9') ||
                    enterContribMissoesTextBox.Text[i] == ',')
                {
                    x += enterContribMissoesTextBox.Text[i];
                }
            }
            enterContribMissoesTextBox.Text = x;
            enterContribMissoesTextBox.SelectAll();
        }

        private void enterContribDizimoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                   (e.KeyChar != ',' && e.KeyChar != '.' &&
                    e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!enterContribDizimoTextBox.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void enterContribPrimiciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                   (e.KeyChar != ',' && e.KeyChar != '.' &&
                    e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!enterContribPrimiciaTextBox.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void enterContribMissoesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                  (e.KeyChar != ',' && e.KeyChar != '.' &&
                   e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!enterContribMissoesTextBox.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void enterContribDizimoTextBox_Leave(object sender, EventArgs e)
        {
            if (enterContribDizimoTextBox.Text.Length != 0)
                enterContribDizimoTextBox.Text = Convert.ToDouble(enterContribDizimoTextBox.Text).ToString("C");
        }

        private void enterContribPrimiciaTextBox_Leave(object sender, EventArgs e)
        {
            if (enterContribPrimiciaTextBox.Text.Length != 0)
                enterContribPrimiciaTextBox.Text = Convert.ToDouble(enterContribPrimiciaTextBox.Text).ToString("C");
        }

        private void enterContribMissoesTextBox_Leave(object sender, EventArgs e)
        {
            if (enterContribMissoesTextBox.Text.Length != 0)
                enterContribMissoesTextBox.Text = Convert.ToDouble(enterContribMissoesTextBox.Text).ToString("C");
        }

        private void enterContribComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enterContribComboBox.SelectedValue != null)
                membrosBindingSource.Filter = "Igreja = '" + enterContribComboBox.SelectedValue.ToString() + "'";
        }

        private void enterContribNameTextBox_TextChanged(object sender, EventArgs e)
        {
            membrosBindingSource.Filter = "Igreja = '" + enterContribComboBox.SelectedValue.ToString() + "' AND Nome like '%" + enterContribNameTextBox.Text + "%'";
        }
    }
}
