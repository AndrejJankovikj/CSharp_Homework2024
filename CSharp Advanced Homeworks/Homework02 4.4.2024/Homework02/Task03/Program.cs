﻿using Task03.Domain.Models;
Console.WriteLine("Hello, World!");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Car car = new Car();
Motorbike motorBike = new Motorbike();
Boat boat = new Boat();
Airplane plane = new Airplane();
car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();
car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();