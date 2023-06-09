﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
    
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context  c = new Context();
        [Authorize]

        public ActionResult Index()
        {
            var degerler =c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p) 

        { 
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id) 
        {
            var values = c.Blogs.Find(id);
            return View("BlogGetir",values);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var values=c.Blogs.Find(b.BlogID);
            values.Aciklama= b.Aciklama;
            values.Baslik= b.Baslik;
            values.BlogImage= b.BlogImage;
            values.Tarih= b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
                
        }

        public ActionResult YorumListesi()
        {
            var yorumlar=c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id) 
        {
            var values=c.Yorumlars.Find(id);
            c.Yorumlars.Remove(values);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var values = c.Yorumlars.Find(id);
            return View("YorumGetir", values);
        }
        public ActionResult YorumGüncelle(Yorumlar y)
        {
            var values = c.Yorumlars.Find(y.YorumlarID);
            values.KullaniciAdi= y.KullaniciAdi;
            values.Mail= y.Mail;
            values.Yorum= y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

    }
}