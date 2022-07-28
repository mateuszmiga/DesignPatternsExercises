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
    public class BigVehicleFactory : IAbstractVehicleFactory
    {
        public IBike CreateBike()
        {
            return new BigBike();
        }

        public ICar CreateCar()
        {
            return new BigCar();
        }

        public ITruck CreateTruck()
        {
            return new BigTruck();
        }
    }
}
