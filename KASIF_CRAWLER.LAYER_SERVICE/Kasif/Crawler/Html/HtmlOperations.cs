using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_SERVICE.Kasif.Crawler.Html
{
    public class HtmlOperations
    {
        private HtmlAgilityPack.HtmlDocument hdoc { get; set; }
        private Uri siteUri { get; set; }
        /// <summary>
        /// Sınıf için yapılandırıcıyı temsil eder.
        /// </summary>
        /// <param name="uri">Hedef adresin url'sini temsil eder</param>
        public HtmlOperations(Uri uri) {
            try
            {
                HtmlAgilityPack.HtmlWeb hweb = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument hdoc = hweb.Load(uri.ToString());
                this.hdoc = hdoc;
            }
            catch (Exception)
            {

                this.hdoc = null;
            }
        }

        /// <summary>
        /// Girilen web adresindeki ld+json itemları getiren asenkron fonksiyon
        /// </summary>
        /// <returns>List of string</returns>
        public async Task<List<string>> _getLdJsonItems()
        {
            try
            {
                if (hdoc == null) return null;
                var result = hdoc.DocumentNode
                   .SelectNodes("//script[@type='application/ld+json']")
                   .ToList();
                List<string> items = new List<string>();
                foreach (var item in result)
                {
                    items.Add(item.InnerText.Replace("@", ""));
                }
                return items;
            }
            catch (Exception)
            {

                return null;
            }
        }
        /// <summary>
        /// Girilen web adresininin sayfa kaynağını getiren asenkron fonksiyondur
        /// </summary>
        /// <returns>HtmlAgilityPack.HtmlDocument</returns>
        public async Task<HtmlAgilityPack.HtmlDocument>
            _getPageSource() => this.hdoc;
       
    }
}
