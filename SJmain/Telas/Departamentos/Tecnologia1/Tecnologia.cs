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

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Inventario>().Count() > 0)
            {
                Application.OpenForms.OfType<Inventario>().First().Focus();
            }
            else
            {
                Inventario invent = new Inventario();
                invent.MdiParent = this;
                invent.Show();
            }
        }

        private void outroStripToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tecnologia_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<VerificarEmpresa>().Count() > 0)
            {
                Application.OpenForms.OfType<VerificarEmpresa>().First().Focus();
            }
            else
            {
                VerificarEmpresa ve = new VerificarEmpresa();
                ve.MdiParent = this;
                ve.Show();
            }
        }
    }
}
