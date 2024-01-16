using Microsoft.AspNetCore.Mvc;
namespace FormInTheWeb.Controllers;


public class HelloController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpPost("process")]
    public IActionResult Process(string FavoriteAnimal)
    {
        if (FavoriteAnimal.ToLower() == "dog")
        {

            ViewBag.Error = "Dogs are great but pick something else";
            return View("Index");


        }
        Console.WriteLine(FavoriteAnimal);

        return RedirectToAction("Index");
    }



}