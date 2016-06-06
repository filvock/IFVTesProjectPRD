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
    public partial class AdminEntriesForm : Form
    {
        public AdminEntriesForm()
        {
            InitializeComponent();
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                adminEntriesComboBox.Visible = false;
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

        private void AdminEntriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Igrejas' table. You can move, or remove it, as needed.
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.TesourariaGeral' table. You can move, or remove it, as needed.
            this.tesourariaGeralTableAdapter.Fill(this.igrejafont11DataSet.TesourariaGeral);

        }

        private void adminEntriesCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminEntriesOkButton_Click(object sender, EventArgs e)
        {
            if (adminEntriesCaixaRadioButton.Checked == true)
            {
                createReportCaixa();
            }
            else if (adminEntriesBancoRadioButton.Checked == true)
            {
                createReportBanco();
            }
            else if (adminEntriesCaixaBancoRadioButton.Checked == true)
            {
                createReportCaixaBanco();
            }
            else
            {
                MessageBox.Show("Por favor, selecione o tipo de relatório.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createReportCaixaBanco()
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month));
            DateTime dataInicial = new DateTime(adminEntriesInitialDateTimePicker.Value.Year, adminEntriesInitialDateTimePicker.Value.Month, adminEntriesInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(adminEntriesFinalDateTimePicker.Value.Year, adminEntriesFinalDateTimePicker.Value.Month, adminEntriesFinalDateTimePicker.Value.Day);

            
            if (info.GetRole() == "Igreja Local")
            {

                if (adminEntriesMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicialMonth,dataFinalMonth,loginInfo.igreja, "CaixaBanco");
                    grid.Show();

                }
                else
                    if (adminEntriesPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicial, dataFinal, loginInfo.igreja, "CaixaBanco");
                        grid.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (adminEntriesMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicialMonth, dataFinalMonth, adminEntriesComboBox.SelectedValue.ToString(), "CaixaBanco");
                    grid.Show();

                }
                else
                    if (adminEntriesPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicial, dataFinal, adminEntriesComboBox.SelectedValue.ToString(), "CaixaBanco");
                        grid.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createReportBanco()
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month));
            DateTime dataInicial = new DateTime(adminEntriesInitialDateTimePicker.Value.Year, adminEntriesInitialDateTimePicker.Value.Month, adminEntriesInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(adminEntriesFinalDateTimePicker.Value.Year, adminEntriesFinalDateTimePicker.Value.Month, adminEntriesFinalDateTimePicker.Value.Day);


            if (info.GetRole() == "Igreja Local")
            {

                if (adminEntriesMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicialMonth, dataFinalMonth, loginInfo.igreja, "Banco");
                    grid.Show();

                }
                else
                    if (adminEntriesPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicial, dataFinal, loginInfo.igreja, "Banco");
                        grid.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (adminEntriesMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicialMonth, dataFinalMonth, adminEntriesComboBox.SelectedValue.ToString(), "Banco");
                    grid.Show();

                }
                else
                    if (adminEntriesPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicial, dataFinal, adminEntriesComboBox.SelectedValue.ToString(), "Banco");
                        grid.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createReportCaixa()
        {
            loginInfo info = new loginInfo();
            DateTime dataInicialMonth = new DateTime(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month, 01);
            DateTime dataFinalMonth = new DateTime(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month, DateTime.DaysInMonth(adminEntriesMonthDateTimePicker.Value.Year, adminEntriesMonthDateTimePicker.Value.Month));
            DateTime dataInicial = new DateTime(adminEntriesInitialDateTimePicker.Value.Year, adminEntriesInitialDateTimePicker.Value.Month, adminEntriesInitialDateTimePicker.Value.Day);
            DateTime dataFinal = new DateTime(adminEntriesFinalDateTimePicker.Value.Year, adminEntriesFinalDateTimePicker.Value.Month, adminEntriesFinalDateTimePicker.Value.Day);


            if (info.GetRole() == "Igreja Local")
            {

                if (adminEntriesMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicialMonth, dataFinalMonth, loginInfo.igreja, "Caixa");
                    grid.Show();

                }
                else
                    if (adminEntriesPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicial, dataFinal, loginInfo.igreja, "Caixa");
                        grid.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (adminEntriesMonthRadioButton.Checked == true)
                {
                    TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicialMonth, dataFinalMonth, adminEntriesComboBox.SelectedValue.ToString(), "Caixa");
                    grid.Show();

                }
                else
                    if (adminEntriesPeriodRadioButton.Checked == true)
                    {
                        TesourariaIFV.Forms.AdminEntriesDataGridView grid = new AdminEntriesDataGridView(dataInicial, dataFinal, adminEntriesComboBox.SelectedValue.ToString(), "Caixa");
                        grid.Show();
                    }

                    else MessageBox.Show("Por favor, selecione Mês/Ano ou Período.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
    }
}
