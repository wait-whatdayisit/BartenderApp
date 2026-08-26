using BartenderApp.Data;
using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Text.Json;

namespace BartenderApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly OrderQueue _queue;

        public OrderController(AppDbContext context, OrderQueue queue)
        {
            _context = context;
            _queue = queue;
        }

        // Menu page
        public IActionResult Index()
        {
            var drinks = _context.Drinks.ToList();
            return View(drinks);
        }

        // Receives the cart and adds it to the queue
        [HttpPost]
        public IActionResult Checkout([FromBody] List<OrderItem> items)
        {
            if (items == null || !items.Any())
                return BadRequest("No items in cart.");

            var order = new Order { Items = items };
            _queue.AddOrder(order);

            return Ok();
        }

        // Bartender queue view
        public IActionResult Queue()
        {
            return View(_queue.Orders);
        }

        // Mark an order as complete
        [HttpPost]
        public IActionResult Complete(int id)
        {
            _queue.MarkComplete(id);
            return RedirectToAction("Queue");
        }

        // Remove an order from the queue
        [HttpPost]
        public IActionResult Remove(int id)
        {
            _queue.RemoveOrder(id);
            return RedirectToAction("Queue");
        }
    }
}