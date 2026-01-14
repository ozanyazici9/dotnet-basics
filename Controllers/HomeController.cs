using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
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