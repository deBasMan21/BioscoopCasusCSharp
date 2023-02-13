using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public class FinishedState: OrderState
	{
        private readonly OrderStateHolder _orderStateHolder;

		public FinishedState(OrderStateHolder orderStateHolder)
		{
            _orderStateHolder = orderStateHolder;
		}

        public void AddSeat()
        {
            Console.WriteLine("Order is finished");
        }

        public void Cancel()
        {
            Console.WriteLine("Order is finished");
        }

        public void HoursUntilMovieChanged(int hours)
        {
            Console.WriteLine("Order is finished");
        }

        public void Pay()
        {
            Console.WriteLine("Order is finished");
        }

        public void RemoveSeat()
        {
            Console.WriteLine("Order is finished");
        }

        public void Submit()
        {
            Console.WriteLine("Order is finished");
        }
    }
}

