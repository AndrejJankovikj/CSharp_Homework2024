using Cars.Domain.Entities;
using Cars.Domain.Helpers;
Console.ForegroundColor = ConsoleColor.DarkCyan;
//Where, First,Single,Last/ Select Many/Distinct DistinctBy/ Any, All/Orderby,ThenBy,GroupBy
Console.WriteLine("Origin from Europe");
List<string> fromEurope = CarsData.Cars.Where(car => car.Origin == "Europe").Select(car => car.Model).ToList();
ListHelper.PrintCollectionItems(fromEurope);
ConsoleHelper.PrintInColor("Unique cylind values", ConsoleColor.DarkMagenta);
List<string> uniqueNumberOfCylinders = CarsData.Cars.DistinctBy(car => car.Cylinders).Select(car => $"{car.Cylinders} cylinders").ToList();
ListHelper.PrintCollectionItems(uniqueNumberOfCylinders);
//Go napraiv u string idk najubavo izglea nema da pisuva 3,4,6,8
ConsoleHelper.PrintInColor("All Car names uppercase: ", ConsoleColor.DarkBlue);
List<string> allNamesUppercase = CarsData.Cars.Select(car => (car.Model.ToUpper())).ToList();
ListHelper.PrintCollectionItems(allNamesUppercase);
bool areAnyHigherThan300Hp = CarsData.Cars.Any(car => car.HorsePower > 300);
ConsoleHelper.PrintInColor($"Are there any cars with more than 300 horsepower? {areAnyHigherThan300Hp}", ConsoleColor.Red);
Car carWithMaxHp = CarsData.Cars.MaxBy(car => car.HorsePower);
ConsoleHelper.PrintInColor($"{carWithMaxHp} is the car with the highest horsepower Car", ConsoleColor.Magenta);
ConsoleHelper.PrintInColor("All chevrolet cars and their wieght ordered by descending ", ConsoleColor.Red);
List<string> allChevroletCars = CarsData.Cars.Where(car => car.Model.Contains("Chevrolet")).OrderByDescending(car => car.Weight).Select(car => $"Name: {car.Model}Weight: {car.Weight}").ToList();
ListHelper.PrintCollectionItems(allChevroletCars);
string carWithLongestModelName = CarsData.Cars.OrderByDescending(car => car.Model.Length).Select(car => car.Model).FirstOrDefault();
ConsoleHelper.PrintInColor($"The car with the longest name is: {carWithLongestModelName}", ConsoleColor.Green);
ConsoleHelper.PrintInColor($"Cars grouped by their origin and orderen in the groups by the number of cars in each group in ascending order", ConsoleColor.Green);
var groupByOrigin = CarsData.Cars.GroupBy(car => car.Origin).ToList();
groupByOrigin.OrderBy(cars => cars.Count());
var groupingByOrigin = CarsData.Cars.GroupBy(car => car.Origin)
    .OrderBy(group => group.Count())
    .ToList();
foreach (var group in groupingByOrigin)
{
    Console.WriteLine($"Origin: {group.Key}, Number of Cars: {group.Count()}");
}
//Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
var top5Cars = CarsData.Cars
                            .OrderByDescending(car => car.HorsePower)
                            .Take(5)
                            .ToList();
Console.WriteLine("Top 5 cars with the highest horsepower:");
foreach (var car in top5Cars)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} horsepower");
}
//Find the car with the highest acceleration time.
string highestAccelTime = CarsData.Cars.OrderByDescending(car => car.AccelerationTime).Select(car => $"{car.Model} and time is: {car.AccelerationTime}").FirstOrDefault();
ConsoleHelper.PrintInColor($"The car with the highest acceleration time is: {highestAccelTime}", ConsoleColor.DarkCyan);
//Select only the model and horsepower of cars with horsepower greater than 200.
List<string> above200Horsepower = CarsData.Cars.Where(car => car.HorsePower > 200).Select(car => $"{car.Model} has above 200 horsepower. Precisely: {car.HorsePower}").ToList();
ListHelper.PrintCollectionItems(above200Horsepower);
//Select all unique origins of cars, ordered alphabetically (ascending).
List<string> uniqueOriginsOfCars = CarsData.Cars.DistinctBy(car => car.Origin).OrderBy(car => car.Origin).Select(car => car.Origin).ToList();
var uniqueOriginsOfCars2 = CarsData.Cars.Select(car => car.Origin).Distinct().OrderBy(c => c).ToList();
ListHelper.PrintCollectionItems(uniqueOriginsOfCars);
ListHelper.PrintCollectionItems(uniqueOriginsOfCars2);
//Valjda e tocno ova^_^
ConsoleHelper.PrintInColor("Selected more than 4 cyl ordered by origin and then by hp.", ConsoleColor.Green);
List<string> moreThan4Cylinders = CarsData.Cars.Where(car => car.Cylinders > 4).OrderBy(car => car.Origin).ThenBy(car => car.HorsePower).Select(car => $"{car.Model} from {car.Origin} has {car.HorsePower} horsepower").ToList();
ListHelper.PrintCollectionItems(moreThan4Cylinders);
ConsoleHelper.PrintInColor("Many requests, more than 6 cyl, exactly 4 and hp above 110. Dont think It's right.", ConsoleColor.Red);
//List<string> manyStuffNeeded = (from car in CarsData.Cars where car.Cylinders > 6 && car.Cylinders == 4 && car.HorsePower > 110.0 select $"{car.Model} has ${car.HorsePower} horsepower and {car.Cylinders} cylinders").ToList();
//ListHelper.PrintCollectionItems(manyStuffNeeded);
List<Car> moreThan6CylCars = CarsData.Cars.Where(car => car.Cylinders > 6).ToList();
List<Car> fourCylCars = CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110.0).ToList();
List<string> result = moreThan6CylCars.Concat(fourCylCars).Select(car => car.Model).ToList();
ListHelper.PrintCollectionItems(result);
ConsoleHelper.PrintInColor("Lowest, highest and average mpg GLITCHINGGG", ConsoleColor.Cyan);
List<Car> lowestHighestAverageMPG = CarsData.Cars.Where(car => car.HorsePower == 200).ToList();
Car lowestMPG = CarsData.Cars.Where(car => car.HorsePower > 200).MinBy(car => car.MilesPerGalon);
Car highestMPG = CarsData.Cars.Where(car => car.HorsePower > 200).MaxBy(car => car.MilesPerGalon);
double averageMPG = CarsData.Cars.Where(car => car.HorsePower > 200).Average(car => car.MilesPerGalon);
//ConsoleHelper.PrintInColor($"The highest MPG is {highestMPG}", ConsoleColor.DarkMagenta);
//ConsoleHelper.PrintInColor($" The lowers MPG is {lowestMPG}", ConsoleColor.Blue);
//ConsoleHelper.PrintInColor($" The Average MPG of all cars is {averageMPG.}", ConsoleColor.Blue);
//NE GI PECATAM NIKADE NO ZNAM KAKO, SIMPLY ZATOA STO TREBA MALKU DA GO SREDAM KODOT I NE MI E PROBLEM TOA.
//Samo probuvam da gi resam na nacinot na koj sto mi vrati Ilija na mailot

//string highestMPG = lowestHighestAverageMPG.OrderByDescending(car => car.MilesPerGalon).Select(car => $"{car.Model} has the highest mpg which is: {car.MilesPerGalon}").FirstOrDefault();
//string lowestMPG = lowestHighestAverageMPG.OrderBy(car => car.MilesPerGalon).Select(car => $"{car.Model} has the highest mpg which is: {car.MilesPerGalon}").FirstOrDefault();
//double lowestCarMPG = 100;
//double highestCarMPG = 0;
//double totalMPG = 0;
//int count = 0;
//foreach (Car car in lowestHighestAverageMPG)
//{
//    if (car.MilesPerGalon > highestCarMPG)
//    {
//        lowestCarMPG = car.MilesPerGalon;
//    }
//    if (car.MilesPerGalon < lowestCarMPG)
//    {
//        highestCarMPG = car.MilesPerGalon;
//    }
//    totalMPG += car.MilesPerGalon;
//    count++;
//}
//double averageMPG = totalMPG / count;

//Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
//FDetermine the average weight of cars produced in each country of origin and find the country with the lightest cars on average
var orderByOrigin = CarsData.Cars.GroupBy(car => car.Origin).ToList();
var averageWeightOne = orderByOrigin[0].Average(car => car.Weight);
var averageWeightTwo = orderByOrigin[1].Average(car => car.Weight);
var averageWeightThree = orderByOrigin[2].Average(car => car.Weight);
List<double> averageWeightOfAllOrigins = new()
{
    averageWeightOne,
    averageWeightTwo,
    averageWeightThree

};
//Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)


Console.ReadLine();