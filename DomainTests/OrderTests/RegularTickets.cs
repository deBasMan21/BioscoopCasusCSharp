using BioscoopCasus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTests.OrderTests
{
    public class RegularTickets
    {
		[Theory]
        [InlineData("2023-02-06")]
		[InlineData("2023-02-07")]
		[InlineData("2023-02-08")]
		[InlineData("2023-02-09")]
		public void CalculatePrice_FiveRegularTicketsOnWeekday_ShouldReturnThirty(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new ("Avatar: The way of water");
			MovieScreening movieScreening = new (movie, DateTime.Parse(date), price);
			MovieTicket ticket = new (movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 5; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(price * 3 == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-10")]
		[InlineData("2023-02-11")]
		[InlineData("2023-02-12")]
		public void CalculatePrice_FiveRegularTicketsOnWeekend_ShouldReturnFifty(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 5; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(price * 5 == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-06")]
		[InlineData("2023-02-07")]
		[InlineData("2023-02-08")]
		[InlineData("2023-02-09")]
		public void CalculatePrice_FiveRegularPremiumTicketsOnWeekday_ShouldReturnThirtyNine(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: true, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 5; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True((price + 3) * 3 == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-10")]
		[InlineData("2023-02-11")]
		[InlineData("2023-02-12")]
		public void CalculatePrice_FiveRegularPremiumTicketsOnWeekend_ShouldReturnSixtyFive(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: true, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 5; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True((price + 3) * 5  == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-06")]
		[InlineData("2023-02-07")]
		[InlineData("2023-02-08")]
		[InlineData("2023-02-09")]
		public void CalculatePrice_SixRegularTicketsOnWeekdays_ShouldReturnThirty(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 6; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(30 == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-10")]
		[InlineData("2023-02-11")]
		[InlineData("2023-02-12")]
		public void CalculatePrice_SixRegularTicketsOnWeekends_ShouldReturnFiftyFour(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 6; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(54 == totalPrice);
		}

	}
}
