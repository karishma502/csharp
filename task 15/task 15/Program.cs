using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    public class Operation
    {

        // Palindrome String Program
        private static bool IsPalRecursion(String str, int s, int l)
        {
            if (s == l)
            {
                return true;
            }
            if ((str[s] != str[l]))
            {
                return false;
            }
            if (s < l + 1)

                return IsPalRecursion(str, s + 1, l - 1);
            return true;
        }

        private static bool IsPalindrome(String str)
        {
            int n = str.Length;
            if (n == 0)

                return true;
            return IsPalRecursion(str, 0, n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            if (IsPalindrome(str))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
            Console.Read();



            //call for fibonacci

            Newclass c = new Newclass();
            c.Fibonacci_Rec(11);
            Console.ReadLine();
            int val = 7;
            int result = c.Get_Nth_Fibonacci_Rec(val);
            Console.WriteLine("{0} th number in Fibonacci Series is = {1}", val, result);
            Console.ReadLine();

            // call for leap year using try catch
            try
            {
                Console.WriteLine("Enter year:");
                int a = Convert.ToInt32(Console.ReadLine());
                //int b = Convert.ToInt32(a);
                CheckLeapYear(a);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }


        private static void CheckLeapYear(int a)
        {


            if ((a % 4) == 0)
            {
                //return false;
                Console.WriteLine("{0} is a Leap Year", a);
            }

            else

                Console.WriteLine("Not a leap year");

        }

    }
}
