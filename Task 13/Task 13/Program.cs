using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        //private static int salary;
        //private static int age;
        //private static string name;
        //private static int id;

        static void Main(string[] args)
        {

            ///propertis created
            ///

            //Employee e = new Employee();

            //e.id = 45;
            //Console.WriteLine(e.id);


            //e.name = "sakshi";
            //Console.WriteLine(e.name);

            //e.age = 22;
            //Console.WriteLine(e.age);


            //e.PhoneNum = 123456789;
            //Console.WriteLine(e.PhoneNum);

            //e.Department = "computer";
            //Console.WriteLine(e.Department);

            //e.salary = 45000;
            //Console.WriteLine(e.salary);


            //Console.Read();

            //FiveEmpDetail();

            ITEmployee t = new ITEmployee();

            t.skillsemp();
            t.CalculateBonus();
        }

       
      



        /// <summary>
        /// five emp details
        /// </summary>

        //private static void FiveEmpDetail()
        //{
        //    List<Employee> emp = new List<Employee>();
        //    emp.Add(new Employee { id = 101, name = "sumit", age = 23, salary = 4000 });
        //    emp.Add(new Employee { id = 102, name = "kiran", age = 24, salary = 6000 });
        //    emp.Add(new Employee { id = 103, name = "suman", age = 25, salary = 7000 });
        //    emp.Add(new Employee { id = 104, name = "raman", age = 26, salary = 9000 });
        //    emp.Add(new Employee { id = 105, name = "samir", age = 26, salary = 9000 });
        //
        //
        //    foreach (var Employee in emp)
        //    {
        //        Console.WriteLine("id: {0}, name:{1}, age: {2}, salary: {3}", Employee.id, Employee.name, Employee.age, Employee.salary);
        //    }
        //    Console.ReadLine();
        //
        //
        //}
    }
}
