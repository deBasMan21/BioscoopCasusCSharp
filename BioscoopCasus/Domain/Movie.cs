using System;
namespace BioscoopCasus.Domain
{
	public class Movie
	{
        public string Title { get; private set; }
        public List<MovieScreening> Screenings { get; private set; }

        public Movie(string title)
        {
            this.Title = title;
            this.Screenings = new List<MovieScreening>();
        }

        public void AddScreening(MovieScreening screening) => this.Screenings.Add(screening);

        public override string ToString()
        {
            return "";
        }
    }
}

