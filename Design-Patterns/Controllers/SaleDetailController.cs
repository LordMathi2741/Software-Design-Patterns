using Microsoft.AspNetCore.Mvc;
using Tools.Factory;

namespace Design_Patterns.Controllers;

public class SaleDetailController : Controller
{
    // GET
    public IActionResult Index(decimal total)
    {
        MobileSaleFactory mobileSaleFactory = new MobileSaleFactory(0.20m);    
        var mobileSale = mobileSaleFactory.CreateSale();
        ViewBag.totalMobile = total + mobileSale.Earn(total);
        return View();
    }
    
    public IActionResult InternetSale(decimal total)
    {
        InternetSaleFactory internetSaleFactory = new InternetSaleFactory(0.10m);
        var internetSale = internetSaleFactory.CreateSale();
        ViewBag.totalInternet = total - internetSale.Earn(total);
        return View();
    }
}