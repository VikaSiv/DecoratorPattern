using DecoratorPattern;
using System;
class Program
{
    static void Main(string[] args)
    {
      
        INotifier notifier = new EmailNotifier("admin@example.com");

        notifier = new SMSNotifier(notifier, "+1234567890");

        notifier = new FacebookNotifier(notifier, "admin_facebook_account");

        notifier.Send("System alert: Check server status!");
    }
}
