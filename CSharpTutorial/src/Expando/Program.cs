using System;
using System.Dynamic;
using System.Text.Json;


namespace DynamicObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create ExpandoObject instance
            dynamic apiObject = new ExpandoObject();
            // Dynamically add attributes to the object
            apiObject.Name = "Marcin";
            apiObject.SecondName = "Tymon";

            // Serialize the object to Json
            string json = JsonSerializer.Serialize(apiObject);

            // Remove Name attribute from the object
            ((IDictionary<string, object>) apiObject).Remove("Name");

            // Iterate through the expando Key - Value pairs
            foreach (KeyValuePair<string, object> memberName in apiObject)
            {
                System.Console.WriteLine(memberName.Key);
            } 

            System.Console.WriteLine(json);
        }
    }

}