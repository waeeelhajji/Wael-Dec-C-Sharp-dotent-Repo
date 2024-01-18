using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<Pet> Pets = new List<Pet>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }






    [HttpPost("add/pet")]
    public IActionResult Create(Pet newPet)
    {
        if (ModelState.IsValid)
        {
            Pets.Add(newPet);
            // Console.WriteLine(newPet.Name);
            return RedirectToAction("AllPets");

        }
        else
        {
            // render validation in the View
            return View("Index");
        }
    }

    [HttpGet("AllPets")]
    public IActionResult AllPets()
    {
        return View("AllPets", Pets);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
