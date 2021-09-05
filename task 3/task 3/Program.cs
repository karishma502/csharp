using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        private static string id;
        private static string name;

        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(0,"1");
            d.Add(1, "karishma");
            d.Add(2, "21");

            foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine("key {0} and value {1} ", item.Key, item.Value);
            }
            

            Console.WriteLine("Enter key to delete");
            int k = Convert.ToInt32(Console.ReadLine());
            if (!d.ContainsKey(k))
            {
                Console.WriteLine("key does not exist");
            }
            else
            {
                d.Remove(k);
                Console.WriteLine("key removed...");
            }

            foreach (KeyValuePair<int, string> D in d)
            {
                Console.WriteLine("Key: {0}, Value: {1}", D.Key, D.Value);
            }


            Console.Read();



        }
    }
}
