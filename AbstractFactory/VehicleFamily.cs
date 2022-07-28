using AbstractFactory.Factories;
using AbstractFactory.Products.Bike;
using AbstractFactory.Products.Car;
using AbstractFactory.Products.Truck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VehicleFamily
    {
        private IBike _Bike;
        private ITruck _Truck;
        private ICar _Car;

        public VehicleFamily(IAbstractVehicleFactory concreteVehicleFactory)
        {
            _Bike = concreteVehicleFactory.CreateBike();
            _Car = concreteVehicleFactory.CreateCar();
            _Truck = concreteVehicleFactory.CreateTruck();
        }

        public void GetFamilyMembersType()
        {
            Console.WriteLine($"{_Bike.GetType().Name}");
            Console.WriteLine($"{_Truck.GetType().Name}");
            Console.WriteLine($"{_Car.GetType().Name}");
        }

    }
}
