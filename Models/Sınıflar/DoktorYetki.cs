using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class DoktorYetki
    {
        public List<Doktor> Bashekim { get; set; }
        public List<Doktor> Uzman { get; set; }
        public List<Doktor> Asistan { get; set; }
    }
}
