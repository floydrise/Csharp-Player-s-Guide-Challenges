/*
Objectives:
• Create an InventoryItem class that represents any of the different item types. This class must represent the item’s weight
and volume, which it needs at creation time (constructor).
• Create derived classes for each of the types of items above. Each class should pass the correct weight and volume to the
base class constructor but should be creatable themselves with a parameterless constructor(forexample,new Rope()ornew Sword()).
• Build a Pack class that can store an array of items. The total number of items, the maximum weight, and the maximum volume
are provided at creation time and cannot change afterward.
• Make a public bool Add(InventoryItem item) method to Pack that allows you to add items of any type to the pack’s contents.
This method should fail (return false and not modify the pack’s fields) if adding the item would cause it to exceed the pack’s
item, weight, or volume limit.
• Add properties to Pack that allow it to report the current item count, weight, and volume, and the limits of each.
• Create a program that creates a new pack and then allow the user to add (or attempt to add) items chosen from a menu.
*/

Pack pack = new(10, 20, 30);

while (true)
{
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
public class Arrow : InventoryItem { public Arrow() : base((decimal)0.1, (decimal)0.05) { } }
public class Bow : InventoryItem { public Bow() : base(1, 4) { } }
public class Rope : InventoryItem { public Rope() : base(1, (decimal)1.5) { } }
public class Water : InventoryItem { public Water() : base(2, 3) { } }
public class Food : InventoryItem { public Food() : base(1, (decimal)0.5) { } }
public class Sword : InventoryItem { public Sword() : base(5, 3) { } }