using System;

namespace BioscoopCasus.Domain
{
	public class Customer
	{
		private string name;
		private NotificationType notificationType;
		private List<Order> orders;

		public Customer(string name, NotificationType notificationType)
		{
			this.name = name;
			this.notificationType = notificationType;
			this.orders = new List<Order>();
		}

		public void AddOrder(Order order)
        {
			orders.Add(order);
			order.RegisterSubscriber(notificationType.GetSubscriber());
        }
	}
}