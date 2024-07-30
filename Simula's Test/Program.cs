/*
Objectives:
• Define an enumeration for the state of the chest.
• Make a variable whose type is this new enumeration.
• Write code to allow you to manipulate the chest with the lock, unlock, open, and close commands, but ensure that you don’t transition between states that don’t support it.
• Loop forever, asking for the next command.
*/

string? readLine;
Chest state = Chest.Locked;
System.Console.WriteLine("Allowed commands: 'lock', 'unlock', 'open', 'close' ");
System.Console.WriteLine();

while (true)
{
    System.Console.Write($"The chest is {state}. What do you want to do? ");
    readLine = Console.ReadLine();

    if (state == Chest.Locked && readLine == "unlock")
    {
        state = Chest.Closed;
    }

    if (state == Chest.Closed && readLine == "open")
    {
        state = Chest.Opened;
    }

    if (state == Chest.Opened && readLine == "close")
    {
        state = Chest.Closed;
    }

    if (state == Chest.Closed && readLine == "lock")
    {
        state = Chest.Locked;
    }

}



enum Chest
{
    Opened,
    Closed,
    Locked
}