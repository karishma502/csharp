using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1400, "python");
            dic.Add(456, "java");
            dic.Add(1900, "javascript");
            dic.Add(1500, "sql");
            dic.Add(1200, "csharp");



            for (int i = 0; i < dic.count; i++)
            {
            //    console.writeline("{0} and {1}", dic.keys.elementat(i),
                                 // dic[dic.keys.elementat(i)]);
             Console.WriteLine("Rank: {0} - {1} ", i + 1, dic.Values[i]);
            }

            //Boolean highestrank = false;

            //for (int i = 0; i < dic.Count; i++)
            //{
            //    Console.WriteLine(" Enter rank ");
            //    Console.ReadLine();
            //    if (dic.ContainsKey(1900)==true)
            //    {
            //        Console.WriteLine("Rank 1- javascript");
            //    }
            //    else if (dic.ContainsKey(1500) == true)
            //    {
            //        Console.WriteLine("Rank 2 - SQL");
            //    }
            //    else if (dic.ContainsKey(1400) == true)
            //    {
            //        Console.WriteLine("rank 3 - python");
            //    }
            //    else if (dic.ContainsKey(1200) == true)
            //    {
            //        Console.WriteLine("rank 4 -csharp");
            //    }
            //    else
            //    {
            //        Console.WriteLine("rank 5 - java");
            //    }

            //}


            //Console.ReadLine();


            //SortedList of int keys, string values

            //var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
            //
            //SortedList<int, string> descSortedList = new SortedList<int, string>(descendingComparer);
            //descSortedList.Add(1200, "CSharp");
            //descSortedList.Add(1400, "Python");
            //descSortedList.Add(456, "Java");
            //descSortedList.Add(1900, "JavaScript");
            //descSortedList.Add(1500, "SQL");

            //for (int i = 0; i < descSortedList.Count; i++)
            //{
            //    Console.WriteLine("Rank: {0} - {1} ", i + 1, descSortedList.Values[i]);
          //  }

          //  Console.Read();
        }
    }
}
