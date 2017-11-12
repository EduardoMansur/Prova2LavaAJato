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
    }
}
