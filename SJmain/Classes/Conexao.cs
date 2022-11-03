using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SJmain.Classes
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            try
            {
                con.ConnectionString = @"server=sjbd.mysql.uhserver.com;User Id=gruposaojudas;database=sjbd; password= SJadm@2014";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o programa!", "Erro");
            }
        }
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
        


    }
}
