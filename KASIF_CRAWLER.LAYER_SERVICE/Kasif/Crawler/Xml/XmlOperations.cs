using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace KASIF_CRAWLER.LAYER_SERVICE.Kasif.Crawler.Xml
{
    public class XmlOperations
    {
        private async Task<IEnumerable<XElement>> zipConvert(string uri)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            req.Timeout = 1000 * 60 * 60; // milliseconds  
            WebResponse res = req.GetResponse();
            Stream responseStream = res.GetResponseStream();
            GZipStream zip = new GZipStream(responseStream, CompressionMode.Decompress);
            XDocument xml2 = XDocument.Load(zip);

            return xml2.Root.Elements();
        }
        private async Task<List<string>> getSiteFromUrlAsync(string xmlUri)
        {
            try
            {
                XElement xElement = null;
                if (xmlUri.EndsWith("xml.gz"))
                {
                    IEnumerable<XElement>
                     elemList = await zipConvert(xmlUri);
                    var locList = elemList.Elements().Where(f => f.Name.LocalName == "loc" || f.Name.LocalName == "link").ToList();
                    return locList.Select(f => f.Value).ToList();
                }
                else
                {
                    xmlUri = xmlUri.Replace("https", "http");
                    xElement = XElement.Load(xmlUri);
                    IEnumerable<XElement>
                  elemList = xElement.Elements();
                    var locList = elemList.Elements().Where(f => f.Name.LocalName == "loc" || f.Name.LocalName == "link").ToList();
                    return locList.Select(f => f.Value).ToList();
                }




            }
            catch (Exception)
            {

                return null;
            }
        }
        private async Task<bool> isXmlSite(string addres)
        {
            try
            {
                XDocument xml = XDocument.Load(addres);
                var result = xml.Document.Elements();
                return true;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("doctype")) return false;
                else return false;
            }
        }
        public async Task<List<string>> getAllSiteAsync(string siteXmlUri)
        {
            List<string> sitemapIndexList = new List<string>(75000);
          
            var sitemapList= await getSiteFromUrlAsync(siteXmlUri);
            if (sitemapList == null) return sitemapIndexList;
            if(sitemapList.Count>0)
            {
                bool result = await isXmlSite(sitemapList[0]);
                if (result == false)
                {
                    if(!sitemapList[0].EndsWith("xml.gz"))
                    {
                        foreach (var xmlLink in sitemapList)
                        {
                            if (sitemapIndexList.Count == 75000) return sitemapIndexList;
                            sitemapIndexList.Add(xmlLink);
                        }
                        return sitemapIndexList;
                    }
                   
                    
                   
                }
            }
            foreach (var item in sitemapList)
            {
                var itemResult = await getSiteFromUrlAsync(item);
                if (itemResult == null) break;
                foreach (var xmlLink in itemResult)
                {
                    if (xmlLink.EndsWith("xml.gz"))
                    {
                        var gzipLinks = await getSiteFromUrlAsync(xmlLink);
                        foreach (var gziplink in gzipLinks)
                        {
                            if (sitemapIndexList.Count == 75000) return sitemapIndexList;
                            sitemapIndexList.Add(gziplink);
                        }
                    }
                    else {
                        if (sitemapIndexList.Count == 75000) return sitemapIndexList;
                        sitemapIndexList.Add(xmlLink);
                    }
                    
                }
                
            }
            var totalLink = sitemapIndexList;
            return sitemapIndexList;
        }
    }
}
