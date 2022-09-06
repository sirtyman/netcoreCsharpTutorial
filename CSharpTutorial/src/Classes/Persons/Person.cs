namespace CSharpTutorial.Persons;

internal class Person
{
    public string SecondName { get; set; } = "";
    public string FirstName { get; set; } = "";

    public void Introduce()
    {
        Console.WriteLine($"### {FirstName} {SecondName} ###");
    }
}