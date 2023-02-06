using BioscoopCasus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTests.OrderTests
{
    public class StudentTickets
    {

		[Theory]
        [InlineData("2023-02-06")]
		[InlineData("2023-02-07")]
		[InlineData("2023-02-08")]
		[InlineData("2023-02-09")]
		[InlineData("2023-02-10")]
		[InlineData("2023-02-11")]
		[InlineData("2023-02-12")]
		public void CalculatePrice_FourStudentTicketsAllWeek_ShouldReturnTwenty(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, isStudentOrder: true);

			Order sut = new(1);
			for (int i = 0; i < 4; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(20 == totalPrice);
		}

		[Fact]
		public void CalculatePrice_ThreeStudentTickets_ShouldReturnTwenty()
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse("2023-02-06"), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, isStudentOrder: true);

			Order sut = new(1);
			for (int i = 0; i < 3; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(20 == totalPrice);
		}

		[Fact]
		public void CalculatePrice_FourPremiumStudentTickets_ShouldReturnTwenty()
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse("2023-02-06"), price);
			MovieTicket ticket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: true, isStudentOrder: true);

			Order sut = new(1);
			for (int i = 0; i < 4; i++)
			{
				sut.AddSeatReservation(ticket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True((price + 2) * 2 == totalPrice);
		}
	}
}
