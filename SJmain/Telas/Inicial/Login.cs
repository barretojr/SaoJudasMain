using SJmain.Modelo;
using SJmain.Telas;
using System;
using System.Linq;
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
            Controle controle = new Controle();
            Properties.Settings.Default.usuario = UsuarioLogin.Text;

            controle.acessar(UsuarioLogin.Text, SenhaLogin.Text);

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

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    SistemaPrincipal sp = new SistemaPrincipal();
                    sp.Show();
                    this.Hide();
                }
                else MessageBox.Show("Login não encontrado", "Erro Login");

            }


        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            DialogResult desejasair;
            desejasair = MessageBox.Show("Deseja sair ?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (desejasair == DialogResult.Yes) Application.Exit();

        }

        private void EntrarLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Controle controle = new Controle();
                controle.acessar(UsuarioLogin.Text, SenhaLogin.Text);
                if (UsuarioLogin.Text != null)
                {
                    if (controle.mensagem.Equals(""))
                    {
                        if (controle.tem == true)
                        {
                            SistemaPrincipal sp = new SistemaPrincipal();
                            sp.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Login não encontrado", "Erro Login");
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.usuario != null)
                UsuarioLogin.Text = Properties.Settings.Default.usuario;
            if (Properties.Settings.Default.senha != null)
                SenhaLogin.Text = Properties.Settings.Default.senha;
            LembrarUsuario.Checked = true;
        }
        private void testOpen()
        {
            if (Application.OpenForms.OfType<SistemaPrincipal>().Count() < 0)
            {
                Application.OpenForms.OfType<SistemaPrincipal>().First().Focus();
            }
            else
            {
                //Application.OpenForms.OfType<frmLogin>().First().Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            testOpen();
        }

        
    }
}
