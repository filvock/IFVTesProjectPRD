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
    public partial class EditContrib : Form
    {
        public EditContrib()
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

            dataGridView.DefaultCellStyle.Font = new Font("Arial", 14);

            
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
            this.controleIndividual1TableAdapter.FillBy(this.igrejafont11DataSet.ControleIndividual1);
            this.controleIndividualTableAdapter.Fill(this.igrejafont11DataSet.ControleIndividual);
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);
            
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                membersListComboBox.Visible = false;
                label1.Visible = false;
                controleIndividual1BindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";

            }
            else
            {
                FillIgrejasDropDown();
                controleIndividual1BindingSource.Filter = "Igreja = '" + membersListComboBox.SelectedValue.ToString() + "'";
            }
            //SetValuesToMoney();
        }

        
        private void membersListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codeTextBox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            dizimoTextBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            primiciaTextBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            missoesTextBox.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        

        private void membersListCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void membersListSaveButton_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Equals(""))
            {
                MessageBox.Show("Selecione uma entrada da tabela para editar.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                controleIndividualBindingSource.Position = controleIndividualBindingSource.Find("CodLancamento", dataGridView.CurrentRow.Cells[6].Value.ToString());
                DataRowView row = (DataRowView)controleIndividualBindingSource.Current;


                row["Data"] = dateTimePicker.Text;
                if (dizimoTextBox.Text.Length == 0 || ConvertMoneyToInt(dizimoTextBox.Text) == 0) row["Dizimo"] = 0;
                else row["Dizimo"] = GetValue(dizimoTextBox.Text);
                if (primiciaTextBox.Text.Length == 0 || ConvertMoneyToInt(primiciaTextBox.Text) == 0) row["Primicia"] = 0;
                else row["Primicia"] = GetValue(primiciaTextBox.Text);
                if (missoesTextBox.Text.Length == 0 || ConvertMoneyToInt(missoesTextBox.Text) == 0) row["Missoes"] = 0;
                else row["Missoes"] = GetValue(missoesTextBox.Text);
                try
                {
                    controleIndividualBindingSource.EndEdit();
                    controleIndividualTableAdapter.Update(igrejafont11DataSet.ControleIndividual);

                    codeTextBox.Text = "";
                    nameTextBox.Text = "";
                    dizimoTextBox.Text = "";
                    primiciaTextBox.Text = "";
                    missoesTextBox.Text = "";
                    controleIndividual1TableAdapter.FillBy(igrejafont11DataSet.ControleIndividual1);
                }
                catch { MessageBox.Show("Edição Falhou!"); }
            }
            //SetValuesToMoney();
        }

        private int ConvertMoneyToInt(String money)
        {
            int valor=0;

            if (money.Length == 1)
            {
                valor = Convert.ToInt32(money);
            }
            else if (money.Length == 0)
            {
                valor = 0;
            }
            else
            {
                valor = Convert.ToInt32(money.Substring(3, money.Length - 6));
            }
            return valor;
        }

        private float GetValue(String valueStr)
        {
            String temp = valueStr.Substring(3, valueStr.Length - 3);
            float temp1 = Convert.ToSingle(temp);
            return temp1;
        }

        private void membersListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (membersListComboBox.SelectedValue != null)
                controleIndividual1BindingSource.Filter = "Igreja = '" + membersListComboBox.SelectedValue.ToString() + "'";
        }

        private void enterContribDizimoTextBox_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= dizimoTextBox.Text.Length - 1; i++)
            {
                if ((dizimoTextBox.Text[i] >= '0' &&
                    dizimoTextBox.Text[i] <= '9') ||
                    dizimoTextBox.Text[i] == ',')
                {
                    x += dizimoTextBox.Text[i];
                }
            }
            dizimoTextBox.Text = x;
            dizimoTextBox.SelectAll();
        }

        private void enterContribPrimiciaTextBox_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= primiciaTextBox.Text.Length - 1; i++)
            {
                if ((primiciaTextBox.Text[i] >= '0' &&
                    primiciaTextBox.Text[i] <= '9') ||
                    primiciaTextBox.Text[i] == ',')
                {
                    x += primiciaTextBox.Text[i];
                }
            }
            primiciaTextBox.Text = x;
            primiciaTextBox.SelectAll();
        }

        private void enterContribMissoesTextBox_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= missoesTextBox.Text.Length - 1; i++)
            {
                if ((missoesTextBox.Text[i] >= '0' &&
                    missoesTextBox.Text[i] <= '9') ||
                    missoesTextBox.Text[i] == ',')
                {
                    x += missoesTextBox.Text[i];
                }
            }
            missoesTextBox.Text = x;
            missoesTextBox.SelectAll();
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
                    if (!dizimoTextBox.Text.Contains(','))
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
                    if (!primiciaTextBox.Text.Contains(','))
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
                    if (!missoesTextBox.Text.Contains(','))
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
            if (dizimoTextBox.Text.Length != 0)
                dizimoTextBox.Text = Convert.ToDouble(dizimoTextBox.Text).ToString("C");
        }

        private void enterContribPrimiciaTextBox_Leave(object sender, EventArgs e)
        {
            if (primiciaTextBox.Text.Length != 0)
                primiciaTextBox.Text = Convert.ToDouble(primiciaTextBox.Text).ToString("C");
        }

        private void enterContribMissoesTextBox_Leave(object sender, EventArgs e)
        {
            if (missoesTextBox.Text.Length != 0)
                missoesTextBox.Text = Convert.ToDouble(missoesTextBox.Text).ToString("C");
        }

        private void SetValuesToMoney()
        {
            int count = dataGridView.RowCount;

            for (int i = 0; i < count; i++)
            {
                if (dataGridView.Rows[i].Cells[3].Value != null && dataGridView.Rows[i].Cells[3].Value.ToString().Length != 0 && !dataGridView.Rows[i].Cells[3].Value.ToString().Equals("0"))
                    dataGridView.Rows[i].Cells[3].Value = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value).ToString("C");
                if (dataGridView.Rows[i].Cells[4].Value != null && dataGridView.Rows[i].Cells[4].Value.ToString().Length != 0 && !dataGridView.Rows[i].Cells[4].Value.ToString().Equals("0"))
                    dataGridView.Rows[i].Cells[4].Value = Convert.ToDouble(dataGridView.Rows[i].Cells[4].Value).ToString("C");
                if (dataGridView.Rows[i].Cells[5].Value != null && dataGridView.Rows[i].Cells[5].Value.ToString().Length != 0 && !dataGridView.Rows[i].Cells[4].Value.ToString().Equals("0"))
                    dataGridView.Rows[i].Cells[5].Value = Convert.ToDouble(dataGridView.Rows[i].Cells[5].Value).ToString("C");
            }
        }
    }
}
