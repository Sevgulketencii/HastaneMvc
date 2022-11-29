using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    public class IletisimController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        
        public IActionResult Iletisim()
        {
            var liste = dbbaglan.IletisimDb.ToList();
            return View(liste);
        }

        [HttpPost]
        public IActionResult Iletisim(Iletisim eklenecek)
        {
            dbbaglan.IletisimDb.Add(eklenecek);
            dbbaglan.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
