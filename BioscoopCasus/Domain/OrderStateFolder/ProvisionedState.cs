using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public class ProvisionedState: OrderState
	{
		private readonly OrderStateHolder _orderStateHolder;

		public ProvisionedState(OrderStateHolder orderStateHolder)
		{
			_orderStateHolder = orderStateHolder;
		}

        public void AddSeat()
        {
            Console.WriteLine("order is solid now");
        }

        public void Cancel()
        {
            _orderStateHolder.UpdateState(new CancelledState(_orderStateHolder));
        }

        public void HoursUntilMovieChanged(int hours)
        {
            if (hours < 12) {
                _orderStateHolder.UpdateState(new CancelledState(_orderStateHolder));
            }
        }

        public void Pay()
        {
            _orderStateHolder.UpdateState(new FinishedState(_orderStateHolder));
        }

        public void RemoveSeat()
        {
            Console.WriteLine("order is solid now");
        }

        public void Submit()
        {
            Console.WriteLine("order is solid now");
        }
    }
}

