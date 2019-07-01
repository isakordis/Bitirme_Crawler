using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.DataModel
{
    [Table("Kasif_Arama_Analiz_TB")]
    public class Arama_Analizleri
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int SiteId { get; set; }
        public DateTime Arama_Tarihi { get; set; }
        public Guid Arayan_Id { get; set; }
        public DateTime Tiklama_Tarihi { get; set; }


        [ForeignKey("SiteId")]
        public virtual Siteler Siteler { get; set; }
        [ForeignKey("Arayan_Id")]
        public virtual Kullanicilar Kullanicilar { get; set; }

    }
}
