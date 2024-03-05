// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

Console.WriteLine("Hello, World!");


//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string firstG1 = "Zdravko";
string secondG1 = "Petko";
string thirdG1 = "Stanko";
string fourthG1 = "Branko";
string fifthG1 = "Trajko";
string[] g1Names = new string[5];
g1Names[0] = firstG1;
g1Names[1] = secondG1;
g1Names[2] = thirdG1;
g1Names[3] = fourthG1;
g1Names[4] = fifthG1;


string firstG2 = "Andrej";
string secondG2 = "Martin";
string thirdG2 = "Mario";
string fourthG2 = "Viktor";
string fifthG2 = "Ceco";
string[] g2Names = new string[5];
g2Names[0] = firstG2;
g2Names[1] = secondG2;
g2Names[2] = thirdG2;
g2Names[3] = fourthG2;
g2Names[4] = fifthG2;

Console.Write("Would you like the names of students from G1 or G2(Enter 1 or 2): ");
int whichClass = int.Parse(Console.ReadLine());
if (whichClass == 1)
{
    Console.WriteLine("The students of G1 are: ");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(g1Names[i]);
    }
}
else if (whichClass == 2)
{
    Console.WriteLine("The students of G2 are: ");

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(g2Names[i]);
    }
}
else
{
    Console.WriteLine("Invalid input!!!!");
}

Console.ReadLine();

