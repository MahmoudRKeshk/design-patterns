using Interview.Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.FactoryMethod.Products
{
    internal class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Notification sent with message: {message}");
        }
    }
}
