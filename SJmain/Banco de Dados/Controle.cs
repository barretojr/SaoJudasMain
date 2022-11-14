using System.Windows.Forms;

namespace SJmain.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            else
            {
                MessageBox.Show("Erro");
            }
            return tem;
        }
        public string cadastrar(int iddepartamento, string nomeusu, string email, string cpf, string senha, string confSenha, string telefone)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(iddepartamento, nomeusu, email, cpf, senha, confSenha, telefone);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

    }
}
