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
    public partial class TransferForm : Form
    {
        public TransferForm()
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
            caixaBcoRadioButton.Checked = true;

        }

         
        private void finControlFormOkButton_Click(object sender, EventArgs e)
        {
            loginInfo userInfo = new loginInfo();

            if (caixaBcoRadioButton.Checked == true)
            {
                if (valorTextBox.Text.Length != 0)
                {
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow1 = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();

                    newRow.Data = finControlFormDateTimePicker.Value;
                    newRow.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow.Descricao = finControlFormDescTextBox.Text;
                    newRow.Conta = "Transferência Caixa / Banco";
                    newRow.Igreja = userInfo.GetIgreja();
                    newRow.Valor = GetOut();
                    newRow.Obs = finControlFormObsTextBox.Text;
                    newRow.Origem = "Caixa";
                    newRow.Natureza = "Débito";
                    newRow.Usuario = userInfo.GetNome();
                    newRow.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);

                    newRow1.Data = finControlFormDateTimePicker.Value;
                    newRow1.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow1.Descricao = finControlFormDescTextBox.Text;
                    newRow1.Conta = "Transferência Caixa / Banco";
                    newRow1.Igreja = userInfo.GetIgreja();
                    newRow1.Valor = GetEntry();
                    newRow1.Obs = finControlFormObsTextBox.Text;
                    newRow1.Origem = "Banco";
                    newRow1.Natureza = "Crédito";
                    newRow1.Usuario = userInfo.GetNome();
                    newRow1.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow1);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
                }
            }
            else
            {
                if (valorTextBox.Text.Length != 0)
                {
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    TesourariaIFV.igrejafont11DataSet.TesourariaGeralRow newRow1 = igrejafont11DataSet.TesourariaGeral.NewTesourariaGeralRow();
                    igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.TesourariaGeralTableAdapter();

                    newRow.Data = finControlFormDateTimePicker.Value;
                    newRow.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow.Descricao = finControlFormDescTextBox.Text;
                    newRow.Conta = "Transferência Banco / Caixa";
                    newRow.Igreja = userInfo.GetIgreja();
                    newRow.Valor = GetOut();
                    newRow.Obs = finControlFormObsTextBox.Text;
                    newRow.Origem = "Banco";
                    newRow.Natureza = "Débito";
                    newRow.Usuario = userInfo.GetNome();
                    newRow.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);

                    newRow1.Data = finControlFormDateTimePicker.Value;
                    newRow1.NumDocumento = finControlFormDocNumberTextBox.Text;
                    newRow1.Descricao = finControlFormDescTextBox.Text;
                    newRow1.Conta = "Transferência Banco / Caixa";
                    newRow1.Igreja = userInfo.GetIgreja();
                    newRow1.Valor = GetEntry();
                    newRow1.Obs = finControlFormObsTextBox.Text;
                    newRow1.Origem = "Caixa";
                    newRow1.Natureza = "Crédito";
                    newRow1.Usuario = userInfo.GetNome();
                    newRow1.DataLanc = DateTime.Now;

                    igrejafont11DataSet.TesourariaGeral.Rows.Add(newRow1);
                    tableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
                }
            }

             CleanForm();
        }

        private float GetOut()
        {            
            String temp = valorTextBox.Text.Substring(3, valorTextBox.Text.Length - 3);
            float temp1 = Convert.ToSingle(temp) * -1;
            return temp1;            
        }

        private float GetEntry()
        {
            String temp = valorTextBox.Text.Substring(3, valorTextBox.Text.Length - 3);
            float temp1 = Convert.ToSingle(temp);
            return temp1;
        }

        private void CleanForm()
        {
            finControlFormDocNumberTextBox.Text = "";
            finControlFormDescTextBox.Text = "";
            valorTextBox.Text = "";
            finControlFormObsTextBox.Text = "";
        }

        private void finControlFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void finControlFormCaixaTextBox_Leave(object sender, EventArgs e)
        {
            
                if (valorTextBox.Text.Length != 0)
                valorTextBox.Text = Convert.ToDouble(valorTextBox.Text).ToString("C");
            
        }

        
        private void finControlFormCaixaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (!valorTextBox.Text.Contains(','))
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

        private void finControlFormCaixaTextBox_Enter(object sender, EventArgs e)
        {
            {
                String x = "";
                for (int i = 0; i <= valorTextBox.Text.Length - 1; i++)
                {
                    if ((valorTextBox.Text[i] >= '0' &&
                        valorTextBox.Text[i] <= '9') ||
                        valorTextBox.Text[i] == ',')
                    {
                        x += valorTextBox.Text[i];
                    }
                }
                valorTextBox.Text = x;
                valorTextBox.SelectAll();
            }

        }

    }
}
