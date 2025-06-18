using Interview.Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.FactoryMethod.Factories
{
    public class EmailNotifiactionFactory : NotificationFactory
    {
        private INotification _notification;
        public override INotification CreateNotification()
        {
            this._notification = new Products.EmailNotification();
            return this._notification;
        }
    }
}
