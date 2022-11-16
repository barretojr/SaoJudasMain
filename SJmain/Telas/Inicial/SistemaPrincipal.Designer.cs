﻿namespace SJmain.Telas
{
    partial class SistemaPrincipal
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
            this.MenuOpcoes = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.societárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoPessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarInformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocorreuUmErroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip1 = new System.Windows.Forms.StatusStrip();
            this.UsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuOpcoes.SuspendLayout();
            this.Strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOpcoes
            // 
            this.MenuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.MenuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.MenuOpcoes.Name = "MenuOpcoes";
            this.MenuOpcoes.Size = new System.Drawing.Size(800, 24);
            this.MenuOpcoes.TabIndex = 0;
            this.MenuOpcoes.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contabilidadeToolStripMenuItem,
            this.fiscalToolStripMenuItem,
            this.logisticaToolStripMenuItem,
            this.tecnologiaToolStripMenuItem,
            this.societárioToolStripMenuItem,
            this.departamentoPessoalToolStripMenuItem});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // contabilidadeToolStripMenuItem
            // 
            this.contabilidadeToolStripMenuItem.Name = "contabilidadeToolStripMenuItem";
            this.contabilidadeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.contabilidadeToolStripMenuItem.Text = "Contabilidade";
            this.contabilidadeToolStripMenuItem.Click += new System.EventHandler(this.contabilidadeToolStripMenuItem_Click);
            // 
            // fiscalToolStripMenuItem
            // 
            this.fiscalToolStripMenuItem.Name = "fiscalToolStripMenuItem";
            this.fiscalToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fiscalToolStripMenuItem.Text = "Fiscal";
            this.fiscalToolStripMenuItem.Click += new System.EventHandler(this.fiscalToolStripMenuItem_Click);
            // 
            // logisticaToolStripMenuItem
            // 
            this.logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            this.logisticaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.logisticaToolStripMenuItem.Text = "Logistica";
            this.logisticaToolStripMenuItem.Click += new System.EventHandler(this.logisticaToolStripMenuItem_Click);
            // 
            // tecnologiaToolStripMenuItem
            // 
            this.tecnologiaToolStripMenuItem.Name = "tecnologiaToolStripMenuItem";
            this.tecnologiaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tecnologiaToolStripMenuItem.Text = "Tecnologia";
            this.tecnologiaToolStripMenuItem.Click += new System.EventHandler(this.tecnologiaToolStripMenuItem_Click);
            // 
            // societárioToolStripMenuItem
            // 
            this.societárioToolStripMenuItem.Name = "societárioToolStripMenuItem";
            this.societárioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.societárioToolStripMenuItem.Text = "Societário";
            this.societárioToolStripMenuItem.Click += new System.EventHandler(this.societárioToolStripMenuItem_Click);
            // 
            // departamentoPessoalToolStripMenuItem
            // 
            this.departamentoPessoalToolStripMenuItem.Name = "departamentoPessoalToolStripMenuItem";
            this.departamentoPessoalToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.departamentoPessoalToolStripMenuItem.Text = "Departamento Pessoal";
            this.departamentoPessoalToolStripMenuItem.Click += new System.EventHandler(this.departamentoPessoalToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarInformaçõesToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // exportarInformaçõesToolStripMenuItem
            // 
            this.exportarInformaçõesToolStripMenuItem.Name = "exportarInformaçõesToolStripMenuItem";
            this.exportarInformaçõesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportarInformaçõesToolStripMenuItem.Text = "Exportar Informações";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocorreuUmErroToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ocorreuUmErroToolStripMenuItem
            // 
            this.ocorreuUmErroToolStripMenuItem.Name = "ocorreuUmErroToolStripMenuItem";
            this.ocorreuUmErroToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ocorreuUmErroToolStripMenuItem.Text = "Ocorreu um erro";
            this.ocorreuUmErroToolStripMenuItem.Click += new System.EventHandler(this.ocorreuUmErroToolStripMenuItem_Click);
            // 
            // Strip1
            // 
            this.Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioLogado});
            this.Strip1.Location = new System.Drawing.Point(0, 428);
            this.Strip1.Name = "Strip1";
            this.Strip1.Size = new System.Drawing.Size(800, 22);
            this.Strip1.TabIndex = 1;
            this.Strip1.Text = "statusStrip1";
            // 
            // UsuarioLogado
            // 
            this.UsuarioLogado.Name = "UsuarioLogado";
            this.UsuarioLogado.Size = new System.Drawing.Size(32, 17);
            this.UsuarioLogado.Text = "teste";
            // 
            // SistemaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Strip1);
            this.Controls.Add(this.MenuOpcoes);
            this.MainMenuStrip = this.MenuOpcoes;
            this.Name = "SistemaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.SistemaPrincipal_Load);
            this.MenuOpcoes.ResumeLayout(false);
            this.MenuOpcoes.PerformLayout();
            this.Strip1.ResumeLayout(false);
            this.Strip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem societárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoPessoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarInformaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocorreuUmErroToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Strip1;
        public System.Windows.Forms.ToolStripStatusLabel UsuarioLogado;
    }
}