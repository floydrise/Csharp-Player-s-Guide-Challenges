/* Objectives:
• Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient (mushrooms, chicken, carrots, potatoes),
 and seasoning (spicy, salty, sweet).

• Make a tuple variable to represent a soup composed of the three above enumeration types.

• Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill
the tuple with the results. Hint: You could give the user a menu to pick from or simply compare the user’s
text input against specific strings to determine which enumeration value represents their choice.

• When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
Hint: You don’t need to convert the enumeration value back to a string. Simply displaying an enumeration value with
Write or WriteLine will display the name of the enumeration value.)
 */


Console.Clear();
System.Console.WriteLine("Welcome to Simula's restaurant. I will hand you the menue");
System.Console.Write("Press Enter to continue ...");
Console.ReadLine();
Console.Clear();
(Type type, MainIngridient main, Seasoning seasoning) food = Soup();
System.Console.WriteLine($"You've chosen: {food.seasoning} {food.main} {food.type}");
System.Console.Write("Press Enter to continue ...");
Console.ReadLine();

(Type type, MainIngridient main, Seasoning seasoning) Soup()
{
    System.Console.WriteLine("MENUE");
    System.Console.WriteLine();
    Type type = GetType();
    Console.Clear();
    MainIngridient main = GetMainIngridient();
    Console.Clear();
    Seasoning seasoning = GetSeasoning();
    Console.Clear();
    return (type, main, seasoning);
}

Type GetType()
{
    System.Console.Write($"Choose type - {Type.gumbo}, {Type.soup}, {Type.stew}: ");
    string? readLine = Console.ReadLine();
    return readLine switch
    {
        "gumbo" => Type.gumbo,
        "soup" => Type.soup,
        "stew" => Type.stew
    };
}

MainIngridient GetMainIngridient()
{
    System.Console.Write($"Choose main ingridient - {MainIngridient.carrots}, {MainIngridient.chicken}, {MainIngridient.mushrooms}, {MainIngridient.potatoes}: ");
    string? readLine = Console.ReadLine();
    return readLine switch
    {
        "carrots" => MainIngridient.carrots,
        "chicken" => MainIngridient.chicken,
        "mushrooms" => MainIngridient.mushrooms,
        "potatoes" => MainIngridient.potatoes
    };
}

Seasoning GetSeasoning()
{
    System.Console.Write($"Choose seasoning - {Seasoning.salty}, {Seasoning.spicy}, {Seasoning.sweet}: ");
    string? readLine = Console.ReadLine();
    return readLine switch
    {
        "salty" => Seasoning.salty,
        "spicy" => Seasoning.spicy,
        "sweet" => Seasoning.sweet
    };
}

enum Type
{
    soup,
    stew,
    gumbo
}

enum MainIngridient
{
    mushrooms,
    chicken,
    carrots,
    potatoes
}

enum Seasoning
{
    spicy,
    salty,
    sweet
}