using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms
{
    public partial class FinControlForm : Form
    {
        public FinControlForm()
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
            finControlFormInRadioButton.Checked = true;

        }

         
        private void finControlFormOkButton_Click(object sender, EventArgs e)
        {
            loginInfo userInfo = new loginInfo();

            if(finControlFormInRadioButton.Checked == true)
            {
                if (finControlFormBankTextBox.Text.Length != 0)
                {
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();
      
                    newRow.Data = finControlFormDateTimePicker.Value;
                    newRow.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow.Descricao = finControlFormDescTextBox.Text;
                    newRow.Conta = finControlFormComboBox.Text;
                    newRow.Igreja = userInfo.GetIgreja();
                    newRow.Valor = GetBankValue();
                    newRow.Obs = finControlFormObsTextBox.Text;
                    newRow.Origem = "Banco";
                    newRow.Natureza = "Crédito";
                    newRow.Usuario = userInfo.GetNome();
                    newRow.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
                }
                if (finControlFormCaixaTextBox.Text.Length != 0)
                {
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();
      
                    newRow.Data = finControlFormDateTimePicker.Value;
                    newRow.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow.Descricao = finControlFormDescTextBox.Text;
                    newRow.Conta = finControlFormComboBox.Text;
                    newRow.Igreja = userInfo.GetIgreja();
                    newRow.Valor = GetCaixaValue();
                    newRow.Obs = finControlFormObsTextBox.Text;
                    newRow.Origem = "Caixa";
                    newRow.Natureza = "Crédito";
                    newRow.Usuario = userInfo.GetNome();
                    newRow.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
                }
            }
            else
            {
                if (finControlFormBankTextBox.Text.Length != 0)
                {
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();

                    newRow.Data = finControlFormDateTimePicker.Value;
                    newRow.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow.Descricao = finControlFormDescTextBox.Text;
                    newRow.Conta = finControlFormComboBox.Text;
                    newRow.Igreja = userInfo.GetIgreja();
                    newRow.Valor = GetBankValue();
                    newRow.Obs = finControlFormObsTextBox.Text;
                    newRow.Origem = "Banco";
                    newRow.Natureza = "Débito";
                    newRow.Usuario = userInfo.GetNome();
                    newRow.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
                }
                if (finControlFormCaixaTextBox.Text.Length != 0)
                {
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();

                    newRow.Data = finControlFormDateTimePicker.Value;
                    newRow.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow.Descricao = finControlFormDescTextBox.Text;
                    newRow.Conta = finControlFormComboBox.Text;
                    newRow.Igreja = userInfo.GetIgreja();
                    newRow.Valor = GetCaixaValue();
                    newRow.Obs = finControlFormObsTextBox.Text;
                    newRow.Origem = "Caixa";
                    newRow.Natureza = "Débito";
                    newRow.Usuario = userInfo.GetNome();
                    newRow.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
                }
            }

             CleanForm();
        }

        private float GetCaixaValue()
        {
            if (finControlFormOutRadioButton.Checked == true)
            {
                String temp = finControlFormCaixaTextBox.Text.Substring(3, finControlFormCaixaTextBox.Text.Length - 3);
                float temp1 = Convert.ToSingle(temp) * -1;
                return temp1;
            }
            else
            {
                String temp = finControlFormCaixaTextBox.Text.Substring(3, finControlFormCaixaTextBox.Text.Length - 3);
                float temp1 = Convert.ToSingle(temp);
                return temp1;
            }
        }

        private float GetBankValue()
        {
            if (finControlFormOutRadioButton.Checked == true)
            {
                String temp = finControlFormBankTextBox.Text.Substring(3, finControlFormBankTextBox.Text.Length - 3);
                float temp1 = Convert.ToSingle(temp) * -1;
                return temp1;
            }
            else
            {
                String temp = finControlFormBankTextBox.Text.Substring(3, finControlFormBankTextBox.Text.Length - 3);
                float temp1 = Convert.ToSingle(temp);
                return temp1;
            }

        }

      
        private void CleanForm()
        {
            finControlFormDocNumberTextBox.Text = "";
            finControlFormDescTextBox.Text = "";
            finControlFormComboBox.ValueMember = "";
            finControlFormCaixaTextBox.Text = "";
            finControlFormBankTextBox.Text = "";
            finControlFormObsTextBox.Text = "";
        }

        private void finControlFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinControlForm_Load(object sender, EventArgs e)
        {
            this.planoDeContasDebitoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasDebito);
            this.planoDeContasCreditoTableAdapter.Fill(this.igrejafont11DataSet.PlanoDeContasCredito);

            this.planoDeContasCreditoBindingSource.Sort = "Descricao ASC";
            this.planoDeContasDebitoBindingSource.Sort = "Descricao ASC";            
        }

        private void finControlFormBankTextBox_Leave(object sender, EventArgs e)
        {
            
            if (finControlFormBankTextBox.Text.Length != 0)
                finControlFormBankTextBox.Text = Convert.ToDouble(finControlFormBankTextBox.Text).ToString("C");
        }

        private void finControlFormCaixaTextBox_Leave(object sender, EventArgs e)
        {
            
                if (finControlFormCaixaTextBox.Text.Length != 0)
                finControlFormCaixaTextBox.Text = Convert.ToDouble(finControlFormCaixaTextBox.Text).ToString("C");
            
        }

        private void finControlFormBankTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (!finControlFormBankTextBox.Text.Contains(','))
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

        private void finControlFormCaixaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            //{
            //    MessageBox.Show("Este Campo aceita apenas Numeros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    finControlFormCaixaTextBox.ResetText();
            //    finControlFormCaixaTextBox.Update();
            //}
            //else
            //{
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
                        if (!finControlFormCaixaTextBox.Text.Contains(','))
                        {
                            e.KeyChar = ',';
                        }
                        else
                        {
                            e.KeyChar = (Char)0;
                        }
                    }
                }
            //}
        }

        private void finControlFormBankTextBox_Enter(object sender, EventArgs e)
        {
             {
                String x = "";
                for (int i = 0; i <= finControlFormBankTextBox.Text.Length - 1; i++)
                {
                    if ((finControlFormBankTextBox.Text[i] >= '0' &&
                        finControlFormBankTextBox.Text[i] <= '9') ||
                        finControlFormBankTextBox.Text[i] == ',')
                    {
                        x += finControlFormBankTextBox.Text[i];
                    }
                }
                finControlFormBankTextBox.Text = x;
                finControlFormBankTextBox.SelectAll();
            }

        }
        

        private void finControlFormCaixaTextBox_Enter(object sender, EventArgs e)
        {
            {
                String x = "";
                for (int i = 0; i <= finControlFormCaixaTextBox.Text.Length - 1; i++)
                {
                    if ((finControlFormCaixaTextBox.Text[i] >= '0' &&
                        finControlFormCaixaTextBox.Text[i] <= '9') ||
                        finControlFormCaixaTextBox.Text[i] == ',')
                    {
                        x += finControlFormCaixaTextBox.Text[i];
                    }
                }
                finControlFormCaixaTextBox.Text = x;
                finControlFormCaixaTextBox.SelectAll();
            }

        }

        private void finControlFormInRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (finControlFormInRadioButton.Checked == true)
            {
                this.finControlFormComboBox.DataSource = null;
                this.finControlFormComboBox.Items.Clear();
                this.finControlFormComboBox.DataSource = this.planoDeContasCreditoBindingSource;
                this.finControlFormComboBox.DisplayMember = "Descricao";
                this.finControlFormComboBox.ValueMember = "Codigo";
             
            }
            else
            {
                if (finControlFormOutRadioButton.Checked == true)
                {
                    this.finControlFormComboBox.DataSource = null;
                    this.finControlFormComboBox.Items.Clear();
                    this.finControlFormComboBox.DataSource = this.planoDeContasDebitoBindingSource;
                    this.finControlFormComboBox.DisplayMember = "Descricao";
                    this.finControlFormComboBox.ValueMember = "Codigo";
                    
                 }        
            }           
        }

        private void codeContaTextBox_Leave(object sender, EventArgs e)
        {
            if (codeContaTextBox.Text.Length > 0)
            {
                SetContaComboBox(codeContaTextBox.Text);
            }
        }

        private void codeContaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (codeContaTextBox.Text.Length > 0)
                {
                    SetContaComboBox(codeContaTextBox.Text);
                }
            }
        }

        private void SetContaComboBox(String Code)
        {
            if (finControlFormInRadioButton.Checked == true)
            {
                planoDeContasCreditoBindingSource.Position = planoDeContasCreditoBindingSource.Find("Codigo", Code);
                if (planoDeContasCreditoBindingSource.Position < 0)
                {
                    MessageBox.Show("Conta não existe para esse código, por favor entre novo código.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else
                //{
                //    DataRowView row = (DataRowView)planoDeContasCreditoBindingSource.Current;
                //    finControlFormComboBox.SelectedText = row["Descricao"].ToString();
                //}
            }
            else if (finControlFormOutRadioButton.Checked == true)
            {
                planoDeContasDebitoBindingSource.Position = planoDeContasDebitoBindingSource.Find("Codigo", Code);
                if (planoDeContasDebitoBindingSource.Position < 0)
                {
                    MessageBox.Show("Conta não existe para esse código, por favor entre novo código.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else
                //{
                //    DataRowView row = (DataRowView)planoDeContasDebitoBindingSource.Current;
                //    finControlFormComboBox.SelectedText = row["Descricao"].ToString();
                //}
            }
        }

        private void finControlFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finControlFormComboBox.SelectedItem != null)
            {

                if (finControlFormInRadioButton.Checked == true)
                {
                    //planoDeContasCreditoBindingSource.Position = planoDeContasCreditoBindingSource.Find("Descricao", finControlFormComboBox.SelectedItem.ToString());
                    DataRowView row = (DataRowView)finControlFormComboBox.SelectedItem;
                    codeContaTextBox.Text = row["Codigo"].ToString();

                }
                else if (finControlFormOutRadioButton.Checked == true)
                {
                    //planoDeContasDebitoBindingSource.Position = planoDeContasDebitoBindingSource.Find("Descricao", finControlFormComboBox.SelectedItem.ToString());
                    DataRowView row = (DataRowView)finControlFormComboBox.SelectedItem;
                    codeContaTextBox.Text = row["Codigo"].ToString();

                }
            }
        }
    }
}
