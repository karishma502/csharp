using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Sumit");
            arr.Add(19);
            arr.Add(true);

            //var stringg = arr[0];
            //Console.WriteLine(stringg);

            //var intt = arr[1];
            //Console.WriteLine(intt);


            //var booleann = arr[2];
            //Console.WriteLine(booleann);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

           

           
            Console.ReadLine();
        }
    }
}
