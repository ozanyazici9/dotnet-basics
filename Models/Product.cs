using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_basics.Models;

    public class Product
    {
        public int Id { get; set; }
        public string? UrunBaslik { get; set; }
        public string? UrunAciklama { get; set; }
        public double UrunFiyat { get; set; }
        public string? UrunResim { get; set; }
        public bool UrunSatistami { get; set; }
        public int StokAdedi { get; set; }
        public bool IsHome { get; set; }
    }
