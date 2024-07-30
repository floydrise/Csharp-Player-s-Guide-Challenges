public class GameEngine()
{
    public int GameStop { get; set; }
    public char[] CellNumbers
    {
        get
        {
            return ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
        }
    }
    public int DeterminePlayer(int player)
    {
        if (player.Equals(1))
        {
            return 2;
        }

        return 1;
    }

    public WarningsAndResults Logic(char[] cellNumbers, int player, int choice)
    {
        WarningsAndResults results = new();
        results.ValidMove = false;
            if (choice == 1 ||
                choice == 2 ||
                choice == 3 ||
                choice == 4 ||
                choice == 5 ||
                choice == 6 ||
                choice == 7 ||
                choice == 8 ||
                choice == 9)
            {
                char playerCell = cellNumbers[choice - 1];
                if (playerCell.Equals('X') || playerCell.Equals('O'))
                {
                    results.Message = "Cell already occupied, choose another one";
                }
                else
                {
                    cellNumbers[choice - 1] = PlayerSymbol(player);
                    results.ValidMove = true;
                }
            }
            else
            {
                results.Message = "Not a valid move, choose number between 1 and 9: ";
            }
        return results;
    }

    private char PlayerSymbol(int player)
    {
        if (player % 2 == 0)
        {
            return 'O';
        }
        return 'X';
    }

    private bool AreCellsTheSame(char[] cellNumbers, int pos1, int pos2, int pos3)
    {
        if (cellNumbers[pos1] == cellNumbers[pos2] && cellNumbers[pos2] == cellNumbers[pos3])
        {
            return true;
        }
        return false;
    }

    private bool DetermineWinner(char[] cellNumbers)
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

    private bool DetermineDraw(char[] cellNumbers)
    {
        if (cellNumbers[0] != '1' &&
            cellNumbers[1] != '2' &&
            cellNumbers[2] != '3' &&
            cellNumbers[3] != '4' &&
            cellNumbers[4] != '5' &&
            cellNumbers[5] != '6' &&
            cellNumbers[6] != '7' &&
            cellNumbers[7] != '8' &&
            cellNumbers[8] != '9')
        {
            return true;
        }
        return false;
    }

    public int EndGame(char[] cellNumbers)
    {
        if (DetermineWinner(cellNumbers))
        {
            return 1;
        }
        if (DetermineDraw(cellNumbers))
        {
            return 2;
        }
        return 0;
    }
}

