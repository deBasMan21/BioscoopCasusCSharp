using System;
namespace BioscoopCasus.Domain.OrderState
{
	public class SubmitOrderState: OrderState
	{
		private readonly OrderStateHolder _orderStateHolder;

		public SubmitOrderState(OrderStateHolder orderStateHolder)
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
            _orderStateHolder.UpdateState(new SoldState(_orderStateHolder));
        }
    }
}

