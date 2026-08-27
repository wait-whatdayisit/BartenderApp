using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers;

public class QueueController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}