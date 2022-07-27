using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISender emailSender = new EmailSender();
            ISender smsSender = new SmsSender();

            MessageSender messageSender = new MessageSender(emailSender);

            messageSender.Send("message");

            messageSender.SetStrategy(smsSender);

            messageSender.Send("message");

            Console.ReadKey();
        }
    }
}
