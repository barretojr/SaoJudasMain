using MySqlX.XDevAPI;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Classes
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(); 
        public Conexao()
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //con.ConnectionString = @"Data Source=http://sjbd.mysql.uhserver.com/;Initial Catalog=sjbd;User Id=gruposaojudas;Password=SJadm@2014;Integrated Security=True;";            
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
