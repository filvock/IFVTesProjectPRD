using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV.Forms.Admin_Forms
{
    public partial class FormCidadeAdd : Form
    {
        public FormCidadeAdd()
        {
            InitializeComponent();
        }

        private void FormCidadeAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);

        }

        private void formCidadesAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCidadesAddOkButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.CidadesRow newCidadeRow = igrejafont11DataSet.Cidades.NewCidadesRow();
            igrejafont11DataSetTableAdapters.CidadesTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.CidadesTableAdapter();

            newCidadeRow.Estado = formCidadesAddComboBox.SelectedValue.ToString();
            newCidadeRow.Nome = formCidadesAddTextBox.Text;

            igrejafont11DataSet.Cidades.Rows.Add(newCidadeRow);
            tableAdapter.Update(igrejafont11DataSet.Cidades);

            formCidadesAddTextBox.Clear();
            
        }
    }
}
