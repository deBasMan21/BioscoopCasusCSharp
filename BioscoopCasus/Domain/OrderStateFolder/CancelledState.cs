using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public class CancelledState: OrderState
	{
        private readonly OrderStateHolder _orderStateHolder;

		public CancelledState(OrderStateHolder orderStateHolder)
		{
            _orderStateHolder = orderStateHolder;
		}

        public void AddSeat()
        {
            Console.WriteLine("Order is cancelled");
        }

        public void Cancel()
        {
            Console.WriteLine("Order is cancelled");
        }

        public void HoursUntilMovieChanged(int hours)
        {
            Console.WriteLine("Order is cancelled");
        }

        public void Pay()
        {
            Console.WriteLine("Order is cancelled");
        }

        public void RemoveSeat()
        {
            Console.WriteLine("Order is cancelled");
        }

        public void Submit()
        {
            Console.WriteLine("Order is cancelled");
        }
    }
}

