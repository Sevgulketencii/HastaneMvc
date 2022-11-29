using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class Doktor
    {
        [Key]
        public int DoktorId { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public string DoktorImgUrl { get; set; }
        public string DoktorAlani { get; set; }
        public string DoktorYetki { get; set; }
        public string DoktorFcLink{ get; set; }
        public string DoktorTwLink{ get; set; }
    }
}
