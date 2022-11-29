using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class Haberler
    {
        [Key]
        public int HaberId { get; set; }
        public string HaberBaslik{ get; set; }
        public string HaberAciklama { get; set; }
        public string HaberImgUrl { get; set; }
        public string Etiket { get; set; }
        public DateTime Tarih { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
    }
}
