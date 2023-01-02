using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Classes
{
    public class Patrimonio
    {
        public bool tem = false;
        public string mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao conec = new Conexao();
        SqlDataReader dr;

        public bool VerificaPatri(string numpatri)
        {

            cmd.CommandText = "SELECT * FROM Inventario WHERE idpatrimonio = @numpatri";
            cmd.Parameters.AddWithValue("@numpatri", numpatri);
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
