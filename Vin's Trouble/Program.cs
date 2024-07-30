/*
Objectives:
• Modify your Arrow class to have private instead of public fields.
• Add in getter methods for each of the fields that you have.
*/


MainMenue();

Arrow arrow = GetArrow();
System.Console.WriteLine($"Price is: {arrow.GetCost()}");
System.Console.WriteLine($"Arrowhead type chosen: {arrow.GetArrowheadType()}");
System.Console.WriteLine($"Fletching type chosen: {arrow.GetFletchingType()}");
System.Console.WriteLine($"Length chosen: {arrow.GetLength()}cm");

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
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private decimal _length;
    public Arrow(Arrowhead arrowhead, Fletching fletching, decimal length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public decimal GetCost()
    {
        decimal arrowheadCost = _arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        decimal fletchingCost = _fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.GooseFeathers => 3,
            Fletching.TurkeyFeathers => 5
        };

        decimal shaftCost = (decimal)0.05 * _length;

        return (arrowheadCost + fletchingCost + shaftCost);

    }

    public Arrowhead GetArrowheadType() => _arrowhead;
    public Fletching GetFletchingType() => _fletching;
    public decimal GetLength() => _length;
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