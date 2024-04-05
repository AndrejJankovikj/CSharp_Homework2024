// See https://aka.ms/new-console-template for more information
using Task01.Domain;
Console.ForegroundColor = ConsoleColor.DarkCyan;
PrintsInConsole<string> printString = new PrintsInConsole<string>();
printString.Print("aa");
PrintsInConsole<int> printInt = new PrintsInConsole<int>();
printInt.PrintCollection(new List<int> { 1, 2, 3, 4, 5, 6, 7 });