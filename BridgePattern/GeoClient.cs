using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class GeoClient
    {
        public void ShowGeoResults(ShapePrinter shapePrinter)
        {
            shapePrinter.PrintAllParameters();
        }
    }
}
