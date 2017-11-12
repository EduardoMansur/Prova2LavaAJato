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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!nomeBox.Text.Equals("") && !telBox.Text.Equals("") )
            {
                //Adicionar no Banco requisitando da web api
                errorLbl.Text = "Preencha os campos corretamente";

            }
            else
            {
                errorLbl.Text = "Preencha os campos corretamente";
            }
        }
    }
}
