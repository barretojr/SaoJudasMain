using SJmain.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Tecnologia1
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            rdbPatrimonio.Checked = true;
            ListaGrid();

        }
        private void ListaGrid(string strSQL = "SELECT * FROM Inventario")
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
            }
            catch
            {
                MessageBox.Show("Alert", "Alert");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Patrimonio pm = new Patrimonio();
            pm.VerificaPatri(txtBuscar.Text);
            if (pm.tem == true)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DialogResult CadPatrimon;
                CadPatrimon = MessageBox.Show("Deseja cadastrar equipamento?", "Deseja Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (CadPatrimon != DialogResult.No)
                {
                    AlterarInvent ai = new AlterarInvent();
                    ai.Show();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
