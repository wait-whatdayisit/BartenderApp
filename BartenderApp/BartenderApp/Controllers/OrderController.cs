using BartenderApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers;

public class OrderController : Controller
{
    
    private readonly AppDbContext _context;

    public OrderController(AppDbContext context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var drinks = _context.Drinks.ToList();
        return View(drinks);

    }
}