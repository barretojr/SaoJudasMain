namespace SJmain.Telas
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
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOpcoes
            // 
            this.MenuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.opçõesToolStripMenuItem});
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
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contabilidadeToolStripMenuItem,
            this.fiscalToolStripMenuItem,
            this.logisticaToolStripMenuItem,
            this.tecnologiaToolStripMenuItem});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // contabilidadeToolStripMenuItem
            // 
            this.contabilidadeToolStripMenuItem.Name = "contabilidadeToolStripMenuItem";
            this.contabilidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contabilidadeToolStripMenuItem.Text = "Contabilidade";
            // 
            // fiscalToolStripMenuItem
            // 
            this.fiscalToolStripMenuItem.Name = "fiscalToolStripMenuItem";
            this.fiscalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fiscalToolStripMenuItem.Text = "Fiscal";
            // 
            // logisticaToolStripMenuItem
            // 
            this.logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            this.logisticaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logisticaToolStripMenuItem.Text = "Logistica";
            // 
            // tecnologiaToolStripMenuItem
            // 
            this.tecnologiaToolStripMenuItem.Name = "tecnologiaToolStripMenuItem";
            this.tecnologiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tecnologiaToolStripMenuItem.Text = "Tecnologia";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // SistemaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuOpcoes);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuOpcoes;
            this.Name = "SistemaPrincipal";
            this.Text = "SistemaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuOpcoes.ResumeLayout(false);
            this.MenuOpcoes.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}