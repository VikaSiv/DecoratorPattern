using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class EmailNotifier : INotifier
    {
        private string _email;

        public EmailNotifier(string email)
        {
            _email = email;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Sending email to {_email}: {message}");
        }
    }
}
