// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Homework third exercise
Console.Write("Input first number");
double firstNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number");
double secondNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The numbers before change are: " + firstNum + " " + secondNum);
double changeValue = firstNum;
firstNum = secondNum;
secondNum = changeValue;
Console.WriteLine("The numbers after the change are: " + firstNum + " " + secondNum);

#endregion