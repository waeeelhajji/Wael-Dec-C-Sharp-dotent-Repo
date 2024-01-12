using Microsoft.AspNetCore.Mvc; // this is a service that brings in our MVC functionality 

namespace FirstWeb.Controllers; // use your own project's namespace!


public class HelloController : Controller // remember the inheritance
{
    // for each route this controller is to handle:
    [HttpGet] //? type of your request --- app.get
    // http://localhost:5XXX/
    [Route("")] //? associated route string (exclude the landing /) -- app.get("/")
    public ViewResult Index()
    {
        // ViewBag allows us to pass data from our controller to our view
        // think of view bag as dictionary it has keys and value
        ViewBag.Number = 8;
        ViewBag.Name = "Ghassen";
        return View();
    }

    [HttpGet("seconde/{id}")]
    public ViewResult Second(int id)
    {
        ViewBag.Routing = id;
        ViewBag.MyArray = new int[5] { 1, 2, 3, 4, 5 };
        return View();
    }



}