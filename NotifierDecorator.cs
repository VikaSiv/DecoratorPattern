using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _wrappedNotifier;

        public NotifierDecorator(INotifier notifier)
        {
            _wrappedNotifier = notifier;
        }

        public virtual void Send(string message)
        {
            _wrappedNotifier.Send(message);
        }
    }
}
