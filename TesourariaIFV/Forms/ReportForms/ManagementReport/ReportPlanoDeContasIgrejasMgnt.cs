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
    public partial class ReportPlanoDeContasIgrejasMgnt : Form
    {
        public ReportPlanoDeContasIgrejasMgnt()
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

        private void ReportPlanoDeContas_Load(object sender, EventArgs e)
        {
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);
            comboBox1.SelectedIndex = 0;

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
            if (checkBox3.Checked == true)
            {
                if (reportPlanoDeContasMonthRadioButton.Checked == true)
                {
                    DateTime dataInicial = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, 01);
                    DateTime dataFinal = new DateTime(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportPlanoDeContasMonthDateTimePicker.Value.Year, reportPlanoDeContasMonthDateTimePicker.Value.Month));

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejas report = new ReportForms.PCMIgrejas(dataInicial, dataFinal, reportPlanoDeContasComboBox.SelectedValue.ToString());
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejas report = new ReportForms.PCMIgrejas(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, reportPlanoDeContasComboBox.SelectedValue.ToString());
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

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasEstado report = new ReportForms.PCMIgrejasEstado(dataInicial, dataFinal, comboBox2.SelectedValue.ToString());
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasEstado report = new ReportForms.PCMIgrejasEstado(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, comboBox2.SelectedValue.ToString());
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

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasRegiao report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasRegiao(dataInicial, dataFinal, comboBox1.SelectedItem.ToString());
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasRegiao report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasRegiao(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value, comboBox1.SelectedItem.ToString());
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

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasPais report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasPais(dataInicial, dataFinal);
                    report.Show();

                }
                else
                if (reportPlanoDeContasPeriodRadioButton.Checked == true)
                {

                    TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasPais report = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.PCMIgrejasPais(reportPlanoDeContasInitialDateTimePicker.Value, reportPlanoDeContasFinalDateTimePicker.Value);
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
    }
}
