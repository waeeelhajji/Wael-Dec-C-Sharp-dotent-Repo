using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sessionLecture.Models;
// using Microsoft.AspNetCore.Http;


namespace sessionLecture.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Making Session
        // HttpContext.Session.SetString("UserName", "Wael");
        string name = "Wael";
        // string? UserNAme = HttpContext.Session.GetString("UserName");

        // Console.WriteLine(UserNAme);

        return View();
    }
    [HttpPost("Login")]
    public IActionResult Login(string UserName)

    {
        HttpContext.Session.SetString("UserName", UserName);
        HttpContext.Session.SetString("IsAdmin", "true");
        return RedirectToAction("Privacy");
    }
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
    public IActionResult Privacy()
    {
        if (HttpContext.Session.GetString("IsAdmin") == null)
        {

            return RedirectToAction("Index");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
