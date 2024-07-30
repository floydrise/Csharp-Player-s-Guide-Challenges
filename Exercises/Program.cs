/*
Objectives:
• Put the three class definitions above into a new project.
• Define a generic class to represent a colored item. It must have properties for the item itself (generic
in type) and a ConsoleColor associated with it.
• Add a void Display() method to your colored item type that changes the console’s foreground color to
the item’s color and displays the item in that color. (Hint: It is sufficient to just call ToString()
on the item to get a text representation.)
• In your main method, create a new colored item containing a blue sword, a red bow, and a green axe.
Display all three items to see each item displayed in its color.
*/

ColouredItem<Sword> sword = new(new Sword(), ConsoleColor.Blue);
ColouredItem<Bow> bow = new(new Bow(), ConsoleColor.Red);
ColouredItem<Axe> axe = new(new Axe(), ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();
public class ColouredItem<T>
{
    public T Item { get; }
    public ConsoleColor Colour { get; }

    public ColouredItem(T item, ConsoleColor colour)
    {
        Item = item;
        Colour = colour;
    }

    public void Display()
    {
        Console.ForegroundColor = Colour;
        System.Console.WriteLine(Item);
    }
}

public class Sword { }
public class Bow { }
public class Axe { }