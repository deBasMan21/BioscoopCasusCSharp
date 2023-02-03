using System;
using BioscoopCasus.Domain;

namespace DomainTests.OrderTests
{
	public class SecondTicketFree
	{
        [Fact]
		public void StudentShouldHaveSecondTicketFree()
        {
			// Arrange
			double price = 10;
			Movie movie = new Movie("Avatar: The way of water");
			MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-31"), price);
			MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, false, true);

			Order sut = new Order(1);
			sut.AddSeatReservation(ticket);
			sut.AddSeatReservation(ticket);
			sut.AddSeatReservation(ticket);
			sut.AddSeatReservation(ticket);
			sut.AddSeatReservation(ticket);
			sut.AddSeatReservation(ticket);

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(price * 3 == totalPrice);
		}

		//[Fact]
		//public void StudentShouldHaveSecondTicketFreeWithUnevenTickets()
		//{
		//	// Arrange
		//	double price = 10;
		//	Movie movie = new Movie("Avatar: The way of water");
		//	MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-31"), price);
		//	MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, false, true);

		//	Order sut = new Order(1);
		//	sut.AddSeatReservation(ticket);
		//	sut.AddSeatReservation(ticket);
		//	sut.AddSeatReservation(ticket);
		//	sut.AddSeatReservation(ticket);
		//	sut.AddSeatReservation(ticket);

		//	// Act
		//	double totalPrice = sut.CalculatePrice();

		//	// Assert
		//	Assert.True(price * 3 == totalPrice);
		//}
	}
}

