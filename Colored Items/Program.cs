/*
Objectives:
• Put the three class definitions above into a new project.
• Define a generic class to represent a colored item. It must have properties for the item itself (generic
in type) and a ConsoleColor associated with it.
• Add a void Display() method to your colored item type that changes the console’s foreground color to the
item’s color and displays the item in that color. (Hint: It is sufficient to just call ToString() on the item to get a text representation.)
• In your main method, create a new colored item containing a blue sword, a red bow, and a green axe.
Display all three items to see each item displayed in its color.
*/
ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();

public class Sword { }
public class Bow { }
public class Axe { }
public class ColoredItem<T>
{
    public T Item { get; }
    public ConsoleColor Color { get; }

    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }
    public void Display()
    {
        Console.ForegroundColor = Color;
        System.Console.WriteLine(Item);
    }
}