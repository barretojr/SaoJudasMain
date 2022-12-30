using SJmain.agendaaa;
using SJmain.Classes;
using SJmain.Telas.Departamentos.Tecnologia1;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Logistica
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, System.EventArgs e)
        {
            ListarAgenda();
        }
        private void ListarAgenda(string strSQL = "SELECT * FROM Agenda")
        {
            Conexao conec = new Conexao();
            SqlCommand cmd = new SqlCommand(strSQL);
            cmd.Connection = conec.Conectar();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            } catch
            {
                MessageBox.Show("Error");
            }


        }
       

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            verificaContato verifica = new verificaContato();
            verifica.verificaCt(txtContato.Text);
            if (verifica.tem == true)
            {
                MessageBox.Show("Contato já cadastrado");
            }
            else
            {
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = "INSERT INTO Agenda (nome, email, endereco, contato)" +
                    "VALUES (@nome, @email, @endereco, @contato);";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                    cmd.ExecuteNonQuery();
                    con.Desconectar();

                    MessageBox.Show("Contato salvo com sucesso!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Algo deu errado. Verifique os dados");
                }
            }
        }
    }
}
