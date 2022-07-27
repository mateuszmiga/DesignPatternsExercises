using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class EmailSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending via Email");
        }
    }
}
