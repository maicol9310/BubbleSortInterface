using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Utilities
{
    public class PrintArrayAndCountSwap
    {
        //Method that prints and replaces the values ​​of the array
        public void printArrayNumAndString(string[] arr)
        {
            ConvertIntToChar ConvertNum = new ConvertIntToChar();
            //Array size
            int n = arr.Length;

            //Traverse the size of the array
            for (int i = 0; i < n; ++i)
            {
                int multiplosDe10 = Convert.ToInt32(arr[i]);

                if (multiplosDe10 % 10 == 0)
                {
                    Console.Write(ConvertNum.NumeroALetras(multiplosDe10) + " ");
                }
                else
                {
                    //switch case - for replacing integers to string
                    switch (multiplosDe10)
                    {
                        case 0:
                            Console.Write("Zero" + " ");
                            break;
                        case 1:
                            Console.Write("ONE" + " ");
                            break;
                        case 2:
                            Console.Write("two" + " ");
                            break;
                        case 3:
                            Console.Write("TREE" + " ");
                            break;
                        case 4:
                            Console.Write("four" + " ");
                            break;
                        case 5:
                            Console.Write("FIVE" + " ");
                            break;
                        case 6:
                            Console.Write("six" + " ");
                            break;
                        case 7:
                            Console.Write("SEVEN" + " ");
                            break;
                        case 8:
                            Console.Write("eight" + " ");
                            break;
                        case 9:
                            Console.Write("NINE" + " ");
                            break;
                        default:
                            Console.Write(arr[i] + " ");
                            break;
                    }
                }
            }
            Console.WriteLine();
        }

        //Method count swap
        public string countSwap(int[] numbersS)
        {
            //Array size
            int n = numbersS.Length;

            //Num Swap
            int swap = 0;

            //sort algorithm count swap
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbersS[j] > numbersS[j + 1])
                    {
                        int temp = numbersS[j];
                        numbersS[j] = numbersS[j + 1];
                        numbersS[j + 1] = temp;
                        swap++;
                    }
                }
            }

            //Convert int to string
            string totalSwap = Convert.ToString(swap);

            return totalSwap;
        }

        static void Main(string[] args)
        {
        }
    }
}
