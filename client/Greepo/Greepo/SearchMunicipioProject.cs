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
    public partial class SearchMunicipioProject : Form
    {
        private int _municipioId;
        public SearchMunicipioProject(int municipioId)
        {
            InitializeComponent();
            _municipioId = municipioId;
        }
        private async void Search_Load(object sender, EventArgs e)
        {
            await GetProjectsByMunicipio();

        }
        private async Task GetProjectsByMunicipio()
        {
            List<string> resultsList = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/municipalityProject/{_municipioId}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        foreach (var item in json)
                        {
                            resultsList.Add(item["project_name"].ToString());
                        }
                        listBox1.Invoke((MethodInvoker)(() => listBox1.DataSource = resultsList));
                    }
                    else
                    {
                        MessageBox.Show("Error parsing response JSON");
                    }
                }
                else
                {
                    MessageBox.Show("Error getting response from the API. Status Code: " + response.StatusCode);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}