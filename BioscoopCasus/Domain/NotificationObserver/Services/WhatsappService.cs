using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Domain.NotificationObserver.Services
{
    public class WhatsappService : IWhatsappService
    {
        public void SendWhatsappMessage(string message)
        {
            Console.WriteLine($"Whatsapp: {message}");
        }
    }
}
