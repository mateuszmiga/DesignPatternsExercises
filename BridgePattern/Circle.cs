using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Circle : IGeoCalculator
    {
        public string CalculateArea()
        {
            return "Area of circle: 12";
        }

        public string CalculatePerimeter()
        {
            return "Perimeter of circle 25";
        }
    }
}
