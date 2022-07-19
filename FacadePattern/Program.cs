using System;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string productId = "1234";
            IShopFacade shopFacade = new ShopFacade();

            shopFacade.Buy(productId);
            Console.ReadKey();
        }
    }
}
