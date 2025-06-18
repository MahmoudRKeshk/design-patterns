using Interview.Creational.FactoryMethod.Interfaces;
using Interview.Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.FactoryMethod.Factories
{
    public class WhatsAppNotifiacationFactory  : NotificationFactory
    {
        private INotification _notification;
        public override INotification CreateNotification()
        {
            this._notification = new WhatsAppNotification();
            return this._notification;
        }
    }
}
