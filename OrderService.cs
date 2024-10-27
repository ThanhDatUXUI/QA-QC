using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class OrderService
{
    private readonly ApplicationDbContext _context;

    public OrderService(ApplicationDbContext context)
    {
        _context = context;
    }

    public void CreateOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public List<Order> GetOrders()
    {
        return _context.Orders.ToList();
    }
}
