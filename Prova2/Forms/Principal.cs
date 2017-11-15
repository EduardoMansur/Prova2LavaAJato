using Prova2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastraClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cadastro = new Cadastrar();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void materiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibir cadastro = new Exibir();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void cadastrarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarMaterial cadastro = new CadastrarMaterial();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void cadastrarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviço cadastro = new Serviço();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void custosEGanhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custos cadastro = new Custos();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void cadastrarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarGasto cadastro = new CadastrarGasto();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void atualizarMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarMaterial cadastro = new AtualizarMaterial();

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Email cadastro = new Email();

            cadastro.MdiParent = this;
            cadastro.Show();
        }
    }
}
