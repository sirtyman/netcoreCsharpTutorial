namespace TypeConversion;

internal class TypeConversion
{
    private static void Main(string[] args)
    {
        var integerNumber = 1;
        var byteNumber = (byte)integerNumber; // can store one byte
        var intNumAsStr = "30";

        var intFromStr = int.Parse(intNumAsStr); // one type of conversion
        var intFromStr2 = Convert.ToInt32(intNumAsStr); // 2nd type of conversion using .NET types

        Console.WriteLine($"{intFromStr}");
        Console.WriteLine($"{intFromStr2}");

        // Overflow
        try
        {
            Convert.ToByte(256);
        }
        catch (Exception)
        {
            Console.WriteLine("Ouuuc... An overflow happened!");
            // throw;
        }
    }
}