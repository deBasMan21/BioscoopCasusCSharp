using System;
namespace BioscoopCasus.Domain.OrderState
{
	public class NoSeatsState: OrderState
	{
        private readonly OrderStateHolder _orderStateHolder;

		public NoSeatsState(OrderStateHolder orderStateHolder)
		{
            _orderStateHolder = orderStateHolder;
		}

        public void AddSeat()
        {
            _orderStateHolder.UpdateState(new SelectedSeatsState(_orderStateHolder));
        }

        public void Purchase()
        {
            throw new NotImplementedException();
        }

        public void RemoveSeat()
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}

