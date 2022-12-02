using System;
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
                if (desejacriar != DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Alterar_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult desejasalvar;
            desejasalvar = MessageBox.Show("Deseja salvar as alterações?", "Deseja Salvar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (desejasalvar == DialogResult.Yes)
            {

            }
            else if ( desejasalvar == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Equals(txtConfSenha))
            {
                
            }
            else
            {
                MessageBox.Show("Senhas não coincidem");
            }
        }
    }
}
