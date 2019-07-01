using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KASIF_CRAWLER.LAYER_SERVICE.Kasif;

namespace KASIF_CRAWLER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_LoadAsync(object sender, EventArgs e)
        {
            List<string> lditems
                = await new LAYER_SERVICE.Kasif.Crawler.
                Html.HtmlOperations(new Uri("https://shiftdelete.net/snapdragon-8150-tum-dengeleri-bozmaya-geliyor"))._getLdJsonItems();
            Dictionary<string, JToken> siteDatas = new Dictionary<string, JToken>();
            var action = new LAYER_SERVICE.Kasif.Crawler.Actions.ActionOperations();
            action.allDictionaryList = siteDatas;
            if (lditems == null) return;
            foreach (var item in lditems)
            {
              
                JObject ld = await new LAYER_SERVICE.Kasif.Crawler.Json
                    .JsonOperations()._getJobject(item.ToString());
                Dictionary<string, JToken>
                    ldtoken = await new LAYER_SERVICE.Kasif.Crawler.Json
                    .JsonOperations()._getDictionary(ld.ToString());
                
                foreach (var tokenControl in ldtoken)
                {
                    if (tokenControl.Value.GetType() == typeof(JValue) || tokenControl.Value.GetType()==typeof(string))
                    {
                        siteDatas = await action._addDictionary(tokenControl);

                    }
                    else if (tokenControl.Value.GetType() == typeof(JObject))
                    {
                        JObject other = await new LAYER_SERVICE.Kasif.Crawler.Json
                                                    .JsonOperations()._getJobject(tokenControl.Value.ToString());

                        Dictionary<string, JToken>
                            othertoken = await new LAYER_SERVICE.Kasif.Crawler.Json
                            .JsonOperations()._getDictionary(other.ToString());
                        siteDatas = await action._addDictonary(othertoken);

                    }
                    else if (tokenControl.Value.GetType() == typeof(JArray))
                    {
                        //JArray other = await new LAYER_SERVICE.Kasif.Crawler.Json
                        //                             .JsonOperations()
                        //                             ._getJArray(tokenControl.Value.ToString());
                        //siteDatas = await action._addDictonary(other, tokenControl.Key);
                    }

                }
               
            }
            kontrolEt:
            var jobjectQuery
                = siteDatas.Where(sa => sa.Value.GetType() != typeof(JValue)).Count();
            Dictionary<string, JToken> onlyDatas = new Dictionary<string, JToken>();
            action.allDictionaryList = onlyDatas;
            List<string> removesKey = new List<string>();
            if (jobjectQuery > 0)
            {
                foreach (var data in siteDatas)
                {
                    if (data.Value.GetType() == typeof(JObject))
                    {
                        JObject other =
                            await new
                            LAYER_SERVICE.Kasif.Crawler.Json
                            .JsonOperations()._getJobject(data.Value.ToString());

                        Dictionary<string, JToken>
                            othertoken = await new LAYER_SERVICE.Kasif.Crawler.Json
                            .JsonOperations()._getDictionary(other.ToString());
                        action.allDictionaryList = onlyDatas;
                        onlyDatas = await action._addDictonary(othertoken);
                        removesKey.Add(data.Key);
                        //onlyDatas = await action._removeKey(data.Key);
                    }

                }
            }
            foreach (var key in removesKey)
            {
                siteDatas.Remove(key);
            }
            siteDatas.Concat(onlyDatas);
            var endjObjectQuery = siteDatas.Where(s => s.Value.GetType() != typeof(JValue)).Count();
            if (endjObjectQuery > 0) goto kontrolEt;
            this.Text = siteDatas.Count.ToString();
            var res = siteDatas;
        }
    }
}
