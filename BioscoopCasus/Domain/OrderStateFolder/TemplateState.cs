using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public class TemplateState: OrderState
	{
        private readonly OrderStateHolder _orderStateHolder;

		public TemplateState(OrderStateHolder orderStateHolder)
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
            Console.WriteLine("Nothing happens");
        }

        public void Pay()
        {
            Console.WriteLine("Cannot pay here");
        }

        public void RemoveSeat()
        {
            Console.WriteLine("removed seat");
        }

        public void Submit()
        {
            _orderStateHolder.UpdateState(new SubmittedState(_orderStateHolder));
        }
    }
}

