using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.DataModel
{
    [Table("Kasif_Alinan_Indexler_TB")]
    public class Indexler
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public int SiteId { get; set; }
        public DateTime Index_Tarih { get; set; } = DateTime.Now;
        public string Index_Baslik { get; set; }
        public string Index_Aciklama { get; set; }
        public string Index_Tip { get; set; }
        public string Index_Resim { get; set; }
        public List<string> Index_Etiketler { get; set; }
        public string Index_Data_Tipi { get; set; } = "XML";
        public DateTime Index_Guncelleme_Tarih { get; set; }

        [ForeignKey("SiteId")]
        public virtual Siteler Siteler { get; set; }
    }
}
