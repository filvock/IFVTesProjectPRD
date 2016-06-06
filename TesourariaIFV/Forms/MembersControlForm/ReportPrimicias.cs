using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.MembersControlForm
{
    public partial class ReportPrimicias : Form
    {
        public ReportPrimicias()
        {
            InitializeComponent();
            reportDizimosDataGridView.DefaultCellStyle.Font = new Font("Arial", 14);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

        }

        private void FillIgrejasDropDown()
        {
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Coord Estadual")
            {
                igrejasBindingSource.Filter = "Estado = '" + info.GetEstado() + "'";
            }
        }

        private void ReportDizimos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Membros' table. You can move, or remove it, as needed.
            this.membrosTableAdapter.Fill(this.igrejafont11DataSet.Membros);
            this.controleIndividualTableAdapter.Fill(this.igrejafont11DataSet.ControleIndividual);
            this.igrejasTableAdapter.Fill(this.igrejafont11DataSet.Igrejas);
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                reportDizimoComboBox.Visible = false;
                label1.Visible = false;
                membrosBindingSource.Filter = "Igreja = '" + info.GetIgreja() + "'";
            }
            else
            {
                FillIgrejasDropDown();
                membrosBindingSource.Filter = "Igreja = '" + reportDizimoComboBox.SelectedValue.ToString() + "'";
            }
            FillDataGridView();

        }

        private void FillDataGridView()
        {
            int count = membrosBindingSource.Count;
            membrosBindingSource.MoveFirst();
            controleIndividualBindingSource.MoveFirst();

            reportDizimosDataGridView.Rows.Clear();

            for (int i = 0; i < count; i++)
            {
                DataRowView row = (DataRowView) membrosBindingSource.Current;
                reportDizimosDataGridView.Rows.Add();
                
                reportDizimosDataGridView.Rows[i].Cells[0].Value = row[0].ToString();
                reportDizimosDataGridView.Rows[i].Cells[1].Value = row[1].ToString();
                
                membrosBindingSource.MoveNext();
            }

            if (reportDizimosDataGridView.RowCount != 0)
            {
                count = controleIndividualBindingSource.Count;

                for (int i = 0; i < count; i++)
                {
                    DataRowView row = (DataRowView)controleIndividualBindingSource.Current;

                    int mes = Convert.ToInt32(row[2].ToString().Substring(3, 2));
                    int ano = Convert.ToInt32(row[2].ToString().Substring(6, 4));

                    if (ano.ToString().Equals(dateTimePicker1.Value.Year.ToString()))
                    {
                        bool notfound = true;
                        int valor = 0;
                        int j = 0;
                        while (notfound)
                        {
                            if (reportDizimosDataGridView.Rows[j].Cells[0].Value.ToString().Equals(row["CodMembro"].ToString()))
                            {
                                notfound = false;
                                if (reportDizimosDataGridView.Rows[j].Cells[mes + 1].Value != null && !reportDizimosDataGridView.Rows[j].Cells[mes + 1].Value.ToString().Equals(""))
                                {
                                    valor = Convert.ToInt32(reportDizimosDataGridView.Rows[j].Cells[mes + 1].Value.ToString());
                                    if (row[4] != null && row[4].ToString().Length != 0)
                                    {
                                        valor = valor + Convert.ToInt32(row[4].ToString());
                                        reportDizimosDataGridView.Rows[j].Cells[mes + 1].Value = valor.ToString();
                                    }
                                }
                                else
                                {
                                    reportDizimosDataGridView.Rows[j].Cells[mes + 1].Value = row[4].ToString();
                                }
                            }
                            j++;
                        }
                    }
                    controleIndividualBindingSource.MoveNext();
                }
            }
            SetValuesToMoney();
            
        }

        private void SetValuesToMoney()
        {
            int count = reportDizimosDataGridView.RowCount;

            for (int i = 0; i < count; i++)
            {
                if (reportDizimosDataGridView.Rows[i].Cells[2].Value != null && reportDizimosDataGridView.Rows[i].Cells[2].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[2].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[2].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[3].Value != null && reportDizimosDataGridView.Rows[i].Cells[3].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[3].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[3].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[4].Value != null && reportDizimosDataGridView.Rows[i].Cells[4].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[4].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[4].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[5].Value != null && reportDizimosDataGridView.Rows[i].Cells[5].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[5].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[5].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[6].Value != null && reportDizimosDataGridView.Rows[i].Cells[6].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[6].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[6].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[7].Value != null && reportDizimosDataGridView.Rows[i].Cells[7].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[7].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[7].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[8].Value != null && reportDizimosDataGridView.Rows[i].Cells[8].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[8].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[8].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[9].Value != null && reportDizimosDataGridView.Rows[i].Cells[9].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[9].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[9].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[10].Value != null && reportDizimosDataGridView.Rows[i].Cells[10].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[10].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[10].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[11].Value != null && reportDizimosDataGridView.Rows[i].Cells[11].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[11].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[11].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[12].Value != null && reportDizimosDataGridView.Rows[i].Cells[12].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[12].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[12].Value).ToString("C");
                if (reportDizimosDataGridView.Rows[i].Cells[13].Value != null && reportDizimosDataGridView.Rows[i].Cells[13].Value.ToString().Length != 0)
                    reportDizimosDataGridView.Rows[i].Cells[13].Value = Convert.ToDouble(reportDizimosDataGridView.Rows[i].Cells[13].Value).ToString("C");
            }
        }

        private void reportDizimoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginInfo info = new loginInfo();
            membrosBindingSource.Filter = "igreja = '" + reportDizimoComboBox.Text + "'";
            FillDataGridView();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
