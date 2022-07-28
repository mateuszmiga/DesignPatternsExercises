using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAbstractVehicleFactory bigFactory = new BigVehicleFactory();
            IAbstractVehicleFactory smallFactory = new SmallVehicleFactory();
            
            var smallBike = smallFactory.CreateBike();
            var bigTruck = bigFactory.CreateTruck();

            Console.WriteLine(smallBike.GetType().Name);
            Console.WriteLine(bigTruck.GetType().Name);
            
            smallBike.Turn();
            smallBike.ChangeGearing();

            bigTruck.DeliverLoad();

            Console.ReadKey();
        }
    }
}
