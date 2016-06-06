﻿namespace TesourariaIFV.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainWindowMenuStrip = new System.Windows.Forms.MenuStrip();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarIgrejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerIgrejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposDePlanosDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesourariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeContasEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totaisPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirLançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarContribuiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dízimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primíciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowMenuStrip
            // 
            this.mainWindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçãoToolStripMenuItem,
            this.tesourariaToolStripMenuItem,
            this.loginLogoutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mainWindowMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainWindowMenuStrip.Name = "mainWindowMenuStrip";
            this.mainWindowMenuStrip.Size = new System.Drawing.Size(922, 33);
            this.mainWindowMenuStrip.TabIndex = 0;
            this.mainWindowMenuStrip.Text = "menuStrip1";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesToolStripMenuItem1,
            this.igrejasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.gruposDePlanosDeContasToolStripMenuItem,
            this.planoDeContasToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // cidadesToolStripMenuItem1
            // 
            this.cidadesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCidadeToolStripMenuItem,
            this.removerCidadeToolStripMenuItem});
            this.cidadesToolStripMenuItem1.Name = "cidadesToolStripMenuItem1";
            this.cidadesToolStripMenuItem1.Size = new System.Drawing.Size(309, 30);
            this.cidadesToolStripMenuItem1.Text = "Cidades";
            // 
            // adicionarCidadeToolStripMenuItem
            // 
            this.adicionarCidadeToolStripMenuItem.Name = "adicionarCidadeToolStripMenuItem";
            this.adicionarCidadeToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.adicionarCidadeToolStripMenuItem.Text = "Adicionar Cidade";
            this.adicionarCidadeToolStripMenuItem.Click += new System.EventHandler(this.adicionarCidadeToolStripMenuItem_Click);
            // 
            // removerCidadeToolStripMenuItem
            // 
            this.removerCidadeToolStripMenuItem.Name = "removerCidadeToolStripMenuItem";
            this.removerCidadeToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.removerCidadeToolStripMenuItem.Text = "Remover Cidade";
            this.removerCidadeToolStripMenuItem.Click += new System.EventHandler(this.removerCidadeToolStripMenuItem_Click);
            // 
            // igrejasToolStripMenuItem
            // 
            this.igrejasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarIgrejaToolStripMenuItem,
            this.removerIgrejaToolStripMenuItem});
            this.igrejasToolStripMenuItem.Name = "igrejasToolStripMenuItem";
            this.igrejasToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.igrejasToolStripMenuItem.Text = "Igrejas";
            // 
            // adicionarIgrejaToolStripMenuItem
            // 
            this.adicionarIgrejaToolStripMenuItem.Name = "adicionarIgrejaToolStripMenuItem";
            this.adicionarIgrejaToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.adicionarIgrejaToolStripMenuItem.Text = "Adicionar Igreja";
            this.adicionarIgrejaToolStripMenuItem.Click += new System.EventHandler(this.adicionarIgrejaToolStripMenuItem_Click);
            // 
            // removerIgrejaToolStripMenuItem
            // 
            this.removerIgrejaToolStripMenuItem.Name = "removerIgrejaToolStripMenuItem";
            this.removerIgrejaToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.removerIgrejaToolStripMenuItem.Text = "Remover Igreja";
            this.removerIgrejaToolStripMenuItem.Click += new System.EventHandler(this.removerIgrejaToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarUsuárioToolStripMenuItem,
            this.removerUsuárioToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            this.adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            this.adicionarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.adicionarUsuárioToolStripMenuItem.Text = "Adicionar Usuário";
            this.adicionarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.adicionarUsuárioToolStripMenuItem_Click);
            // 
            // removerUsuárioToolStripMenuItem
            // 
            this.removerUsuárioToolStripMenuItem.Name = "removerUsuárioToolStripMenuItem";
            this.removerUsuárioToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.removerUsuárioToolStripMenuItem.Text = "Remover Usuário";
            this.removerUsuárioToolStripMenuItem.Click += new System.EventHandler(this.removerUsuárioToolStripMenuItem_Click);
            // 
            // gruposDePlanosDeContasToolStripMenuItem
            // 
            this.gruposDePlanosDeContasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarGrupoToolStripMenuItem,
            this.removerGrupoToolStripMenuItem});
            this.gruposDePlanosDeContasToolStripMenuItem.Name = "gruposDePlanosDeContasToolStripMenuItem";
            this.gruposDePlanosDeContasToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.gruposDePlanosDeContasToolStripMenuItem.Text = "Grupos de Planos de Contas";
            // 
            // adicionarGrupoToolStripMenuItem
            // 
            this.adicionarGrupoToolStripMenuItem.Name = "adicionarGrupoToolStripMenuItem";
            this.adicionarGrupoToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.adicionarGrupoToolStripMenuItem.Text = "Adicionar Grupo";
            this.adicionarGrupoToolStripMenuItem.Click += new System.EventHandler(this.adicionarGrupoToolStripMenuItem_Click);
            // 
            // removerGrupoToolStripMenuItem
            // 
            this.removerGrupoToolStripMenuItem.Name = "removerGrupoToolStripMenuItem";
            this.removerGrupoToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.removerGrupoToolStripMenuItem.Text = "Remover Grupo";
            this.removerGrupoToolStripMenuItem.Click += new System.EventHandler(this.removerGrupoToolStripMenuItem_Click);
            // 
            // planoDeContasToolStripMenuItem
            // 
            this.planoDeContasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.planoDeContasToolStripMenuItem.Name = "planoDeContasToolStripMenuItem";
            this.planoDeContasToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.planoDeContasToolStripMenuItem.Text = "Plano de Contas";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.adicionarToolStripMenuItem.Text = "Adicionar Conta";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.removerToolStripMenuItem.Text = "Remover Conta";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // tesourariaToolStripMenuItem
            // 
            this.tesourariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaSaídaToolStripMenuItem,
            this.transferênciasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.excluirLançamentosToolStripMenuItem});
            this.tesourariaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tesourariaToolStripMenuItem.Name = "tesourariaToolStripMenuItem";
            this.tesourariaToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.tesourariaToolStripMenuItem.Text = "Tesouraria";
            // 
            // entradaSaídaToolStripMenuItem
            // 
            this.entradaSaídaToolStripMenuItem.Name = "entradaSaídaToolStripMenuItem";
            this.entradaSaídaToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.entradaSaídaToolStripMenuItem.Text = "Entrada/Saída";
            this.entradaSaídaToolStripMenuItem.Click += new System.EventHandler(this.entradaSaídaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroCaixaToolStripMenuItem,
            this.planoDeContasEntradaToolStripMenuItem,
            this.totaisPorPeríodoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // livroCaixaToolStripMenuItem
            // 
            this.livroCaixaToolStripMenuItem.Name = "livroCaixaToolStripMenuItem";
            this.livroCaixaToolStripMenuItem.Size = new System.Drawing.Size(345, 30);
            this.livroCaixaToolStripMenuItem.Text = "Livro Caixa";
            this.livroCaixaToolStripMenuItem.Click += new System.EventHandler(this.livroCaixaToolStripMenuItem_Click);
            // 
            // planoDeContasEntradaToolStripMenuItem
            // 
            this.planoDeContasEntradaToolStripMenuItem.Name = "planoDeContasEntradaToolStripMenuItem";
            this.planoDeContasEntradaToolStripMenuItem.Size = new System.Drawing.Size(345, 30);
            this.planoDeContasEntradaToolStripMenuItem.Text = "Relatório Plano de Contas";
            this.planoDeContasEntradaToolStripMenuItem.Click += new System.EventHandler(this.planoDeContasEntradaToolStripMenuItem_Click);
            // 
            // totaisPorPeríodoToolStripMenuItem
            // 
            this.totaisPorPeríodoToolStripMenuItem.Name = "totaisPorPeríodoToolStripMenuItem";
            this.totaisPorPeríodoToolStripMenuItem.Size = new System.Drawing.Size(345, 30);
            this.totaisPorPeríodoToolStripMenuItem.Text = "Totais Entrada/Saída por período";
            this.totaisPorPeríodoToolStripMenuItem.Click += new System.EventHandler(this.totaisPorPeríodoToolStripMenuItem_Click);
            // 
            // excluirLançamentosToolStripMenuItem
            // 
            this.excluirLançamentosToolStripMenuItem.Name = "excluirLançamentosToolStripMenuItem";
            this.excluirLançamentosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.excluirLançamentosToolStripMenuItem.Text = "Excluir Lançamentos";
            this.excluirLançamentosToolStripMenuItem.Click += new System.EventHandler(this.excluirLançamentosToolStripMenuItem_Click);
            // 
            // loginLogoutToolStripMenuItem
            // 
            this.loginLogoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMembrosToolStripMenuItem,
            this.lançarContribuiçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem1,
            this.editarLançamentosToolStripMenuItem});
            this.loginLogoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.loginLogoutToolStripMenuItem.Name = "loginLogoutToolStripMenuItem";
            this.loginLogoutToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.loginLogoutToolStripMenuItem.Text = "Controle por Membro";
            // 
            // listaDeMembrosToolStripMenuItem
            // 
            this.listaDeMembrosToolStripMenuItem.Name = "listaDeMembrosToolStripMenuItem";
            this.listaDeMembrosToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.listaDeMembrosToolStripMenuItem.Text = "Lista de Membros";
            this.listaDeMembrosToolStripMenuItem.Click += new System.EventHandler(this.listaDeMembrosToolStripMenuItem_Click);
            // 
            // lançarContribuiçõesToolStripMenuItem
            // 
            this.lançarContribuiçõesToolStripMenuItem.Name = "lançarContribuiçõesToolStripMenuItem";
            this.lançarContribuiçõesToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.lançarContribuiçõesToolStripMenuItem.Text = "Lançar Contribuições";
            this.lançarContribuiçõesToolStripMenuItem.Click += new System.EventHandler(this.lançarContribuiçõesToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem1
            // 
            this.relatóriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dízimosToolStripMenuItem,
            this.primíciasToolStripMenuItem,
            this.missõesToolStripMenuItem});
            this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
            this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(248, 30);
            this.relatóriosToolStripMenuItem1.Text = "Relatórios";
            // 
            // dízimosToolStripMenuItem
            // 
            this.dízimosToolStripMenuItem.Name = "dízimosToolStripMenuItem";
            this.dízimosToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.dízimosToolStripMenuItem.Text = "Dízimos";
            this.dízimosToolStripMenuItem.Click += new System.EventHandler(this.dízimosToolStripMenuItem_Click);
            // 
            // primíciasToolStripMenuItem
            // 
            this.primíciasToolStripMenuItem.Name = "primíciasToolStripMenuItem";
            this.primíciasToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.primíciasToolStripMenuItem.Text = "Primícias";
            this.primíciasToolStripMenuItem.Click += new System.EventHandler(this.primíciasToolStripMenuItem_Click);
            // 
            // missõesToolStripMenuItem
            // 
            this.missõesToolStripMenuItem.Name = "missõesToolStripMenuItem";
            this.missõesToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.missõesToolStripMenuItem.Text = "Missões";
            this.missõesToolStripMenuItem.Click += new System.EventHandler(this.missõesToolStripMenuItem_Click);
            // 
            // editarLançamentosToolStripMenuItem
            // 
            this.editarLançamentosToolStripMenuItem.Name = "editarLançamentosToolStripMenuItem";
            this.editarLançamentosToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.editarLançamentosToolStripMenuItem.Text = "Editar Lançamentos";
            this.editarLançamentosToolStripMenuItem.Click += new System.EventHandler(this.editarLançamentosToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // transferênciasToolStripMenuItem
            // 
            this.transferênciasToolStripMenuItem.Name = "transferênciasToolStripMenuItem";
            this.transferênciasToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.transferênciasToolStripMenuItem.Text = "Transferências";
            this.transferênciasToolStripMenuItem.Click += new System.EventHandler(this.transferênciasToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 375);
            this.Controls.Add(this.mainWindowMenuStrip);
            this.MainMenuStrip = this.mainWindowMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Controle Financeiro - Igreja Fonte de Vida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.mainWindowMenuStrip.ResumeLayout(false);
            this.mainWindowMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainWindowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem igrejasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesourariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginLogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposDePlanosDeContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeContasEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totaisPorPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarIgrejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerIgrejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirLançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeMembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarContribuiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dízimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primíciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciasToolStripMenuItem;
    }
}

