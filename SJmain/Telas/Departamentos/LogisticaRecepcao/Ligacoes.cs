using SJmain.Telas.Departamentos.Log;
using SJmain.Telas.Departamentos;
using System.Windows.Forms;
using System;

namespace SJmain.Telas.Departamentos.Logistica
{
    public partial class Ligacoes : Form
    {
        public Ligacoes()
        {
            InitializeComponent();
        }        

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizarData_Click(object sender, EventArgs e)
        {
            mskHora.Text = DateTime.Now.ToShortTimeString();
            this.Refresh();
            
        }

        private void Ligacoes_Load(object sender, EventArgs e)
        {
            mskHora.Text = DateTime.Now.ToShortTimeString();
            string Data;
            Data = DateTime.Now.ToLongDateString();
            dtpData.Text = Data;
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            string Data;
            Data = DateTime.Now.ToString();
            lblData.Text = Data;
        }        
    }
}
