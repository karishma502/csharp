using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        enum week
        {
           
            monday=1,
            tuesday,
            wednesday,
            friday,
            saturday,
            sunday  

        }



        static void Main(string[] args)
        {
          
            //Console.WriteLine((int)week.friday);
            //Console.Read();


            Console.WriteLine("enter value");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;

                case 2:
                    Console.WriteLine("tuesday");
                    break;

                case 3:
                    Console.WriteLine("wednesday");
                    break;

                case 4:
                    Console.WriteLine("thursday");
                    break;

                case 5:
                    Console.WriteLine("friday");
                    break;

                case 6:
                    Console.WriteLine("saturday");
                    break;

                case 7:
                    Console.WriteLine("sunday");
                    break;

               
                default:
                    Console.WriteLine("wrong input");
                    break;
            }

            Console.ReadLine();

        }
    }
}
