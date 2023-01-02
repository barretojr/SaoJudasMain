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
        private bool Validarform()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Informe o Nome de Usuario");
                txtUsuario.Focus();
                return false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe a Senha do Usuario");
                txtSenha.Focus();
                return false;
            }
            else if (txtConfirmar.Text == "")
            {
                MessageBox.Show("Confirme a Senha do Usuario");
                txtConfirmar.Focus();
                return false;
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o Nome");
                txtNome.Focus();
                return false;
            }
            else if (mskCPF.Text == "")
            {
                MessageBox.Show("Informe o CPF do Usuario");
                txtSenha.Focus();
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Informe o Email do Usuario");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validarform())
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
                else
                {
                    MessageBox.Show("Reveja todos os dados");
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Validarform())
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
                else
                {
                    MessageBox.Show("Reveja todos os dados");
                }
            }
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            rdbContabil.Checked = true;
        }
    }
}
