using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Wpf;
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
            
            MakeApiCall();
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

    //    private void InitGraph()
    //    {
    //        Chart chart = new Chart();
    //        chart.Parent = this;
    //        chart.Location = new Point(20, 20);
    //        chart.Size = new Size(600, 400);
    //        chart.ChartAreas.Add(new ChartArea());
    //        chart.ChartAreas[0].AxisX.Title = "Project Name";
    //        chart.ChartAreas[0].AxisY.Title = "Id Project";
    //    }

    //    private void UpdateGraph()
    //    {
    //        series = new Series("Projects");
    //        series.ChartType = SeriesChartType.Bar;
    //        series.XValueType = ChartValueType.String;
    //        series.YValueType = ChartValueType.Int32;

    //        for (int i = 0; i < resultsList.Count; i++)
    //        {
    //            series.Points.AddXY(resultsList[i], projectIds[i]);
    //        }

    //        chart.Series.Add(series);
    //    }
    //}
}