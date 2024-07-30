/*
Objectives:
• Make a method with the signature int AskForNumber(string text). Display the text parameter in the console window, get a response from the user, convert it to an int, and return it. Thismightlooklikethis:int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");.
• Make a method with the signature int AskForNumberInRange(string text, int min, int max). Only return if the entered number is between the min and max values. Otherwise, ask again.
• Place these methods in at least one of your previous programs to improve it.
*/

/* int result = AskForNumber("What is the airspeed velocity of an unladen swallow? ");
System.Console.WriteLine($"The airspeed velocity is: {result}");
int AskForNumber(string text)
{
    System.Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
} */

string text = "What is the airspeed velocity of an unladen swallow?";
int result2 = AskForNumberInRange(text, 1, 100);
System.Console.WriteLine($"The answer is: {result2}");

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        System.Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= min && number <= max)
        {
            return number;
        }
        System.Console.WriteLine("Try again");
    }
}