using System;
using BioscoopCasus.Utils;

namespace BioscoopCasus.Domain
{
	public class Order
	{
        public int OrderNr { get; private set; }
		public List<MovieTicket> Tickets { get; private set; }

		public Order(int orderNr)
		{
			OrderNr = orderNr;
			Tickets = new List<MovieTicket>();
		}

		public void AddSeatReservation(MovieTicket ticket) {
			Tickets.Add(ticket);
		}

		public void CalculatePrice() {

		}

		public void Export(TicketExportFormat exportFormat) {
			switch (exportFormat) {
				case TicketExportFormat.JSON:
					FileUtils.ExportJSON<Order>(this);
					break;

				case TicketExportFormat.PLAINTEXT:
					FileUtils.ExportPlainText<Order>(this);
					break;
			}
		}

        public override string ToString()
        {
            return $"Order number: {OrderNr}\nTickets: {Tickets.Count}";
        }
    }
}

