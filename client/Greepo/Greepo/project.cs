using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LiveCharts;
using LiveCharts.Wpf;
using Accord;


namespace Greepo
{
    public partial class project : Form
    {
        private int _projectId;
        private string _projectURL;
        private string _muniId;
        public project(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;


        }

        private async void project_Load(object sender, EventArgs e)
        {
            await GetProjectDetails();
            await GetMunicipalityName();
            await ConfigureChart();
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
                        lblDesc.Text = json[0].description;
                        _muniId= json[0].id_municipality;
                    }));
                }
                else
                {
                    MessageBox.Show("Failed to get response from the API, Status Code: " + response.StatusCode);
                }
            }
        }

        private async Task GetMunicipalityName()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/municipality/{_muniId}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    lblMuni.Text = json.name;
                }
                else
                {
                    MessageBox.Show("Failed to get response from the API, Status Code: " + response.StatusCode);
                }
            }
        }

        private async Task ConfigureChart()
        {
            chart1.Series["Objectives"].IsValueShownAsLabel = true;
            chart1.Series["Objectives"].IsVisibleInLegend = false;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/projects-values/{_projectId}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    AddDataPoint("1", json[0].o1);
                    AddDataPoint("2", json[0].o2);
                    AddDataPoint("3", json[0].o3);
                    AddDataPoint("4", json[0].o4);
                    AddDataPoint("5", json[0].o5);
                    AddDataPoint("6", json[0].o6);
                    AddDataPoint("7", json[0].o7);
                    AddDataPoint("8", json[0].o8);
                    AddDataPoint("9", json[0].o9);
                    AddDataPoint("10", json[0].o10);
                    AddDataPoint("11", json[0].o11);
                    AddDataPoint("12", json[0].o12);
                    AddDataPoint("13", json[0].o13);
                    AddDataPoint("14", json[0].o14);
                    AddDataPoint("15", json[0].o15);
                    AddDataPoint("16", json[0].o16);
                    AddDataPoint("17", json[0].o17);
                }
                else
                {
                    MessageBox.Show("Failed to get response from the API, Status Code: " + response.StatusCode);
                }
            }
        }

        private void AddDataPoint(string xValue, dynamic yValue)
        {
            if (yValue != null)
            {
                this.chart1.Series["Objectives"].Points.AddXY(xValue, yValue.ToString());
            }
            else
            {
                this.chart1.Series["Objectives"].Points.AddXY(xValue, 0);
            }
        }


    }
}
