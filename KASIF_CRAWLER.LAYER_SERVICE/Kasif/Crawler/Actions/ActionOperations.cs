using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_SERVICE.Kasif.Crawler.Actions
{
    public class ActionOperations
    {
        public Dictionary<string, JToken> allDictionaryList { get; set; }
        public async Task<Dictionary<string, JToken>>
            _addDictonary(Dictionary<string, JToken> item)
        {
            foreach (var dics in item)
            {
                if (allDictionaryList.ContainsKey(dics.Key))
                {
                    allDictionaryList.Add($"{dics.Key}-{Guid.NewGuid().ToString()}", dics.Value);
                }
                else {
                    allDictionaryList.Add(dics.Key, dics.Value);
                }
                
            }
            return this.allDictionaryList;

        }
         public async Task<Dictionary<string,JToken>> _addDictionary(KeyValuePair<string,JToken> item)
        {
            if (allDictionaryList.ContainsKey(item.Key))
            {
                allDictionaryList.Add($"{item.Key}-{Guid.NewGuid().ToString()}", item.Value);
            }
            else
            {
                allDictionaryList.Add(item.Key, item.Value);
            }
            return this.allDictionaryList;
        }
        public async Task<Dictionary<string,JToken>> _removeKey(string key)
        {
            allDictionaryList.Remove(key);
            return allDictionaryList;
        }

    }
}
