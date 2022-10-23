using System;
using System.Collections;


namespace Persons
{
    public class Person
    {
        public string? Id { get; set; } = "";
        public string? SecondName { get; set; } = "";
        public string? FirstName { get; set; } = "";

        public Person() => (FirstName, SecondName) = ("", "");

        public Person(string firstName, string secondName, string id) =>
            (SecondName, FirstName, Id) = (firstName, secondName, id);

        public void Introduce()
        {
            Console.WriteLine($"Name: {FirstName} {SecondName}, Id: {Id}");
        }
    }

}