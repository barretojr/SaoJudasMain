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

namespace SJmain.Telas.Departamentos.Logistica
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();
            SqlCommand cmd = new SqlCommand();

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtContato.Text = String.Empty;
        }

        
    }
}
