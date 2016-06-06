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
    public partial class ReportPlanoDeContas : Form
    {
        public ReportPlanoDeContas()
        {
            InitializeComponent();

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

            if (info.GetRole() == "Coord Estadual")
            {
                igrejasBindingSource.Filter = "Estado = '" + info.GetEstado() + "'";
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

                    TesourariaIFV.Forms.Reports_Forms.ReportPlanodeContasFinal report = new ReportPlanodeContasFinal(dataInicial, dataFinal, info.GetIgreja());
                    report.Show();

                }
                else
                    if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                    {

                        TesourariaIFV.Forms.Reports_Forms.ReportPlanodeContasFinal report = new ReportPlanodeContasFinal(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, info.GetIgreja());
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

                    TesourariaIFV.Forms.Reports_Forms.ReportPlanodeContasFinal report = new ReportPlanodeContasFinal(dataInicial, dataFinal, reportPlanoDeContasComboBox.SelectedValue.ToString());
                    report.Show();

                }
                else
                    if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                    {

                        TesourariaIFV.Forms.Reports_Forms.ReportPlanodeContasFinal report = new ReportPlanodeContasFinal(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, reportPlanoDeContasComboBox.SelectedValue.ToString());
                        report.Show();

                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ReportPlanoDeContas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);

        }
    }
}
