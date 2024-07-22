using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Design_Patterns.Models;
using Tools;

namespace Design_Patterns.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Log.GetInstance("log.txt").Save("Index page visited");
        return View();
    }

    public IActionResult Privacy()
    {
        Log.GetInstance("log.txt").Save("Privacy page visited");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}