using System;
using BioscoopCasus.Extensions;
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

		public double CalculatePrice() {
			double studentPrice = Tickets
				.FindAll(ticket => ticket.IsStudentOrder)
				.OrderByDescending(ticket => ticket.IsPremium)
				.Select((ticket, i) => (i + 1) % 2 == 1 ? ticket.GetPrice(): 0)
				.Sum();

			double regularPrice = Tickets
				.FindAll(ticket => !ticket.IsStudentOrder)
				.OrderByDescending(ticket => ticket.IsPremium)
				.Select((ticket, i) => {
					if (ticket.GetDateAndTime().IsWeekend())
					{
						return ticket.GetPrice();
					}
					return (i + 1) % 2 == 1 ? ticket.GetPrice() : 0;

				})
				.Sum();

			if (Tickets.Count(t => !t.IsStudentOrder) >= 6)
			{
				regularPrice *= 0.9;
			}

			return studentPrice + regularPrice;
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

