Console.ForegroundColor = ConsoleColor.DarkCyan;
//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the number in the order that the user entered them from the QUEUE
Queue<double> queue = new Queue<double>();
Console.WriteLine("Input first number");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Input third number");
double thirdNumber = double.Parse(Console.ReadLine());
queue.Enqueue(firstNumber);
queue.Enqueue(secondNumber);
queue.Enqueue(thirdNumber);
while (true)
{
    Console.WriteLine("Do you want to input another number?");
    char questionAnswer = char.Parse(Console.ReadLine());
    if (questionAnswer == 'y')
    {
        Console.WriteLine("Input another number: ");
        double newNumber = double.Parse(Console.ReadLine());

        queue.Enqueue(newNumber);
        continue;
    }
    else if (questionAnswer == 'n')
    {
        foreach (double num in queue)
        {
            Console.WriteLine(num);
        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid input");
        break;
    }
}

