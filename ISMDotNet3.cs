using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static double[] InputArray()
        {
            int count;
            double x;
            Console.Write("Input Count: = ");
            count = int.Parse(Console.ReadLine());
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                bool flag;
                do
                {
                    Console.Write($"a[{i}] = ");
                    flag = double.TryParse(Console.ReadLine(), out x);
                    if (flag == true)
                    {
                        arr[i] = x;
                    }
                    else
                    {
                        Console.WriteLine("Eror!");
                    }
                } while (flag == false);
            }
            return arr;

        }
        public static int SumOfNegative(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    sum = sum + arr[i];
            }
            return (int)sum;
        }
        public static double MaxElement(double[] arr)
        {
            double max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }
        public static int IndexOfMax(double[] arr)
        {
            double max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            int indexMax = Array.IndexOf(arr, max);
            return indexMax;
        }
        public static double MaxModElement(double[] arr)
        {
            double maxmod = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > maxmod)
                {
                    maxmod = Math.Abs(arr[i]);
                }

            }
            return maxmod;
        }
        public static int SumIndexOfPozitiveEl(double[] arr)
        {
            int sumindexofpozitiveEl = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sumindexofpozitiveEl += i;
                }

            }
            return sumindexofpozitiveEl;
        }
        public static int Numberofwhole(double[] arr)
        {
            int numberofwhole = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - Math.Truncate(arr[i]) == 0)
                {
                    numberofwhole++;
                }
            }
            return numberofwhole;
        }
        public static double[] SortArray(double[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }
        public static void PrintSortArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {arr[i]}");
            }
        }
        public static int GetpozitiveNumber(double[] arr)
        {
            int cout = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    cout++;
            }
            return cout;
        }
        public static double[] GetPozitiveElements(double[] arr)
        {
            double[] positivearray = new double[GetpozitiveNumber(arr)];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positivearray[j] = arr[i];
                    j++;
                }
            }
            return positivearray;
        }
        public static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {arr[i]}");
            }
        }
        static void Main(string[] args)
        {
            double[] arr = InputArray();
            int sum = SumOfNegative(arr);
            double max = MaxElement(arr);
            int indexMax = IndexOfMax(arr);
            double maxmod = MaxModElement(arr);
            int sumindexofpozitiveEl = SumIndexOfPozitiveEl(arr);
            int numberofwhole = Numberofwhole(arr);
            Console.WriteLine($"Sum of negative elements = {sum}");
            Console.WriteLine($"Maximum element = {max}");
            Console.WriteLine($"Maximum element number = {indexMax}");
            Console.WriteLine($"Maximum element modulo = {maxmod}");
            Console.WriteLine($"Sum of indices of positive elements = {sumindexofpozitiveEl}");
            Console.WriteLine($"Number of integers = {numberofwhole}");
            arr = SortArray(arr);
            Console.WriteLine("Sorted array");
            PrintSortArray(arr);
            arr = GetPozitiveElements(arr);
            Console.WriteLine("Array of positive numbers");
            PrintArray(arr);


        }
    }
}
