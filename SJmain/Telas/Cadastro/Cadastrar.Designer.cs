namespace SJmain.Telas.Cadastro
{
    partial class Cadastrar
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTecnologia = new System.Windows.Forms.RadioButton();
            this.rdbLogistica = new System.Windows.Forms.RadioButton();
            this.rdbFiscal = new System.Windows.Forms.RadioButton();
            this.rdbContabil = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbSocietario = new System.Windows.Forms.RadioButton();
            this.rdbPessoal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(231, 52);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(87, 50);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar...";
            this.btnVerificar.UseVisualStyleBackColor = true;            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(402, 204);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(320, 204);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(22, 200);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPessoal);
            this.groupBox1.Controls.Add(this.rdbSocietario);
            this.groupBox1.Controls.Add(this.rdbTecnologia);
            this.groupBox1.Controls.Add(this.rdbLogistica);
            this.groupBox1.Controls.Add(this.rdbFiscal);
            this.groupBox1.Controls.Add(this.rdbContabil);
            this.groupBox1.Location = new System.Drawing.Point(336, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 159);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões";
            // 
            // rdbTecnologia
            // 
            this.rdbTecnologia.AutoSize = true;
            this.rdbTecnologia.Location = new System.Drawing.Point(7, 92);
            this.rdbTecnologia.Name = "rdbTecnologia";
            this.rdbTecnologia.Size = new System.Drawing.Size(78, 17);
            this.rdbTecnologia.TabIndex = 3;
            this.rdbTecnologia.TabStop = true;
            this.rdbTecnologia.Text = "Tecnologia";
            this.rdbTecnologia.UseVisualStyleBackColor = true;
            // 
            // rdbLogistica
            // 
            this.rdbLogistica.AutoSize = true;
            this.rdbLogistica.Location = new System.Drawing.Point(7, 68);
            this.rdbLogistica.Name = "rdbLogistica";
            this.rdbLogistica.Size = new System.Drawing.Size(67, 17);
            this.rdbLogistica.TabIndex = 2;
            this.rdbLogistica.TabStop = true;
            this.rdbLogistica.Text = "Logistica";
            this.rdbLogistica.UseVisualStyleBackColor = true;
            // 
            // rdbFiscal
            // 
            this.rdbFiscal.AutoSize = true;
            this.rdbFiscal.Location = new System.Drawing.Point(7, 44);
            this.rdbFiscal.Name = "rdbFiscal";
            this.rdbFiscal.Size = new System.Drawing.Size(52, 17);
            this.rdbFiscal.TabIndex = 1;
            this.rdbFiscal.TabStop = true;
            this.rdbFiscal.Text = "Fiscal";
            this.rdbFiscal.UseVisualStyleBackColor = true;
            // 
            // rdbContabil
            // 
            this.rdbContabil.AutoSize = true;
            this.rdbContabil.Location = new System.Drawing.Point(7, 20);
            this.rdbContabil.Name = "rdbContabil";
            this.rdbContabil.Size = new System.Drawing.Size(89, 17);
            this.rdbContabil.TabIndex = 0;
            this.rdbContabil.TabStop = true;
            this.rdbContabil.Text = "Contabilidade";
            this.rdbContabil.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(67, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(251, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(67, 51);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(158, 20);
            this.txtSenha.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 20);
            this.txtNome.TabIndex = 18;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(67, 135);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(86, 20);
            this.mskCPF.TabIndex = 19;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(230, 135);
            this.mskTelefone.Mask = "(99)99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(88, 20);
            this.mskTelefone.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(67, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(67, 77);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(158, 20);
            this.txtConfirmar.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Confirmar:";
            // 
            // rdbSocietario
            // 
            this.rdbSocietario.AutoSize = true;
            this.rdbSocietario.Location = new System.Drawing.Point(6, 115);
            this.rdbSocietario.Name = "rdbSocietario";
            this.rdbSocietario.Size = new System.Drawing.Size(72, 17);
            this.rdbSocietario.TabIndex = 4;
            this.rdbSocietario.TabStop = true;
            this.rdbSocietario.Text = "Societario";
            this.rdbSocietario.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            this.rdbPessoal.AutoSize = true;
            this.rdbPessoal.Location = new System.Drawing.Point(7, 138);
            this.rdbPessoal.Name = "rdbPessoal";
            this.rdbPessoal.Size = new System.Drawing.Size(62, 17);
            this.rdbPessoal.TabIndex = 5;
            this.rdbPessoal.TabStop = true;
            this.rdbPessoal.Text = "Pessoal";
            this.rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 276);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbTecnologia;
        private System.Windows.Forms.RadioButton rdbLogistica;
        private System.Windows.Forms.RadioButton rdbFiscal;
        private System.Windows.Forms.RadioButton rdbContabil;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbPessoal;
        private System.Windows.Forms.RadioButton rdbSocietario;
    }
}