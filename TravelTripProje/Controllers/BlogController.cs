﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar =c.Blogs.ToList();

            return View(bloglar);
        }

        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            //var blogbul=c.Blogs.Where(x=>x.BlogID==id).ToList();
            by.Deger1=c.Blogs.Where(x=>x.BlogID==id).ToList();
            return View(by);
        }
    }
}