/*
Objectives:
• Create a Coordinate struct that can represent a room coordinate with a row and column.
• Ensure Coordinate is immutable.
• Make a method to determine if one coordinate is adjacent to another (differing only by a single row or column).
• Write a main method that creates a few coordinates and determines if they are adjacent to each other to prove that it is working correctly.
*/
Coordinate a = new(3, 3);
Coordinate b = new(2, 3);
Coordinate c = new(2, 2);
System.Console.WriteLine(Coordinate.AreAdjacent(a, b));
System.Console.WriteLine(Coordinate.AreAdjacent(b, c));
System.Console.WriteLine(Coordinate.AreAdjacent(a, c));

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }
    public static bool AreAdjacent(Coordinate a, Coordinate b)
    {
        int rowChange = (a.Row - b.Row);
        int columnChange = a.Column - b.Column;

        if (Math.Abs(rowChange) <= 1 && columnChange == 0) return true;
        if (Math.Abs(columnChange) <= 1 && rowChange == 0) return true;

        return false;
    }
}