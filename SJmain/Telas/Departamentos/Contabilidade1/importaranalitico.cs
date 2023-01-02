using System;
using System.Windows.Forms;

namespace SJmain.Telas.Departamentos.Contabilidade1
{
    public partial class importaranalitico : Form
    {
        public importaranalitico()
        {
            InitializeComponent();
        }


        private void btnProcurar_Click(object sender, EventArgs e)
        {
            GetPdf();

        }
        private string GetPdf()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos PDFs|*.pdf";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            else
            {
                return "";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
