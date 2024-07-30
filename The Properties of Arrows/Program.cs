/*
Objectives:
• Modify your Arrow class to use properties instead of GetX and SetX methods.
• Ensure the whole program can still run, and Vin can keep creating arrows with it.
*/

MainMenue();

Arrow arrow = GetArrow();
System.Console.WriteLine($"Price is: {arrow.Get}");
System.Console.WriteLine($"Arrowhead type chosen: {arrow.Arrowhead}");
System.Console.WriteLine($"Fletching type chosen: {arrow.Fletching}");
System.Console.WriteLine($"Length chosen: {arrow.Length}cm");

void MainMenue()
{
    Console.Clear();
    System.Console.WriteLine("Arrowhead types: steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold.");
    Console.Write("Press enter to continue ... ");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Fletching: plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold.");
    Console.Write("Press enter to continue ... ");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Shaft: 0.05 gold per centimeter.");
    Console.Write("Press enter to continue ... ");
    Console.ReadLine();
    Console.Clear();
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