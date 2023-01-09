using SJmain.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Tecnologia1
{
    public partial class VerificarEmpresa : Form
    {
        public VerificarEmpresa()
        {
            InitializeComponent();
        }
        #region Instancias
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr ;

        #endregion

        private void LimparParametros()
        {
            cmd.Parameters.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarEmpresas()
        {           
            cmd.Connection = con.Conectar();
            cmd.CommandText = "SELECT nomeempresa FROM Empresa";            
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            cmbEmpresas.DisplayMember = "nomeempresa";
            cmbEmpresas.DataSource = dt;
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {   
            
        }

        private void VerificarEmpresa_Load(object sender, EventArgs e)
        {
            CarregarEmpresas();
        }

        private void SelecionarEmpresa()
        {            

        }

        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
