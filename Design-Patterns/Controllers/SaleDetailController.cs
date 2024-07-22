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
}