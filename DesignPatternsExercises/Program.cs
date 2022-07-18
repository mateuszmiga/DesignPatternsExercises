using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparing to send an eMail...");
            EmailService emailService = new EmailService();
            emailService.SendEmailMessage();

            Console.WriteLine("\nPreparing to send an SMS...");
            SmsService smsService = new SmsService();
            smsService.SendSmsMessage();
            
            Console.WriteLine("\nPreparing to send an eMail by SmsService using SmsServiceAdapter...");
            IEmailService smsServiceAdapter = new SmsServiceAdapter(smsService);
            smsServiceAdapter.SendEmailMessage();

            Console.ReadKey();
        }
    }
}