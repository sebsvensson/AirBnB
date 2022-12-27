// See https://aka.ms/new-console-template for more information
using DataLayer;

Console.WriteLine("Hello, World!");

AirBnbContext airbnbContext = new AirBnbContext();

airbnbContext.Database.EnsureCreated();