using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public class SubmittedState: OrderState
	{
		private readonly OrderStateHolder _orderStateHolder;

		public SubmittedState(OrderStateHolder orderStateHolder)
		{
			_orderStateHolder = orderStateHolder;
		}

        public void AddSeat()
        {
            Console.WriteLine("added seat");
        }

        public void Cancel()
        {
            _orderStateHolder.UpdateState(new CancelledState(_orderStateHolder));
        }

        public void HoursUntilMovieChanged(int hours)
        {
            if (hours < 24)
            {
                _orderStateHolder.UpdateState(new CancelledState(_orderStateHolder));
            }
        }

        public void Pay()
        {
            _orderStateHolder.UpdateState(new FinishedState(_orderStateHolder));
        }

        public void RemoveSeat()
        {
            Console.WriteLine("removed seat");
        }

        public void Submit()
        {
            Console.WriteLine("Already submitted");
        }
    }
}

