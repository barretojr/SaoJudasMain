using SJmain.Telas.Departamentos.Logistica;
using System;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Log
{
    public partial class Logist : Form
    {
        public Logist()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();
            ag.MdiParent = this;
            ag.Show();
        }

        private void itinerarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Itinerario iti = new Itinerario();
            iti.MdiParent = this;
            iti.Show();
        }

        private void ligaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ligacoes lig = new Ligacoes();
            lig.MdiParent = this;
            lig.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ligaçõesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ligacoes lig = new Ligacoes();
            lig.MdiParent = this;
            lig.Show();
        }

        private void itinerarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Itinerario iti = new Itinerario();
            iti.MdiParent = this;
            iti.Show();
        }

        private void agendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();
            ag.MdiParent = this;
            ag.Show();
        }

    }
}
