using System;


namespace Extension
{
    internal class NumbersContainer
    {
        public int[] Numbers { get; set; }

        public NumbersContainer(int[] numbers)
        {
            Numbers = numbers;
        }

        public void PrintNumbers()
        {
            foreach (int n in Numbers)
            {
                System.Console.WriteLine($"{n}");
            }
            System.Console.WriteLine("\n");
        }
    }
}