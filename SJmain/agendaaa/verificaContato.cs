using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.agendaaa
{
    public class verificaContato
    {
        public bool tem = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtReader;
        public bool verificaCt(string contato)
        {           
            cmd.CommandText = "SELECT * FROM Agenda WHERE contato = @contato";
            cmd.Parameters.AddWithValue("@contato", contato);

            try
            {
                cmd.Connection = con.Conectar();
                dtReader = cmd.ExecuteReader();

                if(dtReader.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dtReader.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error!");
            }

            return tem;
        }
    }
}
