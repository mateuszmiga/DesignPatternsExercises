using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create EmailNotifier Instance:
            INotifier notifier = new EmailNotifier();

            //Wrap "notifier" with Photo
            NotifierDecorator decoratedNotifierWithPhoto = new PhotoNotification(notifier);

            //Wrap "decoratedNotifierWithPhoto" with Urgent message
            NotifierDecorator decoratedNotifierWithPhotoAndUrgentMessage = new UrgentNotification(decoratedNotifierWithPhoto);

            decoratedNotifierWithPhotoAndUrgentMessage.Send("Your workplace is on fire!");
            Console.ReadKey();
        }
    }
}