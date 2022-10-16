using System;


namespace Persons
{
    public class AugmentedPerson : Person
    {
        public string Id { get; set; } = "";

        public AugmentedPerson(string firstName, 
            string secondName, string id) : base(firstName, secondName) => (Id) = (id);

        new public void Introduce()
        {
            Console.WriteLine($"{FirstName} {SecondName} {Id}");
        }
    }
}