using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    public class HakkimizdaController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        AnasayfaDoktor a = new AnasayfaDoktor();
        public IActionResult Hakkimizda()
        {
            a.Hakkimizda = dbbaglan.HakkındaDb.Take(1).ToList();
            a.Doktor = dbbaglan.DoktorDb.OrderByDescending(x => x.DoktorId).Take(3).ToList();
            return View(a);
        }
    }
}
