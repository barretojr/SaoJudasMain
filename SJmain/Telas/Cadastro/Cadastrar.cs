using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas.Cadastro
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtUsuario != null)
            {                
                if (rdbContabil.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Contabil","Contabil");
                }
                if (rdbFiscal.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Fiscal","Fiscal");
                }
                if (rdbLogistica.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Logistica.","Logistica");
                }
                if (rdbTecnologia.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Tecnologia.","Tecnologia");
                }
            }
            else
            {
                MessageBox.Show("Digite um usuário");
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtUsuario != null)
            {
                if (rdbContabil.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Contabil", "Contabil");
                }
                if (rdbFiscal.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Fiscal", "Fiscal");
                }
                if (rdbLogistica.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Logistica.", "Logistica");
                }
                if (rdbTecnologia.Checked == true)
                {
                    MessageBox.Show("Usuario Cadastrado Tecnologia.", "Tecnologia");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um usuário");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
