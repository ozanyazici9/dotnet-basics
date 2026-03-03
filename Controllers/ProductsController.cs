using Microsoft.AspNetCore.Mvc;
using dotnet_basics.Models;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {

  List<Product> urunler = [
           new Product 
             {
               Id = 1,
               UrunBaslik = "Samsung S24 Ultra",
               UrunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah",
               UrunFiyat = 12.999,
               UrunResim = "samsung-s24.jpg",
               UrunSatistami = true,
               IsHome = true
             },
             new Product 
             {
               Id = 2,
               UrunBaslik = "Samsung S25 Ultra",
               UrunAciklama = "Samsung Galaxy S25 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               UrunFiyat = 19.999,
               UrunResim = "samsung-s24.jpg",
               UrunSatistami = false,
               IsHome = true
             },        
             new Product 
             {
               Id = 3,
               UrunBaslik = "Samsung S26 Ultra",
               UrunAciklama = "Samsung Galaxy S26 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               UrunFiyat = 20.999,
               UrunResim = "samsung-s24.jpg",
               UrunSatistami = true,
               IsHome = true
             },        
             new Product 
             {
               Id = 4,
               UrunBaslik = "Samsung S26 Ultra",
               UrunAciklama = "Samsung Galaxy S26 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               UrunFiyat = 20.999,
               UrunResim = "samsung-s24.jpg",
               UrunSatistami = true,
               IsHome = true
             },        
             new Product 
             {
               Id = 5,
               UrunBaslik = "Samsung S26 Ultra",
               UrunAciklama = "Samsung Galaxy S26 Ultra 256 GB 24 GB Ram (Samsung Türkiye Garantili) Mavi",
               UrunFiyat = 20.999,
               UrunResim = "samsung-s24.jpg",
               UrunSatistami = true,
               IsHome = false
             }        

        ];

    // localhost:5022/
    public ActionResult Index()
    {
        List<Product> products = urunler.Where(a => a.IsHome == true).ToList();
        return View(products);
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
    public ActionResult Details(int id)
    {
        Product? urun = urunler.FirstOrDefault(a => a.Id == id);

        return View(urun); // Views/Products/Details
    }

}
    
    
    
