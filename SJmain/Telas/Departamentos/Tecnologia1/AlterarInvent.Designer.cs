namespace SJmain.Telas.Departamentos.Tecnologia1
{
    partial class AlterarInvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarInvent));
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mskValorEsti = new System.Windows.Forms.MaskedTextBox();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.txtProcessador = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleDescription = "";
            this.txtUsuario.Location = new System.Drawing.Point(14, 411);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(112, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // mskValorEsti
            // 
            this.mskValorEsti.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskValorEsti.Location = new System.Drawing.Point(212, 352);
            this.mskValorEsti.Mask = "9999999";
            this.mskValorEsti.Name = "mskValorEsti";
            this.mskValorEsti.Size = new System.Drawing.Size(112, 20);
            this.mskValorEsti.TabIndex = 6;
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(553, 350);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(112, 20);
            this.txtMemoria.TabIndex = 8;
            // 
            // txtProcessador
            // 
            this.txtProcessador.Location = new System.Drawing.Point(553, 287);
            this.txtProcessador.Name = "txtProcessador";
            this.txtProcessador.Size = new System.Drawing.Size(112, 20);
            this.txtProcessador.TabIndex = 4;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(212, 287);
            this.txtLocal.MaxLength = 15;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(112, 20);
            this.txtLocal.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(360, 352);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "Piancó",
            "Orfanato"});
            this.cbUnidade.Location = new System.Drawing.Point(15, 352);
            this.cbUnidade.MaxLength = 10;
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(156, 21);
            this.cbUnidade.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(360, 287);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(156, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Memória";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Processador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Valor Estimado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Localização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Modelo";
            // 
            // txtPatri
            // 
            this.txtPatri.Location = new System.Drawing.Point(15, 287);
            this.txtPatri.MaxLength = 6;
            this.txtPatri.Name = "txtPatri";
            this.txtPatri.Size = new System.Drawing.Size(156, 20);
            this.txtPatri.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Patrimônio";
            // 
            // AlterarInvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.mskValorEsti);
            this.Controls.Add(this.txtMemoria);
            this.Controls.Add(this.txtProcessador);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarInvent";
            this.Text = "Alterar Inventário";
            this.Load += new System.EventHandler(this.AlterarInvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mskValorEsti;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.TextBox txtProcessador;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}