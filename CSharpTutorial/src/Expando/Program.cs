using System;
using System.Dynamic;
using System.Text.Json;


namespace DynamicObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            dynamic apiObject = new ExpandoObject();
            apiObject.name = "Marcin";
            apiObject.secondName = "Tymon";

            string json = JsonSerializer.Serialize(apiObject);
            System.Console.WriteLine(json);
        }
    }

}