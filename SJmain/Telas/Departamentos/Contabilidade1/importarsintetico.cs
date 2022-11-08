using System;
using System.IO;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Contabilidade1
{
    public partial class importarsintetico : Form
    {
        public importarsintetico()
        {
            InitializeComponent();
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
                foreach (String arquivo in openFileDialog1.FileNames)
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
