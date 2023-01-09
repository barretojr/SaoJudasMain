using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
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
        
        private void ListarUsuarios (string sqlstr = "SELECT * FROM Inventario")
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
            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "UPDATE Inverario SET unidade=@unidade, descricao=@desc, modelo=@model, localizacao=@local, valorestim=@valor, processador=@proce, memoriaram=@ram, usuario=@user WHERE idpatrimonio=@id";
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
                cmd.Connection = con.Conectar();
                cmd.CommandText = "DELETE Agenda WHERE idcontato = @id";
                cmd.Parameters.AddWithValue("@id", txtPatri);
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            else
            {
                epPatri.SetError(txtPatri, "Digite um patrimonio a ser excluido");
            }
        }
    }
}
