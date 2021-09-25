using System;

namespace Bubble
{
    interface ICollectionSorter
    {
        string[] SortAscending(int[] numbers);
        string[] SortDescending(int[] numbers);
    }
    class BubbleSortCollectionSorter : ICollectionSorter
    {
        static void printArrayNumAndString(string[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
            {
                switch (arr[i])
                {
                    case "0":
                        Console.Write("Zero" + " ");
                        break;
                    case "1":
                        Console.Write("ONE" + " ");
                        break;
                    case "2":
                        Console.Write("two" + " ");
                        break;
                    case "3":
                        Console.Write("TREE" + " ");
                        break;
                    case "4":
                        Console.Write("four" + " ");
                        break;
                    case "5":
                        Console.Write("FIVE" + " ");
                        break;
                    case "6":
                        Console.Write("six" + " ");
                        break;
                    case "7":
                        Console.Write("SEVEN" + " ");
                        break;
                    case "8":
                        Console.Write("eight" + " ");
                        break;
                    case "9":
                        Console.Write("NINE" + " ");
                        break;
                    default:
                        Console.Write(arr[i] + " ");
                        break;
                }
            }
            Console.WriteLine();
        }

        public string[] SortAscending(int[] numbers)
        {
            string[] result = { };
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            result = Array.ConvertAll(numbers, element => element.ToString());
            printArrayNumAndString(result);
            return result;
        }

        public string[] SortDescending(int[] numbers)
        {
            string[] result = { };
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            result = Array.ConvertAll(numbers, element => element.ToString());
            printArrayNumAndString(result);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = { 1, 5, 6, 23, 86, 5, 55, 8, 4, 1, 2, 3, 5 };
            BubbleSortCollectionSorter BubbleSorter = new BubbleSortCollectionSorter();
           
            Console.WriteLine("Ascending sort:");
            BubbleSorter.SortAscending(arrayNum);


            Console.WriteLine("Descending sort:");
            BubbleSorter.SortDescending(arrayNum);

        }
    }
}
