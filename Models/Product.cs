using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_basics.Models;

    public class Product
    {
        public string? urunBaslik { get; set; }
        public string? urunAciklama { get; set; }
        public double urunFiyat { get; set; }
        public string? urunResim { get; set; }
        public bool urunSatistami { get; set; }
        public int stokAdedi { get; set; }
        public bool IsHome { get; set; }
    }
