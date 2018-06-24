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

        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        public static async Task InvokeRequestResponseService(string key, string dat1, string dat2, string dat3)    //dodani parametri za stvaranje inputa i odabiranje api kljuca za ulaz/izlaz
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
                                ColumnNames = new string[] {"Col1", "Col2", "Col3"},
                                Values = new string[,] {  { dat1, dat2, dat3 }, }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                string apiKey = key; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);


                if(key == "MUBPIvheS07W459cz1sYd7S2uLUuEAju8+3yUcBPJTJbtdSHfq64QKhpVskMfkce5EiyPrZDFKvzb4AWGeB7og==")       //u slucaju da je odabran ulazak putnika
                {
                    client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/ca10e95ffa45402cba2785091231bc41/services/3724c966bea44c17981642b147036881/execute?api-version=2.0&details=true");
                }
                else if(key == "fFRaDJSz9XDkGmpFZ6Ui/f9qDldgO+eAu04GQdezxnZ9SROxeiBValm9onIPczsafZQi9J4J1D3psfkmvLxxAQ==")  //u slucaju da je odabran ulazak putnika
                {
                    client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/ca10e95ffa45402cba2785091231bc41/services/c04dd72dd12c4301acc88930803b8958/execute?api-version=2.0&details=true");
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
                    System.IO.File.WriteAllText(@"C:\Users\Antonio\Documents\Visual Studio 2015\Projects\RUAPprojekt\rezultat.json", result); //ispis rezultata predikcije u .json datoteku
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

        public Form1()
        {
            InitializeComponent();
        }


        private void doPrediction_Click(object sender, EventArgs e)
        {
            string apikey;
            string datum1, datum2, datum3;
            datum1 = date1.Text.ToString();
            datum2 = date2.Text.ToString();
            datum3 = date3.Text.ToString();


            if (selectedEntries.Checked == true) //ako je odabran broj ulazaka
            {
                apikey = "MUBPIvheS07W459cz1sYd7S2uLUuEAju8+3yUcBPJTJbtdSHfq64QKhpVskMfkce5EiyPrZDFKvzb4AWGeB7og==";
                InvokeRequestResponseService(apikey, datum1, datum2, datum3).Wait();
            }
            else if(selectedExits.Checked == true) //ako je odabran broj izlazaka
            {
                apikey = "fFRaDJSz9XDkGmpFZ6Ui/f9qDldgO+eAu04GQdezxnZ9SROxeiBValm9onIPczsafZQi9J4J1D3psfkmvLxxAQ==";
                InvokeRequestResponseService(apikey, datum1, datum2, datum3).Wait();
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
    }
}
