
// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

//Console.WriteLine("Hello, World!");
//Write a method that formats a given date and time as a string in a specific format.
//Get the needed inputs from screen.
//Allowed formats: "MM/dd/yyyy", "MM/dd/yyyy hh:mm:ss", "dddd, dd MMMM yyyy HH:mm:ss", "MM.dd.yyyy"

//Bonus: Create separate method that validates whether the entered format is allowed




//Console.Write("Enter your date of birth(mm/dd/yyyy hh:mm:ss):  ");
//DateTime dateInput = DateTime.Parse(Console.ReadLine());
//static void printInputDate(DateTime dateInput)
//{
//string theDate = dateInput.ToString();
//    string printTheDate = "The date your wrote is: " + theDate;
////Console.WriteLine(theDate);
//    return printTheDate;

//}
//string inputDate = printInputDate(DateTime dateInput);




static void DateFormat()
{

DateTime theDate = new DateTime(1994, 5, 24, 7, 20, 30);


Console.Write("Input the format you would like the date to be printed in(\n\"MM/dd/yyyy\"\n\"MM/dd/yyyy hh:mm:ss\"\n \"dddd, dd MMMM yyyy HH:mm:ss\"\n \"MM.dd.yyyy\"):  \n");
string theFormatInput = Console.ReadLine();


if(theFormatInput== "mm/dd/yyyy".ToLower())
{
    string dateFormat = theDate.ToString("mm/dd/yyyy");
    Console.WriteLine(dateFormat);
}
else if(theFormatInput== "MM/dd/yyyy hh:mm:ss".ToLower())
{
    string dateFormat = theDate.ToString("mm/dd/yyyy hh:mm:ss");
    Console.WriteLine(dateFormat);

}
else if(theFormatInput== "dddd, dd MMMM yyyy HH:mm: ss".ToLower()) {
    string dateFormat = theDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");
    Console.WriteLine(dateFormat);
}
else if(theFormatInput== "MM.dd.yyyy".ToLower())
{
    string dateFormat = theDate.ToString("MM.dd.yyyy");
    Console.WriteLine(dateFormat);
}
    else
    {
        Console.WriteLine("Invalid format input!");
    }
}
DateFormat();