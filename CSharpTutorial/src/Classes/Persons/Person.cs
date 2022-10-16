using System;


namespace Persons
{
    public class Person
    {
        public string SecondName { get; set; } = "";
        public string FirstName { get; set; } = "";

        public Person() => (FirstName, SecondName) = ("", "");

        public Person(string firstName, string secondName) =>
            (SecondName, FirstName) = (firstName, secondName);

        public void Introduce()
        {
            Console.WriteLine($"### {FirstName} {SecondName} ###");
        }
    }

}