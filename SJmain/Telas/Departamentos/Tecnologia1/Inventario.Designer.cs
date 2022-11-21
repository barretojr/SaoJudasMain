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
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.rdbColaborador = new System.Windows.Forms.RadioButton();
            this.rdbPatrimonio = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatrimonio = new System.Windows.Forms.Label();
            this.Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.rdbMarca);
            this.Buscar.Controls.Add(this.rdbColaborador);
            this.Buscar.Controls.Add(this.rdbPatrimonio);
            this.Buscar.Controls.Add(this.txtBuscar);
            this.Buscar.Controls.Add(this.btnBuscar);
            this.Buscar.Location = new System.Drawing.Point(12, 27);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(293, 99);
            this.Buscar.TabIndex = 1;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Location = new System.Drawing.Point(111, 46);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(55, 17);
            this.rdbMarca.TabIndex = 4;
            this.rdbMarca.TabStop = true;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            // 
            // rdbColaborador
            // 
            this.rdbColaborador.AutoSize = true;
            this.rdbColaborador.Location = new System.Drawing.Point(6, 70);
            this.rdbColaborador.Name = "rdbColaborador";
            this.rdbColaborador.Size = new System.Drawing.Size(82, 17);
            this.rdbColaborador.TabIndex = 3;
            this.rdbColaborador.TabStop = true;
            this.rdbColaborador.Text = "Colaborador";
            this.rdbColaborador.UseVisualStyleBackColor = true;
            // 
            // rdbPatrimonio
            // 
            this.rdbPatrimonio.AutoSize = true;
            this.rdbPatrimonio.Location = new System.Drawing.Point(7, 46);
            this.rdbPatrimonio.Name = "rdbPatrimonio";
            this.rdbPatrimonio.Size = new System.Drawing.Size(74, 17);
            this.rdbPatrimonio.TabIndex = 2;
            this.rdbPatrimonio.TabStop = true;
            this.rdbPatrimonio.Text = "Patrimônio";
            this.rdbPatrimonio.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(203, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(215, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 68);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patrimônio";
            // 
            // lblPatrimonio
            // 
            this.lblPatrimonio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatrimonio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPatrimonio.Location = new System.Drawing.Point(12, 157);
            this.lblPatrimonio.Name = "lblPatrimonio";
            this.lblPatrimonio.Size = new System.Drawing.Size(148, 23);
            this.lblPatrimonio.TabIndex = 3;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPatrimonio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.RadioButton rdbColaborador;
        private System.Windows.Forms.RadioButton rdbPatrimonio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatrimonio;
    }
}