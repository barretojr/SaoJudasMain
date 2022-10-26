using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJmain.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool Acessar(string Login, string senha)
        {
            LoginDaoComandos logindao =new LoginDaoComandos();
            tem = logindao.VerificarLogin(Login, senha); 
            if (logindao.Equals(""))
            {

            }
            return tem;
        }
        public string cadastrarlogin(string email, string senha, string confsenha)
        {
            return mensagem;
        }
    }
}
