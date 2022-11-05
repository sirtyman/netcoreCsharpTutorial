using System;


namespace IEnumerableExample
{
    public class Customer
    {
        public string? Name { get; set; }
        public long Mobile { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"{Name} {Mobile} {Amount}";
        }
    }
}