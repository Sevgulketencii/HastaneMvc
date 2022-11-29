using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class SonHaberler
    {
        public List<Haberler> haberler { get; set; }
        public List<Haberler> SonHaber { get; set; }
        public List<Haberler> Kategori { get; set; }
        public List<Yorum>  Yorumlar { get; set; }

    }
}
