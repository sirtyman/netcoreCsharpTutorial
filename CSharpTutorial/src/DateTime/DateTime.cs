using System;


class Program
{
    public static void Main(string[] args)
    {
        var now = DateTime.Now;
        // Console.WriteLine(now.ToLongDateString());
        // Console.WriteLine(now.ToShortDateString());
        // Console.WriteLine(now.ToLongTimeString());
        // Console.WriteLine(now.ToShortTimeString());
        // Console.WriteLine(now.ToString("yy-MM-dd hh-mm-ss"));

        var future = DateTime.Now.AddDays(2);
        var deltaTime = future - now;
        Console.WriteLine(deltaTime.TotalMilliseconds);
        // Console.WriteLine(deltaTime);  // TimeSpan object
    }
}