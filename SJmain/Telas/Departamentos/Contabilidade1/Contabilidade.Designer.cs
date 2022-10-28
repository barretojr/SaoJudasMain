namespace SJmain.Telas.Departamentos
{
    partial class Contabilidade
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
            this.MenuContabilidade = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarStatusEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarStatusEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContabilidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContabilidade
            // 
            this.MenuContabilidade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.informaçõesToolStripMenuItem});
            this.MenuContabilidade.Location = new System.Drawing.Point(0, 0);
            this.MenuContabilidade.Name = "MenuContabilidade";
            this.MenuContabilidade.Size = new System.Drawing.Size(653, 24);
            this.MenuContabilidade.TabIndex = 0;
            this.MenuContabilidade.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
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
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarStatusEmpresaToolStripMenuItem,
            this.visualizarStatusEmpresaToolStripMenuItem});
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // alterarStatusEmpresaToolStripMenuItem
            // 
            this.alterarStatusEmpresaToolStripMenuItem.Name = "alterarStatusEmpresaToolStripMenuItem";
            this.alterarStatusEmpresaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.alterarStatusEmpresaToolStripMenuItem.Text = "Alterar Status Empresa";
            this.alterarStatusEmpresaToolStripMenuItem.Click += new System.EventHandler(this.alterarStatusEmpresaToolStripMenuItem_Click);
            // 
            // visualizarStatusEmpresaToolStripMenuItem
            // 
            this.visualizarStatusEmpresaToolStripMenuItem.Name = "visualizarStatusEmpresaToolStripMenuItem";
            this.visualizarStatusEmpresaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.visualizarStatusEmpresaToolStripMenuItem.Text = "Visualizar Status Empresa";
            // 
            // Contabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 497);
            this.Controls.Add(this.MenuContabilidade);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuContabilidade;
            this.Name = "Contabilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilidade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuContabilidade.ResumeLayout(false);
            this.MenuContabilidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuContabilidade;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarStatusEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarStatusEmpresaToolStripMenuItem;
    }
}