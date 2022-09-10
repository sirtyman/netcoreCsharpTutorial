using System;

namespace CSharpTutorial;

internal class Program
{
    public static void Main(string[] args)
    {
        var firstName = "Marcin";
        var secondName = "Tyman";

        Console.WriteLine(firstName + " " + secondName);
        Console.WriteLine("{0} {1}", firstName, secondName);

        Pprint(firstName, secondName);

        Console.WriteLine(string.Join(", ", firstName, secondName));

        var path = @"c:\git\MyRepo";
        Console.WriteLine(path);
    }

    public static void Pprint(params object[] args)
    {
        foreach (var arg in args) Console.Write(arg + " ");
        Console.Write("\n");
    }


}