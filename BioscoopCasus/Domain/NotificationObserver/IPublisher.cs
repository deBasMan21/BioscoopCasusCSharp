using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopCasus.Domain.OrderStateFolder;

namespace BioscoopCasus.Domain.NotificationObserver
{
    public interface IPublisher
    {
        void Publish(OrderState message);
        void RegisterSubscriber(ISubscriber s);
        void UnRegisterSubscriber(ISubscriber s);
    }
}
