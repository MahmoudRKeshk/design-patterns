using Interview.Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.FactoryMethod.Services
{
    public class NotificationService
    {
        private readonly NotificationFactory _notificationFactory;
        public NotificationService(NotificationFactory notificationFactory)
        {
            _notificationFactory = notificationFactory;
        }
        public void Notify(string message)
        {
            var notification = _notificationFactory.CreateNotification();
            notification.Send(message);
        }
    }
}
