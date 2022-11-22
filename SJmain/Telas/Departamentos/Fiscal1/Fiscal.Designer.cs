namespace SJmain.Telas.Departamentos
{
    partial class Fiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscal));
            this.MenuFiscal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFiscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFiscal
            // 
            this.MenuFiscal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.informaçõesToolStripMenuItem});
            this.MenuFiscal.Location = new System.Drawing.Point(0, 0);
            this.MenuFiscal.Name = "MenuFiscal";
            this.MenuFiscal.Size = new System.Drawing.Size(802, 24);
            this.MenuFiscal.TabIndex = 0;
            this.MenuFiscal.Text = "menuStrip1";
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
            this.atualizarEmpresaToolStripMenuItem});
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // atualizarEmpresaToolStripMenuItem
            // 
            this.atualizarEmpresaToolStripMenuItem.Name = "atualizarEmpresaToolStripMenuItem";
            this.atualizarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.atualizarEmpresaToolStripMenuItem.Text = "Atualizar Status da Empresa";
            this.atualizarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.atualizarEmpresaToolStripMenuItem_Click);
            // 
            // Fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 353);
            this.Controls.Add(this.MenuFiscal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuFiscal;
            this.Name = "Fiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuFiscal.ResumeLayout(false);
            this.MenuFiscal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuFiscal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarEmpresaToolStripMenuItem;
    }
}