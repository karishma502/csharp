using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            NamesDisplay("karishma", "miraj");
            NamesDisplay("sayli", "janhvi", "sangli", "kokan", "01");

            Console.Read();

        }

        private static void NamesDisplay(params string[] parameters)
        {
            Console.WriteLine("Employee Details are as follows.....");

            foreach (var item in parameters)
            {
                Console.WriteLine(item);
            }

        }
    }
    
}
