using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Car
{
    public class BigCar : ICar
    {
        public int NumberOfDoors { get ; set ; }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
