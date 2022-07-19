using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class EmailService : IEmailService
    {
        public void SendEmailMessage()
        {
            Console.WriteLine("Sending eMail message...");
        }
    }
}
