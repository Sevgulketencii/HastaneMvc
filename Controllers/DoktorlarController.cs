using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    public class DoktorlarController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        DoktorYetki liste = new DoktorYetki();
        public IActionResult Doktorlar()
        {
            liste.Bashekim = dbbaglan.DoktorDb.Where(x => x.DoktorYetki == "1").ToList();
            liste.Uzman = dbbaglan.DoktorDb.Where(x => x.DoktorYetki == "2").ToList();
            liste.Asistan = dbbaglan.DoktorDb.Where(x => x.DoktorYetki == "3").ToList();
            return View(liste);
        }
    }
}
