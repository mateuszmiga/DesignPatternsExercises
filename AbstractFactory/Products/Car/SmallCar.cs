using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Car
{
    public class SmallCar : ICar
    {
        public int NumberOfDoors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
