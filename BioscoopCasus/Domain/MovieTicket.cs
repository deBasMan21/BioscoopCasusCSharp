using System;
namespace BioscoopCasus.Domain
{
	public class MovieTicket
	{
		private readonly MovieScreening _movieScreening;
		private readonly int _rowNr;
		private readonly int _seatNr;
		private readonly bool _isPremium;
		private readonly bool _isStudentOrder;

		public MovieTicket(MovieScreening movieScreening, int rowNr, int seatNr, bool isPremium, bool isStudentOrder)
		{
			this._movieScreening = movieScreening;
			this._rowNr = rowNr;
			this._seatNr = seatNr;
			this._isPremium = isPremium;
			this._isStudentOrder = isStudentOrder;
		}

		public bool IsPremiumTicket() => _isPremium;

		public bool GetIsStudentOrder() => _isStudentOrder;

		public double GetPrice() {
			if (_isPremium)
			{
				return _movieScreening.GetPricePerSeat() + (_isStudentOrder ? 2 : 3);
			}
			else {
				return _movieScreening.GetPricePerSeat();
			}
		}

		public DateTime GetDateAndTime() => _movieScreening.GetDateAndTime();

        public override string ToString()
        {
            return "";
        }
    }
}

