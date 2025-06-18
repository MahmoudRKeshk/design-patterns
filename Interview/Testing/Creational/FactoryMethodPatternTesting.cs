using Interview.Creational.FactoryMethod.Factories;
using Interview.Creational.FactoryMethod.Products;
using Interview.Creational.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Creational
{
    public static class FactoryMethodPatternTesting
    {
        public static void Run()
        {
            var emailFactory = new EmailNotifiactionFactory();
            var smsFactory = new SMSNotificationFactory();
            var whatsAppFactory = new WhatsAppNotifiacationFactory();

            var emailService = new NotificationService(emailFactory);
            var smsService = new NotificationService(smsFactory);
            var whatsAppService = new NotificationService(whatsAppFactory);
            
            var emailNotification = emailFactory.CreateNotification();
            var smsNotification = smsFactory.CreateNotification();
            var whatsAppNotificationInstance = whatsAppFactory.CreateNotification();
            
            emailService.Notify("Hello!");
            smsService.Notify("Hello!");
            whatsAppService.Notify("Hello!");
        }
    }
}
