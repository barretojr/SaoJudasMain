using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SJmain.Classes;

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
            cmd.CommandText = "select * from Usuario where nomeusuario = @login and senha = @senha";
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
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";                
            }
            return tem;
        }
        public string cadastrar(string email, string cpf, string senha, string confSenha)
        {
            return mensagem;
        }
    }
}
