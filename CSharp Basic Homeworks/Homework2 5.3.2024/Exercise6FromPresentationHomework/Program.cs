// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//06 EXERCISE
//● Create an array with names
//● Give an option to the user to enter a name from the keyboard
//● After entering the name put it in the array
//● Ask the user if they want to enter another name(Y / N)
//● Do the same process over and over until the user enters N
//● Print all the names after user enters N
string firstName = "Danilo";
string secondName = "Ilija";
string thirdName = "Ivan";

string[] namesArray = new string[3];
namesArray[0] = firstName;
namesArray[1] = secondName;
namesArray[2] = thirdName;
Console.Write("Enter a name: ");
string addedName = Console.ReadLine();
Array.Resize(ref namesArray, 4);
namesArray[3] = addedName;
for (int i = 0; i < namesArray.Length; i++)
{
Console.Write("Would you like to add another name to the array?(Y/N)= ");
    char inputAnswer = Convert.ToChar(Console.ReadLine());
    if (inputAnswer == 'Y')
    {
        Console.Write("Write wanted name: ");
        string addAnotherName = Console.ReadLine();
        Array.Resize(ref namesArray, 4 + i);
        namesArray[3 + i] = addAnotherName ;
      

    }
    else if (inputAnswer == 'N')
    {
        foreach (string name in namesArray)
        {
            Console.WriteLine(name);
        }
            break;
    }
}
Console.ReadLine();
