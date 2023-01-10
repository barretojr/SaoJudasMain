using SJmain.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Tecnologia1
{
    public partial class AlterarInvent : Form
    {
        public AlterarInvent()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        int RecordID = 0;

        private void ListarUsuarios(string sqlstr = "SELECT * FROM Inventario")
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = sqlstr;
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInvent.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar", "Erro");
            }
            con.Desconectar();
        }
        private void LimparParametros()
        {
            txtPatri.Text = "";
            cbUnidade.Text = "";
            txtDescricao.Text = "";
            txtModelo.Text = "";
            txtLocal.Text = "";
            mskValorEsti.Text = "";
            txtProcessador.Text = "";
            txtMemoria.Text = "";
            txtUsuario.Text = "";
            cmd.Parameters.Clear();
        }


        private void AlterarInvent_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sJBDDataSet.Inventario'. Você pode movê-la ou removê-la conforme necessário.
            this.inventarioTableAdapter.Fill(this.sJBDDataSet.Inventario);
            ListarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecordID = Convert.ToInt32(dgvInvent.Rows[e.RowIndex].Cells[0].Value);
            txtPatri.Text = dgvInvent.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbUnidade.Text = dgvInvent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescricao.Text = dgvInvent.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtModelo.Text = dgvInvent.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLocal.Text = dgvInvent.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskValorEsti.Text = dgvInvent.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProcessador.Text = dgvInvent.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMemoria.Text = dgvInvent.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtUsuario.Text = dgvInvent.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarUsuarios();
            dgvInvent.Refresh();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string patri = txtPatri.Text;

            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "UPDATE Inventario SET unidade=@unidade, descricao=@desc, modelo=@model, localizacao=@local, valorestim=@valor, processador=@proce, memoriaram=@ram, usuario=@user WHERE idpatrimonio=@id";
                cmd.Parameters.AddWithValue("@id", txtPatri.Text);
                cmd.Parameters.AddWithValue("@unidade", cbUnidade.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@model", txtModelo.Text);
                cmd.Parameters.AddWithValue("@local", txtLocal.Text);
                cmd.Parameters.AddWithValue("@valor", mskValorEsti.Text);
                cmd.Parameters.AddWithValue("@proce", txtProcessador.Text);
                cmd.Parameters.AddWithValue("@ram", txtMemoria.Text);
                cmd.Parameters.AddWithValue("@user", txtUsuario.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Dados do Patrimonio {patri} alterado com sucesso!");
                LimparParametros();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparParametros();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtPatri != null)
            {
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = "DELETE FROM Inventario WHERE idpatrimonio = @id";
                    cmd.Parameters.AddWithValue("@id", txtPatri);
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                epPatri.SetError(txtPatri, "Digite um patrimonio a ser excluido");
                txtPatri.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "INSERT INTO Inventario (idpatrimonio, unidade, descricao, modelo, localizacao, valorestim, processador, memoriaram, usuario) " +
                "VALUES (@numpatri,@unidade,@descri,@model,@local,@valorestim, @process, @ram, @usuario);";
                cmd.Parameters.AddWithValue("@numpatri", txtPatri.Text);
                cmd.Parameters.AddWithValue("@unidade", cbUnidade.Text);
                cmd.Parameters.AddWithValue("@descri", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@model", txtModelo.Text);
                cmd.Parameters.AddWithValue("@local", txtLocal.Text);
                cmd.Parameters.AddWithValue("@valorestim", mskValorEsti.Text);
                cmd.Parameters.AddWithValue("@process", txtProcessador.Text);
                cmd.Parameters.AddWithValue("@ram", txtMemoria.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.ExecuteNonQuery();

                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Algum dado está invalido", "Reveja os dados");
            }
        }
    }
}
