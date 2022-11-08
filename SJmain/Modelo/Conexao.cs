using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SJmain.Classes
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //private MySqlConnection con;
        public Conexao()
        {
            con.ConnectionString= "Server = 10.129.76.12; Database = sjbd; Uid = gruposaojudas; Pwd = SJadm@2014";
            //con.ConnectionString = "server=sjbd.mysql.uhserver.com;User Id=gruposaojudas;database=sjbd; password= SJadm@2014";
            //con = new MySqlConnection("server=sjbd.mysql.uhserver.com;User Id=gruposaojudas;database=sjbd; password= SJadm@2014");
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
