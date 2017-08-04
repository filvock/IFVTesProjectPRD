using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.ReportForms.ManagementReport
{
    public partial class ReportEntradaSaidaIgreja : Form
    {
        public ReportEntradaSaidaIgreja()
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

            
        }

        private void ReportPlanoDeContas_Load(object sender, EventArgs e)
        {
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);
            comboBox1.SelectedIndex = 0;
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
                comboBox1.SelectedItem = info.GetRegiao();
                comboBox1.Enabled = false;
                checkBox1.Enabled = false;

                comboBox2.SelectedValue = info.GetEstado();
                comboBox2.Enabled = false;
                checkBox2.Enabled = false;

            }
            else if (info.GetRole() == "Presidente Regional")
            {
                comboBox1.SelectedItem = info.GetRegiao();
                comboBox1.Enabled = false;
                checkBox1.Enabled = false;
            }
        }

        private void reportPlanoDeContasCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportPlanoDeContasOkButton_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (reportPlanoDeContasMonthRadioButton.Checked == true)
                {
                    DateTime dataInicial = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, 01);
                    DateTime dataFinal = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month));

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESIgreja report = new ReportForms.ESIgreja(dataInicial, dataFinal, reportPlanoDeContasComboBox.SelectedValue.ToString());
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESIgreja report = new ReportForms.ESIgreja(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, reportPlanoDeContasComboBox.SelectedValue.ToString());
                    report.Show();

                }

                else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (checkBox2.Checked == true)
            {
                if (reportPlanoDeContasMonthRadioButton.Checked == true)
                {
                    DateTime dataInicial = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, 01);
                    DateTime dataFinal = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month));

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESEstadoPorIgreja report = new ReportForms.ESEstadoPorIgreja(dataInicial, dataFinal, comboBox2.SelectedValue.ToString());
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESEstadoPorIgreja report = new ReportForms.ESEstadoPorIgreja(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, comboBox2.SelectedValue.ToString());
                    report.Show();

                }

                else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (checkBox1.Checked == true)
            {
                if (reportPlanoDeContasMonthRadioButton.Checked == true)
                {
                    DateTime dataInicial = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, 01);
                    DateTime dataFinal = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month));

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESRegiaoPorIgreja report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESRegiaoPorIgreja(dataInicial, dataFinal, comboBox1.SelectedItem.ToString());
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESRegiaoPorIgreja report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESRegiaoPorIgreja(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, comboBox1.SelectedItem.ToString());
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

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESPaisPorIgreja report = new ReportForms.ESPaisPorIgreja(dataInicial, dataFinal);
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESPaisPorIgreja report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ESPaisPorIgreja(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value);
                    report.Show();

                }

                else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                reportPlanoDeContasComboBox.Enabled = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                reportPlanoDeContasComboBox.Enabled = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox2.Enabled = true;
                reportPlanoDeContasComboBox.Enabled = true;
                checkBox3.Checked = true;
            }
            else
            {
                comboBox2.Enabled = false;
                reportPlanoDeContasComboBox.Enabled = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                reportPlanoDeContasComboBox.Enabled = true;
            }
            else
            {
                reportPlanoDeContasComboBox.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedValue != null)
            {
                estadosBindingSource.Filter = "Regiao = '" + comboBox1.SelectedItem.ToString() + "'";
                igrejasBindingSource.Filter = "Estado = '" + comboBox2.SelectedValue.ToString() + "'";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                igrejasBindingSource.Filter = "Estado = '" + comboBox2.SelectedValue.ToString() + "'";
            }
        }

        private void reportPlanoDeContasMonthDateTimePicker_Enter(object sender, EventArgs e)
        {
            if (reportPlanoDeContasMonthDateTimePicker.Value.Day > 28)
                reportPlanoDeContasMonthDateTimePicker.Value = DateTime.Now.AddDays(-5);
        }
    }
}
