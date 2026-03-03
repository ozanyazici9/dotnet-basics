using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{

    List<Course> kurslar = [
        new Course { Id = 1, Title = "Javascript Kursu", Image = "1.jpg", IsActive = false, IsHome = true },
        new Course { Id = 2, Title = "Python Kursu", Image = "2.jpg", IsActive = true, IsHome = true },
        new Course { Id = 3, Title = "Django Kursu", Image = "3.jpg", IsActive = true, IsHome = false },
        new Course { Id = 4, Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = true },
        new Course { Id = 5, Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = false },
        new Course { Id = 6, Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = true },
        new Course { Id = 7, Title = "Angular Kursu", Image = "4.jpg", IsActive = false, IsHome = false },
    ];


    public ActionResult Index()
    {
        
        return View(kurslar); // Views/Course/Index
    }

    public ActionResult List()
    {
        // Course[] kurslar = [kurs1, kurs2];

        return View(kurslar); // Views/Course/List
    }

    public ActionResult Details(int id) 
    {
        Course? kurs = kurslar.FirstOrDefault(x => x.Id == id);
        return View(kurs); // Views/Course/Details
    }
}
