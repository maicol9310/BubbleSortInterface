using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class BubbleSortCollectionSorter : ICollectionSorter
    {

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

            return result;
        }

        //Method ascending sort
        public string[] SortDescending(int[] numbers)
        {
            //Array where the final ordered array is stored
            string[] result = SortAscending(numbers);

            ////Array revez
            Array.Reverse(result);        

            return result;
        }
    }
}
