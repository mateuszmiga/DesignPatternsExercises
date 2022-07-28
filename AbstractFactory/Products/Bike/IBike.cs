using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Bike
{
    public interface IBike
    {
        void ChangeGearing();
        void Turn();
    }
}
