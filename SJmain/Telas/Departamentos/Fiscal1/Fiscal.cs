using SJmain.Telas.Departamentos.Fiscal1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos
{
    public partial class Fiscal : Form
    {
        public Fiscal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Verificarfisc_Click(object sender, EventArgs e)
        {
            
        }

        private void atualizarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusEmpresa se = new StatusEmpresa();
            se.Show();
        }
    }
}
