using SJmain.Telas.Cadastro;
using System;
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
            Cadastrar cad = new Cadastrar();
            cad.MdiParent = this;
            cad.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.MdiParent = this;
            alterar.Show();
        }
    }
}
