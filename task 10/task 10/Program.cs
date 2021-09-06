using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] StuID = new int[10];
            string[] FullName = new string[100];
            string[] CourseName = new string[100];
            string[] PhoneNum = new string[10];
            int vall = 0;
            Console.WriteLine("Enter how many entries you want to enter:");
            vall = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < vall; i++)
            {
                Console.WriteLine("Enter StudentID:");
                int ID = Convert.ToInt32(Console.ReadLine());
                StuID[i] = ID;
                Console.WriteLine("Enter FullName:");
                string FN = Console.ReadLine();
                FullName[i] = FN;
                Console.WriteLine("Enter CourseName:");
                string CN = Console.ReadLine();
                CourseName[i] = CN;
                Console.WriteLine("Enter PhoneNo:");
                string PN = Console.ReadLine();
                PhoneNum[i] = PN;
            }

            Console.WriteLine("Students data entered by user are...");

            for (int i = 0; i < vall; i++)
            {
                Console.WriteLine("ID: {0}", StuID[i]);
                Console.WriteLine("FullName: {0}", FullName[i]);
                Console.WriteLine("CourseName: {0}", CourseName[i]);
                Console.WriteLine("PhoneNo: {0}", PhoneNum[i]);

            }

            Console.Read();
        }
    }
}
