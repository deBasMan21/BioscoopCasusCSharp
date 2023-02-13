using System;
using BioscoopCasus.Domain.NotificationObserver.Services;
using BioscoopCasus.Domain.OrderStateFolder;


namespace BioscoopCasus.Domain.NotificationObserver
{
	public class WhatsappSubscriber : ISubscriber
	{
		private IWhatsappService WhatsAppService;

		public WhatsappSubscriber()
		{
			WhatsAppService = new WhatsappService();
		}

		public void Update(OrderState message)
		{
			WhatsAppService.SendWhatsappMessage(message.ToString());
		}
	}
}
