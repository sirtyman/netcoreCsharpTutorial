﻿namespace CSharpTutorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstName = "Marcin";
            var secondName = "Tyman";

            Console.WriteLine(firstName + " " + secondName);
            Console.WriteLine(string.Format("{0} {1}", firstName, secondName));

            Pprint(firstName, secondName);

            Console.WriteLine(string.Join(", ", firstName, secondName));

            string path = @"c:\git\MyRepo";
        }

        public static void Pprint(params object[] args)
        {
            foreach(var arg in args)
            {
                Console.Write(arg + " ");
            }
            Console.Write("\n");
        }
    }
}