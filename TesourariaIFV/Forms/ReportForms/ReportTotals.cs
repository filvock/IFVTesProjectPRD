using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.ReportForms
{
    public partial class ReportTotals : Form
    {
        public ReportTotals()
        {
            InitializeComponent();

            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                reportTotalsComboBox.Visible = false;
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

        private void reportTotalsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportTotals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);

        }

        private void reportTotalsOkButton_Click(object sender, EventArgs e)
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(reportTotalsMonthDateTimePicker.Value.Year, reportTotalsMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(reportTotalsMonthDateTimePicker.Value.Year, reportTotalsMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportTotalsMonthDateTimePicker.Value.Year, reportTotalsMonthDateTimePicker.Value.Month));

            DateTime dataInicial = new DateTime(reportTotalsInitialDateTimePicker.Value.Year, reportTotalsInitialDateTimePicker.Value.Month, reportTotalsInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(reportTotalsFinalDateTimePicker.Value.Year, reportTotalsFinalDateTimePicker.Value.Month, reportTotalsFinalDateTimePicker.Value.Day);

            if (info.GetRole() == "Igreja Local")
            {

                if (reportTotalsMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportForms.ReportTotalsFinal report = new ReportForms.ReportTotalsFinal(dataInicialMonth, dataFinalMonth, info.GetIgreja());
                    report.Show();
                }
                else
                    if (reportTotalsPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportForms.ReportTotalsFinal report = new ReportForms.ReportTotalsFinal(dataInicial, dataFinal, info.GetIgreja());
                        report.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (reportTotalsMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportForms.ReportTotalsFinal report = new ReportForms.ReportTotalsFinal(dataInicialMonth, dataFinalMonth, reportTotalsComboBox.SelectedValue.ToString());
                    report.Show();
                }
                else
                    if (reportTotalsPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportForms.ReportTotalsFinal report = new ReportForms.ReportTotalsFinal(dataInicial, dataFinal, reportTotalsComboBox.SelectedValue.ToString());
                        report.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
