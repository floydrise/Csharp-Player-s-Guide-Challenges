System.Console.Write("Enter coordinates X value: ");
int xValue = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinates Y value: ");
int yValue = Convert.ToInt32(Console.ReadLine());
if (yValue > 0)
{
    if (xValue < 0)
    {
        System.Console.WriteLine("The enemy is to the northwest!");
    }
    else if (xValue == 0)
    {
        System.Console.WriteLine("The enemy is to the north!");
    }
    else if (xValue > 0)
    {
        System.Console.WriteLine("The enemy is to the northeast!");
    }
}
else if (yValue == 0)
{
    if (xValue < 0)
    {
        System.Console.WriteLine("The enemy is to the west!");
    }
    else if (xValue == 0)
    {
        System.Console.WriteLine("The enemy is here!");
    }
    else if (xValue > 0)
    {
        System.Console.WriteLine("The enemy is to the east!");
    }
}
else
{
    if (xValue < 0)
    {
        System.Console.WriteLine("The enemy is to the southwest!");
    }
    else if (xValue == 0)
    {
        System.Console.WriteLine("The enemy is to the south!");
    }
    else
    {
        System.Console.WriteLine("The enemy is to the southwest!");
    }
}