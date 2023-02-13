using System;
namespace BioscoopCasus.Domain
{
	public class Room
	{
		private int AvailableSeats;

		public Room(int availableSeats)
		{
			this.AvailableSeats = availableSeats;
		}

		public void OccupyChair()
        {
			AvailableSeats -= 1;
        }
	}
}

