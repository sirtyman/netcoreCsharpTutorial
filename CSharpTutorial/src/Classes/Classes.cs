using System;

using Persons;
using Vehicles;


namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.SecondName = "Blezinskas";
            john.Introduce();

            AugmentedPerson marcin = new AugmentedPerson("Marcin", "Tejman", "88031111992");
            marcin.Introduce();

            Person basePerson = new AugmentedPerson("Robert", "Gala", "43546576");
            basePerson.Introduce();

            var viola = new AugmentedPerson()
            {
                FirstName = "Viola",
                SecondName = "Baya",
                Id = "0344343"
            };
            viola.Introduce();
            viola.Augmentations.Add(new MantisBlades() { Description = "Mantis Blades" });
            viola.Introduce();

            // Upcasting and downcasting
            Person genericPerson = new AugmentedPerson() {
                FirstName = "Generic",
                SecondName = "Person"
            };
            AugmentedPerson augmentedPerson = new AugmentedPerson() {
                FirstName = "Augmented",
                SecondName = "Person"
            };

            genericPerson = augmentedPerson;
            genericPerson.Introduce();

            augmentedPerson = (AugmentedPerson) genericPerson;
            augmentedPerson.Introduce();

            doSomething(augmentedPerson);
            doSomething(new Car());
        }

        public static void doSomething(object sender)
        {
            AugmentedPerson? augmentedPerson = sender as AugmentedPerson;
            if (augmentedPerson != null)
            {
                System.Console.WriteLine("Successful conversion");
            }
            else
            {
                System.Console.WriteLine("Not successful conversion");
            }
        }
    }
}