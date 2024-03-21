// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


//Declare a new array of integers with 5 elements
//● Initialize the array elements with values from input
//● Sum all the values and print the result in the console

Console.Write("Enter first number: ");
int firstNumber=int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber=int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int thirdNumber=int.Parse(Console.ReadLine());
Console.Write("Enter fourth number: ");
int fourthNumber=int.Parse(Console.ReadLine());
Console.Write("Enter fifth Number: ");
int fifthNumber = int.Parse(Console.ReadLine());


int[] intArray = new int[5];
intArray[0] = firstNumber;
intArray[1] = secondNumber;
intArray[2] = thirdNumber;
intArray[3]=fourthNumber;
intArray[4]=fifthNumber;
int sumOfAllNumbers = 0;
for(int i=0; i<intArray.Length; i++)
{
    sumOfAllNumbers += intArray[i];
}
Console.WriteLine("The sum of all the number entered is: "+sumOfAllNumbers);
