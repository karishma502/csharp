using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];
            string name;
            try
            {
                Console.WriteLine("Enter Student Names:");

                for (int i = 0; i <= 4; i++)
                {
                    name = Console.ReadLine();
                    student[i] = name;
                }

                Console.WriteLine("Array of students entered by user..... ");

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(student[i]);

                }

           

                name = Console.ReadLine();
                student[6] = name;


            }

            catch (IndexOutOfRangeException err)
            {

                Console.WriteLine(err.Message);

            }

            catch (Exception)
            {

                Console.WriteLine("error - array size is full, exception is handled");


            }

            Console.ReadLine();
        }
    }
}
