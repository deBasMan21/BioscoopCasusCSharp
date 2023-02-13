using System;
using BioscoopCasus.Domain.ExportStrategy;
using BioscoopCasus.Extensions;
using BioscoopCasus.Utils;
using BioscoopCasus.Domain.OrderStateFolder;

namespace BioscoopCasus.Domain
{
	public class Order: OrderStateHolder
	{
        public int OrderNr { get; private set; }
		public List<MovieTicket> Tickets { get; private set; }
		public IExportBehaviour? ExportBehaviour { get; set; }
		public OrderState OrderState { get; set; }

		public Order(int orderNr)
		{
			OrderNr = orderNr;
			Tickets = new List<MovieTicket>();
			OrderState = new TemplateState(this);
		}

		public void AddSeatReservation(MovieTicket ticket) {
			Tickets.Add(ticket);
		}

		public double CalculatePrice() {
			List<MovieTicket> studentTickets = Tickets
				.FindAll(ticket => ticket.CustomerType.IsStudent())
				.OrderByDescending(ticket => ticket.IsPremium)
				.ToList();

			double studentPrice = studentTickets
				.Select((ticket, i) => (i + 1) % 2 == 1 ? ticket.GetPrice() : 0)
				.Sum();

			List<MovieTicket> regularTickets = Tickets
				.FindAll(ticket => !ticket.CustomerType.IsStudent())
				.OrderByDescending(ticket => ticket.IsPremium)
				.ToList();

			double regularPrice = regularTickets
				.Select((ticket, i) => {
					if (ticket.GetDateAndTime().IsWeekend())
					{
						return ticket.GetPrice();
					}
					return (i + 1) % 2 == 1 ? ticket.GetPrice() : 0;

				})
				.Sum();

			if (regularTickets.Count >= 6 && regularTickets[0].GetDateAndTime().IsWeekend())
			{
				regularPrice *= 0.9;
			}

			return studentPrice + regularPrice;
		}

		public void Submit()
        {
			OrderState.Submit();
        }

		public void Pay()
        {
			OrderState.Pay();
        }

		public void Cancel()
        {
			OrderState.Cancel();
        }

		public void Export() {
			ExportBehaviour?.Export(this);
		}

        public override string ToString()
        {
            return $"Order number: {OrderNr}\nTickets: {Tickets.Count}";
        }

        public void UpdateState(OrderState newState)
        {
			OrderState = newState;
        }
    }
}

