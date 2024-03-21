// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Given a string, create a method to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
//Examples:
//ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

//ReverseCase("MANY THANKS") ➞ "many thanks"

//ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"

static string ReverseCase()
{

Console.Write("Write what you want reversed: ");
string inputValue = Console.ReadLine();
    //char[] newCharArray = { };
    char[] inputChars = inputValue.ToCharArray();
    char[] newCharArray = new char[inputChars.Length];

   for (int i = 0; i < inputChars.Length; i++)
    {
        if (Char.IsLower(inputChars[i]))
        {
            newCharArray[i] = char.ToUpper(inputChars[i]);
        }
        else if (Char.IsUpper(inputChars[i]))
        {
            newCharArray[i] = char.ToLower(inputChars[i]);
        }
        else
        {
            newCharArray[i] = inputChars[i];
        }
    }
    string reversedString = new string(newCharArray);
    return $"The reversed string looks like this: {reversedString}";
   
}
string reversed = ReverseCase();
Console.WriteLine(reversed);