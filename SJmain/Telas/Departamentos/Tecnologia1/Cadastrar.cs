using SJmain.Classes;
using SJmain.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Telas.Cadastro
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;        
        DataTable dt = new DataTable();

        private bool Validarform()
        {
            if (txtUsuario.Text == "")
            {
                epUsuario.SetError(txtUsuario, "Informe um Usuário");
                txtUsuario.Focus();
                return false;
            }
            else if (txtSenha.Text == "")
            {
                epSenha.SetError(txtSenha, "Informe a Senha do Usuario");
                txtSenha.Focus();
                return false;
            }
            else if (txtConfirmar.Text == "")
            {
                epConfSenha.SetError(txtConfirmar, "Confirme a Senha do Usuario");
                txtConfirmar.Focus();
                return false;
            }
            else if (txtNome.Text == "")
            {
                epNome.SetError(txtNome, "Informe o Nome");
                txtNome.Focus();
                return false;
            }
            else if (mskCPF.Text == "")
            {
                epCPF.SetError(mskCPF, "Informe o CPF do Usuario");
                txtSenha.Focus();
                return false;
            }
            else if (txtEmail.Text == "")
            {
                epEmail.SetError(txtEmail, "Informe o Email do Usuario");
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
        

        private void btnAlt_Click(object sender, EventArgs e)
        {
            #region ifradiobutton
            int dept = 0;
            if (rbContabil.Checked) { dept = 2; }
            if (rbFisc.Checked) { dept = 3; }
            if (rbLog.Checked) { dept = 4; }
            if (rbTec.Checked) { dept = 5; }
            if (rbPess.Checked) { dept = 6; }
            if (rbSocio.Checked) { dept = 7; }
            #endregion


        }
        private void AlterarCad (string cad)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(rdbNome.Checked == true)
            {
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = "SELECT * FROM Usuario WHERE nomeusuario = @pesquisa;";
                    cmd.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvAlterar.DataSource = dt;
                    dgvAlterar.Refresh();
                }
                catch
                {
                    epPesquisa.SetError(txtPesquisa, "Usuário não existe ou foi digitado errado");
                }

            }
            if(rdbCPF.Checked== true)
            {
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = "SELECT * FROM Usuario WHERE cpfusuario = @pesquisa;";
                    cmd.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvAlterar.DataSource = dt;
                    dgvAlterar.Refresh();
                }
                catch
                {
                    epPesquisa.SetError(txtPesquisa, "CPF não existe ou foi digitado errado");
                }
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
