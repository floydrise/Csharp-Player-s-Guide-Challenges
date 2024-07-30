/*
Objectives:
• Define a new Point class with properties for X and Y.
• Add a constructor to create a point from a specific x- and y-coordinate.
• Add a parameterless constructor to create a point at the origin (0, 0).
• In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the
console window in the format (x, y) to illustrate that the class works.
• Answer this question: Are your X and Y properties immutable? Why did you choose what you did?
*/

Point point = new(2, 3);
System.Console.WriteLine($"({point.X}, {point.Y})");

Point point1 = new(-4, 0);
System.Console.WriteLine($"({point1.X}, {point1.Y})");

Point origin = new Point();
System.Console.WriteLine($"({origin.X}, {origin.Y})");


public class Point
{
    public int X {get;}
    public int Y {get;}

    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

}