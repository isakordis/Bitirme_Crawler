using ComponentFactory.Krypton.Toolkit;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASIF_CRAWLER
{
    public partial class frmAna : KryptonForm
    {
        private LiteDatabase db = new LiteDatabase($@"E:\bit\kasifLocalv1.db");
        public frmAna()
        {
            InitializeComponent();
        }
        int total = 0;
        double sn = 0;
        List<string> totalResult = new List<string>();
        public async Task siteMapGezintisi(string adres)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = await new LAYER_SERVICE.Kasif.Crawler
                .Xml.XmlOperations()
                .getAllSiteAsync(adres);
            stopwatch.Stop();
            string outPut
                = $"\nSite\t\t:{adres}\nSonuç\t\t:{result.Count}\nSüre\t\t:{stopwatch.Elapsed.TotalSeconds} sn\n--------------------------";
            outPutTxt.Text += outPut;
            total += result.Count;
            sn += stopwatch.Elapsed.TotalSeconds;
            totalResult = totalResult.Concat(result.ToList())
                .ToList();
        }
        private async void gezintiBtn_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            loading.Visible = true;
            Thread thread = new Thread(t =>
            {
                for (int i = 0; i < siteAdresList.Items.Count; i++)
                {
                    string adres = siteAdresList.Items[i].ToString();
                    siteAdresList.SelectedIndex = i;
                    siteMapGezintisi(adres);
                }
                outPutTxt.Text += $"\n=======BİTTİ=========\nRAPOR:\n{siteAdresList.Items.Count} harita gezildi.\nToplamda {total.ToString()} adet açık adrese,{sn} sn içerisinde adresine ulaşıldı";
                loading.Visible = false;
                #region Siteleri Kaydet
                System.IO.StreamWriter
                    SaveFile
                    = new System.IO.StreamWriter($@"C:\Users\MSI\Desktop\{DateTime.Now.Ticks.ToString()}.txt", true);
                for (int i = 0; i < totalResult.Count; i++)
                {
                    
                    SaveFile.WriteLine(totalResult[i].ToString());
                }
                SaveFile.Close();
                //MessageBox.Show("Tüm siteler kaydedil");
                #endregion
            })
            { Priority = ThreadPriority.Normal, IsBackground = true };
            thread.Start();
            outPutTxt.Text += "\n=======BAŞLADI=========\n";
            //kryptonPage1.

           
        }

        private void outPutTxt_TextChanged(object sender, EventArgs e)
        {
            outPutTxt.SelectionStart = outPutTxt.Text.Length;

            outPutTxt.ScrollToCaret();
        }

        private void kayitBtn_LinkClicked(object sender, EventArgs e)
        {
            //string kayit = $@"C:\Users\{Environment.UserName}\Desktop";
            //string dosyaAdi = $"{kayit}\\{System.DateTime.Now.Ticks}.txt";
            //using (File.Create(dosyaAdi,1000000,System.IO.FileOptions.Asynchronous))
            //{
            //    outPutTxt.SaveFile(dosyaAdi, RichTextBoxStreamType.RichText);
            //}
            

        }

        private void frmAna_Load(object sender, EventArgs e)
        {

        }
    }
}
