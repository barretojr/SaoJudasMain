using SJmain.Properties;
using SJmain.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SJmain.Modelo;

namespace SJmain
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void EntrarLogin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(UsuarioLogin.Text, SenhaLogin.Text);
            if (UsuarioLogin.Text != null && SenhaLogin.Text != null)
            {
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        SistemaPrincipal sp = new SistemaPrincipal();
                        sp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login não encontrado", "Erro Login");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um usuário e senha", "Erro");
            }
        } 

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            DialogResult desejasair;
            desejasair = MessageBox.Show("Deseja sair ?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (desejasair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           

        }
    }
}
