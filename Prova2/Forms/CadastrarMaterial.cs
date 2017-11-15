using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Prova2.Model;

namespace Prova2
{
    public partial class CadastrarMaterial : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        int codigoProduto = 1;
        public CadastrarMaterial()
        {
            InitializeComponent();
        }

        private void CadastrarMaterial_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            if (!nomeBox.Text.Equals("") && (qtdNbr.Value>=0) )
            {
                AddMaterial();
                this.Hide();
            }
        }
        private async void AddMaterial()
        {
           var  newURI = URI + "/Materials";
            Material prod = new Material();
            prod.nome = nomeBox.Text;
            prod.qtd = Convert.ToInt32(qtdNbr.Value) ;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }

        }

        private void qtdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
