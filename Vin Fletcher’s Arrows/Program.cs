/*
Objectives:
• Define a new Arrow class with fields for arrowhead type, fletching type, and length. (Hint:
arrowhead types and fletching types might be good enumerations.)
• Allow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.
• Add a GetCost method that returns its cost as a float based on the numbers above, and use this to display the arrow’s cost.
*/
Menue();

Arrow arrow = GetArrow();
System.Console.WriteLine($"Price is: {arrow.GetCost()}");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowhead();
    Fletching fletching = GetFletching();
    float length = GetLength();
    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowhead()
{
    System.Console.Write("Choose arrowhead type (steel, wood, or obsidian): ");
    string? readLine = Console.ReadLine();
    return readLine switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}

Fletching GetFletching()
{
    System.Console.Write("Choose fletching type (plastic, turkey feathers, or goose feathers): ");
    string? readLine = Console.ReadLine();
    return readLine switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.Turkey_feathers,
        "goose feathers" => Fletching.Goose_feathers
    };
}

float GetLength()
{
    float length = 0;
    while (length < 60 || length > 100)
    {
        Console.Write("Choose length (between 60cm and 100cm): ");
        length = Convert.ToInt32(Console.ReadLine());
    }
    return length;
}

void Menue()
{
    Console.Clear();
    System.Console.WriteLine("Arrowheads:");
    System.Console.WriteLine($"{Arrowhead.Steel} - 10 gold");
    System.Console.WriteLine($"{Arrowhead.Wood} - 3 gold");
    System.Console.WriteLine($"{Arrowhead.Obsidian} - 5 gold");
    System.Console.Write("Press Enter to continue ...");
    Console.ReadLine();
    Console.Clear();
    System.Console.WriteLine("Fletching type:");
    System.Console.WriteLine($"{Fletching.Plastic} - 10 gold");
    System.Console.WriteLine($"{Fletching.Goose_feathers} - 3 gold");
    System.Console.WriteLine($"{Fletching.Turkey_feathers} - 5 gold");
    System.Console.WriteLine("Press enter to continues ...");
    Console.ReadLine();
    Console.Clear();
    System.Console.WriteLine("Length should be between 60cm and 100cm long");
    System.Console.WriteLine("Press Enter to continue ...");
    Console.ReadLine();
    Console.Clear();
}
class Arrow
{
    public Arrowhead _arrowheadType;
    public Fletching _fletchingType;
    public float _length;

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowheadType = arrowhead;
        _fletchingType = fletching;
        _length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = _arrowheadType switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        float fletchingCost = _fletchingType switch
        {
            Fletching.Plastic => 10,
            Fletching.Turkey_feathers => 5,
            Fletching.Goose_feathers => 3
        };

        float length = (float)(_length * 0.05);

        float price = arrowheadCost + fletchingCost + length;
        return price;
    }
}
enum Fletching
{
    Plastic,
    Turkey_feathers,
    Goose_feathers
}
enum Arrowhead
{
    Steel,
    Wood,
    Obsidian
}