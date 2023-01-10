namespace SJmain.Telas.Departamentos.Tecnologia1
{
    partial class VerificarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificarEmpresa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEmpresas = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.rbDesativ = new System.Windows.Forms.RadioButton();
            this.rbInativa = new System.Windows.Forms.RadioButton();
            this.rbAtiva = new System.Windows.Forms.RadioButton();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbEmpresa.SuspendLayout();
            this.gbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEmpresas);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.Location = new System.Drawing.Point(7, 19);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(320, 21);
            this.cmbEmpresas.TabIndex = 2;
            this.cmbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresas_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(340, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 65);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 354);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.gbSituacao);
            this.gbEmpresa.Controls.Add(this.lbCNPJ);
            this.gbEmpresa.Controls.Add(this.textBox2);
            this.gbEmpresa.Controls.Add(this.lbNome);
            this.gbEmpresa.Controls.Add(this.textBox1);
            this.gbEmpresa.Location = new System.Drawing.Point(12, 113);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(421, 235);
            this.gbEmpresa.TabIndex = 2;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Empresa";
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(this.btnAlterar);
            this.gbSituacao.Controls.Add(this.rbDesativ);
            this.gbSituacao.Controls.Add(this.rbInativa);
            this.gbSituacao.Controls.Add(this.rbAtiva);
            this.gbSituacao.Location = new System.Drawing.Point(7, 125);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(339, 45);
            this.gbSituacao.TabIndex = 4;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(252, 15);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 22);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // rbDesativ
            // 
            this.rbDesativ.AutoSize = true;
            this.rbDesativ.Location = new System.Drawing.Point(152, 18);
            this.rbDesativ.Name = "rbDesativ";
            this.rbDesativ.Size = new System.Drawing.Size(79, 17);
            this.rbDesativ.TabIndex = 2;
            this.rbDesativ.TabStop = true;
            this.rbDesativ.Text = "Desativada";
            this.rbDesativ.UseVisualStyleBackColor = true;
            // 
            // rbInativa
            // 
            this.rbInativa.AutoSize = true;
            this.rbInativa.Location = new System.Drawing.Point(77, 18);
            this.rbInativa.Name = "rbInativa";
            this.rbInativa.Size = new System.Drawing.Size(57, 17);
            this.rbInativa.TabIndex = 1;
            this.rbInativa.TabStop = true;
            this.rbInativa.Text = "Inativa";
            this.rbInativa.UseVisualStyleBackColor = true;
            // 
            // rbAtiva
            // 
            this.rbAtiva.AutoSize = true;
            this.rbAtiva.Location = new System.Drawing.Point(7, 18);
            this.rbAtiva.Name = "rbAtiva";
            this.rbAtiva.Size = new System.Drawing.Size(49, 17);
            this.rbAtiva.TabIndex = 0;
            this.rbAtiva.TabStop = true;
            this.rbAtiva.Text = "Ativa";
            this.rbAtiva.UseVisualStyleBackColor = true;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(4, 73);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbCNPJ.TabIndex = 3;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(7, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(70, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Razão Social";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(408, 20);
            this.textBox1.TabIndex = 0;
            // 
            // VerificarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 389);
            this.Controls.Add(this.gbEmpresa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerificarEmpresa";
            this.Text = "Verificar Empresa";
            this.Load += new System.EventHandler(this.VerificarEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbEmpresas;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gbSituacao;
        private System.Windows.Forms.RadioButton rbDesativ;
        private System.Windows.Forms.RadioButton rbInativa;
        private System.Windows.Forms.RadioButton rbAtiva;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textBox1;
    }
}