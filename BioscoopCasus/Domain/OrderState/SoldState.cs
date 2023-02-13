using System;
namespace BioscoopCasus.Domain.OrderState
{
	public class SoldState: OrderState
	{
        private readonly OrderStateHolder _orderStateHolder;

		public SoldState(OrderStateHolder orderStateHolder)
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
            throw new NotImplementedException();
        }
    }
}

