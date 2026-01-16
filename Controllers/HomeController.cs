using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        int sayi1 = 10;
        int sayi2 = 20;
        int urunFiyat = 5000;

        sayi1 = 30;
        sayi2 = 40;

        int toplam = sayi1 + sayi2;

        ViewData["Toplam"] = toplam;

        return View(); // Views/Home/Index.cshtml
    }

    public ActionResult About()
    {
        return View(); // Views/Home/About.cshtml
    }

    public ActionResult Contact()
    {
        return View(); // Views/Home/Contact.cshtml
    }
}