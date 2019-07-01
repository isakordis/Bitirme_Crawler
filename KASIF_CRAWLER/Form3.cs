using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASIF_CRAWLER
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public async Task Cagir()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result
                = await new LAYER_SERVICE.Kasif.Crawler.Xml.XmlOperations()
                .getAllSiteAsync("https://onedio.com/secure/sitemap.xml");
            stopwatch.Stop();
            string outPut = string.Format($"Toplamda\t\t:{stopwatch.Elapsed.Seconds} sn\nSonuc\t\t:{result.Count}");
             richTextBox1.Text += outPut;
            

        }
        private async void Form3_Load(object sender, EventArgs e)
        {
            await Cagir();
        }
    }
}
