using System;
using Utilities;

namespace Bubble
{

    class Program
    {
        static void Main(string[] args)
        {
            //Main array
            int[] arrayNum = { 2, 8, 6, 40, 555, 65, 155, 7, 3, 2, 2, 1, 4, 5, 1, 1, 5, 4, 100, 200 };

            BubbleSortCollectionSorter BubbleSorter = new BubbleSortCollectionSorter();
            PrintArrayAndCountSwap OrderAndCount = new PrintArrayAndCountSwap();

            //Interface method call ascending sort
            Console.WriteLine("Amount of Swap: " + OrderAndCount.countSwap(arrayNum));
            Console.WriteLine("");

            Console.WriteLine("Ascending sort:");

            //call the method that prints and replaces the values ​​of the array
            //Interface method call ascending sort
            OrderAndCount.printArrayNumAndString(BubbleSorter.SortAscending(arrayNum));

            Console.WriteLine("");

            Console.WriteLine("Descending sort:");
            //Interface method call ascending sort
            OrderAndCount.printArrayNumAndString(BubbleSorter.SortDescending(arrayNum));
        }
    }
}
