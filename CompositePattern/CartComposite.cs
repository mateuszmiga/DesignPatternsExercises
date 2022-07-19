using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CartComposite : CartBase, ICartOperations
    {
        private List<CartBase> _carts;
        public CartComposite(string id, int price) : base(id, price)
        {
            _carts = new List<CartBase>();
        }

        public void Add(CartBase cart)
        {
            _carts.Add(cart);
        }

        public void Remove(CartBase cart)
        {
            _carts.Remove(cart);
        }

        public override int CalculateTotal()
        {
            int totalIncome = 0;

            Console.WriteLine($"{id} contains products with prices:");

            foreach (var cart in _carts)
            {
                totalIncome += cart.CalculateTotal();
            }

            return totalIncome;
        }
    }
}
