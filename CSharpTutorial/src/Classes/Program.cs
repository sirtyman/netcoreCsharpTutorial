using System;


namespace CSharpTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var john = new Persons.Person();
            john.FirstName = "John";
            john.SecondName = "Blezinskas";

            john.Introduce();
        }
    }
}
