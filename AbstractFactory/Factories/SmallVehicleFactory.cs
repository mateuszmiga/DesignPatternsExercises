using AbstractFactory.Products.Bike;
using AbstractFactory.Products.Car;
using AbstractFactory.Products.Truck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class SmallVehicleFactory : IAbstractVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SmallBike();
        }

        public ICar CreateCar()
        {
            return new SmallCar();
        }

        public ITruck CreateTruck()
        {
            return new SmallTruck();
        }
    }
}
