using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.DataModel
{
    public class KasifContext:DbContext
    {
        public KasifContext() : base("Data Source=.;Initial Catalog=KasifDB2019;Integrated Security=SSPI")
        {

        }
        public virtual DbSet<Siteler> Siteler { get; set; }//Siteler Tablosu
        public virtual DbSet<Indexler> Indexler { get; set; }//Kayıtlı Sayfalar Tablosu
        public virtual DbSet<Arama_Analizleri> Aramalar { get; set; }//Aramalar Tablosu
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }//Kullanıcılar Sayfalar Tablosu
    }
}
