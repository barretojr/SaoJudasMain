using SJmain.Telas.Cadastro;
using SJmain.Telas.Departamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas
{
    public partial class SistemaPrincipal : Form
    {
        public SistemaPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void contabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contabilidade Cont = new Contabilidade();
            Cont.Show();

        }

        private void logisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logistica log = new Logistica();
            log.Show();
        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiscal fis = new Fiscal();
            fis.Show();
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.usuario == "jonathan")
            {
                Tecnologia tec = new Tecnologia();
                tec.Show();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }
            
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.usuario == "jonathan")
            {
                Cadastrar cad = new Cadastrar();
                cad.Show();
            }
            
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.usuario == "jonathan")
            {
                Alterar alterar = new Alterar();
                alterar.Show();
            }
            
        }

        private void departamentoPessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Derpatpessoal dp = new Derpatpessoal();
            dp.Show();
        }

        private void societárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Societario societario = new Societario();
            societario.Show();
        }
    }
}
