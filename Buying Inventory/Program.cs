/*
The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies

What number do you want to see the price of? 2 Torches cost 15 gold.

You search around the shop and find ledgers that show the following prices for these items:
Rope: 10 gold
Torches: 15 gold
Climbing Equipment: 25 gold
Clean Water: 1 gold
Machete: 20 gold
Canoe: 200 gold
Food Supplies: 1 gold
*/

System.Console.WriteLine("Ahoy, matey!");
System.Console.WriteLine("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n");
System.Console.Write("What's your name matey? ");
string? name = Console.ReadLine();
System.Console.Write("What number do you want to see the price of? ");
int numberInput = Convert.ToInt32(Console.ReadLine());
string choice = "";
if (name == "Stefan")
{
    System.Console.WriteLine("You get 50% discount, matey!");
    choice = numberInput switch
    {
        1 => "Rope costs 5 gold",
        2 => "Torches cost 7.5 gold",
        3 => "Climbing Equipment costs 12.5 gold",
        4 => "Clean water costs 0.5 gold",
        5 => "Machete costs 10 gold",
        6 => "Canoe costs 100 gold",
        7 => "Food supplies cost 0.5 gold",
        _ => "I didn't quite get this, matey"
    };
    System.Console.WriteLine(choice);
}
else
{
    choice = numberInput switch
    {
        1 => "Rope costs 10 gold",
        2 => "Torches cost 15 gold",
        3 => "Climbing Equipment costs 25 gold",
        4 => "Clean water costs 1 gold",
        5 => "Machete costs 20 gold",
        6 => "Canoe costs 200 gold",
        7 => "Food supplies cost 1 gold",
        _ => "I didn't quite get this, matey"
    };
    System.Console.WriteLine(choice);
}