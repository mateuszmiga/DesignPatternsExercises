using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending via Email: {message}");
        }
    }
}
