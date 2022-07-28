using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Truck
{
    public class SmallTruck : ITruck
    {
        public int MaxLoad { get; set; }

        public void DeliverLoad()
        {
            throw new NotImplementedException();
        }
    }
}
