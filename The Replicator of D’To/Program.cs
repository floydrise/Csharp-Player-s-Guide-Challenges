/*
Objectives:
• Make a program that creates an array of length 5.
• Ask the user for five numbers and put them in the array.
• Make a second array of length 5.
• Use a loop to copy the values out of the original array and into the new one.
• Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works again.
*/

//initiallize array, ask for user input
Console.Clear();
int[] firstArray = new int[5];
System.Console.WriteLine("Give me five numbers to put in an array!");
for (int i = 0; i < firstArray.Length; i++)
{
    System.Console.Write($"Number {i + 1}: ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    firstArray[i] = userInput;
}

// display contents of the array to the console
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.WriteLine("Contents of the first array:");
DisplayArray(firstArray);
System.Console.WriteLine("Press any key to continue:");
Console.ReadKey();

// copy contents of first array into second array and display them to the console
Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine("Copying contents of the first array into a second array!");
System.Console.WriteLine("Array 2 contents:");
int[] secondArray = new int[5];
Array.Copy(firstArray, secondArray, firstArray.Length);
DisplayArray(secondArray);

void DisplayArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Index {i} - {array[i]}");
    }
}