using Microsoft.AspNetCore.Mvc;
using Tools.Factory;

namespace Design_Patterns.Controllers;

public class SaleDetailController : Controller
{
    private readonly SaleFactory _factory;
    
    public SaleDetailController(InternetSaleFactory factory)
    {
        _factory = factory;
    }
    // GET
    public IActionResult Index(decimal total)
    {
        var mobileSale = _factory.CreateSale();
        ViewBag.totalMobile = total + mobileSale.Earn(total);
        return View();
    }
    
    public IActionResult InternetSale(decimal total)
    {
        var internetSale = _factory.CreateSale();
        ViewBag.totalInternet = total - internetSale.Earn(total);
        return View();
    }
}