using HastaneMvc.Models.Sınıflar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Models.Dbcontext
{
    public class Dbcontext:DbContext
    {
        public DbSet<Anasayfa> AnasayfaDb { get; set; }
        public DbSet<Doktor> DoktorDb { get; set; }
        public DbSet<Haberler> HaberlerDb { get; set; }
        public DbSet<Hakkında> HakkındaDb { get; set; }
        public DbSet<Randevu> RandevuDb { get; set; }
        public DbSet<Iletisim> IletisimDb { get; set; }
        public DbSet<Yorum> YorumDb { get; set; }
        public DbSet<Admin> AdminDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=HastaneData;integrated security=true");
        }
    }
}
