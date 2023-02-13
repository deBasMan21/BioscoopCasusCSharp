using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public interface OrderStateHolder
	{
		void UpdateState(OrderState newState);
	}
}

