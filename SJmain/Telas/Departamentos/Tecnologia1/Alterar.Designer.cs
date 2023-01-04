namespace SJmain.Telas.Cadastro
{
    partial class Alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbSenha = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.gbDepart = new System.Windows.Forms.GroupBox();
            this.ckbCoord = new System.Windows.Forms.CheckBox();
            this.rdbPessoal = new System.Windows.Forms.RadioButton();
            this.rdbSocietario = new System.Windows.Forms.RadioButton();
            this.rdbTecnologia = new System.Windows.Forms.RadioButton();
            this.rdbLogistica = new System.Windows.Forms.RadioButton();
            this.rdbFiscal = new System.Windows.Forms.RadioButton();
            this.rdbContabil = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSenha.SuspendLayout();
            this.gbDepart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.rdbCPF);
            this.groupBox1.Controls.Add(this.rdbNome);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Usuário";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(302, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Location = new System.Drawing.Point(155, 46);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.rdbCPF.TabIndex = 1;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(6, 46);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(107, 17);
            this.rdbNome.TabIndex = 0;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome de Usuário";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(344, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 63);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 103);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbSenha
            // 
            this.gbSenha.Controls.Add(this.label2);
            this.gbSenha.Controls.Add(this.label1);
            this.gbSenha.Controls.Add(this.txtConfSenha);
            this.gbSenha.Controls.Add(this.txtSenha);
            this.gbSenha.Controls.Add(this.btnVerificar);
            this.gbSenha.Location = new System.Drawing.Point(12, 220);
            this.gbSenha.Name = "gbSenha";
            this.gbSenha.Size = new System.Drawing.Size(254, 116);
            this.gbSenha.TabIndex = 3;
            this.gbSenha.TabStop = false;
            this.gbSenha.Text = "Alterar Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme a Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(6, 81);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(130, 20);
            this.txtConfSenha.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 38);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(130, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(155, 38);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(84, 63);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar...";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // gbDepart
            // 
            this.gbDepart.Controls.Add(this.ckbCoord);
            this.gbDepart.Controls.Add(this.rdbPessoal);
            this.gbDepart.Controls.Add(this.rdbSocietario);
            this.gbDepart.Controls.Add(this.rdbTecnologia);
            this.gbDepart.Controls.Add(this.rdbLogistica);
            this.gbDepart.Controls.Add(this.rdbFiscal);
            this.gbDepart.Controls.Add(this.rdbContabil);
            this.gbDepart.Location = new System.Drawing.Point(272, 220);
            this.gbDepart.Name = "gbDepart";
            this.gbDepart.Size = new System.Drawing.Size(226, 116);
            this.gbDepart.TabIndex = 4;
            this.gbDepart.TabStop = false;
            this.gbDepart.Text = "Departamento";
            // 
            // ckbCoord
            // 
            this.ckbCoord.AutoSize = true;
            this.ckbCoord.Location = new System.Drawing.Point(109, 89);
            this.ckbCoord.Name = "ckbCoord";
            this.ckbCoord.Size = new System.Drawing.Size(90, 17);
            this.ckbCoord.TabIndex = 6;
            this.ckbCoord.Text = "Coordenação";
            this.ckbCoord.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            this.rdbPessoal.AutoSize = true;
            this.rdbPessoal.Location = new System.Drawing.Point(109, 43);
            this.rdbPessoal.Name = "rdbPessoal";
            this.rdbPessoal.Size = new System.Drawing.Size(62, 17);
            this.rdbPessoal.TabIndex = 5;
            this.rdbPessoal.TabStop = true;
            this.rdbPessoal.Text = "Pessoal";
            this.rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbSocietario
            // 
            this.rdbSocietario.AutoSize = true;
            this.rdbSocietario.Location = new System.Drawing.Point(109, 19);
            this.rdbSocietario.Name = "rdbSocietario";
            this.rdbSocietario.Size = new System.Drawing.Size(72, 17);
            this.rdbSocietario.TabIndex = 4;
            this.rdbSocietario.TabStop = true;
            this.rdbSocietario.Text = "Societário";
            this.rdbSocietario.UseVisualStyleBackColor = true;
            // 
            // rdbTecnologia
            // 
            this.rdbTecnologia.AutoSize = true;
            this.rdbTecnologia.Location = new System.Drawing.Point(6, 88);
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
            this.rdbLogistica.Location = new System.Drawing.Point(6, 65);
            this.rdbLogistica.Name = "rdbLogistica";
            this.rdbLogistica.Size = new System.Drawing.Size(69, 17);
            this.rdbLogistica.TabIndex = 2;
            this.rdbLogistica.TabStop = true;
            this.rdbLogistica.Text = "Logistíca";
            this.rdbLogistica.UseVisualStyleBackColor = true;
            // 
            // rdbFiscal
            // 
            this.rdbFiscal.AutoSize = true;
            this.rdbFiscal.Location = new System.Drawing.Point(6, 42);
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
            this.rdbContabil.Location = new System.Drawing.Point(6, 19);
            this.rdbContabil.Name = "rdbContabil";
            this.rdbContabil.Size = new System.Drawing.Size(89, 17);
            this.rdbContabil.TabIndex = 0;
            this.rdbContabil.TabStop = true;
            this.rdbContabil.Text = "Contabilidade";
            this.rdbContabil.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(423, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(342, 415);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDepart);
            this.Controls.Add(this.gbSenha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSenha.ResumeLayout(false);
            this.gbSenha.PerformLayout();
            this.gbDepart.ResumeLayout(false);
            this.gbDepart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox gbDepart;
        private System.Windows.Forms.RadioButton rdbPessoal;
        private System.Windows.Forms.RadioButton rdbSocietario;
        private System.Windows.Forms.RadioButton rdbTecnologia;
        private System.Windows.Forms.RadioButton rdbLogistica;
        private System.Windows.Forms.RadioButton rdbFiscal;
        private System.Windows.Forms.RadioButton rdbContabil;
        private System.Windows.Forms.CheckBox ckbCoord;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
    }
}