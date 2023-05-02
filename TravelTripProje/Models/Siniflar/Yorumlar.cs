﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int YorumlarID { get; set; }
        public string KullaniciAdi { get;set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }   
        public int BlogID { get; set; }
        public Blog Blog { get; set;}
    }
}