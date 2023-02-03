using System;
namespace BioscoopCasus.Domain
{
	public class Order
	{
        private readonly int _orderNr;
		private readonly List<MovieTicket> _tickets;

		public Order(int orderNr)
		{
			this._orderNr = orderNr;
			this._tickets = new List<MovieTicket>();
		}

		public int GetOrderNr() => _orderNr;

		public void AddSeatReservation(MovieTicket ticket) {
			this._tickets.Add(ticket);
		}

		public void CalculatePrice() {

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

