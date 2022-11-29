using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class AnasayfaDoktor
    {
        public List<Anasayfa> Anasayfa { get; set; }
        public List<Doktor> Doktor { get; set; }
        public List<Randevu> Randevu { get; set; }
        public List<Hakkında> Hakkimizda { get; set; }
        public List<Haberler> Haberler { get; set; }

        
    }



}
