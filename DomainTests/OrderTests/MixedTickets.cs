using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopCasus.Domain;

namespace DomainTests.OrderTests
{
    public class MixedTickets
    {
        [Theory]
		[InlineData("2023-02-10")]
		[InlineData("2023-02-11")]
		[InlineData("2023-02-12")]
		public void CalculatePrice_TwoStudentsAndTwoRegularInWeekend_ShouldReturnThirty(string date)
        {
			// Students always second one free -> 2 tickets == 1 ticket -> €10 in total
			// Regular in weekend not second one free -> 2 tickets == 2 tickets -> €20 in total

			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket studentTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.STUDENT);
			MovieTicket regularTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);

			Order sut = new(1);
			for (int i = 0; i < 2; i++)
			{
				sut.AddSeatReservation(studentTicket);
				sut.AddSeatReservation(regularTicket);
			}

			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(30 == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-06")]
		[InlineData("2023-02-07")]
		[InlineData("2023-02-08")]
		[InlineData("2023-02-09")]
		public void CalculatePrice_TwoStudentsAndTwoRegularOnWeekdays_ShouldReturnTwenty(string date)
		{
			// Students always second one off -> 2 tickets == 1 ticket -> €10 in total
			// Regular on weekdays are also second one free -> 2 tickets == 1 ticket -> €10 in total


			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket studentTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.STUDENT);
			MovieTicket regularTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);

			Order sut = new(1);

			for (int i = 0; i < 2; i++)
			{
				sut.AddSeatReservation(studentTicket);
				sut.AddSeatReservation(regularTicket);
			}


			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(20 == totalPrice);
		}

		[Theory]
		[InlineData(false, false, 30)]
		[InlineData(true, false, 32)]
		[InlineData(false, true, 36)]
		[InlineData(true, true, 38)]
		public void CalculatePrice_TwoStudentsAndTwoRegularInWeekendWithAndWithoutPremium(bool studentPremium, bool regularPremium, int totalPrice)
		{
			// Students always second one free and €2 for premium -> 2 tickets == 1 ticket -> €12 in total
			// Regular in weekend not second one free and €3 for premium -> 2 tickets == 2 ticket -> €26 in total


			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse("2023-02-10"), price);
			MovieTicket studentTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: studentPremium, type: CustomerType.STUDENT);
			MovieTicket regularTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: regularPremium, type: CustomerType.REGULAR);

			Order sut = new(1);

			for (int i = 0; i < 2; i++)
			{
				sut.AddSeatReservation(studentTicket);
				sut.AddSeatReservation(regularTicket);
			}


			// Act
			double actualPrice = sut.CalculatePrice();

			// Assert
			Assert.True(actualPrice == totalPrice);
		}

		[Theory]
		[InlineData("2023-02-06")]
		[InlineData("2023-02-07")]
		[InlineData("2023-02-08")]
		[InlineData("2023-02-09")]
		public void CalculatePrice_SixRegularTicketsAndOneStudentTicketInWeekend_ShouldReturnForty(string date)
		{
			// Arrange
			double price = 10;
			Movie movie = new("Avatar: The way of water");
			MovieScreening movieScreening = new(movie, DateTime.Parse(date), price);
			MovieTicket regularTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.REGULAR);
			MovieTicket studentTicket = new(movieScreening, rowNr: 1, seatNr: 1, isPremium: false, type: CustomerType.STUDENT);

			Order sut = new(1);
			for (int i = 0; i < 6; i++)
			{
				sut.AddSeatReservation(regularTicket);
			}
			sut.AddSeatReservation(studentTicket);


			// Act
			double totalPrice = sut.CalculatePrice();

			// Assert
			Assert.True(40 == totalPrice);
		}
	}
}
