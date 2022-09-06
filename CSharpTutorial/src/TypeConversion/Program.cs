using System;


namespace TypeConversion
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            int integerNumber = 1;
            byte byteNumber = (byte)integerNumber;  // can store one byte
            string intNumAsStr = "30";

            int intFromStr = int.Parse(intNumAsStr);  // one type of conversion
            int intFromStr2 = Convert.ToInt32(intNumAsStr);  // 2nd type of conversion using .NET types

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
}
