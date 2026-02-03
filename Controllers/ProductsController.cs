using Microsoft.AspNetCore.Mvc;
using dotnet_basics.Models;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {

  List<Product> urunler = new List<Product>
        { 
           new Product 
             {
               urunBaslik = "Samsung S24 Ultra",
               urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah",
               urunFiyat = 12.999,
               urunResim = "samsung-s24.jpg",
               urunSatistami = true,
               IsHome = true
             },
             new Product 
             {
               urunBaslik = "Samsung S25 Ultra",
               urunAciklama = "Samsung Galaxy S25 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               urunFiyat = 19.999,
               urunResim = "samsung-s24.jpg",
               urunSatistami = false,
               IsHome = true
             },        
             new Product 
             {
               urunBaslik = "Samsung S26 Ultra",
               urunAciklama = "Samsung Galaxy S26 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               urunFiyat = 20.999,
               urunResim = "samsung-s24.jpg",
               urunSatistami = true,
               IsHome = true
             },        
             new Product 
             {
               urunBaslik = "Samsung S26 Ultra",
               urunAciklama = "Samsung Galaxy S26 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               urunFiyat = 20.999,
               urunResim = "samsung-s24.jpg",
               urunSatistami = true,
               IsHome = true
             },        
             new Product 
             {
               urunBaslik = "Samsung S26 Ultra",
               urunAciklama = "Samsung Galaxy S26 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               urunFiyat = 20.999,
               urunResim = "samsung-s24.jpg",
               urunSatistami = true,
               IsHome = false
             }        

        };

    // localhost:5022/
    public ActionResult Index()
    {
        return View(urunler);
    }

    // localhost:5022/products    
    public ActionResult Products()
    {
        return View(urunler); // Views/Products/Products
    }

    // localhost:5022/products/list
    public ActionResult List()
    {
        return View(urunler); // Views/Products/List
    }

    // localhost:5022/products/details
    public ActionResult Details()
    {
        // string urunBaslik = "Samsung S24 Ultra";
        // string urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
        // double urunFiyat = 12.999;
        // string urunResim = "samsung-s24.jpg";
        // bool urunSatistami = false;

        Product urun1 = new()
        {
            urunBaslik = "Samsung S24 Ultra",
            urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah",
            urunFiyat = 12.999,
            urunResim = "samsung-s24.jpg",
            urunSatistami = true,
            stokAdedi = 0
        };


        return View(urun1); // Views/Products/Details
    }

}
    
    
    
