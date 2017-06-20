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

            //float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            //float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            //SizeF scale = new SizeF(widthRatio, heightRatio);
            //this.Scale(scale);

            //mainWindowMenuStrip.Font = new Font("Microsoft Sans Serif", administraçãoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //administraçãoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", administraçãoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //tesourariaToolStripMenuItem.Font = new Font("Microsoft Sans Serif", administraçãoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //ControleMembroToolStripMenuItem.Font = new Font("Microsoft Sans Serif", administraçãoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            //logoutToolStripMenuItem.Font = new Font("Microsoft Sans Serif", administraçãoToolStripMenuItem.Font.SizeInPoints * heightRatio * widthRatio);
            
            SetWindowToRole();
        }

        private void SetWindowToRole()
        {
            loginInfo info = new loginInfo();

            if (info.GetRole() == "Igreja Local")
            {
                administraçãoToolStripMenuItem.Enabled = false;
                relatóriosGerenciaisToolStripMenuItem.Enabled = false;                
            }
            else if (info.GetRole() == "Presidente Nacional" || info.GetRole() == "Presidente Estadual" || info.GetRole() == "Presidente Regional")
            {
                relatóriosToolStripMenuItem.Enabled = false;
                gráficosToolStripMenuItem.Enabled = false;
            }
                



        }

        private void entradaSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.FinControlForm financialForm = new FinControlForm();
            financialForm.Show();
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


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("ATENÇÂO!!! \n Lançamentos do mês anterior devem ser lançados \n até o dia 15 do mês corrente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //loginInfo info = new loginInfo();
            //info.SetLoggedToNo();
        }

        private void planoDeContasEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContasTotais planoDeContasTotais = new Reports_Forms.ReportPlanoDeContasTotais();
            planoDeContasTotais.Show();
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

        private void cidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.CidadeAdmin window = new Admin_Forms.CidadeAdmin();
            window.Show();
        }

        private void igrejasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.IgrejasAdmin window = new Admin_Forms.IgrejasAdmin();
            window.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.UserAdmin window = new Admin_Forms.UserAdmin();
            window.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.PlanoDeContasEntradaAdmin window = new Admin_Forms.PlanoDeContasEntradaAdmin();
            window.Show();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Admin_Forms.PlanoDeContasSaidaAdmin window = new Admin_Forms.PlanoDeContasSaidaAdmin();
            window.Show();
        }

        private void planoDeContasDetalhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.Reports_Forms.ReportPlanoDeContasDetalhes planoDeContasDetalhes = new Reports_Forms.ReportPlanoDeContasDetalhes();
            planoDeContasDetalhes.Show();
        }

        private void totaisEntradasSaidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.ManagementReport.ReportEntradaSaida mgntReport = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportEntradaSaida();
            mgntReport.Show();
        }

        private void livroCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.ManagementReport.ReportCaixaMgnt mgntReport = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportCaixaMgnt();
            mgntReport.Show();
        }

        private void planoDeContasTotaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.ManagementReport.ReportPlanoDeContasTotaisMgnt mgntReport = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportPlanoDeContasTotaisMgnt();
            mgntReport.Show();
        }

        private void planoDeContasDetalhadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.ManagementReport.ReportPlanoDeContasIgrejasMgnt mgntReport = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportPlanoDeContasIgrejasMgnt();
            mgntReport.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.ManagementReport.ReportEntradaSaidaIgreja mgntReport = new TesourariaIFV.Forms.ReportForms.ManagementReport.ReportEntradaSaidaIgreja();
            mgntReport.Show();
        }

        private void planoDeContasTotaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TesourariaIFV.Forms.ReportForms.Charts.ChartPlanoDeContasTotaisMgnt mgntReport = new TesourariaIFV.Forms.ReportForms.Charts.ChartPlanoDeContasTotaisMgnt();
            mgntReport.Show();
        }
    }
}
