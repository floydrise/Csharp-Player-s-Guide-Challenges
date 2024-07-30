/*
• Passwords must be at least 6 letters long and no more than 13 letters long.
• Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
• Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.

foreach with a string lets you get its characters!
> foreach (char letter in word) { ... }
char has static methods to categorize letters!
> char.IsUpper('A'), char.IsLower('a'), char.IsDigit('0')

• Define a new PasswordValidator class that can be given a password and determine if the password follows the rules above.
• Make your main method loop forever, asking for a password and reporting whether the password
is allowed using an instance of the PasswordValidator class.
*/
Console.Clear();

while (true)
{
    System.Console.Write("Enter password: ");
    string? readLine = Console.ReadLine();

    if (readLine == null || readLine == "")
    {
        System.Console.WriteLine("Must enter password");
        continue;
    }


    PasswordValidator password = new(readLine);
    System.Console.WriteLine($"Can be used: {password.IsValidPassword(readLine)}");
}

public class PasswordValidator
{
    public string Password { get; private set; }

    public PasswordValidator(string password)
    {
        Password = password;
    }

    public bool IsValidPassword(string password)
    {
        if (!IsWithinBoundaries(password)) return false;
        if (!IsUpper(password)) return false;
        if (!IsLower(password)) return false;
        if (!IsDigit(password)) return false;
        if (Contains(password, 'T')) return false;
        if (Contains(password, '&')) return false;

        return true;
    }

    public bool IsWithinBoundaries(string password) => password.Length >= 6 && password.Length <= 13;

    public bool IsUpper(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsUpper(letter))
            {
                return true;
            }
        }

        return false;
    }

    public bool IsLower(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsLower(letter))
            {
                return true;
            }
        }
        return false;
    }

    public bool IsDigit(string password)
    {
        foreach (char digit in password)
        {
            if (char.IsDigit(digit))
            {
                return true;
            }
        }
        return false;
    }

    private bool Contains(string password, char letter)
    {
        foreach (char character in password)
            if (character == letter) return true;

        return false;
    }
}