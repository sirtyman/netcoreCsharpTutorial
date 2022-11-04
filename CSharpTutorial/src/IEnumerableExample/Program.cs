using System;
using System.Collections;


namespace IEnumerableExample
{
    public class Customer
    {
        public string Name { get; set; }
        public long Mobile { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"{Name} {Mobile} {Amount}";
        }

    }

    public class Customers : IEnumerable
    {
        private Customer[] _customers;

        public Customers(Customer[] customers)
        {
            _customers = new Customer[customers.Length];
            for (int i = 0; i < customers.Length; i++ )
            {
                _customers[i] = customers[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) (new CustomerIter(_customers));
        }
    }


    public class CustomerIter : IEnumerator
    {
        private int _currentIndex = -1;
        private Customer[] _customers;

        public CustomerIter(Customer[] customers)
        {
            _customers = customers;
        }

        object IEnumerator.Current
        {
            get 
            {
                return _customers[_currentIndex];
            }
        }

        bool IEnumerator.MoveNext()
        {
            bool? result = null;
            if (_currentIndex < _customers.Length - 1)
            {
                _currentIndex++;
                result = true;
            }
            else
                result = false;
            return (bool) result;
        }

        void IEnumerator.Reset()
        {
            _currentIndex = -1;
        }
    }


    public class Program
    {
        private static Customer[] _customers = new Customer[]
        {
            new Customer { Name="Basia", Mobile=333333333, Amount=300.4 },
            new Customer { Name="Kasi", Mobile=333333331, Amount=302.4 },
            new Customer { Name="Ola", Mobile=333333332, Amount=303.4 }
        };

        public static void Main(string[] args)
        {
            Customers customers = new Customers(_customers);

            foreach (var customer in customers)
            {
                System.Console.WriteLine(customer);
            }
        }
    }

}
