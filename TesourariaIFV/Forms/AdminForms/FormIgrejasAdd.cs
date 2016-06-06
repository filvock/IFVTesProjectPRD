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
    public partial class FormIgrejasAdd : Form
    {
        public FormIgrejasAdd()
        {
            InitializeComponent();
        }

        private void FormIgrejasAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.igrejafont11DataSet.Cidades);

        }

        private void formIgrejasAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formIgrejasAddOkButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.IgrejasRow newIgrejaRow = igrejafont11DataSet.Igrejas.NewIgrejasRow();
            igrejafont11DataSetTableAdapters.IgrejasTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.IgrejasTableAdapter();

            newIgrejaRow.Cidade = formIgrejasAddComboBox.SelectedValue.ToString();
            newIgrejaRow.Nome = formIgrejasAddTextBox.Text;
            newIgrejaRow.Estado = formIgrejaAddEstadoComboBox.SelectedValue.ToString();

            igrejafont11DataSet.Igrejas.Rows.Add(newIgrejaRow);
            tableAdapter.Update(igrejafont11DataSet.Igrejas);

            formIgrejasAddTextBox.Clear();
            formIgrejasAddComboBox.Refresh();
        }
    }
}
