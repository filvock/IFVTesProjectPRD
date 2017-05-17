using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.Reports_Forms
{
    public partial class ReportPlanoDeContasDetalhes : Form
    {
        public ReportPlanoDeContasDetalhes()
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

            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                reportPlanoDeContasComboBox.Visible = false;
                label4.Visible = false;
            }
            else
            {
                FillIgrejasDropDown();
            }
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

        private void reportPlanoDeContasCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportPlanoDeContasOkButton_Click(object sender, EventArgs e)
        {
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                if (reportPlanoDeContasMonthRadioButton.Checked == true)
                {
                    DateTime dataInicial = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, 01);
                    DateTime dataFinal = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month));

                    TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContasDetalhesFinal report = new ReportPlanoDeContasDetalhesFinal(dataInicial, dataFinal, info.GetIgreja());
                    report.Show();

                }
                else
                    if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                    {

                        TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContasDetalhesFinal report = new ReportPlanoDeContasDetalhesFinal(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, info.GetIgreja());
                        report.Show();

                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (reportPlanoDeContasMonthRadioButton.Checked == true)
                {
                    DateTime dataInicial = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, 01);
                    DateTime dataFinal = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month));

                    TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContasDetalhesFinal report = new ReportPlanoDeContasDetalhesFinal(dataInicial, dataFinal, reportPlanoDeContasComboBox.SelectedValue.ToString());
                    report.Show();

                }
                else
                    if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                    {

                        TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContasDetalhesFinal report = new ReportPlanoDeContasDetalhesFinal(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, reportPlanoDeContasComboBox.SelectedValue.ToString());
                        report.Show();

                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ReportPlanoDeContas_Load(object sender, EventArgs e)
        {
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);

        }
    }
}
