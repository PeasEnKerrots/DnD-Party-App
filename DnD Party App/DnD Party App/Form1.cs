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

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            HttpClient client = new System.Net.Http.HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "kAvJer4b6Hd4yWWlrAfHmrTsnQtJXAk75PthaNoxUcWtRIIRIBTM5YNU_maCnLOTusfiKG-6jZCTfWHqA9QJAsNgSaO7txjb7T9-lJJ22ZEj84s_0dccmy38AEppWnYx");
            richTextBox1.Text = await (await client.GetAsync("https://api.yelp.com/v3/autocomplete?text=del&latitude=37.786882&longitude=-122.399972")).Content.ReadAsStringAsync();
        }
    }
}
