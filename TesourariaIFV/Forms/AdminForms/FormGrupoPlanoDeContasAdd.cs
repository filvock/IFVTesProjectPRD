using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesourariaIFV
{
    public partial class FormGrupoPlanoDeContasAdd : Form
    {
        public FormGrupoPlanoDeContasAdd()
        {
            InitializeComponent();
        }

        private void formGrupoAddOkButton_Click(object sender, EventArgs e)
        {
            TesourariaIFV.igrejafont11DataSet.GruposPlanosDeContasRow newGrupo = igrejafont11DataSet.GruposPlanosDeContas.NewGruposPlanosDeContasRow() ;
            igrejafont11DataSetTableAdapters.GruposPlanosDeContasTableAdapter tableAdapter = new igrejafont11DataSetTableAdapters.GruposPlanosDeContasTableAdapter();

            newGrupo.Descricao = formGrupoAddTextBox.Text;
            
            igrejafont11DataSet.GruposPlanosDeContas.Rows.Add(newGrupo);
            tableAdapter.Update(igrejafont11DataSet.GruposPlanosDeContas);

            formGrupoAddTextBox.Clear();
        }

        private void formGrupoAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
