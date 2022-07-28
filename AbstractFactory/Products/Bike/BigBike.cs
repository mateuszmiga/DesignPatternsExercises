using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Bike
{
    public class BigBike : IBike
    {
        public void ChangeGearing()
        {
            throw new NotImplementedException();
        }

        public void Turn()
        {
            throw new NotImplementedException();
        }
    }
}
