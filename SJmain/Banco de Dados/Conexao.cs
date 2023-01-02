using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SJmain.Classes
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        MySqlConnection cnn = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = "Data Source = 192.168.5.112,49170; Initial Catalog = SJBD; User ID = sa; Password = Alemanha1982;";
            //con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sjbd;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        public SqlConnection Conectar()
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
