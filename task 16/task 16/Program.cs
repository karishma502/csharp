using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HP\source\repos\FileOperation\Text.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File has been Deleted");
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("New File Recreated");
                sw.WriteLine("Welcome to Zensar");
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("Accessing existing file");
                sw.WriteLine("Appending New file");
            }


            using (StreamReader rdr = File.OpenText(path))
            {
                Console.WriteLine("reading from file");
                Console.WriteLine(rdr.ReadToEnd());
            }
            Console.ReadLine();

        }
    }
    
}
