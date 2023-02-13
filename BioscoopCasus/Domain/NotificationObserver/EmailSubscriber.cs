using System;
using BioscoopCasus.Domain.NotificationObserver.Services;
using BioscoopCasus.Domain.OrderStateFolder;

namespace BioscoopCasus.Domain.NotificationObserver
{
	public class EmailSubscriber: ISubscriber
	{
		private IEmailService EmailService;

		public EmailSubscriber()
		{
			EmailService = new EmailService();
		}

        public void Update(OrderState message)
        {
			EmailService.SendEmail(message.ToString());
        }
    }
}
