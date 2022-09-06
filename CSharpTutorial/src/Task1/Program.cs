namespace CSharpTutorial;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide numbers separated by coma");
        var inp = Console.ReadLine();

        var numbers = inp.Split(',');
        int max = int.Parse(numbers[0]);
        foreach(var num in numbers)
        {
            Console.WriteLine(num);
            if (max < int.Parse(num))
            {
                max = int.Parse(num);
            }
        }
        Console.WriteLine(string.Format("Max number: {0}", max));
    }
}