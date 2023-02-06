using System;
namespace BioscoopCasus.Domain
{
	public class MovieTicket
	{
		public MovieScreening MovieScreening { get; private set; }
		public int RowNr { get; private set; }
		public int SeatNr { get; private set; }
		public bool IsPremium { get; private set; }
		public bool IsStudentOrder { get; private set; }

		public MovieTicket(MovieScreening movieScreening, int rowNr, int seatNr, bool isPremium, bool isStudentOrder)
		{
			this.MovieScreening = movieScreening;
			this.RowNr = rowNr;
			this.SeatNr = seatNr;
			this.IsPremium = isPremium;
			this.IsStudentOrder = isStudentOrder;
		}

		public double GetPrice() {
			if (IsPremium)
			{
				return MovieScreening.PicePerSeat + (IsStudentOrder ? 2 : 3);
			}
			else {
				return MovieScreening.PicePerSeat;
			}
		}

		public DateTime GetDateAndTime() => MovieScreening.DateAndTime;

        public override string ToString()
        {
            return "";
        }
    }
}

