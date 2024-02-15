using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LinQDemo.Models;

namespace LinQDemo.Controllers;

public class HomeController : Controller
{
    public static Game[] AllGames = new Game[] {
        new Game {Title="Elden Ring", Price=59.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="League of Legends", Price=0.00, Genre="MOBA", Rating="T", Platform="PC"},
        new Game {Title="World of Warcraft", Price=39.99, Genre="MMORPG", Rating="T", Platform="PC"},
        new Game {Title="Elder Scrolls Online", Price=14.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="Smite", Price=0.00, Genre="MOBA", Rating="T", Platform="All"},
        new Game {Title="Overwatch", Price=39.00, Genre="First-person Shooter", Rating="T", Platform="PC"},
        new Game {Title="Scarlet Nexus", Price=59.99, Genre="Action JRPG", Rating="T", Platform="All"},
        new Game {Title="Wonderlands", Price=59.99, Genre="RPG FPS", Rating="M", Platform="All"},
        new Game {Title="Rocket League", Price=0.00, Genre="Sports", Rating="E", Platform="All"},
        new Game {Title="StarCraft", Price=0.00, Genre="RTS", Rating="T", Platform="PC"},
        new Game {Title="God of War", Price=29.99, Genre="Action-adventure ", Rating="M", Platform="PC"},
        new Game{Title="Doki Doki Literature Club Plus!", Price=10.00, Genre="Casual", Rating="E", Platform="PC"},
        new Game {Title="Red Dead Redemption", Price=40.00, Genre="Action adventure", Rating="M", Platform="All"},
        new Game {Title="My Little Pony A Maretime Bay Adventure", Price=39.99, Genre="Adventure", Rating="E",Platform="All"},
        new Game {Title="Fallout New Vegas", Price=10.00, Genre="Open World RPG", Rating="M", Platform="PC"}
    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // All Games that Works Only in PCs
        List<Game> AllPCGames = AllGames.Where(pc => pc.Platform == "PC").ToList();
        ViewBag.AllPCGames = AllPCGames;
        // ----------------------------------
        // Get One Game
        Game? Overwatch = AllGames.FirstOrDefault(o => o.Title == "Overwatch");
        ViewBag.Overwatch = Overwatch;
        // ----------------------------------
        // Get the first 3 free games
        List<Game> Top3Free = AllGames.Where(f => f.Price == 0.00).OrderBy(t => t.Title).Take(3).ToList();
        ViewBag.Top3Free = Top3Free;

        // Get the price of the most expensive game
        double MostExpensive = AllGames.Max(s => s.Price);
        ViewBag.MostExpensive = MostExpensive;

        // The Price of all the games together
        double Total = AllGames.Sum(a => a.Price);
        ViewBag.Total = Total;
        // Grab All the Titles ... just the titles , not the hole Game
        List<string> AllTitles = AllGames.Select(s => s.Title).ToList();
        ViewBag.AllTitles = AllTitles;
        // Bonus Query
        // We can get back a boolean whether a condition was met
        bool MatchTitle = AllGames.Any(s => s.Title == "Rocket League");
        ViewBag.MatchTitle = MatchTitle;



        return View();
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
