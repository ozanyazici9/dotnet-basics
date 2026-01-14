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
        return View(); // Views/Products/Details
    }

}
    
    
    
