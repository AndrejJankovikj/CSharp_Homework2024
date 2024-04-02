// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Homework second exercise
Console.Write("Input first Number");
double theFirstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number");
double theSecondNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Input third number");
double theThirdNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Input fourth number");
double theFourthNumber = Convert.ToDouble(Console.ReadLine());
int devisionNumber = 4;
double theAverageResult = (theFirstNumber + theSecondNumber + theThirdNumber + theFourthNumber) / devisionNumber;
Console.WriteLine("The average number of " + theFirstNumber + ", " + theSecondNumber + " , " + theThirdNumber + ", " + theFourthNumber + " is " + theAverageResult);
#endregion