using System;
using BioscoopCasus.Domain.NotificationObserver.Services;
using BioscoopCasus.Domain.OrderStateFolder;

namespace BioscoopCasus.Domain.NotificationObserver
{
	public class SmsSubscriber : ISubscriber
	{

		private ISmsService SmsService;

		public SmsSubscriber()
		{
			SmsService = new SmsService();	
		}

		public void Update(OrderState message)
		{
			SmsService.SendSMS(message.ToString());
		}
	}
}
