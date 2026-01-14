using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{
    public ActionResult Index()
    {
        return View(); // Views/Course/Index
    }

    public ActionResult List()
    {
        return View(); // Views/Course/List
    }

    public ActionResult Details()
    {
        return View(); // Views/Course/Details
    }
}
