using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Contabilidade1
{
    public partial class importaranalitico : Form
    {
        public importaranalitico()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Arquivo PDF|*.pdf",
                Title = "Selecione o arquivo PDF"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(String arquivo in openFileDialog1.FileNames)
                {
                    txtCaminho.Text = arquivo;
                }
                string destino = Path.Combine(Properties.Settings.Default.Pasta, ".pdf");

                if (File.Exists(destino))
                    File.Delete(destino);

                File.Copy(openFileDialog1.FileName, destino);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
