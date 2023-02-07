using System;
using BioscoopCasus.Domain.PremiumPriceStrategy;

namespace BioscoopCasus.Domain
{
	public class MovieTicket
	{
		public MovieScreening MovieScreening { get; private set; }
		public int RowNr { get; private set; }
		public int SeatNr { get; private set; }
		public bool IsPremium { get; private set; }
		public CustomerType CustomerType { get; private set; }
		public IPremiumPriceBehaviour PremiumPriceBehaviour { get; private set; }

		public MovieTicket(MovieScreening movieScreening, int rowNr, int seatNr, bool isPremium, CustomerType type)
		{
			this.MovieScreening = movieScreening;
			this.RowNr = rowNr;
			this.SeatNr = seatNr;
			this.IsPremium = isPremium;
			this.CustomerType = type;

			switch(type)
            {
				case CustomerType.STUDENT:
					PremiumPriceBehaviour = new StudentPremiumPrice();
					break;

				case CustomerType.REGULAR:
					PremiumPriceBehaviour = new RegularPremuimPrice();
					break;
            }
		}

		public double GetPrice() => MovieScreening.PicePerSeat + PremiumPriceBehaviour.GetPremiumPrice(isPremium: IsPremium);

		public DateTime GetDateAndTime() => MovieScreening.DateAndTime;

        public override string ToString()
        {
            return "";
        }
    }
}

