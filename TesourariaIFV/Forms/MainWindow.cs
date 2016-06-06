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
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            SetWindowToRole();
        }

        private void SetWindowToRole()
        {
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                administraçãoToolStripMenuItem.Enabled = false;

            }
        }

        private void entradaSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.FinControlForm financialForm = new FinControlForm();
            financialForm.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.FormPlanoDeContasAdd planoDeContasAdd = new FormPlanoDeContasAdd();
            planoDeContasAdd.Show();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.FormPlanoDeContasRemove planoDeContasRemove = new FormPlanoDeContasRemove();
            planoDeContasRemove.Show();
        }

        private void adicionarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.FormGrupoPlanoDeContasAdd grupoPlanoDeContasAdd = new FormGrupoPlanoDeContasAdd();
            grupoPlanoDeContasAdd.Show();
        }

        private void removerGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.FormGrupoPlanoDeContasRemove grupoPlanoDeContasRemove = new FormGrupoPlanoDeContasRemove();
            grupoPlanoDeContasRemove.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportCaixa reportCaixaForm = new ReportCaixa();
            reportCaixaForm.Show();
        }

        private void adicionarCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.FormCidadeAdd cidadeAdd = new Admin_Forms.FormCidadeAdd();
            cidadeAdd.Show();
        }

        private void removerCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.FormCidadeRemove cidadeRemove = new Admin_Forms.FormCidadeRemove();
            cidadeRemove.Show();
        }

        private void adicionarIgrejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.FormIgrejasAdd igrejasAdd = new Admin_Forms.FormIgrejasAdd();
            igrejasAdd.Show();
        }

        private void removerIgrejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.FormIgrejasRemove igrejasRemove = new Admin_Forms.FormIgrejasRemove();
            igrejasRemove.Show();
        }

        private void adicionarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.FormUserAdd userAdd = new Admin_Forms.FormUserAdd();
            userAdd.Show();

        }

        private void removerUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.FormUserRemove userRemove = new Admin_Forms.FormUserRemove();
            userRemove.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("ATENÇÂO!!! \n Lançamentos do mês anterior devem ser lançados \n até o dia 15 do mês corrente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            loginInfo info = new loginInfo();
            info.SetLoggedToNo();
        }

        private void planoDeContasEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContas planoDeContas = new Reports_Forms.ReportPlanoDeContas();
            planoDeContas.Show();
        }

        private void livroCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportCaixa reportCaixaForm = new ReportCaixa();
            reportCaixaForm.Show();
        }

        private void totaisPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.ReportTotals report = new ReportForms.ReportTotals();
            report.Show();

        }

        private void excluirLançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.AdminEntriesForm report = new AdminEntriesForm();
            report.Show();
        }

        private void listaDeMembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.MembersControlForm.MembersAdminForm window = new MembersControlForm.MembersAdminForm();
            window.Show();
        }

        private void lançarContribuiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.MembersControlForm.EnterContribForm window = new MembersControlForm.EnterContribForm();
            window.Show();
        }

        private void dízimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.MembersControlForm.ReportDizimos window = new MembersControlForm.ReportDizimos();
            window.Show();
        }

        private void primíciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.MembersControlForm.ReportPrimicias window = new MembersControlForm.ReportPrimicias();
            window.Show();

        }

        private void missõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.MembersControlForm.ReportMissoes window = new MembersControlForm.ReportMissoes();
            window.Show();
        }

        private void editarLançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.MembersControlForm.EditContrib window = new MembersControlForm.EditContrib();
            window.Show();
        }

        private void transferênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.TransferForm window = new TransferForm();
            window.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
