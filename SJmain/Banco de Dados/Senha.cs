using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        
    }
}
