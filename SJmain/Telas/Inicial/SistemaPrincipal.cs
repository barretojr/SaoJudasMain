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
            Contabilidade Cont = new Contabilidade();
            Cont.Show();
            this.Close();

        }



        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiscal fis = new Fiscal();
            fis.Show();
            this.Hide();
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.usuario == "jonathan")
            {
                Cadastrar cad = new Cadastrar();
                cad.Show();

            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.usuario == "jonathan")
            {
                Alterar alterar = new Alterar();
                alterar.Show();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
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
            Agenda ag = new Agenda();
            ag.Show();
        }

        private void entineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Itinerario it = new Itinerario();
            it.Show();
        }

        private void ligaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ligacoes lig = new Ligacoes();
            lig.Show();
        }
    }
}
