using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {

    // localhost:5022/
    public ActionResult Index()
    {
        return View(); // Views/Products/Index
    }

    // localhost:5022/products    
    public ActionResult Products()
    {
        return View(); // Views/Products/Products
    }

    // localhost:5022/products/list
    public ActionResult List()
    {
        return View(); // Views/Products/List
    }

    // localhost:5022/products/details
    public ActionResult Details()
    {
        string urunBaslik = "Samsung S24 Ultra";
        string urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
        double urunFiyat = 12.999;
        string urunResim = "samsung-s24.jpg";
        bool urunSatistami = false;

        ViewData["UrunBaslik"] = urunBaslik;
        ViewData["UrunAciklama"] = urunAciklama;
        ViewData["UrunFiyat"] = urunFiyat;
        ViewData["UrunResim"] = urunResim;
        ViewData["UrunSatistami"] = urunSatistami;

        return View(); // Views/Products/Details
    }

}
    
    
    
