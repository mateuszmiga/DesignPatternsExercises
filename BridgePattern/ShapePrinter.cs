using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class ShapePrinter
    {
        private protected IGeoCalculator _geoCalculator;

        public ShapePrinter(IGeoCalculator geoCalculator)
        {
            _geoCalculator = geoCalculator;
        }

        public virtual void PrintAllParameters()
        {
            Console.WriteLine($"\n basic print: {_geoCalculator.CalculatePerimeter()} , {_geoCalculator.CalculateArea()}");
        }
    }
}
