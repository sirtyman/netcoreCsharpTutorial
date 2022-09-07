using System.Collections.Generic;

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
numbers.Add(2);
numbers.AddRange(new int[] {3, 4, 5, 6, 7 });

while(true)
{
    if (!numbers.Remove(3)) break;
}

foreach (var num in numbers)
{
    Console.WriteLine(num);
}