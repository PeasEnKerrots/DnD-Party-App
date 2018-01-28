using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Party_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private async Task testAsync()
        {
            HttpClient client = new System.Net.Http.HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("kAvJer4b6Hd4yWWlrAfHmrTsnQtJXAk75PthaNoxUcWtRIIRIBTM5YNU_maCnLOTusfiKG-6jZCTfWHqA9QJAsNgSaO7txjb7T9-lJJ22ZEj84s_0dccmy38AEppWnYx");
            HttpResponseMessage result = await client.GetAsync("https://api.yelp.com/v3/businesses/search/+12162263699");
            string tmp = await result.Content.ReadAsStringAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testAsync();
        }
    }
}
