namespace SJmain.Telas.Departamentos.Tecnologia1
{
    partial class Inventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbUnidade = new System.Windows.Forms.RadioButton();
            this.rdbPatrimonio = new System.Windows.Forms.RadioButton();
            this.rdbUsuario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 236);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(508, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 63);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUsuario);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.rdbUnidade);
            this.groupBox1.Controls.Add(this.rdbPatrimonio);
            this.groupBox1.Location = new System.Drawing.Point(172, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar equipamento";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(302, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // rdbUnidade
            // 
            this.rdbUnidade.AutoSize = true;
            this.rdbUnidade.BackColor = System.Drawing.SystemColors.Control;
            this.rdbUnidade.Location = new System.Drawing.Point(123, 45);
            this.rdbUnidade.Name = "rdbUnidade";
            this.rdbUnidade.Size = new System.Drawing.Size(65, 17);
            this.rdbUnidade.TabIndex = 1;
            this.rdbUnidade.TabStop = true;
            this.rdbUnidade.Text = "Unidade";
            this.rdbUnidade.UseVisualStyleBackColor = false;
            // 
            // rdbPatrimonio
            // 
            this.rdbPatrimonio.AutoSize = true;
            this.rdbPatrimonio.Location = new System.Drawing.Point(25, 46);
            this.rdbPatrimonio.Name = "rdbPatrimonio";
            this.rdbPatrimonio.Size = new System.Drawing.Size(74, 17);
            this.rdbPatrimonio.TabIndex = 0;
            this.rdbPatrimonio.TabStop = true;
            this.rdbPatrimonio.Text = "Patrimônio";
            this.rdbPatrimonio.UseVisualStyleBackColor = true;
            // 
            // rdbUsuario
            // 
            this.rdbUsuario.AutoSize = true;
            this.rdbUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.rdbUsuario.Location = new System.Drawing.Point(226, 45);
            this.rdbUsuario.Name = "rdbUsuario";
            this.rdbUsuario.Size = new System.Drawing.Size(61, 17);
            this.rdbUsuario.TabIndex = 3;
            this.rdbUsuario.TabStop = true;
            this.rdbUsuario.Text = "Usuário";
            this.rdbUsuario.UseVisualStyleBackColor = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventario";
            this.Text = "Inventário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbUnidade;
        private System.Windows.Forms.RadioButton rdbPatrimonio;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUsuario;
    }
}