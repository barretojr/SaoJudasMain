using SJmain.Classes;
using SJmain.Classess;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Logistica
{
    public partial class Agenda : Form
    {
        Conexao connect = new Conexao();
        SqlCommand cmd = new SqlCommand();
        int RecordID = 0;
        public Agenda()
        {
            InitializeComponent();
        }

        private void ListarContatos(string strSQL = "SELECT * FROM Agenda")
        {
            Conexao connection = new Conexao();
            SqlCommand cmd = new SqlCommand(strSQL);
            cmd.Connection = connection.Conectar();
            
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                contatosGridView.DataSource = dataTable;
            }
            catch
            {
                MessageBox.Show("Algo deu errado", "Erro");
            }
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            AgendaClass AC = new AgendaClass();
            AC.VerificaContato(txtContato.Text);

            if (AC.tem == true)
            {
                MessageBox.Show("Contato já cadastrado", "Erro");
            }
            else
            {
                try
                {
                    cmd.Connection = connect.Conectar();
                    cmd.CommandText = "INSERT INTO Agenda (nome, email, endereco, contato)" + "" +
                        "VALUES(@nome, @email, @endereco, @contato)";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@contato", txtContato.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato salvo");

                    connect.Desconectar();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Alguma coisa deu errado. Tente novamente");
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparRegistro();
        }

        private void LimparRegistro()
        {
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtContato.Text = String.Empty;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            ListarContatos();
        }

        private void contatosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecordID = Convert.ToInt32(contatosGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = contatosGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContato.Text = contatosGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = contatosGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = contatosGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           if(txtNome.Text != "" && txtContato.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "")
            {
                try
                {
                    cmd.Connection = connect.Conectar();

                    cmd = new SqlCommand("UPDATE Agenda SET nome=@nome, email=@email, endereco=@endereco, contato=@contato WHERE idcontato=@id", connect.Conectar());
                    cmd.Parameters.AddWithValue("@id", int.Parse(RecordID));
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro atualizado com sucesso.");

                    connect.Desconectar();

                    ListarContatos();
                    LimparRegistro();
                } catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                
            }
           else
            {
                MessageBox.Show("Por favor, selecione um registro para alterar.");
            }
   
        }
    }
}
