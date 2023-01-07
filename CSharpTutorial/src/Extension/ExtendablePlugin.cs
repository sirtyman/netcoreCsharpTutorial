using System;
using Extension;


namespace Extension.Plugins
{
    internal static class NumbersContainerPlugins
    {
        public static void SelectNumToPrint(this NumbersContainer nc, Func<int, bool> lambdaDel)
        {
            foreach (int n in nc.Numbers)
            {
                if (lambdaDel(n))
                {
                    System.Console.WriteLine(n);
                }
            }
            System.Console.WriteLine("\n");
        }

        public static void SelectNumToPrintByCustomSelDel(this NumbersContainer nc, CustomNumbersSelector selector)
        {
            foreach (int n in nc.Numbers)
            {
                if (selector(n))
                {
                    System.Console.WriteLine(n);
                }
            }
            System.Console.WriteLine("\n");
        }
    }
}