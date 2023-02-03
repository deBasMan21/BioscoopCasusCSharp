using System;
using BioscoopCasus.Domain;

namespace DomainTests.OrderTests
{
	public class PremiumFeeTests
	{
        [Fact]
        public void ShouldHaveStudentPremiumFee()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-31"), price);
            MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, true, true);

            Order sut = new Order(1);
            sut.AddSeatReservation(ticket);

            // Act
            double totalPrice = sut.CalculatePrice();

            // Assert
            Assert.True(price + 2 == totalPrice);
        }

        [Fact]
        public void ShouldHaveNonStudentPremiumFee()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-31"), price);
            MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, true, false);
            
            Order sut = new Order(1);
            sut.AddSeatReservation(ticket);

            // Act
            double totalPrice = sut.CalculatePrice();

            // Assert
            Assert.True(price + 3 == totalPrice);
        }

        [Fact]
        public void ShouldNotHavePremiumFee()
        {
            // Arrange
            double price = 10;
            Movie movie = new Movie("Avatar: The way of water");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-01-31"), price);
            MovieTicket ticket = new MovieTicket(movieScreening, 1, 1, false, false);

            Order sut = new Order(1);
            sut.AddSeatReservation(ticket);

            // Act
            double totalPrice = sut.CalculatePrice();

            // Assert
            Assert.True(price == totalPrice);
        }
    }
}