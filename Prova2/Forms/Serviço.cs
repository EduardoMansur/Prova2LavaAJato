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
    public partial class Serviço : Form
    {
        string URI = "http://localhost:52936/api";
        int codigoProduto = 1;
        int idCliente = 1;
        List<string> names = new List<string>();
        public Serviço()
        {
            InitializeComponent();
        }

        private void Serviço_Load(object sender, EventArgs e)
        {
            GetAllClientes();
        }
        private async void GetAllClientes()
        {
            var newURI = URI + "/Customers";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        names.Clear();
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<Model.Customer[]>(ProdutoJsonString).ToList();
                        list.ForEach(get);
                        ClienteCb.DataSource = names;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
                void get(Model.Customer s)
                {

                    names.Add(s.nome);
                }
                
            }
        }
        async void AddServiço()
        {
            var newURI = URI + "/Servicoes";
            Servico prod = new Servico();
            prod.idCliente = idCliente;
            prod.placaVeiculo = PlacaBox.Text;
            prod.preco = (double)precoBnr.Value;
            prod.tipoServico = 1;
            if (moto.Checked)
            {
                prod.tipoVeiculo = 1;

            }

            else if(carro.Checked)
            {
                prod.tipoVeiculo = 2;
            }
            else if (caminhao.Checked)
            {
                prod.tipoVeiculo = 3;
            }


            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            setClientId();
            AddServiço();
            this.Hide();

        }
        private async void setClientId() 
        {
            var newURI = URI + "/Customers/search/" + ClienteCb.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        names.Clear();
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<Model.Customer[]>(ProdutoJsonString).ToList();
                        idCliente = list.First().idCustomer;
                        

                    }
                    

                }
            }
           
        }

    }
}
