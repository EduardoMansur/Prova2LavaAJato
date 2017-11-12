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
    public partial class Cadastrar : Form
    {
        string URI = "http://localhost:52936/api";
        int codigoProduto = 1;
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!nomeBox.Text.Equals("") && !telBox.Text.Equals("") )
            {
                //Adicionar no Banco requisitando da web api
                errorLbl.Text = "";
                AddCustomer();
                this.Hide();
            }
            else
            {
                errorLbl.Text = "Preencha os campos corretamente";
            }
        }
        private async void AddCustomer()
        {
            var newURI = URI + "/Customers";
            Customer prod = new Customer();
            prod.nome = nomeBox.Text;
            prod.telefone = telBox.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }

        }
    }
}
