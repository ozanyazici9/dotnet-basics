using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{

    List<Course> kurslar = new List<Course>
    {
        new Course { Title = "Javascript Kursu", Image = "1.jpg", IsActive = false, IsHome = true },
        new Course { Title = "Python Kursu", Image = "2.jpg", IsActive = true, IsHome = true },
        new Course { Title = "Django Kursu", Image = "3.jpg", IsActive = true, IsHome = false },
        new Course { Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = true },
        new Course { Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = false },
        new Course { Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = true },
        new Course { Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = false },
    };


    public ActionResult Index()
    {
        
        return View(kurslar); // Views/Course/Index
    }

    public ActionResult List()
    {
        // Course[] kurslar = [kurs1, kurs2];

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
