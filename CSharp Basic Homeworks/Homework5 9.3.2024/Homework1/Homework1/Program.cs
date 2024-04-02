// See https://aka.ms/new-console-template for more information

//Make a class Driver. Add properties: Name, Skill
//Make a class Car. Add properties: Model, Speed and Driver
//Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
//Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
//Make 4 car objects and 4 driver objects.
//Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and call the RaceCars() methods
//Test Data:
//Choose a car no.1:
//Hyundai
//Mazda
//Ferrari
//Porsche
//Choose Driver:
//Bob
//Greg
//Jill
//Anne
//Choose a car no.2:
//Hyundai
//Mazda
//Ferrari
//Porsche
//Choose Driver:
//Bob
//Greg
//Jill
//Anne
//Expected Output:
//Car no. 2 was faster.
//BONUS 1: If a user chooses option one for the first care, eliminate that option when the user picks car two.

//BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

//BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.

using Homework01.Driver;
    using Homework01.Car;

Driver ilija = new Driver("Ilija", 7);
Driver ivan = new Driver("Ivan", 3);
Driver ivo = new Driver("Ivo", 5);
Driver danilo = new Driver("Danilo", 9);

Driver[] availableDrivers = { ilija, ivan, ivo, danilo };

Console.WriteLine("Please choose your driver for the first car: (Ilija/Ivan/Ivo/Danilo)");
string firstDriver = Console.ReadLine();
Console.WriteLine("Please choose your driver for the second car: (Ilija/Ivan/Ivo/Danilo)");
string secondDriver = Console.ReadLine();

Driver? selectedFirstDriver = null;
Driver? selectedSecondDriver = null;

foreach (Driver driver in availableDrivers)
{
    if (firstDriver?.ToLower() == driver.Name.ToLower())
    {
        selectedFirstDriver = driver;
    }
    else
    if (secondDriver?.ToLower() == driver.Name.ToLower())
    {
        selectedSecondDriver = driver;
    }

}


Car hyundai = new Car("Hyundai", 3);
Car mazda = new Car("Mazda", 5);
Car ferrari = new Car("Ferrari", 6);
Car porsche = new Car("Porsche", 9);

Car[] availableCars = { hyundai, mazda, ferrari, porsche };

Console.WriteLine("Please choose your car for the first car: (Hyundai/Mazda/Ferrari/Porsche)");
string firstCarModel = Console.ReadLine();
Console.WriteLine("Please choose your car for the second car: (Hyundai/Mazda/Ferrari/Porsche)");
string secondCarModel = Console.ReadLine();

Car? selectedFirstCar = null;
Car? selectedSecondCar = null;

foreach (Car car in availableCars)
{
    if (firstCarModel?.ToLower() == car.Model.ToLower())
    {
        selectedFirstCar = car;
    }
    else
    if (secondCarModel?.ToLower() == car.Model.ToLower())
    {
        selectedSecondCar = car;
    }
}


if (selectedFirstCar == null || selectedSecondCar == null || selectedFirstDriver == null || selectedSecondDriver == null)
{
    Console.WriteLine("You have selected invalid car or driver or duplicate car or driver!!");
    return;
}


selectedFirstCar!.Driver = selectedFirstDriver;
selectedSecondCar!.Driver = selectedSecondDriver;

Car.RaceCars(selectedFirstCar, selectedSecondCar);