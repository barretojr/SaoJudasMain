using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data.SqlClient;
using System.Dynamic;
using System.Windows.Forms;

namespace SJmain.Classes
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(); 
        MySqlConnection cnn = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = "Data Source = 192.168.5.112,49170; Initial Catalog = SJBD; User ID = sa; Password = Alemanha1982;";
            //con.ConnectionString = "jdbc:sqlserver://;serverName=192.168.5.112;port=49170;databaseName=SJBD";
            //con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sjbd;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
             
        }
        public  SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
