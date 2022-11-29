using HastaneMvc.Models;
using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    public class HomeController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        AnasayfaDoktor x = new AnasayfaDoktor();

        public IActionResult Index()
        {
            
            x.Anasayfa = dbbaglan.AnasayfaDb.ToList();
            x.Doktor = dbbaglan.DoktorDb.ToList();
            x.Haberler = dbbaglan.HaberlerDb.OrderByDescending(x => x.Tarih).Take(3).ToList();
            return View(x);
        }

        [HttpPost]
        public IActionResult Index(Randevu yeniRandevu)
        {
            dbbaglan.RandevuDb.Add(yeniRandevu);
            dbbaglan.SaveChanges();

            return RedirectToAction("Index");
        }





    }
}
