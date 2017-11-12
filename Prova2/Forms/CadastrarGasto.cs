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

namespace Prova2.Forms
{
    public partial class CadastrarGasto : Form
    {
        string URI = "http://localhost:52936/api";
        int idMaterial = 1;
        List<string> names = new List<string>();
        Material old = new Material();
        public CadastrarGasto()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            setMaterialId();
           // this.Hide();
        }

        private async void GetAllMateriais()
        {
            var newURI = URI + "/Materials";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        names.Clear();
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<Model.Material[]>(ProdutoJsonString).ToList();
                        list.ForEach(get);
                        materialCb.DataSource = names;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
                

            }
        }
        private async void setMaterialId()
        {
            var newURI = URI + "/Material/search/" + materialCb.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        names.Clear();
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<Model.Material[]>(ProdutoJsonString).ToList();
                        idMaterial = list.First().id;
                        GetMaterialById(idMaterial);

                    }
                   

                }
            }


        }
        void get(Model.Material s)
        {

            names.Add(s.nome);
        }

        async void AddGasto()
        {
            var newURI = URI + "/Gastos";
            Gasto prod = new Gasto();
            prod.idMaterial = idMaterial;
            prod.valor = (double)precoNbr.Value;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }

        }
        private async void UpdateMaterial(int codProduto)
        {
            var newURI = URI + "/Materials";

            old.qtd = old.qtd + (int)qtdNbr.Value;

            using (var client = new HttpClient())
            {
                
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(newURI + "/" + old.id, old);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto atualizado");
                    AddGasto();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }
        }
        private async void GetMaterialById(int codProduto)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                var newURI =URI + "/Materials/" + codProduto.ToString();

                HttpResponseMessage response = await client.GetAsync(newURI);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    old =JsonConvert.DeserializeObject<Material>(ProdutoJsonString);
                    UpdateMaterial(old.id);
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }
        }

        private void CadastrarGasto_Load(object sender, EventArgs e)
        {
            GetAllMateriais();
        }
    }
}
