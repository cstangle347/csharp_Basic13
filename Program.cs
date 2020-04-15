using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            object[] array = new object[] { 1, -2, -3, 4 };
            NumToString(array);
            PrintNumbers();
            PrintNumbersOdd();
            PrintSum();
        }
        public static void PrintNumbers()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintNumbersOdd()
        {
            for (int k = 0; k <= 255; k++)
            {
                if (k % 2 == 1)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int q = 0; q <= 255; q++)
            {
                sum += q;
                Console.WriteLine("New number" + q + "Sum" + sum);
            }
        }
        public static void IteratingThroughArray(int[] numbers)
        {
            Console.WriteLine(String.Join("\n", numbers));
        }
        public static void FindMax(int[] numbers)
        {
            int max = -99;
            for (int u = 0; u < numbers.Length; u++)
            {
                if (numbers[u] >= max)
                {
                    max = numbers[u];
                };
            }
            Console.WriteLine(max);
        }
        public static void Average(int[] numbers)
        {
            float sum1 = 0;
            for (int p = 0; p < numbers.Length; p++)
            {
                sum1 += numbers[p];
            }
            Console.WriteLine(sum1 / numbers.Length);
        }
        public static void OddArray()
        {
            List<int> numbers = new List<int>();
            for (int l = 1; l <= 255; l += 2)
            {
                numbers.Add(l);
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
        public static void GreaterThanY(int[] numbers, int y)
        {
            int counter = 0;
            for (int m = 0; m < numbers.Length; m++)
            {
                if (numbers[m] > y)
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
        }
        public static void SquareValues(int[] numbers)
        {
            for (int n = 0; n < numbers.Length; n++)
            {
                numbers[n] = numbers[n] * numbers[n];
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
        
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        public static void ShiftValues(int[] numbers)
        {
            int temp = 0;
            int temp2 = 0;
            for (int x = numbers.Length - 1; x >= 0; x--)
            {
                temp2 = numbers[x];
                numbers[x] = temp;
                temp = temp2;
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(String.Join(", ", numbers));
        }
        public static void NumToString(object[] numbers)
        {
            for (int w = 0; w < numbers.Length; w++)
            {
                if ((int)numbers[w] < 0)
                {
                    numbers[w] = "dojo";
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
