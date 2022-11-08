using SJmain.Modelo;
using System;
using System.Windows.Forms;

namespace SJmain.Telas.Cadastro
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            #region ifradiobutton
            int dept = 0;
            if (rdbContabil.Checked) { dept = 2; }
            if (rdbFiscal.Checked) { dept = 3; }
            if (rdbLogistica.Checked) { dept = 4; }
            if (rdbTecnologia.Checked) { dept = 5; }
            if (rdbPessoal.Checked) { dept = 6; }
            if (rdbSocietario.Checked) { dept = 7; }
            #endregion
            string mensagem = controle.cadastrar(dept, txtUsuario.Text, txtEmail.Text, mskCPF.Text, txtSenha.Text, txtConfirmar.Text, mskTelefone.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro Feito com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            #region ifradiobutton
            int dept = 0;
            if (rdbContabil.Checked) { dept = 2; }
            if (rdbFiscal.Checked) { dept = 3; }
            if (rdbLogistica.Checked) { dept = 4; }
            if (rdbTecnologia.Checked) { dept = 5; }
            if (rdbPessoal.Checked) { dept = 6; }
            if (rdbSocietario.Checked) { dept = 7; }
            #endregion
            string mensagem = controle.cadastrar(dept, txtUsuario.Text, txtEmail.Text, mskCPF.Text, txtSenha.Text, txtConfirmar.Text, mskTelefone.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro Feito com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
