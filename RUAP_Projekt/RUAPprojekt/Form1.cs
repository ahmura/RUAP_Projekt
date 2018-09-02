using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace RUAPprojekt
{

    public partial class Form1 : Form
    {
        public List<string> lista = new List<string>();

        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public async Task InvokeRequestResponseService(string key, string dat1, string dat2, string dat3, string dat4)    //dodani parametri za stvaranje inputa i odabiranje api kljuca za ulaz/izlaz
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"datum_predvidjanja", "datum_predvidjanja-1", "datum_predvidjanja-2", "datum_predvidjanja-3"},
                                Values = new string[,] {  { dat1, dat2, dat3, dat4 }, }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                string apiKey = key; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);


                if(key == "ReLiTuwKLzIU6fj8Zn0M9YveCnWBXlCGj2k1F1NiY+BeqoMJMek9bU7aNC9ANH6C+kqslBnygpDok/TzzNzglQ==")       //u slucaju da je odabran ulazak putnika
                {
                    client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/ca10e95ffa45402cba2785091231bc41/services/f46453a134754fda8367c2b44859ed1f/execute?api-version=2.0&details=true");
                }
                else if(key == "xrVcnMU4g+BzVVfIvoSWl3ZpSn+kWrNbFIjqxZsT8wxBk6GJtInZ1T7VlG2wKJU2qgYd44YNP0+/mPxhVUbucw==")  //u slucaju da je odabran izlazak putnika
                {
                    client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/ca10e95ffa45402cba2785091231bc41/services/8520f79c8a8d40eca7f264308f2fa1cd/execute?api-version=2.0&details=true");
                }
                
                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);   //dodan .ConfigureAwait(false) jer se koristi C# aplikacija

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    
                    lista = result.Split(',').ToList();
                    lista[lista.Count - 2] = lista[lista.Count - 2].Replace(".",",");
                    lista = lista[lista.Count - 2].Split(',').ToList();
                    lista[0] = lista[0].Remove(0, 1);

                    MessageBox.Show("Predviđanje uspješno!");               //prikaz uspješno odrađene predikcije u message box-u
                }
                else                //prikaz errora u message box-ovima ako do njih dođe
                {
                    //Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));
                    MessageBox.Show("The request failed with status code: {0}");

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    MessageBox.Show(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseContent);
                }
            }
        }

        


        private void doPrediction_Click(object sender, EventArgs e)
        {
            string apikey;
            string datum1, datum2, datum3, datum4;
            datum1 = date1.Text.ToString();
            datum2 = date2.Text.ToString();
            datum3 = date3.Text.ToString();
            datum4 = date4.Text.ToString();

            if (selectedEntries.Checked == true) //ako je odabran broj ulazaka
            {
                apikey = "ReLiTuwKLzIU6fj8Zn0M9YveCnWBXlCGj2k1F1NiY+BeqoMJMek9bU7aNC9ANH6C+kqslBnygpDok/TzzNzglQ==";
                InvokeRequestResponseService(apikey, datum1, datum2, datum3, datum4).Wait();
                rez.Text = lista[0].ToString();
            }
            else if(selectedExits.Checked == true) //ako je odabran broj izlazaka
            {
                apikey = "xrVcnMU4g+BzVVfIvoSWl3ZpSn+kWrNbFIjqxZsT8wxBk6GJtInZ1T7VlG2wKJU2qgYd44YNP0+/mPxhVUbucw==";
                InvokeRequestResponseService(apikey, datum1, datum2, datum3, datum4).Wait();
                rez.Text = lista[0].ToString();
            }
            else        //ako nije odabrano niti jedno
            {
                MessageBox.Show("Odaberite koju predikciju želite!");
            }
        }

        //kontrola da se u text box-eve upisuju samo brojevi
        private void date1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void date2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void date3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void date4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
