using System;
using BioscoopCasus.Extensions;

namespace BioscoopCasus.Domain
{
	public class Order
	{
        private readonly int _orderNr;
		private readonly List<MovieTicket> _tickets;

		public Order(int orderNr)
		{
			_orderNr = orderNr;
			_tickets = new List<MovieTicket>();
		}

		public int GetOrderNr() => _orderNr;

		public void AddSeatReservation(MovieTicket ticket) {
			_tickets.Add(ticket);
		}

		public double CalculatePrice() {
			bool isStudentOrder = _tickets.Where(x => x.GetIsStudentOrder()).ToList().Count > 0;

			var prices = _tickets
				.Select(x => x.GetPrice() * (!isStudentOrder && _tickets.Count >= 6 && x.GetDateAndTime().IsWeekend() ? 0.9 : 1));

			if(isStudentOrder || !_tickets[0].GetDateAndTime().IsWeekend())
            {
				prices = prices.SplitList(2).Select(x => x.ToList()[0]);
            }

			return prices.Aggregate((x, y) => x + y);
		}

		public void Export(TicketExportFormat exportFormat) {
			switch (exportFormat) {
				case TicketExportFormat.PLAINTEXT:
					Console.WriteLine("");
					break;

				case TicketExportFormat.JSON:
					Console.WriteLine("");
					break;
			}
		}
	}
}

