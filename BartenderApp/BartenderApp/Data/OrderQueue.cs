using BartenderApp.Models;

namespace BartenderApp.Data
{
    public class OrderQueue
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1;

        public IReadOnlyList<Order> Orders => _orders.AsReadOnly();

        public void AddOrder(Order order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
        }

        public void MarkComplete(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
                order.IsComplete = true;
        }

        public void RemoveOrder(int id)
        {
            _orders.RemoveAll(o => o.Id == id);
        }
    }
}