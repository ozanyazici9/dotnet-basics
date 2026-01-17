using dotnet_basics.Models;
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
        Course kurs1 = new Course();
        kurs1.Title = "Django kursu";
        kurs1.Image = "1.jpg";
        return View(kurs1); // Views/Course/Details
    }
}
