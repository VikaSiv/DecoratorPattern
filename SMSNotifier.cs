using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SMSNotifier : NotifierDecorator
    {
        private string _phoneNumber;

        public SMSNotifier(INotifier notifier, string phoneNumber) : base(notifier)
        {
            _phoneNumber = phoneNumber;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending SMS to {_phoneNumber}: {message}");
        }
    }
}
