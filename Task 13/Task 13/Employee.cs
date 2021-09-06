using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Employee
    {
        public int id { get; set; }
        public string name {get; set; }
            
        public int PhoneNum { get; set; }
        public string Department { get; set; }

        public int salary { get; set; }
        public int age { get; set; }



        public void skillsemp()
        {
            {
                List<string> skills = new List<string>();
                ITEmployee e = new ITEmployee();

                skills.Add("SQL");
                skills.Add("python");
                skills.Add("Azure");
                skills.Add("SQL");
                skills.Add("CSharp ");
                skills.Add(" Angular ");




                foreach (var item in skills)
                {
                    Console.WriteLine("Details are {0}", item);
                }
            }


            Console.ReadLine();

        }








    }
}
