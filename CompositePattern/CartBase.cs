using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class CartBase // this is Component
    {
        protected string id;
        protected int price;

        public CartBase(string id, int price)
        {
            this.id = id;
            this.price = price;
        }

        public abstract int CalculateTotal();
    }
}
