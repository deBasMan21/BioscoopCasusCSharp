using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopCasus.Domain.OrderStateFolder;

namespace BioscoopCasus.Domain.NotificationObserver.Services
{
    public interface IEmailService
    {
        public void SendEmail(string message);
    }
}
