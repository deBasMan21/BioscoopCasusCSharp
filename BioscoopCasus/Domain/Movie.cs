using System;
namespace BioscoopCasus.Domain
{
	public class Movie
	{
        private readonly string _title;
        private readonly List<MovieScreening> _screenings;

        public Movie(string title)
        {
            this._title = title;
            this._screenings = new List<MovieScreening>();
        }

        public void AddScreening(MovieScreening screening) => this._screenings.Add(screening);

        public override string ToString()
        {
            return "";
        }
    }
}

