using System;
using Extension.Plugins;


namespace Extension
{
    delegate bool CustomNumbersSelector(int n);

    public class MainProgram
    {
        private static void Main(string[] args)
        {
            NumbersContainer nc = new(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            nc.PrintNumbers();

            // By passing lambda
            nc.SelectNumToPrint(x => x % 2 == 0);
            nc.SelectNumToPrint(x => x % 3 == 0);

            // By passing delegate
            CustomNumbersSelector SelectOdd = delegate(int n)
            {
                return n % 2 != 0;
            };
            nc.SelectNumToPrintByCustomSelDel(SelectOdd);
        }
    }
}