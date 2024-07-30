/*
Objectives:
• Take a number as input from the console.
• Display the word “Tick” if the number is even. Display the word “Tock” if the number is odd.
• Hint: Remember that you can use the remainder operator to determine if a number is even or odd.
*/

System.Console.WriteLine("Enter a number:");
string? input = Console.ReadLine();
int inputNumber = Convert.ToInt32(input);
if (inputNumber % 2 == 0)
{
    System.Console.WriteLine("Tick");
}
else
{
    System.Console.WriteLine("Tock");
}
