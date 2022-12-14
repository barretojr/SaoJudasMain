using SJmain.Classes;
using SJmain.Classess;
using System;
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
                tss1.Text = "Contato ja cadastrado";
            }
            else
            {
                if (txtNome.Text == "" || txtEmail.Text == "" || txtContato.Text == "" || txtEndereco.Text == "")
                {
                    MessageBox.Show("Não deixe nenhum campo em branco.");
                    tss1.Text = "Campo em Branco";
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
                        tss1.Text = " Cadastrado com sucesso";

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Contato salvo");
                        ListarContatos();
                        contatosGridView.Refresh();
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
            cmd.Parameters.Clear();
            tss1.Text = "Parametros Limpos";
        }

        private void LimparRegistro()
        {
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtContato.Text = String.Empty;
            ListarContatos();
            contatosGridView.Refresh();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sJBDDataSet2.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter.Fill(this.sJBDDataSet2.Agenda);
            ListarContatos();
            tss1.Text = "Pronto...";
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

            if (txtNome.Text != "" && txtContato.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "")
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
                    contatosGridView.Refresh();
                    LimparRegistro();

                    contatosGridView.Refresh();
                    tss1.Text = "Contato atualizado";


                }
                catch (Exception error)
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
            if (RecordID != 0)
            {
                cmd.Connection = connect.Conectar();
                cmd.CommandText = "DELETE Agenda WHERE idcontato = @id";
                cmd.Parameters.AddWithValue("@id", RecordID);
                cmd.ExecuteNonQuery();
                connect.Desconectar();

                MessageBox.Show("Contato deletado com sucesso.");
                ListarContatos();
                contatosGridView.Refresh();
                LimparRegistro();
                cmd.Parameters.Clear();
                tss1.Text = "Contato deletado";
            }
            else
            {
                MessageBox.Show("Selecione um contato para deletar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarContatos();
            contatosGridView.Refresh();
        }
    }
}
