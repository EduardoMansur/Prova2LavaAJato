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
            sendEmail();
            this.Hide();
        }
        async void sendEmail()
        {
          
            String email = emailBox.Text;
            var newURI = URI + "/Email?email=" + email;
            using (var client = new HttpClient())
            {
                //var content = new StringContent(email, Encoding.UTF8, "application/json");
                var content = new StringContent(email);
                var result = await client.PostAsync(newURI, content);
            }

        }
    }
}
