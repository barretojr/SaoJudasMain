using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Tecnologia1
{
    public partial class CadastrarPatrics : Form
    {
        public CadastrarPatrics()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarPatrics_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao con= new Conexao();
            SqlCommand cmd = new SqlCommand();
            tss1.Text = "Aguardando Entradas...";
            statusStrip1.Refresh();

            try
            {
                tss1.Text = "Salvando o Equipamento...";
                statusStrip1.Refresh();
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
                tss1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Algum dado está invalido", "Reveja os dados");
            }
            tss1.Text = " Pronto.";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            tss1.Text = "Aguardando Entradas...";
            statusStrip1.Refresh();

            try
            {
                tss1.Text = "Salvando o Equipamento...";
                statusStrip1.Refresh();
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
                tss1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Algum dado está invalido", "Reveja os dados");
            }
            tss1.Text = " Pronto.";
            this.Close();

        }
    }
}
