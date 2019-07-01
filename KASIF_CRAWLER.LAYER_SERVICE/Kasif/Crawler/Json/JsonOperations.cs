using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_SERVICE.Kasif.Crawler.Json
{
    public class JsonOperations
    {
        public async Task<JObject> _getJobject(string json)
        {
            return JsonConvert.DeserializeObject<JObject>(json);
        }
        public async Task<Dictionary<string,JToken>> _getDictionary(string json)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
        }
        public async Task<JArray> _getJArray(string json)
        {
            return JsonConvert.DeserializeObject<JArray>(json);
        }
    }
}
