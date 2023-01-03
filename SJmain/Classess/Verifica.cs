using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJmain.Classess
{
    public class Verifica
    {
        Conexao conec = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public bool tem = false;

        public bool VerificaPatrimonio(string patrimo)
        {
            cmd.Connection = conec.Conectar();
            cmd.Parameters.AddWithValue("@patri", patrimo);


            if (dr.HasRows)
            {
                tem = true;
            }

            return tem;
        }
        public bool VerificaModelo (string modelo)
        {
            cmd.Connection = conec.Conectar();
            cmd.Parameters.AddWithValue("@mode", modelo);

            if (dr.HasRows)
            {
                tem = true;
            }
            
            
            return tem;
        }
        public bool VerificaUsuario (string usuario)
        {
            cmd.Connection=conec.Conectar();
            cmd.Parameters.AddWithValue("@user", usuario);

            if (dr.HasRows)
            {
                tem = true;
            }
            return tem;
        }
    }
}
