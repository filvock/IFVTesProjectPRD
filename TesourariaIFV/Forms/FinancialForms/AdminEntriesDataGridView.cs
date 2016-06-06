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
    public partial class AdminEntriesDataGridView : Form
    {
        public AdminEntriesDataGridView(DateTime dataInicial, DateTime dataFinal, string igreja, string origem)
        {
            InitializeComponent();
            if (origem == "CaixaBanco")
            {
                tesourariaGeralBindingSource.Filter = "Data  >='" + dataInicial + "' and Data <='" + dataFinal + "'and Igreja ='" + igreja + "'";
            }
            else
            {
                tesourariaGeralBindingSource.Filter = "Data  >='" + dataInicial + "' and Data <='" + dataFinal + "'and Igreja ='" + igreja + "' and Origem = '" + origem + "'";
            }
        }

        private void AdminEntriesDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.TesourariaGeral' table. You can move, or remove it, as needed.
            this.tesourariaGeralTableAdapter.Fill(this.igrejafont11DataSet.TesourariaGeral);

        }

        private void adminEntriesCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminEntriesOkButton_Click(object sender, EventArgs e)
        {
            tesourariaGeralTableAdapter.Update(igrejafont11DataSet.TesourariaGeral);
            this.Close();
        }
    }
}
