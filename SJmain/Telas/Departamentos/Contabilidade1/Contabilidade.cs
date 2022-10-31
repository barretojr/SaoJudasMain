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

        private void analíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importaranalitico ia = new importaranalitico();
            ia.MdiParent = this;
            ia.Show();
        }

        private void sintéticoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            importarsintetico ims = new importarsintetico();
            ims.MdiParent = this;
            ims.Show();
        }

        private void analiticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceteanalitico ba = new balanceteanalitico();
            ba.MdiParent = this;
            ba.Show();
        }

        private void sintéticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balancetesintetico bs = new balancetesintetico();
            bs.MdiParent = this;
            bs.Show();
        }
        
    }
}
