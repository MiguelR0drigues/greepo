﻿using Newtonsoft.Json.Linq;
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
    public partial class SearchDistrito : Form
    {
        private List<int> distritosIds = new List<int>();
        List<string> resultsList = new List<string>();
        private bool isFormLoad = true;
        public SearchDistrito()
        {
            InitializeComponent();
        }
        private async void Search_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            await MakeApiCall();
            isFormLoad = false;

        }
        private async Task MakeApiCall()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:2080/distritos");
                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    if (json != null)
                    {
                        foreach (var item in json)
                        {
                            distritosIds.Add(int.Parse(item["id"].ToString()));
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
                    int distritoId = distritosIds[selectedIndex];
                    //Creating a new instance of the Project form and passing the project id
                    SearchDistritoProject search = new SearchDistritoProject(distritoId);
                    search.Show();
                }
            }

        }
    }
}