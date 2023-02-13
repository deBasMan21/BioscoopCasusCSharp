using System;
namespace BioscoopCasus.Domain.OrderStateFolder
{
	public interface OrderState
	{
		void AddSeat();
		void RemoveSeat();
		void Submit();
		void Pay();
		void Cancel();
		void HoursUntilMovieChanged(int hours);
	}
}

