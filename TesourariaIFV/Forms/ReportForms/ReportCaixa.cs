﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace TesourariaIFV.Forms
{
    public partial class ReportCaixa : Form
    {
        public ReportCaixa()
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
                formReportCaixaComboBox.Visible = false;
                label4.Visible = false;
            }
            else 
            {
                FillIgrejasDropDown();
            }
        }

        private void reportCaixaCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportCaixaOkButton_Click(object sender, EventArgs e)
        {
            
            if (reportCaixaCaixaRadioButton.Checked == true)
            {
                createReportCaixa();
            }
            else if(reportCaixaBancoRadioButton.Checked == true)
            {
                createReportBanco();
            }
            else if (reportCaixaCaixaBancoRadioButton.Checked == true)
            {
                createReportCaixaBanco();
            }
            else
            {
                MessageBox.Show("Por favor, selecione o tipo de relatório.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void createReportCaixaBanco()
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month));

            DateTime dataInicial = new DateTime(reportCaixaInitialDateTimePicker.Value.Year, reportCaixaInitialDateTimePicker.Value.Month, reportCaixaInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(reportCaixaFinalDateTimePicker.Value.Year, reportCaixaFinalDateTimePicker.Value.Month, reportCaixaFinalDateTimePicker.Value.Day);

            if (info.GetRole() == "Igreja Local")
            {
                if (reportCaixaMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportForms.ReportLivroCaixaBanco report = new ReportForms.ReportLivroCaixaBanco(dataInicialMonth, dataFinalMonth, info.GetIgreja(), CalculaSaldoInicialGeral(info.GetIgreja(), dataInicialMonth));
                    report.Show();
                }
                else
                    if (reportCaixaPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportForms.ReportLivroCaixaBanco report = new ReportForms.ReportLivroCaixaBanco(dataInicial, dataFinal, info.GetIgreja(), CalculaSaldoInicialGeral(info.GetIgreja(), dataInicial));
                        report.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (reportCaixaMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportForms.ReportLivroCaixaBanco report = new ReportForms.ReportLivroCaixaBanco(dataInicialMonth, dataFinalMonth, formReportCaixaComboBox.SelectedValue.ToString(), CalculaSaldoInicialGeral(formReportCaixaComboBox.SelectedValue.ToString(), dataInicialMonth));
                    report.Show();
                }
                else
                    if (reportCaixaPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportForms.ReportLivroCaixaBanco report = new ReportForms.ReportLivroCaixaBanco(dataInicial, dataFinal, formReportCaixaComboBox.SelectedValue.ToString(), CalculaSaldoInicialGeral(formReportCaixaComboBox.SelectedValue.ToString(), dataInicial));
                        report.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string CalculaSaldoInicialGeral(string igreja, DateTime data)
        {
            loginInfo info = new loginInfo();
            SqlConnection conn = new SqlConnection(info.GetStringConnection());
            conn.Open();

            SqlCommand comm1 = new SqlCommand("select sum(valor) from TesourariaGeral where igreja like @igreja and Data < @Data ", conn);
            comm1.Parameters.Add("@igreja", SqlDbType.VarChar).Value = igreja;
            comm1.Parameters.Add("@Data", SqlDbType.VarChar).Value = data.ToString("yyyy/MM/dd");
            string total = comm1.ExecuteScalar().ToString();

            if (total == "")
            {
                return "0";
            }
            else
                return total;

        }

        private string CalculaSaldoInicialCaixa(string igreja, DateTime data)
        {
            loginInfo info = new loginInfo();
            SqlConnection conn = new SqlConnection(info.GetStringConnection());
            conn.Open();

            SqlCommand comm1 = new SqlCommand("select sum(valor) from TesourariaGeral where igreja like @igreja and Data < @Data and Origem='Caixa'", conn);
            comm1.Parameters.Add("@igreja", SqlDbType.VarChar).Value = igreja;
            comm1.Parameters.Add("@Data", SqlDbType.VarChar).Value = data.ToString("yyyy/MM/dd");
            string total = comm1.ExecuteScalar().ToString();

            if (total == "")
            {
                return "0";
            }
            else
                return total;

        }

        private string CalculaSaldoInicialBanco(string igreja, DateTime data)
        {
            loginInfo info = new loginInfo();
            SqlConnection conn = new SqlConnection(info.GetStringConnection());
            conn.Open();

            SqlCommand comm1 = new SqlCommand("select sum(valor) from TesourariaGeral where igreja like @igreja and Data < @Data and Origem='Banco'", conn);
            comm1.Parameters.Add("@igreja", SqlDbType.VarChar).Value = igreja;
            comm1.Parameters.Add("@Data", SqlDbType.VarChar).Value = data.ToString("yyyy/MM/dd");
            string total = comm1.ExecuteScalar().ToString();

            if (total == "")
            {
                return "0";
            }
            else
                return total;

        }
        private void createReportBanco()
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month));

            DateTime dataInicial = new DateTime(reportCaixaInitialDateTimePicker.Value.Year, reportCaixaInitialDateTimePicker.Value.Month, reportCaixaInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(reportCaixaFinalDateTimePicker.Value.Year, reportCaixaFinalDateTimePicker.Value.Month, reportCaixaFinalDateTimePicker.Value.Day);


            if (info.GetRole() == "Igreja Local")
            {

                if (reportCaixaMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportLivroBanco reportBanco = new ReportLivroBanco(dataInicialMonth, dataFinalMonth, info.GetIgreja(), CalculaSaldoInicialBanco(info.GetIgreja(), dataInicialMonth));
                    reportBanco.Show();
                }
                else
                    if (reportCaixaPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportLivroBanco reportBanco = new ReportLivroBanco(dataInicial, dataFinal, info.GetIgreja(), CalculaSaldoInicialBanco(info.GetIgreja(), dataInicial));
                        reportBanco.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (reportCaixaMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportLivroBanco reportBanco = new ReportLivroBanco(dataInicialMonth, dataFinalMonth, formReportCaixaComboBox.SelectedValue.ToString(), CalculaSaldoInicialBanco(formReportCaixaComboBox.SelectedValue.ToString(), dataInicialMonth));
                    reportBanco.Show();
                }
                else
                    if (reportCaixaPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportLivroBanco reportBanco = new ReportLivroBanco(dataInicial, dataFinal, formReportCaixaComboBox.SelectedValue.ToString(), CalculaSaldoInicialBanco(formReportCaixaComboBox.SelectedValue.ToString(), dataInicial));
                        reportBanco.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createReportCaixa()
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(reportCaixaMonthDateTimePicker.Value.Year, reportCaixaMonthDateTimePicker.Value.Month));

            DateTime dataInicial = new DateTime(reportCaixaInitialDateTimePicker.Value.Year, reportCaixaInitialDateTimePicker.Value.Month, reportCaixaInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(reportCaixaFinalDateTimePicker.Value.Year, reportCaixaFinalDateTimePicker.Value.Month, reportCaixaFinalDateTimePicker.Value.Day);

            if (info.GetRole() == "Igreja Local")
            {
                if (reportCaixaMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportLivroCaixa reportCaixa = new ReportLivroCaixa(dataInicialMonth, dataFinalMonth, info.GetIgreja(), CalculaSaldoInicialCaixa(info.GetIgreja(), dataInicialMonth));
                    reportCaixa.Show();
                }
                else
                    if (reportCaixaPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportLivroCaixa reportCaixa = new ReportLivroCaixa(dataInicial, dataFinal, info.GetIgreja(), CalculaSaldoInicialCaixa(info.GetIgreja(), dataInicial));
                        reportCaixa.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (reportCaixaMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.ReportLivroCaixa reportCaixa = new ReportLivroCaixa(dataInicialMonth, dataFinalMonth, formReportCaixaComboBox.SelectedValue.ToString(), CalculaSaldoInicialCaixa(formReportCaixaComboBox.SelectedValue.ToString(), dataInicialMonth));
                    reportCaixa.Show();
                }
                else
                    if (reportCaixaPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.ReportLivroCaixa reportCaixa = new ReportLivroCaixa(dataInicial, dataFinal, formReportCaixaComboBox.SelectedValue.ToString(), CalculaSaldoInicialCaixa(formReportCaixaComboBox.SelectedValue.ToString(), dataInicial));
                        reportCaixa.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ReportCaixa_Load(object sender, EventArgs e)
        {
            this.igrejasTableAdapter.FillBy(this.igrejafont11DataSet.Igrejas);

        }

        private void reportCaixaMonthDateTimePicker_Enter(object sender, EventArgs e)
        {
            if (reportCaixaMonthDateTimePicker.Value.Day > 28)
                reportCaixaMonthDateTimePicker.Value = DateTime.Now.AddDays(-5);
        }
    }
}
