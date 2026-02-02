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
        // Course[] kurslar = [kurs1, kurs2];

        List<Course> kurslar = new List<Course>{
            new Course { Title = "Javascript Kursu", Image = "1.jpg", IsActive = false },
            new Course { Title = "React Kursu", Image = "2.jpg", IsActive = true }
        };

        return View(kurslar); // Views/Course/List
    }

    public ActionResult Details() 
    {
        Course kurs1 = new Course();
        kurs1.Title = "Django kursu";
        kurs1.Image = "1.jpg";
        return View(kurs1); // Views/Course/Details
    }
}
