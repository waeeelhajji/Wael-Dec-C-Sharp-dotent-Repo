using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using databaseLecture.Models;

namespace databaseLecture.Controllers;

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
        return View();
    }
    [HttpPost("item/create")]
    public IActionResult CreateSong(Item newItem)
    {
        if (ModelState.IsValid)
        {
            // Add the item to our database
            _context.Add(newItem);
            // Save the changes
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("Index");
        }
    }
    [HttpGet("AllItems")]
    public IActionResult AllItems()
    {
        List<Item> AllItems = _context.Items.ToList();
        return View("AllItems", AllItems);
    }



    [HttpPost("items/{itemId}/destroy")]
    public IActionResult DeleteSong(int itemId)
    {
        Item? ItemToDestroy = _context.Items.SingleOrDefault(a => a.ItemId == itemId);
        _context.Items.Remove(ItemToDestroy);
        _context.SaveChanges();
        return RedirectToAction("AllItems");

    }
    [HttpGet("item/edit/{itemId}")]
    public IActionResult EditItems(int itemId)
    {
        // WE need to find the item
        Item? ItemToUpdate = _context.Items.FirstOrDefault(a => a.ItemId == itemId);
        return View(ItemToUpdate);
    }
    [HttpPost("item/update/{itemId}")]
    public IActionResult UpdateItem(int itemId, Item newVersionOfTheItem)
    {
        Item? oldItem = _context.Items.FirstOrDefault(b => b.ItemId == itemId);
        oldItem.Name = newVersionOfTheItem.Name;
        oldItem.Description = newVersionOfTheItem.Description;
        oldItem.UpdatedAt = newVersionOfTheItem.UpdatedAt;
        _context.SaveChanges();
        return RedirectToAction("AllItems");
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
