using SJmain.Telas.Cadastro;
using SJmain.Telas.Departamentos.Tecnologia1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos
{
    public partial class Tecnologia : Form
    {
        public Tecnologia()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Cadastrar>().Count() > 0)
            {
                Application.OpenForms.OfType<Cadastrar>().First().Focus();
            }
            else
            {
                Cadastrar cad = new Cadastrar();
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void Tecnologia_Load(object sender, EventArgs e)
        {

        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AlterarInvent>().Count() > 0)
            {
                Application.OpenForms.OfType<AlterarInvent>().First().Focus();
            }
            else
            {
                AlterarInvent ai = new AlterarInvent();
                ai.MdiParent = this;
                ai.Show();
            }

        }
    }
}
