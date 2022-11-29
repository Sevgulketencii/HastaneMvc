using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class Randevu
    {
        [Key]
        public int HastaId { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyad{ get; set; }
        public string HastalikAlan { get; set; }
        public DateTime Tarih{ get; set; }
        public string HastaMail { get; set; }
        public string HastaAciklama { get; set; }
        public int Bayrak{ get; set; }
    }
}
