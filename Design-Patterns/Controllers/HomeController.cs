using System.Diagnostics;
using Design_Patterns.Configuration;
using Microsoft.AspNetCore.Mvc;
using Design_Patterns.Models;
using Microsoft.Extensions.Options;
using Tools;
using Tools.Singleton;

namespace Design_Patterns.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IOptions<PathConfig> _pathConfig;

    public HomeController(ILogger<HomeController> logger, IOptions<PathConfig> pathConfig)
    {
        _logger = logger;
        _pathConfig = pathConfig;
    }

    public IActionResult Index()
    {
        Log.GetInstance(_pathConfig.Value.Path).Save("Index page visited");
        return View();
    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_pathConfig.Value.Path).Save("Privacy page visited");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}