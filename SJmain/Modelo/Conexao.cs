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
            con.ConnectionString = "Data Source=http://sjbd.mysql.uhserver.com/;Initial Catalog=sjbd;User Id=gruposaojudas;Password=SJadm@2014;";
            //con.ConnectionString = "Data Source=sjbd.mysql.uhserver.com; Database = sjbd; User ID=gruposaojudas; Password=SJadm@2014;";
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
