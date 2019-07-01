using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.DataModel
{
    [Table("Kasif_Kayitli_Siteler_TB")]
    public class Siteler
    {
        [Key]
        public int Id { get; set; }
        public string Site_Host { get; set; }
        public DateTime Kayit_Tarihi { get; set; }
        public DateTime Son_Indexlenme_Tarihi { get; set; }
    }
}
