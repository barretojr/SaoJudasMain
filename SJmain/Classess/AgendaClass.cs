using SJmain.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Classess
{
    public class AgendaClass
    {
        public bool tem = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conec = new Conexao();
        SqlDataReader dr;

        public bool VerificaContato(string contato)
        {
            cmd.CommandText = "SELECT * FROM Agenda WHERE contato = @contato";
            cmd.Parameters.AddWithValue("@contato", contato);
            try
            {
                cmd.Connection = conec.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conec.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("erro", "Erro");
            }


            return tem;
        }
    }


}
