using SJmain.Telas.Departamentos.Logistica;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Log
{
    public partial class Logist : Form
    {
        public Logist()
        {
            InitializeComponent();
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
            if (Application.OpenForms.OfType<Ligacoes>().Count() > 0)
            {
                Application.OpenForms.OfType<Itinerario>().First().Focus();
            }
            else
            {
                Ligacoes lig = new Ligacoes();
                lig.MdiParent = this;
                lig.Show();
            }
        }

        private void itinerarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Itinerario>().Count() > 0)
            {
                Application.OpenForms.OfType<Itinerario>().First().Focus();
            }
            else
            {
                Itinerario iti = new Itinerario();
                iti.MdiParent = this;
                iti.Show();
            }
            
        }

        private void agendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Agenda>().Count() > 0)
            {
                Application.OpenForms.OfType<Agenda>().First().Focus();
            }
            else
            {
                Agenda ag = new Agenda();
                ag.MdiParent = this;
                ag.Show();
            }
            
        }

    }
}
