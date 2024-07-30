/*
Objectives:
• Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15. The game starts at round 1.
• Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen afterward.
• Run the game in a loop until either the Manticore’s or city’s health reaches 0.
• Before the second player’s turn, display the round number, the city’s health, and the Manticore’s
health.
• Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to the player.
• Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected amount.
• If the Manticore is still alive, reduce the city’s health by 1.
• Advance to the next round.
• When the Manticore or the city’s health reaches 0, end the game and display the outcome.
• Use different colors for different types of messages.
• Note: This is the largest program you have made so far. Expect it to take some time!
• Note: Use methods to focus on solving one problem at a time.
• Note: This version requires two players, but in the future, we will modify it to allow the computer to randomly place the Manticore so that it can be a single-player game.
*/
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
int cityLife = 15;
int manticoreLife = 10;
int round = 0;
int cannonRange;

// Initialize game and ask player 1 to set range
System.Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
int manticoreRange = ManticoreRange();
Console.Clear();

System.Console.WriteLine("Player 2, it is your turn.");
while (cityLife > 0 && manticoreLife > 0)
{
    round++;
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine("----------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    System.Console.WriteLine($"STATUS: Round: {round} City: {cityLife}/15 Manticore: {manticoreLife}/10");
    DisplayExpectedMessage();
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.Write("Enter desired cannon range: ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    cannonRange = Convert.ToInt32(Console.ReadLine());
    DisplayCannonMessage();
    Calculations();
    WinnerMessage();
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine("----------------------------------------------");
}

int ManticoreRange()
{
    int range = Convert.ToInt32(Console.ReadLine());
    if (range >= 0 && range <= 100)
    {
        return range;
    }
    while (true)
    {
        System.Console.Write("Try again! Range should be between 0 and 100: ");
        range = Convert.ToInt32(Console.ReadLine());
        if (range >= 0 && range <= 100)
        {
            return range;
        }
    }
}

void DisplayExpectedMessage()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    if (round % 3 == 0 && round % 5 == 0)
    {
        System.Console.WriteLine("The cannon is expected to deal 10 damage this round.");
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        System.Console.WriteLine("The cannon is expected to deal 3 damage this round.");
    }
    else
    {
        System.Console.WriteLine("The cannon is expected to deal 1 damage this round.");
    }
}

void DisplayCannonMessage()
{
    if (cannonRange > manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        System.Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (cannonRange < manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        System.Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("That round was a DIRECT HIT!");
    }
}

void Calculations ()
{
    if (manticoreLife > 0)
        cityLife--;

    if (round % 3 == 0 && round % 5 == 0 && cannonRange == manticoreRange)
    {
        manticoreLife -=10;
    }
    else if ((round % 3 == 0 || round % 5 == 0) && cannonRange == manticoreRange)
    {
        manticoreLife -= 3;
    }
    else if (cannonRange == manticoreRange)
    {
        manticoreLife -= 1;
    }
}

void WinnerMessage ()
{
    if (cityLife <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("The City has been destroyed! Manticore WINS!");
    }
    else if (manticoreLife <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("The Manticore has been destroyed! The City WINS!");
    }
}