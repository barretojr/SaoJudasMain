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
           if(UsuarioLogin.Text == "admin" && SenhaLogin.Text == "admin")
            {
                SistemaPrincipal sp = new SistemaPrincipal();
                sp.Show();
                this.Hide();
                if (LembrarUsuario.Checked == true)
                {
                    Properties.Settings.Default.usuario = UsuarioLogin.Text;
                    Properties.Settings.Default.Save();
                    if (LembrarSenha.Checked == true)
                    {
                        Properties.Settings.Default.senha = SenhaLogin.Text;
                        Properties.Settings.Default.Save();
                    }
                    if (LembrarSenha.Checked == false)
                    {
                        Properties.Settings.Default.senha = "";
                        Properties.Settings.Default.Save();
                    }
                }
                if (LembrarUsuario.Checked == false)
                {
                    Properties.Settings.Default.usuario = "";
                    Properties.Settings.Default.Save();
                }
                

            }
            else if (UsuarioLogin.Text == "jonathan" && SenhaLogin.Text == "1234")
            {
                SistemaPrincipal sp = new SistemaPrincipal();
                sp.Show();
                this.Hide();                
                
                if (LembrarUsuario.Checked == true)
                {
                    Properties.Settings.Default.usuario = UsuarioLogin.Text;
                    Properties.Settings.Default.Save();
                    if (LembrarSenha.Checked == true)
                    {
                        Properties.Settings.Default.senha = SenhaLogin.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.senha = "";
                        Properties.Settings.Default.Save();
                    }
                }
                if (LembrarUsuario.Checked == false)
                {
                    Properties.Settings.Default.usuario = "";
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("Usuário Incorreto");
            }
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {          

            if (Settings.Default.usuario != null)
            UsuarioLogin.Text = Properties.Settings.Default.usuario;
            if(Settings.Default.senha != null)
            SenhaLogin.Text = Properties.Settings.Default.senha;
            LembrarUsuario.Checked = true;
            LembrarSenha.Checked = true;
            
        }
    }
}
