using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_table_of_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any No.");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine("multiplication of no. is " + (num * i));
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            Console.ReadLine();
        }

        enum MyEnum
        {
            
         
        }
    }
}
