/*
Objectives:
• Swords can be made out of any of the following materials: wood, bronze, iron, steel, and the rare binarium.
Create an enumeration to represent the material type.
• Gemstones can be attached to a sword, which gives them strange powers through Cygnus and Lyra’s touch.
Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone. Or no gemstone at all.
Create an enumeration to represent a gemstone type.
• Create a Sword record with a material, gemstone, length, and crossguard width.
• In your main program, create a basic Sword instance made out of iron and with no gemstone. Then
create two variations on the basic sword using with expressions.
• Display all three sword instances with code like Console.WriteLine(original);.
*/

//OG sword
Sword sword = new(Materials.Iron, Gemstones.Empty, 10, 5);

//Testing value semantics
Sword sameSword = new(Materials.Iron, Gemstones.Empty, 10, 5);

//Variations on the OG sword
Sword sword1 = sword with { Material = Materials.Binarium, Gemstone = Gemstones.Emerald };
Sword sword2 = sword with {Material = Materials.Bronze, Gemstone = Gemstones.Amber, Length = 15};

System.Console.WriteLine(sword);
System.Console.WriteLine(sword1);
System.Console.WriteLine(sword2);

//Testist value semantics
System.Console.WriteLine();
System.Console.WriteLine(sword == sameSword);
System.Console.WriteLine(sword == sword1);

//Record and enumerations
public record Sword(Materials Material, Gemstones Gemstone, int Length, int Width);
public enum Gemstones { Emerald, Amber, Sapphire, Diamond, Bitstone, Empty }
public enum Materials { Wood, Bronze, Iron, Steel, Binarium }