namespace CSharpTutorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arr1 = new int[3] {1, 2, 3};
            foreach(var num in arr1)
            {
                Console.WriteLine(num);
            }

            var arr2 = new bool[3];
            arr2[0] = true;
            foreach(var num in arr2)
            {
                Console.WriteLine(num);
            }

        }
    }
}
