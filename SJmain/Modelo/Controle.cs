﻿using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public string cadastrar(string email, string senha, string confsenha)
        {
            return mensagem;
        }
        
    }
}
