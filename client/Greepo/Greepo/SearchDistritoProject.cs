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
    public partial class SearchDistritoProject : Form
    {
        private int _distritoId;
        private List<int> projectIds = new List<int>();
        private bool isFormLoad = true;
        public SearchDistritoProject(int distritoId)
        {
            InitializeComponent();
            _distritoId = distritoId;
        }
        private async void Search_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            isFormLoad = false;
            await GetProjectsByDistrito();
        }
        private async Task GetProjectsByDistrito()
        {
            List<string> resultsList = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/distritos/{_distritoId}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        foreach (var item in json)
                        {
                            resultsList.Add(item["project_name"].ToString());
                            projectIds.Add(int.Parse(item["id_project"].ToString()));
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
            if (!isFormLoad)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int selectedIndex = listBox1.SelectedIndex;
                    //Getting the project id of the selected row
                    int projectId = projectIds[selectedIndex];
                    //Creating a new instance of the Project form and passing the project id
                    project project = new project(projectId);
                    project.Show();
                }
            }
        }
    }
}
    