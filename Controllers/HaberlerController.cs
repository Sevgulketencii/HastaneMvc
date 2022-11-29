using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    public class HaberlerController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        SonHaberler haberler = new SonHaberler();
        


        public IActionResult Haberler(string etiket)
        {
           
            if (!string.IsNullOrEmpty(etiket))
            {
                
                haberler.haberler = dbbaglan.HaberlerDb.Where(x => x.Etiket == etiket).ToList();
                haberler.SonHaber = dbbaglan.HaberlerDb.OrderByDescending(x => x.HaberId).Take(3).ToList();

                if (haberler.Kategori == null)
                {
                    ViewBag.hata = 1;
                }


                return View(haberler);

            }
            haberler.haberler = dbbaglan.HaberlerDb.ToList();
            haberler.SonHaber = dbbaglan.HaberlerDb.OrderByDescending(x => x.HaberId).Take(3).ToList();
            return View(haberler);

        }
      
       

        public IActionResult HaberDetay(int id)
        {
            
            haberler.haberler= dbbaglan.HaberlerDb.Where(x => x.HaberId == id).ToList();
            haberler.SonHaber = dbbaglan.HaberlerDb.OrderByDescending(x => x.HaberId).Take(3).ToList();
            haberler.Kategori=dbbaglan.HaberlerDb.ToList();
            haberler.Yorumlar = dbbaglan.YorumDb.Where(x => x.HaberId == id).ToList();
            ViewBag.yorumid = id;
            return View(haberler);
        }
        
        [HttpPost]
        public IActionResult Yorum(Yorum yeniyorum)
        {
            dbbaglan.YorumDb.Add(yeniyorum);
            dbbaglan.SaveChanges();

            return RedirectToAction("Haberler");
        }
    }
}
