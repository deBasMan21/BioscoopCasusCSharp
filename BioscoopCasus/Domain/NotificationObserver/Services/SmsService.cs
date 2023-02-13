using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Domain.NotificationObserver.Services
{
    public class SmsService : ISmsService
    {
        public void SendSMS(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
}
