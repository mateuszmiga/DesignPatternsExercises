using System;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeoClient geoClient = new GeoClient();
            ShapePrinter shapePrinter;

            shapePrinter = new ShapePrinter(new Square());
            geoClient.ShowGeoResults(shapePrinter); //base operation, object A

            shapePrinter = new ExtendedShapePrinter(new Circle());
            geoClient.ShowGeoResults(shapePrinter); //extended operation, object B
        }
    }
}