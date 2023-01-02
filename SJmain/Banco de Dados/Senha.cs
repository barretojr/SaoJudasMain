using CryptSharp;

namespace SJmain.Banco_de_Dados
{
    public static class Senha
    {
        public static string Codifica(string senha)
        {
            return Crypter.MD5.Crypt(senha);
        }
        public static bool Compara(string senha, string hash)
        {
            return Crypter.CheckPassword(hash, senha);
        }
        public static void Confere(string senha, string hash)
        {
            senha = Crypter.MD5.Crypt(hash);
        }
        public static void Certifica(string senha, string hash)
        {
            hash = Crypter.MD5.Crypt(hash, senha);
        }


    }
}
