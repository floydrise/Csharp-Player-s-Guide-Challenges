/*
• Ask the user for the target row and column.
• Compute the neighboring rows and columns of where to deploy the squad.
• Display the deployment instructions in a different color of your choosing.
• Change the window title to be “Defense of Consolas”.
• Play a sound with Console.Beep when the results have been computed and displayed.
*/
Console.Clear();
Console.Title = "Defense of Consolas";
string? targetRow;
string? targetColumn;
Console.Write("Target row? ");
targetRow = Console.ReadLine();
Console.Write("Target columnt? ");
targetColumn = Console.ReadLine();
int[] leftSoldier = [Convert.ToInt32(targetRow), (Convert.ToInt32(targetColumn) - 1)];
int[] rightSoldier = [Convert.ToInt32(targetRow), (Convert.ToInt32(targetColumn) + 1)];
int [] upperSoldier = [(Convert.ToInt32(targetRow) + 1), Convert.ToInt32(targetColumn)];
int[] lowerSoldier = [(Convert.ToInt32(targetRow) - 1), Convert.ToInt32(targetColumn)];
Console.Beep();
Console.WriteLine("Deploy to:");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Left soldier: ({leftSoldier[0]}, {leftSoldier[1]})");
System.Console.WriteLine($"Right soldier: ({rightSoldier[0]}, {rightSoldier[1]})");
System.Console.WriteLine($"Upper soldier: ({upperSoldier[0]}, {upperSoldier[1]})");
System.Console.WriteLine($"Lower soldier: ({lowerSoldier[0]}, {lowerSoldier[1]})");

