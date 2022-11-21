using SJmain.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Patrimonio pm = new Patrimonio();
            pm.VerificaPatri(txtBuscar.Text);
            if (pm.tem == true)
            {
                using(SqlDataAdapter da = new SqlDataAdapter())
                {
                    using(DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;  
                    }
                }

            }
            else
            {
                DialogResult CadPatrimon;
                CadPatrimon = MessageBox.Show("Deseja cadastrar equipamento?", "Deseja Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (CadPatrimon != DialogResult.No)
                {
                    CadastrarPatrics cp = new CadastrarPatrics();
                    cp.Show();
                }
            }

            
             
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
