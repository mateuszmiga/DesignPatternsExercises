using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Shop
    {
        public void CheckProductInWarehouse(string productId)
        {
            Console.WriteLine("Checking product quantity...");
        }
        
        public void GetProductFromWarehouse(string productId)
        {
            Console.WriteLine("Product send to DeliveryService. Correcting inventory quantity...");
        }
    }
}
