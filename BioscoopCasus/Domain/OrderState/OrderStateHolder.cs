using System;
namespace BioscoopCasus.Domain.OrderState
{
	public interface OrderStateHolder
	{
		void UpdateState(OrderState newState);
	}
}

