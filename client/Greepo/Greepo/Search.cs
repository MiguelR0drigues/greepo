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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Greepo
{
    public partial class Search : Form
    {
        private int _regiaoId;
        public Search(int regiaoId)
        {
            InitializeComponent();
            _regiaoId = regiaoId;
        }
        private async void Search_Load(object sender, EventArgs e)
        {
           await GetProjectsByRegion();
          
        }
        private async Task GetProjectsByRegion()
        {
            List<string> resultsList = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/regioes{_regiaoId}");
                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        foreach (var item in json)
                        {
                            resultsList.Add(item["name"].ToString());

                        }
                        MessageBox.Show(resultsList.ToString());
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

        }
    }

