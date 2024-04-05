// See https://aka.ms/new-console-template for more information
using Task02.Domain.Models;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Hello, World!");
Vehicle car = new Car();
Vehicle motorBike = new Motorbike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();
car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();
