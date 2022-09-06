namespace CSharpTutorial;


public enum AccessLevel
{
    READER,
    DEVELOPER,
    ADMIN
}


class Program
{
    public static void Main(string[] args)
    {
        var accessLevel = AccessLevel.ADMIN;
        Console.WriteLine(accessLevel);

        switch(accessLevel)
        {
            case AccessLevel.ADMIN:
            case AccessLevel.DEVELOPER:
                Console.WriteLine("You can modify the code.");
                break;
            case AccessLevel.READER:
                Console.WriteLine("Reader");
                break;
            default:
                throw new ArgumentException("Access Level Undefined");
        }
    }
}
