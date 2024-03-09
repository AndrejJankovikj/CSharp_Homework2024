// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Hello, World!");



Console.WriteLine("Todays date is " + DateTime.Now.ToLongDateString());
static int AgeCalculator(DateTime birthdate)
{
    DateTime currentDate = DateTime.Now;
    int age = currentDate.Year - birthdate.Year;

    if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day))
    {
        age--;
        return age;
    }

    return age;
}
static void Main()
{
    Console.WriteLine("Please enter your birthdate in the format MM/dd/yyyy:");
    string birthdateInput = Console.ReadLine();

    DateTime inputBirthdate;
    if (DateTime.TryParse(birthdateInput, out inputBirthdate))
    {
        int age = AgeCalculator(inputBirthdate);
        Console.WriteLine("Your age is: " + age);
    }
    else
    {
        Console.WriteLine("Invalid birthdate format. Please try again.");
    }
}
Main();
