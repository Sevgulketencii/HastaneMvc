using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Sınıflar
{
    public class Hakkında
    {
        [Key]
        public int HakkımızdaId { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberAciklama { get; set; }
     
    }
}
