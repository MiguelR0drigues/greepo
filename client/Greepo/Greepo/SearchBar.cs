using Newtonsoft.Json.Linq;
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

namespace Greepo
{
    public partial class SearchBar : Form
    {
        private List<int> regiaoIds = new List<int>();
        List<string> resultsList = new List<string>();
        private bool isFormLoad = true;

        public SearchBar()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            await MakeApiCall();
            isFormLoad = false;
        }

        private async Task MakeApiCall()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:2080/regioes");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        foreach (var item in json)
                        {
                            regiaoIds.Add(int.Parse(item["id"].ToString()));
                            resultsList.Add(item["name"].ToString());

                        }
                        listBox1.Invoke((MethodInvoker)(() => listBox1.DataSource = resultsList));
                    }
                    else
                    {
                        MessageBox.Show("Results not found in the response");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to get response from the API, Status Code: " + response.StatusCode);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int selectedIndex = listBox1.SelectedIndex;
                    //Getting the project id of the selected row
                    int regiaoId = regiaoIds[selectedIndex];
                    //Creating a new instance of the Project form and passing the project id
                    Search search= new Search(regiaoId);
                    search.Show();
                }
            }

        }
    }
}
