using Newtonsoft.Json;
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
        private List<int> projectIds = new List<int>();
        private bool isFormLoad = true;
        public Search(int regiaoId)
        {
            InitializeComponent();
            _regiaoId = regiaoId;
        }
        private async void Search_Load(object sender, EventArgs e)
        {
            await GetProjectsByRegion();
            await ConfigureChart();

            listBox1.SelectedIndex = -1;
            isFormLoad = false;

        }
        private async Task GetProjectsByRegion()
        {
            List<string> resultsList = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/regioes/{_regiaoId}");
                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        lblTitle.Text = "Projetos da região de " + json[0]["region_name"].ToString();
                        foreach (var item in json)
                        {
                            resultsList.Add(item["project_name"].ToString());
                            resultsList.Add(item["municipality_name"].ToString());
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

        private async Task ConfigureChart()
        {
            chart1.Series["Objetivos"].IsValueShownAsLabel = true;
            chart1.Series["Objetivos"].IsVisibleInLegend = false;
            double o1 = 0;
            double o2 = 0;
            double o3 = 0;
            double o4 = 0;
            double o5 = 0;
            double o6 = 0;
            double o7 = 0;
            double o8 = 0;
            double o9 = 0;
            double o10 = 0;
            double o11 = 0;
            double o12 = 0;
            double o13 = 0;
            double o14 = 0;
            double o15 = 0;
            double o16 = 0;
            double o17 = 0;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/project-values-district/{_regiaoId}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    int length = json.Count;
                    foreach (var item in json)
                    {
                        o1 += (double)item.o1;
                        o2 += (double)item.o2;
                        o3 += (double)item.o3;
                        o4 += (double)item.o4;
                        o5 += (double)item.o5;
                        o6 += (double)item.o6;
                        o7 += (double)item.o7;
                        o8 += (double)item.o8;
                        o9 += (double)item.o9;
                        o10 += (double)item.o10;
                        o11 += (double)item.o11;
                        o12 += (double)item.o12;
                        o13 += (double)item.o13;
                        o14 += (double)item.o14;
                        o15 += (double)item.o15;
                        o16 += (double)item.o16;
                        o17 += (double)item.o17;
                    }

                    AddDataPoint("1", Math.Round(o1 / length, 2));
                    AddDataPoint("2", Math.Round(o2 / length, 2));
                    AddDataPoint("3", Math.Round(o3 / length, 2));
                    AddDataPoint("4", Math.Round(o4 / length, 2));
                    AddDataPoint("5", Math.Round(o5 / length, 2));
                    AddDataPoint("6", Math.Round(o6 / length, 2));
                    AddDataPoint("7", Math.Round(o7 / length, 2));
                    AddDataPoint("8", Math.Round(o8 / length, 2));
                    AddDataPoint("9", Math.Round(o9 / length, 2));
                    AddDataPoint("10", Math.Round(o10 / length, 2));
                    AddDataPoint("11", Math.Round(o11 / length, 2));
                    AddDataPoint("12", Math.Round(o12 / length, 2));
                    AddDataPoint("13", Math.Round(o13 / length, 2));
                    AddDataPoint("14", Math.Round(o14 / length, 2));
                    AddDataPoint("15", Math.Round(o15 / length, 2));
                    AddDataPoint("16", Math.Round(o16 / length, 2));
                    AddDataPoint("17", Math.Round(o17 / length, 2));


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
                this.chart1.Series["Objetivos"].Points.AddXY(xValue, yValue.ToString());
            }
            else
            {
                this.chart1.Series["Objetivos"].Points.AddXY(xValue, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBar search = new SearchBar();
            search.Show();
            Hide();
        }
    }
}

