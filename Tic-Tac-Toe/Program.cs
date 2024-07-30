Console.Clear();

int gameStatus = 0;
int currentPlayer = 0;
char[] cellNumbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
while (gameStatus == 0)
{
    currentPlayer = CurrentPlayer(currentPlayer);
    DisplayMenue(currentPlayer);
    DisplayBoard(cellNumbers);
    Logic(cellNumbers, currentPlayer);
    gameStatus = UpdateGameStatus(cellNumbers);
    Console.Clear();
}
DisplayMenue(currentPlayer);
DisplayBoard(cellNumbers);
if (gameStatus == 1)
{
    Console.WriteLine($"Player {currentPlayer} is the winner!");
}
if (gameStatus == 2)
{
    Console.WriteLine($"Game is draw!");
}

int UpdateGameStatus(char[] cellNumbers)
{
    if (Draw(cellNumbers))
    {
        return 2;
    }

    if (WinningSituations(cellNumbers))
    {
        return 1;
    }

    return 0;
}

bool Draw(char[] cellNumbers)
{
    return cellNumbers[0] != '1' &&
            cellNumbers[1] != '2' &&
            cellNumbers[2] != '3' &&
            cellNumbers[3] != '4' &&
            cellNumbers[4] != '5' &&
            cellNumbers[5] != '6' &&
            cellNumbers[6] != '7' &&
            cellNumbers[7] != '8' &&
            cellNumbers[8] != '9';
}

bool WinningSituations(char[] cellNumbers)
{

    if (AreCellsTheSame(cellNumbers, 0, 1, 2)) return true;
    if (AreCellsTheSame(cellNumbers, 3, 4, 5)) return true;
    if (AreCellsTheSame(cellNumbers, 6, 7, 8)) return true;
    if (AreCellsTheSame(cellNumbers, 0, 3, 6)) return true;
    if (AreCellsTheSame(cellNumbers, 1, 4, 7)) return true;
    if (AreCellsTheSame(cellNumbers, 2, 5, 8)) return true;
    if (AreCellsTheSame(cellNumbers, 0, 4, 8)) return true;
    if (AreCellsTheSame(cellNumbers, 2, 4, 6)) return true;

    return false;
}

bool AreCellsTheSame(char[] cells, int pos1, int pos2, int pos3)
{
    return cells[pos1] == cells[pos2] && cells[pos2] == cells[pos3];
}

void Logic(char[] cellNumbers, int currentPlayer)
{
    bool notValidMove = true;
    while (notValidMove)
    {
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput.Equals(1) ||
            userInput.Equals(2) ||
            userInput.Equals(3) ||
            userInput.Equals(4) ||
            userInput.Equals(5) ||
            userInput.Equals(6) ||
            userInput.Equals(7) ||
            userInput.Equals(8) ||
            userInput.Equals(9))
        {
            char playerMove = cellNumbers[userInput - 1];
            if (playerMove.Equals('X') || playerMove.Equals('O'))
            {
                Console.Write("Cell already occupied, choose another one: ");
            }
            else
            {
                cellNumbers[userInput - 1] = PlayerSymbol(currentPlayer);
                notValidMove = false;
            }
        }
        else
        {
            System.Console.Write("Input ivalid! Choose between 1 and 9: ");
        }
    }
}

char PlayerSymbol(int player)
{
    if (player % 2 == 0)
    {
        return 'O';
    }

    return 'X';
}

void DisplayMenue(int player)
{
    Console.WriteLine("Welcome to Tic Tac Toe");
    Console.WriteLine();
    Console.WriteLine("Player 1: X");
    Console.WriteLine("Player 2: O");
    Console.WriteLine();
    Console.WriteLine($"Player {player} choose a cell: ");
    Console.WriteLine();
}

void DisplayBoard(char[] cellNumbers)
{
    Console.WriteLine($" {cellNumbers[0]} | {cellNumbers[1]} | {cellNumbers[2]} ");
    Console.WriteLine("---+---+--- ");
    Console.WriteLine($" {cellNumbers[3]} | {cellNumbers[4]} | {cellNumbers[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {cellNumbers[6]} | {cellNumbers[7]} | {cellNumbers[8]} ");
    System.Console.WriteLine();
}

int CurrentPlayer(int currentPlayer)
{
    if (currentPlayer == 1)
    {
        return 2;
    }

    return 1;
}