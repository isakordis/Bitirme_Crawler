using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Schema.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASIF_CRAWLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> structerData = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlWeb
                hweb = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument
                hdoc = hweb.Load("http://www.webtekno.com/uzaktan-kumandali-oyuncak-araba-boyutunda-bir-kesif-araci-gelecek-sene-ay-i-kesfetmeye-gidecek-h57706.html");
            var result = hdoc.DocumentNode
                .SelectNodes("//script[@type='application/ld+json']")
                .ToList();
            string richResult = string.Empty;
            foreach (var item in result)
            {
                structerData.Add(item.InnerText);
                richResult += $"{item.InnerText}\n---------------------------------\n";
            }
            richTextBox1.Text = richResult;

            foreach (var ldJsons in result)
            {
                var _testJsonData = ldJsons;
                string textData = _testJsonData.InnerText.ToString().Replace("@", "");
                JObject deserialize = JsonConvert.DeserializeObject<JObject>(textData);

                Dictionary<string, JToken>
                                des = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(deserialize.ToString());
                foreach (var item in des)
                {

                    if (item.Value.GetType() == typeof(JValue))
                    {
                        listBox1.Items.Add($"{{[Key]:{item.Key}-[Value]:{item.Value}}}");
                    }
                    if (item.Key.Equals("author"))
                    {
                        JObject person = JsonConvert.DeserializeObject<JObject>(item.Value.ToString());
                        Dictionary<string, JToken>
                            personDic = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(person.ToString());
                    }
                    if (item.Key.Equals("mainEntityOfPage"))
                    {
                        JObject sayfa = JsonConvert.DeserializeObject<JObject>(item.Value.ToString());
                        Dictionary<string, JToken>
                            sayfaDic = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(sayfa.ToString());
                    }
                    if (item.Key.Equals("image"))
                    {
                        JObject sayfa = JsonConvert.DeserializeObject<JObject>(item.Value.ToString());
                        Dictionary<string, JToken>
                           imageDic = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(sayfa.ToString());
                    }
                    if (item.Key.Equals("publisher"))
                    {
                        JObject sayfa = JsonConvert.DeserializeObject<JObject>(item.Value.ToString());
                        Dictionary<string, JToken>
                           publisherDic = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(sayfa.ToString());
                    }

                }
            }
        }
    }
}
