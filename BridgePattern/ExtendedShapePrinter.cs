using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class ExtendedShapePrinter : ShapePrinter
    {
        public ExtendedShapePrinter(IGeoCalculator geoCalculator) : base(geoCalculator)
        {
        }

        public override void PrintAllParameters()
        {
            Console.WriteLine($"\nextended print: \n{_geoCalculator.CalculatePerimeter()}\n{_geoCalculator.CalculateArea()}");
        }
    }
}
