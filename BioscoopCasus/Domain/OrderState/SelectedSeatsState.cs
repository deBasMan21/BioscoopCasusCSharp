using System;
namespace BioscoopCasus.Domain.OrderState
{
	public class SelectedSeatsState: OrderState
	{
		private readonly OrderStateHolder _orderStateHolder;

		public SelectedSeatsState(OrderStateHolder orderStateHolder)
		{
			_orderStateHolder = orderStateHolder;
		}

        public void AddSeat()
        {
            throw new NotImplementedException();
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
            _orderStateHolder.UpdateState(new SubmitOrderState(_orderStateHolder))
        }
    }
}

