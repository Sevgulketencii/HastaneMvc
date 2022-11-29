using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumAdi { get; set; }
        public string YorumAciklama { get; set; }
        public string YorumMail { get; set; }
        public int HaberId { get; set; }
        public virtual Haberler Haberler { get; set; }
    }
}
