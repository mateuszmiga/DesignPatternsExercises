using System;

namespace CompositePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var computer = new Product("computer", 2000);
            var tablet = new Product("tablet", 888);
            var cartOne = new CartComposite("cartOne", 0);

            cartOne.Add(computer);
            cartOne.Add(tablet);

            var cartTwo = new CartComposite("cartTwo", 0);
            cartTwo.Add(computer);
            cartTwo.Add(cartOne);

            //CartTwo contains cartOne, so there are 3 pruducts. This structure is similar to three

            Console.WriteLine($"\nTotal value of cartOne composite cart is: {cartOne.CalculateTotal()}");
            Console.WriteLine($"\nTotal value of cartTwo composite cart is: {cartTwo.CalculateTotal()}");

            Console.ReadKey();
        }
    }
}