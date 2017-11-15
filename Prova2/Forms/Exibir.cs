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

namespace Prova2
{
    public partial class Exibir : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        int codigoProduto = 1;
        public Exibir()
        {
            InitializeComponent();
        }
        private async void GetAllMaterials()
        {
            var newURI = URI + "/Materials";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Model.Material[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }
        private async void GetAllServicoes()
        {
            var newURI = URI + "/Servicoes";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Model.Servico[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }
        private async void GetAllCustommers()
        {
            var newURI = URI + "/Customers";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Model.Customer[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }
        private async void GetAllGastos()
        {
            var newURI = URI + "/Gastos";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Model.Gasto[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllMaterials();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllServicoes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAllCustommers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAllGastos();
        }
    }
}
