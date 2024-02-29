// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Homework first exercise
Console.Write("Write your first number!");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Write your second number!");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the Operation (+, -, *, /): ");
char operationIndex = Convert.ToChar(Console.ReadLine());

double result = 0;

switch (operationIndex)
{
    case '+':
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}
Console.WriteLine("The result is: " + result);
#endregion
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
#region Homework third exercise
Console.Write("Input first number");
double firstNum=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number");
double secondNum=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The numbers before change are: " + firstNum + " " + secondNum);
double changeValue = firstNum;
firstNum = secondNum;
secondNum = changeValue;
Console.WriteLine("The numbers after the change are: " + firstNum + " " + secondNum);

#endregion






