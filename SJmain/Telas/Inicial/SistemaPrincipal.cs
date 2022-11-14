using SJmain.Modelo;
using SJmain.Telas.Cadastro;
using SJmain.Telas.Departamentos;
using SJmain.Telas.Departamentos.Logistica;
using System;
using System.Windows.Forms;

namespace SJmain.Telas
{
    public partial class SistemaPrincipal : Form
    {
        public SistemaPrincipal()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,2=contabil,5=tecnologia
            int master = 1, contabil = 2, tecnologia = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, contabil);
            if (controle.mensagem.Equals(""))
            {
                if(controle.tem == true)
                {
                    Contabilidade conta = new Contabilidade();
                    conta.Show();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,3=fiscal,5=tecnologia,
            int master = 1, fiscal = 3, tecnologia = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, fiscal);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Contabilidade conta = new Contabilidade();
                    conta.Show();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,5=tecnologia,
            int  tecnologia = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, Tecnologia);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Contabilidade conta = new Contabilidade();
                    conta.Show();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,5=tecnologia
            int master = 1, tecnologia = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, tecnologia);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Contabilidade conta = new Contabilidade();
                    conta.Show();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,5=tecnologia,
            int master = 1, tecnologia = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, tecnologia);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Contabilidade conta = new Contabilidade();
                    conta.Show();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void departamentoPessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Derpatpessoal dp = new Derpatpessoal();
            dp.Show();
            this.Hide();
        }

        private void societárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Societario societario = new Societario();
            societario.Show();
            this.Hide();
        }

        private void ocorreuUmErroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult eita;
            eita = MessageBox.Show("Eita!", "Eita!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ligaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
