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
    public interface IAbstractVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
        ITruck CreateTruck();
    }
}
