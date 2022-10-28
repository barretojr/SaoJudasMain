using SJmain.Telas.Departamentos.Contabilidade1;
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
    public partial class Contabilidade : Form
    {
        public Contabilidade()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarStatusEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusEmpresaContabil sec = new StatusEmpresaContabil();
            sec.MdiParent = this;
            sec.Show();
        }
    }
}
