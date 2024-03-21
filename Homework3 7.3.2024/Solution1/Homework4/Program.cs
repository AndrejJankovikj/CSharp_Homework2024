// See https://aka.ms/new-console-template for more information
using System.Net.Mail;

Console.WriteLine("Hello, World!");
//Create a method that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

//The string must contain an @ character.
//The string must contain a . character.
//The @ must have at least one character in front of it.
//ex. "e@mail.com" is valid, while "@email.com" is invalid.
//The . and the @ must be in the appropriate places.
//ex. "hello.email@com" is invalid while "john.smith@email.com" is valid.
//If the string passes these tests, it's considered a valid email address.

//Examples:
//ValidateEmail("@gmail.com") ➞ false

//ValidateEmail("hello.gmail@com") ➞ false

//ValidateEmail("gmail") ➞ false

//ValidateEmail("hello@gmail") ➞ false

//ValidateEmail("hello@gmail.com") ➞ true


    Console.Write("Enter the email you want to validate: ");
    string inputEmail = Console.ReadLine();
static bool EmailValidation(string email)
{
    if (!email.Contains("@") || !email.Contains(".")) { 
    return false;
} 
    int atIndex = email.IndexOf("@");
    if (atIndex == 0)
    {
        return false;
    }
    int dotIndex = email.LastIndexOf(".");
    if (dotIndex < atIndex + 2 || dotIndex == email.Length - 1)
        return false;
    if (email.LastIndexOf(".") == email.Length - 1)
    {
        return false;
    }
    return true;

}
string emailValidation=$"The input email after evaluation has returned: {EmailValidation(inputEmail)}";
Console.WriteLine(emailValidation);



