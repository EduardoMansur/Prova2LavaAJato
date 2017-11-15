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
    public partial class Custos : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        double totalGanhos = 0;
        double totalGastos = 0;
        public Custos()
        {
            InitializeComponent();
        }

        private void Custos_Load(object sender, EventArgs e)
        {
            setLabels();
        }
        private void setLabels()
        {
            this.totalGanhos = 0;
            this.totalGastos = 0;
            GetAllServicoes();
            GetAllGastos();
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
                       var list = JsonConvert.DeserializeObject<Model.Servico[]>(ProdutoJsonString).ToList();
                        list.ForEach(get);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }

            
        }
        void get(Model.Servico s)
        {

            totalGanhos = totalGanhos + s.preco;
            LucroLbl.Text = "R$:" + totalGanhos.ToString();
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
                        var list = JsonConvert.DeserializeObject<Model.Gasto[]>(ProdutoJsonString).ToList();
                        list.ForEach(getGastos);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }


        }
        void getGastos(Model.Gasto s)
        {

            totalGastos = totalGastos + s.valor;
            custoLbl.Text = "R$:" + totalGastos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setLabels();
        }
    }
}
