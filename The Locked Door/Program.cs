/*
Objectives:
• Define a Door class that can keep track of whether it is locked, open, or closed.
• Make it so you can perform the four transitions defined above with methods.
• Build a constructor that requires the starting numeric passcode.
• Build a method that will allow you to change the passcode for an existing door by supplying the current passcode
and new passcode. Only change the passcode if the current passcode is correct.
• Make your main method ask the user for a starting passcode, then create a new Door instance. Allow the user to
attempt the four transitions described above (open, close, lock, unlock) and change the code by typing in text commands.
*/

int getPasscode = GetPass();

Door door = new(getPasscode);
while (true)
{
    System.Console.WriteLine($"The door is {door.DoorState}");
    System.Console.WriteLine("What do you want to do (open, close, lock, unlock, change pass): ");
    string? readLine = Console.ReadLine();
    switch (readLine)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "unlock":
            System.Console.Write("What is the passcode: ");
            int passcode = Convert.ToInt32(Console.ReadLine());
            door.Unlock(passcode);
            break;
        case "lock":
            door.Lock();
            break;
        case "change pass":
            System.Console.Write("What is the old passcode: ");
            int oldPasscode = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("What is the new passcode: ");
            int newPasscode = Convert.ToInt32(Console.ReadLine());
            door.ChangePass(oldPasscode, newPasscode);
            break;
    }
}

static int GetPass()
{
    System.Console.Write("Give initial passcode: ");
    int passcode = Convert.ToInt32(Console.ReadLine());
    return passcode;
}

public class Door
{
    private int _passcode;
    public DoorState DoorState { get; private set; } = DoorState.Closed;

    public Door(int passcode)
    {
        _passcode = passcode;
    }

    public void Close()
    {
        if (DoorState == DoorState.Opened)
        {
            DoorState = DoorState.Closed;
        }
    }

    public void Open()
    {
        if (DoorState == DoorState.Closed && DoorState != DoorState.Locked)
        {
            DoorState = DoorState.Opened;
        }
    }

    public void Lock()
    {
        if (DoorState == DoorState.Closed)
        {
            DoorState = DoorState.Locked;
        }
    }

    public void Unlock(int pass)
    {
        if (DoorState == DoorState.Locked)
        {
            if (pass == _passcode)
            {
                DoorState = DoorState.Closed;
            }
        }
    }

    public void ChangePass(int oldPass, int newPass)
    {
        if (oldPass == _passcode)
        {
            _passcode = newPass;
        }
        else
        {
            System.Console.WriteLine("You didn't guess the old passcode! Try again.");
            System.Console.WriteLine();
        }
    }
}


public enum DoorState
{
    Opened,
    Closed,
    Locked
}