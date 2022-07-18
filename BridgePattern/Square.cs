using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Square : IGeoCalculator
    {
        public string CalculateArea()
        {
            return "Area of square: 10";
        }

        public string CalculatePerimeter()
        {
            return "Perimeter of square: 20";
        }
    }
}
