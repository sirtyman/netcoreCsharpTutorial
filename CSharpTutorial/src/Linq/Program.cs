using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

        IEnumerable<int> evenNumbers = from num in numbers
            where num % 2 == 0
            select num;
        
        foreach (var num in evenNumbers)
        {
            System.Console.WriteLine(num);
        }

        System.Console.WriteLine("\n\n\n");

        List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5};
        var evenNumbersFromList = numbersList.Where<int>(num => num % 2 == 0);

        foreach (var num in evenNumbersFromList)
        {
            System.Console.WriteLine(num);
        }
    }
}