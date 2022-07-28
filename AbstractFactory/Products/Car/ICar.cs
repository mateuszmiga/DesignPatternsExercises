using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Car
{
    public interface ICar
    {
        public int NumberOfDoors { get; set; }
        void Drive();
        void Brake();
    }
}
