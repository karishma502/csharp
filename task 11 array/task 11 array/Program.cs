using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11_array
{
     class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter Numbers:");

            for (int i = 0; i < 10; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
            }
            Array.Sort(arr);
       
            Print3largest(arr);
            Console.Read();
        }

        static void Print3largest(int[] arr)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            foreach (int item in arr)
            {
                if (item > first)
                {
                    third = second;
                    second = first;
                    first = item;
                }
                else if (item > second)
                {
                    third = second;
                    second = item;
                }
                else if (item > first)
                {
                    third = item;
                }

            }
            Console.WriteLine("Third Highest Number is: " + third);
            Console.Read();
        }
    }
}
