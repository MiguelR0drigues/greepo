using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Greepo
{
    public partial class Token : Form
    {
        private String Email;
        public Token()
        {
            InitializeComponent();
        }

        public Token(String Email)
        { this.Email = Email; InitializeComponent(); }

        private async void btnSendToken_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new Dictionary<string, string>
                {
                    { "mail", Email },
                    { "token", inptToken.Text }
                };

                HttpResponseMessage response = await client.PostAsync("http://localhost:2080/get-token", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    Options Options = new Options();
                    Options.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error getting response from the API. Status Code: " + response.StatusCode);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Recuperar rec = new Recuperar();
            rec.Show();
            Hide();
        }
    }
}
