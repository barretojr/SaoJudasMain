namespace SJmain
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LembrarUsuario = new System.Windows.Forms.CheckBox();
            this.UsuarioLogin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LembrarSenha = new System.Windows.Forms.CheckBox();
            this.SenhaLogin = new System.Windows.Forms.TextBox();
            this.EntrarLogin = new System.Windows.Forms.Button();
            this.BotaoSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LembrarUsuario);
            this.groupBox1.Controls.Add(this.UsuarioLogin);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // LembrarUsuario
            // 
            this.LembrarUsuario.AutoSize = true;
            this.LembrarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LembrarUsuario.Location = new System.Drawing.Point(7, 46);
            this.LembrarUsuario.Name = "LembrarUsuario";
            this.LembrarUsuario.Size = new System.Drawing.Size(103, 17);
            this.LembrarUsuario.TabIndex = 1;
            this.LembrarUsuario.Text = "Lembrar Usuário";
            this.LembrarUsuario.UseVisualStyleBackColor = true;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.Location = new System.Drawing.Point(6, 19);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(311, 20);
            this.UsuarioLogin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LembrarSenha);
            this.groupBox2.Controls.Add(this.SenhaLogin);
            this.groupBox2.Location = new System.Drawing.Point(32, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Senha";
            // 
            // LembrarSenha
            // 
            this.LembrarSenha.AutoSize = true;
            this.LembrarSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LembrarSenha.Location = new System.Drawing.Point(7, 45);
            this.LembrarSenha.Name = "LembrarSenha";
            this.LembrarSenha.Size = new System.Drawing.Size(98, 17);
            this.LembrarSenha.TabIndex = 1;
            this.LembrarSenha.Text = "Lembrar Senha";
            this.LembrarSenha.UseVisualStyleBackColor = true;
            // 
            // SenhaLogin
            // 
            this.SenhaLogin.Location = new System.Drawing.Point(6, 19);
            this.SenhaLogin.Name = "SenhaLogin";
            this.SenhaLogin.PasswordChar = '*';
            this.SenhaLogin.Size = new System.Drawing.Size(311, 20);
            this.SenhaLogin.TabIndex = 0;
            // 
            // EntrarLogin
            // 
            this.EntrarLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EntrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EntrarLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EntrarLogin.Location = new System.Drawing.Point(280, 216);
            this.EntrarLogin.Name = "EntrarLogin";
            this.EntrarLogin.Size = new System.Drawing.Size(75, 23);
            this.EntrarLogin.TabIndex = 2;
            this.EntrarLogin.Text = "Entrar";
            this.EntrarLogin.UseVisualStyleBackColor = false;
            this.EntrarLogin.Click += new System.EventHandler(this.EntrarLogin_Click);
            this.EntrarLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntrarLogin_KeyPress);
            // 
            // BotaoSair
            // 
            this.BotaoSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotaoSair.Location = new System.Drawing.Point(32, 216);
            this.BotaoSair.Name = "BotaoSair";
            this.BotaoSair.Size = new System.Drawing.Size(75, 23);
            this.BotaoSair.TabIndex = 3;
            this.BotaoSair.Text = "Sair";
            this.BotaoSair.UseVisualStyleBackColor = true;
            this.BotaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(380, 255);
            this.Controls.Add(this.BotaoSair);
            this.Controls.Add(this.EntrarLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "São Judas Contabil";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EntrarLogin;
        private System.Windows.Forms.Button BotaoSair;
        public System.Windows.Forms.CheckBox LembrarUsuario;
        public System.Windows.Forms.TextBox UsuarioLogin;
        public System.Windows.Forms.CheckBox LembrarSenha;
        public System.Windows.Forms.TextBox SenhaLogin;
    }
}

