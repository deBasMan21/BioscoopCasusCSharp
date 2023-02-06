using System;
namespace BioscoopCasus.Domain
{
	public class MovieScreening
	{

		public DateTime DateAndTime { get; private set; }
		public double PicePerSeat { get; private set; }
		public Movie Movie { get; private set; }

		public MovieScreening(Movie movie, DateTime dateAndTime, Double pricePerSeat)
		{
            this.Movie = movie;
			this.DateAndTime = dateAndTime;
			this.PicePerSeat = pricePerSeat;
        }

        public override string ToString()
        {
            return "";
        }

    }
}

