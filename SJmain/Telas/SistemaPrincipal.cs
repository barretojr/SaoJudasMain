﻿using SJmain.Telas.Cadastro;
using SJmain.Telas.Departamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJmain.Telas
{
    public partial class SistemaPrincipal : Form
    {
        public SistemaPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void contabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contabilidade Cont = new Contabilidade();
            Cont.Show();

        }

        private void logisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();
        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiscal fis = new Fiscal();
            fis.Show();
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tecnologia tec = new Tecnologia();
            tec.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.Show();
        }
    }
}
