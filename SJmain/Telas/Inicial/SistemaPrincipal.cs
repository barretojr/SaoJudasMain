using SJmain.Modelo;
using SJmain.Telas.Departamentos;
using SJmain.Telas.Departamentos.Log;
using System;
using System.Linq;
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
            if (Application.OpenForms.OfType<Contabilidade>().Count() > 0)
            {
                Application.OpenForms.OfType<Contabilidade>().First().Focus();
            }
            else
            {
                int depart = 5;
                Controle controle = new Controle();
                controle.acessarform(Properties.Settings.Default.usuario, depart);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem == true)
                    {
                        Contabilidade conta = new Contabilidade();
                        conta.ShowDialog();
                    }

                    else MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Fiscal>().Count() > 0)
            {
                Application.OpenForms.OfType<Fiscal>().First().Focus();
            }
            else
            {
                int depart = 5;
                Controle controle = new Controle();
                controle.acessarform(Properties.Settings.Default.usuario, depart);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem == true)
                    {
                        Fiscal fisc = new Fiscal();
                        fisc.ShowDialog();
                    }

                    else MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Tecnologia>().Count() > 0)
            {
                Application.OpenForms.OfType<Tecnologia>().First().Focus();
            }
            else
            {
                //1 = master,5 = tecnologia,
                int depart = 5;
                Controle controle = new Controle();
                controle.acessarform(Properties.Settings.Default.usuario, depart);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem == true)
                    {
                        Tecnologia tec = new Tecnologia();
                        tec.ShowDialog();
                    }

                    else MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void departamentoPessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Derpatpessoal>().Count() > 0)
            {
                Application.OpenForms.OfType<Derpatpessoal>().First().Focus();
            }
            else
            {
                int depart = 5;
                Controle controle = new Controle();
                controle.acessarform(Properties.Settings.Default.usuario, depart);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem == true)
                    {
                        Derpatpessoal dp = new Derpatpessoal();
                        dp.ShowDialog();
                    }

                    else MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void societárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Societario>().Count() > 0)
            {
                Application.OpenForms.OfType<Societario>().First().Focus();
            }
            else
            {
                int depart = 5;
                Controle controle = new Controle();
                controle.acessarform(Properties.Settings.Default.usuario, depart);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem == true)
                    {
                        Societario societario = new Societario();
                        societario.ShowDialog();
                    }

                    else MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (Application.OpenForms.OfType<Logist>().Count() > 0)
            {
                Application.OpenForms.OfType<Logist>().First().Focus();
            }
            else
            {
                //4 = logistica
                int depart = 5;
                Controle controle = new Controle();
                controle.acessarform(Properties.Settings.Default.usuario, depart);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem == true)
                    {
                        Logist log = new Logist();
                        log.ShowDialog();
                    }

                    else MessageBox.Show("Você não tem permissão para acessar", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
