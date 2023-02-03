using System;
using BioscoopCasus.Domain;

namespace DomainTests.OrderTests
{
	public class TenPercentDiscount
	{
        [Fact]
		public void SixTicketsInWeekendWithoutStudentsShouldHaveDiscount()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-28"), price);
            MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, false, false);

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
            Assert.True(price * 6 * 0.9 == totalPrice);
        }

        [Fact]
        public void SixTicketsInWeekendWithStudentsShouldNotHaveDiscount()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-28"), price);
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
            Assert.True(price * 6 == totalPrice);
        }

        [Fact]
        public void SixTicketsNotInWeekendWithoutStudentsShouldNotHaveDiscount()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-31"), price);
            MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, false, false);

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
            Assert.True(price * 6 == totalPrice);
        }

        [Fact]
        public void FiveTicketsInWeekendWithoutStudentsShouldNotHaveDiscount()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-28"), price);
            MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, false, false);

            Order sut = new Order(1);
            sut.AddSeatReservation(ticket);
            sut.AddSeatReservation(ticket);
            sut.AddSeatReservation(ticket);
            sut.AddSeatReservation(ticket);
            sut.AddSeatReservation(ticket);

            // Act
            double totalPrice = sut.CalculatePrice();

            // Assert
            Assert.True(price * 5 == totalPrice);
        }

        [Fact]
        public void FiveTicketsNotInWeekendWithStudentsShouldNotHaveDiscount()
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

            // Act
            double totalPrice = sut.CalculatePrice();

            // Assert
            Assert.True(price * 5 == totalPrice);
        }
    }
}

