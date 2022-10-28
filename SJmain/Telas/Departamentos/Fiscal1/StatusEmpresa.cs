using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Fiscal1
{
    public partial class StatusEmpresa : Form
    {
        public StatusEmpresa()
        {
            InitializeComponent();
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult alterarstatus;
            alterarstatus = MessageBox.Show("Deseja altera o status?","Alterar Status", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (alterarstatus == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
