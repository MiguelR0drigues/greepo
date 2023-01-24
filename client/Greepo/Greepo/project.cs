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
using System.Diagnostics;

namespace Greepo
{
    public partial class project : Form
    {
        private int _projectId;
        private string _projectURL;
        public project(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;

        }

        private async void project_Load(object sender, EventArgs e)
        {
            await GetProjectDetails();
        }

        private void lblProjectTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_projectURL);
        }

        private async Task GetProjectDetails()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/projects/{_projectId}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    this.Invoke((MethodInvoker)(() =>
                    {
                        lblProjectTitle.Text = json[0].name;
                        _projectURL= json[0].page;
                    }));

                }
                else
                {
                    MessageBox.Show("Failed to get response from the API, Status Code: " + response.StatusCode);
                }
            }
        }

    }
}
