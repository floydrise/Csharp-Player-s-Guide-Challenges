/*
Objectives:
• Start with the code for computing an array’s minimum and average values in the section Some Examples with Arrays, starting on page 94.
• Modify the code to use foreach loops instead of for loops.
*/

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array. for (int index = 0; index < array.Length; index++)
foreach (int arraySmallest in array)
{
    if (arraySmallest < currentSmallest)
        currentSmallest = arraySmallest;
}
Console.WriteLine(currentSmallest);

int total = 0;
foreach(int arrayTotal in array)
    total += arrayTotal;
float average = (float)total / array.Length;
Console.WriteLine(average);

