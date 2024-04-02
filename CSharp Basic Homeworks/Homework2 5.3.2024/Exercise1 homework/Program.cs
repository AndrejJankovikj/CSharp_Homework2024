// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14
Console.Write("Input first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Input third number:");
int thirdNumber = int.Parse(Console.ReadLine());
Console.Write("Input fourth number:");
int fourthNumber = int.Parse(Console.ReadLine());
Console.Write("Input fifth number:");
int fifthNumber = int.Parse(Console.ReadLine());
Console.Write("Input sixth number: ");
int sixthNumber = int.Parse(Console.ReadLine());




int[] numberArray = new int[6];
numberArray[0]=firstNumber;
numberArray[1]=secondNumber;
numberArray[2]=thirdNumber;
numberArray[3]=fourthNumber;
numberArray[4]=fifthNumber;
numberArray[5]=sixthNumber;
Console.WriteLine(numberArray[0]);
Console.WriteLine(numberArray[1]);
Console.WriteLine(numberArray[2]);
Console.WriteLine(numberArray[3]);
Console.WriteLine(numberArray[4]);
Console.WriteLine(numberArray[5]);

int sum = 0;
for (int i = 0; i < numberArray.Length; i++)
{
    if (numberArray[i] % 2 == 0)
    {
        Console.WriteLine("This number is even");
        sum +=numberArray[i];
    }

}
Console.WriteLine("The sum of all the even numbers is: "+sum);






