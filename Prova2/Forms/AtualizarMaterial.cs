using Newtonsoft.Json;
using Prova2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2.Forms
{
  
    public partial class AtualizarMaterial : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        int idMaterial = 1;
        List<string> names = new List<string>();
        Material old = new Material();

        public AtualizarMaterial()
        {
            InitializeComponent();
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
        private async void UpdateMaterial(int codProduto)
        {
            var newURI = URI + "/Materials";

            old.qtd = (int)qtdNbr.Value;

            using (var client = new HttpClient())
            {

                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(newURI + "/" + old.id, old);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto atualizado");
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
                var newURI = URI + "/Materials/" + codProduto.ToString();

                HttpResponseMessage response = await client.GetAsync(newURI);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    old = JsonConvert.DeserializeObject<Material>(ProdutoJsonString);
                    UpdateMaterial(old.id);
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }
        }

        private void AtualizarMaterial_Load(object sender, EventArgs e)
        {
            GetAllMateriais();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            setMaterialId();
            this.Hide();
        }
    }
}
