using System;

namespace Bubble
{
    //Interface BubbleSort
    interface ICollectionSorter
    {
        string[] SortAscending(int[] numbers);
        string[] SortDescending(int[] numbers);
    }
    class BubbleSortCollectionSorter : ICollectionSorter
    {
        //Method that prints and replaces the values ​​of the array
        static void printArrayNumAndString(string[] arr)
        {
            //Array size
            int n = arr.Length;

            //Traverse the size of the array
            for (int i = 0; i < n; ++i)
            {
                //switch case - for replacing integers to string
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

        //Method count swap
        public string countSwap(int[] numbers) 
        {
            //Array size
            int n = numbers.Length;

            //Num Swap
            int swap = 0;

            //sort algorithm count swap
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swap++;
                    }
                }
            }

            //Convert int to string
            string totalSwap = Convert.ToString(swap);

            return totalSwap;
        }

        //Method ascending sort
        public string[] SortAscending(int[] numbers)
        {
            //Array where the final ordered array is stored
            string[] result = { };

            //Array size
            int n = numbers.Length;

            //Ascending sort algorithm
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

            //Convert int array into string array and store in variable "result" type array string
            result = Array.ConvertAll(numbers, element => element.ToString());

            //call the method that prints and replaces the values ​​of the array
            printArrayNumAndString(result);
            return result;
        }

        //Method ascending sort
        public string[] SortDescending(int[] numbers)
        {
            //Array where the final ordered array is stored
            string[] result = { };

            //Array size
            int n = numbers.Length;

            //Descending sort algorithm
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

            //Convert int array into string array and store in variable "result" type array string 
            result = Array.ConvertAll(numbers, element => element.ToString());

            //call the method that prints and replaces the values ​​of the array
            printArrayNumAndString(result);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Main array
            int[] arrayNum = { 2, 8, 6, 40, 555, 65, 155, 7, 3, 2, 2, 1, 4, 5, 1, 1, 5, 4, 100, 200 };
            BubbleSortCollectionSorter BubbleSorter = new BubbleSortCollectionSorter();

            Console.WriteLine("Ascending sort:");
            //Interface method call ascending sort
            BubbleSorter.SortAscending(arrayNum);

            Console.WriteLine("");

            Console.WriteLine("Descending sort:");
            //Interface method call ascending sort
            BubbleSorter.SortDescending(arrayNum);

            Console.WriteLine("");

            //Interface method call ascending sort
            Console.WriteLine("Amount of Swap: " + BubbleSorter.countSwap(arrayNum));
        }
    }
}
