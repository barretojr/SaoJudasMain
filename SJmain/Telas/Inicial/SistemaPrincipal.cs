using SJmain.Modelo;
using SJmain.Telas.Cadastro;
using SJmain.Telas.Departamentos;
using SJmain.Telas.Departamentos.Log;
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
            int depart = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, depart);
            if (controle.mensagem.Equals(""))
            {
                if(controle.tem == true)
                {
                    Contabilidade conta = new Contabilidade();
                    conta.Show();
                }

                else  MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,3=fiscal,5=tecnologia,
            int depart = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, depart);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Fiscal fisc = new Fiscal();
                    fisc.Show();
                }

                else  MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1=master,5=tecnologia,
            int  depart = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, depart);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Tecnologia tec = new Tecnologia();
                    tec.Show();
                }

                else   MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }        

        private void departamentoPessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int depart = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, depart);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Derpatpessoal dp = new Derpatpessoal();
                    dp.Show();
                }

                else   MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void societárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int depart = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, depart);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Societario societario = new Societario();
                    societario.Show();
                }

                else   MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void ocorreuUmErroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Eita;
            Eita = MessageBox.Show("Eita!", "Eita!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            while (Eita == DialogResult.Retry)
            {
                Eita = MessageBox.Show("Eita!", "Eita!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        

        private void SistemaPrincipal_Load(object sender, EventArgs e)
        {
            UsuarioLogado.Text = Properties.Settings.Default.usuario;
        }

        private void logisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //4=  logistica
            int depart = 5;
            Controle controle = new Controle();
            controle.acessarform(Properties.Settings.Default.usuario, depart);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem == true)
                {
                    Logist log = new Logist();
                    log.Show();
                }

                else  MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
