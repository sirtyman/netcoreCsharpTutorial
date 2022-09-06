
namespace CSharpTutorial.Persons
{
    internal class Person
    {
        private string firstName = "";
        private string secondName = "";

        public string SecondName { get => secondName; set => secondName = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        public void Introduce()
        {
            Console.WriteLine($"### {FirstName} {SecondName} ###");
        }
    }
}

