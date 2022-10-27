using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas.Cadastro
{
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == Properties.Settings.Default.usuario)
            {
                MessageBox.Show("Usuário já existe", "Usuário Encontrado");
            }
            else
            {
                DialogResult desejacriar;
                desejacriar = MessageBox.Show("Usuário não existe, deseja criar?", "Usuário Não Existe", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (desejacriar == DialogResult.Yes)
                {
                    Cadastrar cad = new Cadastrar();
                    cad.Show();
                }
                if(desejacriar != DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
