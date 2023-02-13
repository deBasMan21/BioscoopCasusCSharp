using BioscoopCasus.Domain.OrderStateFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Domain.NotificationObserver.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
