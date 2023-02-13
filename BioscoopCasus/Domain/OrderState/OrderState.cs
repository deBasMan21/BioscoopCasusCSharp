using System;
namespace BioscoopCasus.Domain.OrderState
{
	public interface OrderState
	{
		void AddSeat();
		void RemoveSeat();
		void Submit();
		void Purchase();
	}
}

