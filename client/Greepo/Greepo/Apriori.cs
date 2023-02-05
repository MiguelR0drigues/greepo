using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Fuzzy;
using System.Linq;

namespace Greepo
{
    public partial class Apriori : Form
    {
        private List<List<int>> transactions;
        private double supportThreshold;
        private List<List<int>> frequentItemSets;

        public Apriori(List<List<int>> transactions, double supportThreshold)
        {
            this.transactions = transactions;
            this.supportThreshold = supportThreshold;
            this.frequentItemSets = new List<List<int>>();
        }
        public class ProjectValues
        {
            public int id_projects { get; set; }
            public int o1 { get; set; }
            public int o2 { get; set; }
            public int o3 { get; set; }
            public int o4 { get; set; }
            public int o5 { get; set; }
            public int o6 { get; set; }
            public int o7 { get; set; }
            public int o8 { get; set; }
            public int o9 { get; set; }
            public int o10 { get; set; }
            public int o11 { get; set; }
            public int o12 { get; set; }
            public int o13 { get; set; }
            public int o14 { get; set; }
            public int o15 { get; set; }
            public int o16 { get; set; }
            public int o17 { get; set; }
        }

        public Apriori()
        {
            InitializeComponent();
        }
        private async void Apriori_Load(object sender, EventArgs e)
        {
            await MakeApiCall();
        }

        public List<List<int>> GetFrequentItemSets()
        {
            Dictionary<List<int>, int> itemSetCounts = new Dictionary<List<int>, int>(new ListComparer());

            // Find all frequent 1-item sets
            for (int i = 0; i < transactions.Count; i++)
            {
                foreach (int item in transactions[i])
                {
                    List<int> itemSet = new List<int> { item };

                    if (itemSetCounts.ContainsKey(itemSet))
                    {
                        itemSetCounts[itemSet]++;
                    }
                    else
                    {
                        itemSetCounts[itemSet] = 1;
                    }
                }
            }

            int transactionCount = transactions.Count;
            foreach (var itemSetCount in itemSetCounts.ToList())
            {
                if ((double)itemSetCount.Value / transactionCount < supportThreshold)
                {
                    itemSetCounts.Remove(itemSetCount.Key);
                }
            }

            frequentItemSets.AddRange(itemSetCounts.Keys);

            // Generate frequent item sets of increasing size
            int k = 2;
            while (frequentItemSets[k - 2].Count > 0)
            {
                List<List<int>> candidateItemSets = GenerateCandidateItemSets(frequentItemSets[k - 2], k);

                itemSetCounts.Clear();
                foreach (var transaction in transactions)
                {
                    foreach (var candidateItemSet in candidateItemSets)
                    {
                        if (transaction.ContainsAll(candidateItemSet))
                        {
                            if (itemSetCounts.ContainsKey(candidateItemSet))
                            {
                                itemSetCounts[candidateItemSet]++;
                            }
                            else
                            {
                                itemSetCounts[candidateItemSet] = 1;
                            }
                        }
                    }
                }

                foreach (var itemSetCount in itemSetCounts.ToList())
                {
                    if ((double)itemSetCount.Value / transactionCount < supportThreshold)
                    {
                        itemSetCounts.Remove(itemSetCount.Key);
                    }
                }

                frequentItemSets.Add(itemSetCounts.Keys.ToList());
                k++;
            }

            return frequentItemSets;
        }

            private async Task MakeApiCall()
        {
            String municipalityName = "Lisboa";
            List<ProjectValues> resultsList = new List<ProjectValues>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:2080/projectIdandValues/" + municipalityName);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    resultsList = JsonConvert.DeserializeObject<List<ProjectValues>>(responseBody);
                }
                else
                {
                    MessageBox.Show("Failed to get response from the API, Status Code: " + response.StatusCode);
                }
            }
            Dictionary<int, int> itemDictionary = new Dictionary<int, int>();
            List<List<int>> transactions = new List<List<int>>();
            int itemIndex = 0;
            foreach (ProjectValues project in resultsList)
            {

                List<int> transaction = new List<int>();
                transaction.Add(project.o1);
                transaction.Add(project.o2);
                transaction.Add(project.o3);
                transaction.Add(project.o4);
                transaction.Add(project.o5);
                transaction.Add(project.o6);
                transaction.Add(project.o7);
                transaction.Add(project.o8);
                transaction.Add(project.o9);
                transaction.Add(project.o10);
                transaction.Add(project.o11);
                transaction.Add(project.o12);
                transaction.Add(project.o13);
                transaction.Add(project.o14);
                transaction.Add(project.o15);
                transaction.Add(project.o16);
                transaction.Add(project.o17);

                foreach (int item in transaction)
                {
                    if (!itemDictionary.ContainsKey(item))
                    {
                        itemDictionary[item] = itemIndex;
                        itemIndex++;
                    }
                }

                for (int i = 0; i < transaction.Count; i++)
                {
                    transaction[i] = itemDictionary[transaction[i]];
                }

                transactions.Add(transaction);
            }
            using (StreamWriter writer = new StreamWriter("transactions.txt"))
            {
                foreach (List<int> transaction in transactions)
                {
                    string line = string.Join(",", transaction);
                    writer.WriteLine(line);
                }
            }
        }
    }
}
