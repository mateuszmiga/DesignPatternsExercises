using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Bike
{
    public class SmallBike : IBike
    {
        public void ChangeGearing()
        {
            Console.WriteLine("changing gearing...");
        }

        public void Turn()
        {
            Console.WriteLine("turning left...");
        }
    }
}
