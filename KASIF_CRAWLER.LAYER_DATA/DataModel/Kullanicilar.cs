using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.DataModel
{
    [Table("Kasif_Kullanicilar_TB")]
    public class Kullanicilar
    {
        public Guid Id { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Sifre { get; set; }
        public string AdSoyad { get; set; }
        public DateTime Kayit_Tarihi { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }//1 kadın 0 erkek

    }
}
