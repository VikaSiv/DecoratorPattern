using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FacebookNotifier : NotifierDecorator
    {
        private string _facebookAccount;

        public FacebookNotifier(INotifier notifier, string facebookAccount) : base(notifier)
        {
            _facebookAccount = facebookAccount;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Facebook message to {_facebookAccount}: {message}");
        }
    }
}
