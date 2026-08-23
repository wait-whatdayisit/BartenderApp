using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers;

public class OrderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}