/* • Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect. (The % operator may be of use.)
• Change the color of the output based on the type of blast. (For example, red for Fire, yellow for Electric, and blue for Electric and Fire). */

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine($"{i}. Combined");
    }

    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"{i}. Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine($"{i}. Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($"{i}. Normal");
    }
}
