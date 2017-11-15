using Newtonsoft.Json;
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
    public partial class Email : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        public Email()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {

        }
        async void AddGasto()
        {
            var newURI = URI + "/Email/send";
            String email = emailBox.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(email);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }

        }
    }
}
