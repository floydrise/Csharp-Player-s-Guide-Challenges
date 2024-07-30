/*
Objectives:
• Define a new Color class with properties for its red, green, and blue channels.
• Add appropriate constructors that you feel make sense for creating new Color objects.
• Create static properties to define the eight commonly used colors for easy access.
• In your main method, make two Color-typed variables. Use a constructor to create a color instance
and use a static property for the other. Display each of their red, green, and blue channel values.
*/


Color choice = new Color(255, 0, 123);
System.Console.WriteLine($"Red:{choice.R} Green:{choice.G} Blue:{choice.B}");

Color white = Color.White;
System.Console.WriteLine($"Red:{white.R} Green:{white.G} Blue:{white.B}");



public class Color(int red, int green, int blue)
{
    public int R { get; } = red;
    public int G { get; } = green;

    public int B { get; } = blue;

    public static Color White  { get; } = new Color(255,  255,  255);
    public static Color Black {get; } = new(0, 0, 0);
    public static Color Red {get;} = new(255, 0, 0);
    public static Color Orange {get;} = new(255, 165, 0);
    public static Color Yellow {get;} = new(255, 255, 0);
    public static Color Green {get;} = new(0, 128, 0);
    public static Color Blue {get;} = new(0, 0, 255);
    public static Color Purple {get;} = new(128, 0, 128);
}