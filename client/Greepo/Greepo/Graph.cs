using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Greepo
{
    public partial class Graph : Form
    {
       

        // Declare the lists to hold the data
        List<string> resultsList = new List<string>();
        List<int> projectIds = new List<int>();

        public Graph()
        {
            InitializeComponent();
           // InitGraph();
            
        }

        private async Task MakeApiCall()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:2080/projects");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        foreach (var item in json)
                        {
                            resultsList.Add(item["name"].ToString());
                            projectIds.Add(int.Parse(item["id_project"].ToString()));
                        }
                        //UpdateGraph();
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

        private async void Graph_Load(object sender, System.EventArgs e)
        {
            await MakeApiCall();
        }
    }
}