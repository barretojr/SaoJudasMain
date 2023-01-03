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
                if (txtNome.Text == "" || txtEmail.Text == "" || txtContato.Text == "" || txtEndereco.Text == "")
                {
                    MessageBox.Show("Não deixe nenhum campo em branco.");
                }
                else
                {
                    try
                    {
                        cmd.Connection = connect.Conectar();
                        cmd.CommandText = "INSERT INTO Agenda (nome, email, endereco, contato) " +
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

            contatosGridView.Refresh();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            ListarContatos();
        }

        private void contatosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecordID = Convert.ToInt32(contatosGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = contatosGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContato.Text = contatosGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = contatosGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEndereco.Text = contatosGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
           if(txtNome.Text != "" && txtContato.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "")
            {
                try
                {
                    cmd.Connection = connect.Conectar();
                    cmd.CommandText = "UPDATE Agenda SET nome=@nome, email=@email, endereco=@endereco, contato=@contato WHERE idcontato=@id";
                    cmd.Parameters.AddWithValue("@id", RecordID);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro atualizado com sucesso.");
                    cmd.Parameters.Clear();

                    connect.Desconectar();

                    ListarContatos();
                    LimparRegistro();

                    contatosGridView.Refresh();
                    
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(RecordID != 0)
            {
                cmd.Connection = connect.Conectar();
                cmd.CommandText = "DELETE Agenda WHERE idcontato = @id";
                cmd.Parameters.AddWithValue("@id", RecordID);
                cmd.ExecuteNonQuery();
                connect.Desconectar();

                MessageBox.Show("Contato deletado com sucesso.");
                ListarContatos();
                LimparRegistro();
                cmd.Parameters.Clear();
            } else
            {
                MessageBox.Show("Selecione um contato para deletar");
            }
        }
    }
}
