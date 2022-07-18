using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class SmsService : ISmsService
    {
        public void SendSmsMessage()
        {
            Console.WriteLine("Sending SMS Message");
        }
    }
}
