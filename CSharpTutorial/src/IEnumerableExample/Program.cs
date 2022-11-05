using System;
using System.Collections.Generic;


namespace IEnumerableExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] _customers = new Customer[]
            {
                new Customer { Name="Basia", Mobile=333333333, Amount=300.4 },
                new Customer { Name="Kasi", Mobile=333333331, Amount=302.4 },
                new Customer { Name="Ola", Mobile=333333332, Amount=303.4 }
            };

            MyList<Customer> customers = new MyList<Customer>(_customers);

            foreach (var customer in customers)
            {
                System.Console.WriteLine(customer);
            }
        }
    }
}
