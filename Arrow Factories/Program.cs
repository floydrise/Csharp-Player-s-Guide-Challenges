/*
Objectives:
• Modify your Arrow class one final time to include static methods of the form public static Arrow CreateEliteArrow() { ... }
for each of the three above arrow types.
• Modify the program to allow users to choose one of these pre-defined types or a custom arrow. If they select one of
the predefined styles, produce an Arrow instance using one of the new static methods. If they choose to make a custom
arrow, use your earlier code to get their custom data about the desired arrow.
*/



MainMenue();

Arrow CustomMenue()
{
    Console.Clear();
    System.Console.WriteLine("Arrowhead types: steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold.");
    Console.Write("Press enter to continue ... ");
    Console.ReadLine();
    Console.WriteLine("Fletching: plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold.");
    Console.Write("Press enter to continue ... ");
    Console.ReadLine();
    Console.WriteLine("Shaft: 0.05 gold per centimeter.");
    Console.Write("Press enter to continue ... ");
    Console.ReadLine();
    Console.Clear();
    return GetArrow();
}

void MainMenue()
{
    Console.Clear();
    System.Console.WriteLine("Choose arrow:");
    System.Console.WriteLine("1. Elite arrow");
    System.Console.WriteLine("2. Beginner arrow");
    System.Console.WriteLine("3. Marksman arrow");
    System.Console.WriteLine("4. Custom arrow");
    System.Console.Write("Enter your choice: ");
    string? readLine = Console.ReadLine();
    Arrow arrow = readLine switch
    {
        "1" => Arrow.GetEliteArrow(),
        "2" => Arrow.GetBegginerArrow(),
        "3" => Arrow.GetMarksmanArrow(),
        "4" => CustomMenue()
    };
    System.Console.WriteLine($"Price is: {arrow.Get}");
}

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowhead();
    Fletching fletching = GetFletching();
    decimal length = GetLength();

    return new(arrowhead, fletching, length);
}

Arrowhead GetArrowhead()
{
    Console.Write("Choose arrowhead type (steel, wood, obsidian): ");
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
    Console.Write("Choose fletching (plastic, turkey feathers, goose feathers): ");
    string? readLine = Console.ReadLine();
    return readLine switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };
}

decimal GetLength()
{
    int readLine = 0;
    while (readLine < 60 || readLine > 100)
    {
        Console.Write("Choose length (between 60cm and 100cm): ");
        readLine = Convert.ToInt32(Console.ReadLine());
    }
    return readLine;
}

class Arrow
{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public decimal Length { get; }
    public Arrow(Arrowhead arrowhead, Fletching fletching, decimal length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public decimal Get
    {
        get
        {
            decimal arrowheadCost = Arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            decimal fletchingCost = Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.GooseFeathers => 3,
                Fletching.TurkeyFeathers => 5
            };

            decimal shaftCost = (decimal)0.05 * Length;

            return (arrowheadCost + fletchingCost + shaftCost);
        }

    }

    public static Arrow GetEliteArrow() => new(Arrowhead.Steel, Fletching.Plastic, 95);
    public static Arrow GetBegginerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    public static Arrow GetMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
}
enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}
enum Arrowhead
{
    Steel,
    Wood,
    Obsidian
}