/*
Objectives:
• Override the existing ToString method (from the object base class) on all of your inventory item
subclasses to give them a name.For example, new Rope().ToString() shouldreturn "Rope".
• Override ToString on the Pack class to display the contents of the pack. If a pack contains water,
rope, and two arrows, then calling ToString on that Pack object could look like "Pack containing Water Rope Arrow Arrow".
• Before the user chooses the next item to add, display the pack’s current contents via its new ToString method.
*/

Pack pack = new(10, 20, 30);

while (true)
{
    System.Console.WriteLine(pack.ToString());
    System.Console.WriteLine($"Pack currently has: {pack.CurrentItems}/{pack.MaxItems}, {pack.CurrentWeight}/{pack.MaxWeight} ,{pack.CurrentVolume}/{pack.MaxVolume}");
    System.Console.WriteLine("You can add these items:");
    System.Console.WriteLine("1. Arrow\n2. Bow\n3. Rope\n4. Water\n5. Food\n6. Sword");
    System.Console.Write("What would you want to add: ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = userInput switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };
    if (!pack.Add(newItem))
    {
        System.Console.WriteLine("Cannot add this item!");
    }
    System.Console.WriteLine("Press enter to continue ...");
    Console.ReadLine();
    Console.Clear();
}


public class Pack
{
    public int MaxItems { get; }
    public decimal MaxWeight {get;}
    public decimal MaxVolume {get;}

    private InventoryItem[] _items;

    public int CurrentItems {get; private set;}
    public decimal CurrentWeight {get; private set;}
    public decimal CurrentVolume { get; private set; }
    public Pack (int maxItems, decimal maxWeight, decimal maxVolume)
    {
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        _items = new InventoryItem[maxItems];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentItems >= MaxItems) return false;
        if (CurrentWeight + item.Weight > MaxWeight) return false;
        if (CurrentVolume + item.Volume > MaxVolume) return false;

        _items[CurrentItems] = item;
        CurrentItems++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        return true;
    }

    public override string ToString()
    {
        string contains = "Pack contains: ";

        if (CurrentItems <= 0)
        {
            contains += "nothing";
        }

        for (int i = 0; i < CurrentItems; i++)
        {
            contains += _items[i].ToString() + " ";
        }
        return contains;
    }
}
public class InventoryItem
{
    public decimal Weight { get; protected set; }
    public decimal Volume { get; protected set; }

    public InventoryItem(decimal weight, decimal volume)
    {
        Weight = weight;
        Volume = volume;
    }
}
public class Arrow : InventoryItem
{
    public Arrow() : base((decimal)0.1, (decimal)0.05) { }
    public override string ToString()
    {
        return "Arrow";
    }
}
public class Bow : InventoryItem { public Bow() : base(1, 4) { } public override string ToString() => "Bow";}
public class Rope : InventoryItem { public Rope() : base(1, (decimal)1.5) { } public override string ToString() => "Rope";}
public class Water : InventoryItem { public Water() : base(2, 3) { } public override string ToString() => "Water";}
public class Food : InventoryItem { public Food() : base(1, (decimal)0.5) { } public override string ToString() => "Food";}
public class Sword : InventoryItem { public Sword() : base(5, 3) { } public override string ToString() => "Sword";}