using BioscoopCasus.Domain;
using BioscoopCasus.Domain.ExportStrategy;

double price = 10;
Movie movie = new (title: "Avatar: The way of water");
MovieScreening movieScreening = new MovieScreening(movie, DateTime.Parse("2023-02-02"), price);
MovieTicket ticket1 = new(movieScreening: movieScreening, rowNr: 1, seatNr: 1, isPremium: true, isStudentOrder: false);
MovieTicket ticket2 = new(movieScreening: movieScreening, rowNr: 1, seatNr: 1, isPremium: false, isStudentOrder: false);
MovieTicket ticket3 = new(movieScreening: movieScreening, rowNr: 1, seatNr: 1, isPremium: true, isStudentOrder: false);
MovieTicket ticket4 = new(movieScreening: movieScreening, rowNr: 1, seatNr: 1, isPremium: false, isStudentOrder: false);

//MovieTicket ticket5 = new(movieScreening: movieScreening, rowNr: 1, seatNr: 1, isPremium: false, isStudentOrder: false);
//MovieTicket ticket6 = new(movieScreening: movieScreening, rowNr: 1, seatNr: 1, isPremium: false, isStudentOrder: false);

Order sut = new(1);
sut.AddSeatReservation(ticket1);
sut.AddSeatReservation(ticket2);
sut.AddSeatReservation(ticket3);
sut.AddSeatReservation(ticket4);
//sut.AddSeatReservation(ticket5);
//sut.AddSeatReservation(ticket6);

Console.WriteLine(sut.CalculatePrice());

sut.ExportBehaviour = new ExportJSON();
sut.Export();

sut.ExportBehaviour = new ExportPlainText();
sut.Export();
