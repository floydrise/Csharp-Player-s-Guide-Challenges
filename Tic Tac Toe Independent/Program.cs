/*

1. Create main menue
2. Display board
3. Implement logic
    - string interpolation to display player's turn
    - char array to change board numbers to player symbols
    - implement logic for winner and draw
4. Display winner or if it's a draw
*/

int player = 0;
GameEngine gameEngine = new()
{
    GameStop = 0
};
char[] cellNumbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
while (gameEngine.GameStop == 0)
{
    player = gameEngine.DeterminePlayer(player);
    Console.Clear();
    MainMenue(player);
    DisplayBoard(cellNumbers);
    WarningsAndResults results = new();
    while (!results.ValidMove)
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        results = gameEngine.Logic(cellNumbers, player, choice);

        if (!results.ValidMove)
        {
            System.Console.WriteLine(results.Message);
        }

        gameEngine.GameStop = gameEngine.EndGame(cellNumbers);
    }
}

Console.Clear();
DisplayBoard(cellNumbers);
Console.WriteLine();

if (gameEngine.GameStop == 1)
{
    Console.WriteLine($"Congratulations! Player {player} wins!");
}
if (gameEngine.GameStop == 2)
{
    Console.WriteLine("The game is draw");
}


void MainMenue(int player)
{
    // Displays welcome menue and gives the rules
    System.Console.WriteLine("Welcome to Tic Tac Toe");
    System.Console.WriteLine();
    System.Console.WriteLine("Player 1: X");
    System.Console.WriteLine("Player 2: O");
    System.Console.WriteLine();
    System.Console.WriteLine($"Player {player} choose a cell between 1 and 9: ");
    System.Console.WriteLine();
}

void DisplayBoard(char[] cellNumbers)
{
    Console.WriteLine($" {cellNumbers[0]} | {cellNumbers[1]} | {cellNumbers[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {cellNumbers[3]} | {cellNumbers[4]} | {cellNumbers[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {cellNumbers[6]} | {cellNumbers[7]} | {cellNumbers[8]} ");
}