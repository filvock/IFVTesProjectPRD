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
            this.tesourariaGeralTableAdapter.Fill(this.igrejafont11DataSet.TesourariaGeral);
            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }

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
