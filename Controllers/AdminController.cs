using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
         
        
        Dbcontext dbbaglan = new Dbcontext();

       

        public IActionResult Admin()
        {
            ViewBag.mail = dbbaglan.IletisimDb.Where(x => x.Okundu == 0).Count();
            ViewBag.rand = dbbaglan.RandevuDb.Where(x => x.Bayrak == 0).Count();

            var list = dbbaglan.AnasayfaDb.ToList();
            return View(list);
        }
        


        public IActionResult Güncelle(int id)
        {
            var güncellenen = dbbaglan.AnasayfaDb.Find(id);
            ViewBag.id = id;
            return View(güncellenen);
        }

        [HttpPost]
        public IActionResult Güncelle(Anasayfa güncelle)
        {
            var güncel = dbbaglan.AnasayfaDb.FirstOrDefault(x => x.Id == güncelle.Id);
            güncel.Baslik = güncelle.Baslik;
            güncel.Aciklama = güncelle.Aciklama;
           
            dbbaglan.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }


        public IActionResult Hakkimizda()
        {
            var list = dbbaglan.HakkındaDb.ToList();
            return View(list);
        }

        public IActionResult HakkimizdaGüncelle(int id)
        {
            var güncellenen = dbbaglan.HakkındaDb.Find(id);
            ViewBag.id = id;
            return View(güncellenen);
        }

        [HttpPost]
        public IActionResult HakkimizdaGüncelle(Hakkında güncel)
        {
            var gün = dbbaglan.HakkındaDb.FirstOrDefault(x => x.HakkımızdaId == güncel.HakkımızdaId);
            gün.HaberBaslik = güncel.HaberBaslik;
            gün.HaberAciklama = güncel.HaberAciklama;
            dbbaglan.SaveChanges();
            return RedirectToAction("Hakkimizda", "Admin");
        }
       
        public IActionResult Doktorlar()
        {
            var list = dbbaglan.DoktorDb.ToList();
            return View(list);
        }

        public IActionResult DoktorSil(int id)
        {
            var silinen = dbbaglan.DoktorDb.FirstOrDefault(x => x.DoktorId == id);
            dbbaglan.DoktorDb.Remove(silinen);
            dbbaglan.SaveChanges();
            return RedirectToAction("Doktorlar", "Admin");
        }

        public IActionResult DoktorGüncelle(int id)
        {
            var list = dbbaglan.DoktorDb.FirstOrDefault(x => x.DoktorId == id);
            ViewBag.id = id;
            return View(list);

        }

        [HttpPost]
        public IActionResult DoktorGüncelle(Doktor güncelle)
        {
            var güncel = dbbaglan.DoktorDb.FirstOrDefault(x => x.DoktorId == güncelle.DoktorId);
            güncel.DoktorId = güncelle.DoktorId;
            güncel.DoktorAdi = güncelle.DoktorAdi;
            güncel.DoktorSoyadi = güncelle.DoktorSoyadi;
            güncel.DoktorImgUrl = güncelle.DoktorImgUrl;
            güncel.DoktorTwLink = güncelle.DoktorTwLink;
            güncel.DoktorFcLink = güncelle.DoktorFcLink;
            güncel.DoktorAlani = güncelle.DoktorAlani;
            güncel.DoktorYetki = güncelle.DoktorYetki;
            dbbaglan.SaveChanges();

            return RedirectToAction("Doktorlar","Admin");

        }

        public IActionResult DoktorEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoktorEkle(Doktor yeni)
        {
            dbbaglan.DoktorDb.Add(yeni);
            dbbaglan.SaveChanges();

            return RedirectToAction("Doktorlar", "Admin");

        }

        public IActionResult Haberler()
        {
            var list = dbbaglan.HaberlerDb.ToList();
            return View(list);
        }

        public IActionResult HaberSil(int hid)
        {
            ViewBag.id = hid;
            var sil = dbbaglan.HaberlerDb.FirstOrDefault(x => x.HaberId == hid);
            dbbaglan.HaberlerDb.Remove(sil);
            dbbaglan.SaveChanges();
            return RedirectToAction("Haberler", "Admin");

        }

        public IActionResult HaberGüncelle(int id)
        {
            var güncellenen = dbbaglan.HaberlerDb.FirstOrDefault(x => x.HaberId == id);
            return View(güncellenen);
        }

        public IActionResult HaberEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult HaberEkle(Haberler yeni)
        {
            dbbaglan.HaberlerDb.Add(yeni);
            dbbaglan.SaveChanges();
            return RedirectToAction();
        }

        public IActionResult Iletisim()
        {
            var list = dbbaglan.IletisimDb.OrderByDescending(x=>x.IletisimId).Take(10).ToList();
            
            return View(list);     
        }


        public IActionResult IletisimDetay(int id)
        {
            var detay = dbbaglan.IletisimDb.FirstOrDefault(x => x.IletisimId == id);
            detay.Okundu = 1;
            dbbaglan.SaveChanges();
            return View(detay);
        }

        public IActionResult Randevu()
        {
            var list = dbbaglan.RandevuDb.OrderByDescending(x => x.HastaId).Take(15).ToList();
            return View(list);
        }

        public IActionResult RandevuDetay(int id)
        {
            var detay = dbbaglan.RandevuDb.FirstOrDefault(x => x.HastaId== id);
            detay.Bayrak = 1;
            dbbaglan.SaveChanges();
            return View(detay);
        }

    }
        
       
}
