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
    public partial class ReportTotalsMgnt : Form
    {
        public ReportTotalsMgnt()
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

            if (info.GetRole() == "Presidente Estadual")
            {
                igrejasBindingSource.Filter = "Estado = '" + info.GetEstado() + "'";
            }
            else if (info.GetRole() == "Presidente Regional")
            {
                igrejasBindingSource.Filter = "Regiao = '" + info.GetRegiao() + "'";
            }
        }

        private void reportTotalsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportTotals_Load(object sender, EventArgs e)
        {
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);
            comboBox1.SelectedIndex = 0;
        }

        private void reportTotalsOkButton_Click(object sender, EventArgs e)
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(reportTotalsMonthDateTimePicker.Value.Year, reportTotalsMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(reportTotalsMonthDateTimePicker.Value.Year, reportTotalsMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportTotalsMonthDateTimePicker.Value.Year, reportTotalsMonthDateTimePicker.Value.Month));

            DateTime dataInicial = new DateTime(reportTotalsInitialDateTimePicker.Value.Year, reportTotalsInitialDateTimePicker.Value.Month, reportTotalsInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(reportTotalsFinalDateTimePicker.Value.Year, reportTotalsFinalDateTimePicker.Value.Month, reportTotalsFinalDateTimePicker.Value.Day);

            
            if (reportTotalsMonthRadioButton.Checked == true)
            {
                TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ReportTotalsMgntFinal report = new ReportForms.ReportTotalsMgntFinal(dataInicialMonth, dataFinalMonth, reportTotalsComboBox.SelectedValue.ToString());
                report.Show();
            }
            else
                if (reportTotalsPeriodRadioButton.Checked == true)
                {
                TesourariaIFV.Forms.ReportForms.ManagementReport.ReportForms.ReportTotalsMgntFinal report = new ReportForms.ReportTotalsMgntFinal(dataInicial, dataFinal, reportTotalsComboBox.SelectedValue.ToString());
                    report.Show();
                }

                else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                reportTotalsComboBox.Enabled = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                reportTotalsComboBox.Enabled = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox2.Enabled = true;
                reportTotalsComboBox.Enabled = true;
                checkBox3.Checked = true;
            }
            else
            {
                comboBox2.Enabled = false;
                reportTotalsComboBox.Enabled = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                reportTotalsComboBox.Enabled = true;
            }
            else
            {
                reportTotalsComboBox.Enabled = false;
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
