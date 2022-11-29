using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string IletisimAdi { get; set; }
        public string IletisimPosta { get; set; }
        public string IletisimTel { get; set; }
        public string IletisimAciklama { get; set; }
        public int Okundu { get; set; }

    }
}
