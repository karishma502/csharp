using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    public class Newclass
    {
        // Method for Fibonacci series
        public void Fibonacci_Rec(int length)
        {
            Fibonacci_Rec_1(0, 1, 1, length);
        }

        private void Fibonacci_Rec_1(int a, int b, int counter, int length)
        {
            if (counter <= length)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_1(b, a + b, counter + 1, length);
            }
        }


  

        public int Get_Nth_Fibonacci_Rec(int n)
        {

            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return Get_Nth_Fibonacci_Rec(n - 1) + Get_Nth_Fibonacci_Rec(n - 2);
            }
        }
    }
}
