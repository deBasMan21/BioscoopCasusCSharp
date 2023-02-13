using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopCasus.Domain.NotificationObserver;

namespace BioscoopCasus.Domain
{
    public enum NotificationType
    {
        EMAIL,
        SMS,
        WHATSAPP
    }

    public static class NotificationExtensions
    {
        public static ISubscriber GetSubscriber(this NotificationType type)
        {
            switch(type)
            {
                case NotificationType.EMAIL:
                    return new EmailSubscriber();
                case NotificationType.SMS:
                    return new SmsSubscriber();
                default:
                    return new WhatsappSubscriber();
            }
        }
    }
}
