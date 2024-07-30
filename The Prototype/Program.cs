/*
Objectives:
• Build a program that will allow a user, the pilot, to enter a number.
• If the number is above 100 or less than 0, keep asking.
• Clear the screen once the program has collected a good number.
• Ask a second user, the hunter, to guess numbers.
• Indicate whether the user guessed too high, too low, or guessed right.
• Loop until they get it right, then end the program.
*/

int user1Input;
do
{
    System.Console.Write("User 1, enter a number between 0 and 100: ");
    user1Input = Convert.ToInt32(Console.ReadLine());
} while (user1Input < 0 || user1Input > 100);

Console.Clear();
System.Console.WriteLine("User 2, guess the number.");
int user2Input;

do
{
    System.Console.Write("What is your next guess? ");
    user2Input = Convert.ToInt32(Console.ReadLine());

    if (user2Input > user1Input)
    {
        System.Console.WriteLine($"{user2Input} is too high");
    }
    else if (user2Input < user1Input)
    {
        System.Console.WriteLine($"{user2Input} is too low");
    }
    else
    {
        System.Console.WriteLine("You guessed the number!");
    }

} while (user2Input != user1Input);