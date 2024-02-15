using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mtmLecture.Models;

namespace mtmLecture.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.AllMovies = _context.Movies.Include(c => c.MyActors).ThenInclude(d => d.Actor).ToList();
        return View();
    }
    [HttpPost("add/movie")]
    public IActionResult CreateMovie(Movie newMovie)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newMovie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("Index");
    }
    [HttpGet("Actor")]
    public IActionResult Actor()
    {
        ViewBag.AllActors = _context.Actors.Include(c => c.MyMovies).ThenInclude(d => d.Movie).ToList();
        return View();
    }
    [HttpPost("add/actor")]
    public IActionResult AddActor(Actor newActor)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newActor);
            _context.SaveChanges();
            return RedirectToAction("Actor");
        }
        return View("Actor");
    }
    [HttpGet("Association")]
    public IActionResult Association()
    {
        ViewBag.AllActors = _context.Actors.ToList();
        ViewBag.AllMovies = _context.Movies.ToList();
        return View();
    }
    [HttpPost("association/add")]
    public IActionResult AddAssociation(Cast newAssociation)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newAssociation);
            _context.SaveChanges();
            return RedirectToAction("Association");
        }
        return View("Association");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
