using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace LOLEMCosmetics.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private LOLEMCosmeticsDbContext context;
        public EFOrderRepository(LOLEMCosmeticsDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.LOLEM);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.LOLEM));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
