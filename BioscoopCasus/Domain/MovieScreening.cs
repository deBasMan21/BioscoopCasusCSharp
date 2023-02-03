using System;
namespace BioscoopCasus.Domain
{
	public class MovieScreening
	{

		private readonly DateTime _dateAndTime;
		private readonly double _pricePerSeat;
        private readonly Movie _movie;

		public MovieScreening(Movie movie, DateTime dateAndTime, Double pricePerSeat)
		{
            this._movie = movie;
			this._dateAndTime = dateAndTime;
			this._pricePerSeat = pricePerSeat;
        }

		public double GetPricePerSeat() => _pricePerSeat;

		public DateTime GetDateAndTime() => _dateAndTime;

        public override string ToString()
        {
            return "";
        }

    }
}

