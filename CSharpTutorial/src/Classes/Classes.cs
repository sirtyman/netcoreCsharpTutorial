using System;
using Persons;

namespace Persons;

public class Program
{
    public static void Main(string[] args)
    {
        var john = new Person();
        john.FirstName = "John";
        john.SecondName = "Blezinskas";

        john.Introduce();

        AugmentedPerson marcin = new AugmentedPerson("Marcin", 
            "Tejman", "88031111992");
        marcin.Introduce();


        Person basePerson = new AugmentedPerson("Robert", "Gala", "00000000");
        basePerson.Introduce();
    }
}