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
    public partial class ReportLivroCaixa : Form
    {
        public ReportLivroCaixa(DateTime dataInicial, DateTime dataFinal, string igreja, string saldo)
        {
            InitializeComponent();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", dataInicial.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dataFinal.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Igreja", igreja));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Saldo", saldo));

        }

        private void ReportLivroCaixa_Load(object sender, EventArgs e)
        {
            this.tesourariaGeralTableAdapter.Fill(this.igrejafont11DataSet.TesourariaGeral);
            this.reportViewer1.RefreshReport();

        }
    }
}
