using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LOLEMCosmetics.Models
{
    public class MyCart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(LOLEM LOLEM, int quantity)
        {
            CartLine line = Lines
            .Where(b => b.LOLEM.LOLEMID == LOLEM.LOLEMID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    LOLEM = LOLEM,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(LOLEM LOLEM) =>
        Lines.RemoveAll(l => l.LOLEM.LOLEMID == LOLEM.LOLEMID);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.LOLEM.Price * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public LOLEM LOLEM { get; set; }
        public int Quantity { get; set; }
    }
}
