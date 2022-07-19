using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Product : CartBase //this is Leaf
    {
        public Product(string id, int price) : base(id, price)
        {
        }

        public override int CalculateTotal()
        {
            Console.WriteLine($"product: {id} ==> price: {price}");
            return price;
        }
    }
}
