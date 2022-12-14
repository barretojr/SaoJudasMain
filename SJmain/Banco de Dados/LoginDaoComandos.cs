using SJmain.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Modelo
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conec = new Conexao();
        SqlDataReader dr;


        public bool verificarLogin(string login, string senha)
        {

            cmd.CommandText = "SELECT * FROM Usuario WHERE nomeusuario = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = conec.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conec.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "erro";
            }

            return tem;
        }
        public bool verificarusuario(string usuario, int idderpt)
        {
            cmd.CommandText = "SELECT * FROM Usuario WHERE nomeusuario = @usuario and iddepartamento = @iddepart";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@iddepart", idderpt);
            try
            {
                cmd.Connection = conec.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conec.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "erro";
            }

            return tem;
        }
        public string cadastrar(int idderp, string nomeusu, string email, string cpf, string senha, string confSenha, string telefone)
        {


            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO Usuario ([iddepartamento], [nome], [nomeusuario], [senha], [cpfusuario], [telefone], [email]) VALUES (@idderp, @nome, @senha, @email, @cpf, @tel);";
                cmd.Parameters.AddWithValue("@idderp", idderp);//1=master,2=contabil,3=fiscal,4=logistica,5=tecnologia,6=pessoal,7=societario
                cmd.Parameters.AddWithValue("@nome", nomeusu);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@tel", telefone);
                try
                {
                    cmd.Connection = conec.Conectar();
                    cmd.ExecuteNonQuery();
                    conec.Desconectar();
                    this.mensagem = " Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de dados";
                }
            }
            else
            {
                MessageBox.Show("Senhas não se coincidem", "Senhas Não se Coincidem");
            }
            return mensagem;
        }

    }
}
