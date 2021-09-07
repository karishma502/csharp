using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo u = new UserInfo("karishma.com","Admin",123);
             Login();


            void Login()
            {
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Username");
                string username = Console.ReadLine();

                Console.WriteLine("Enter Password");
                int pass = Convert.ToInt32(Console.ReadLine());


                if (u.UserName == username ||u.Password == pass ||  u.Email== email)
                {
                    Console.WriteLine("Welcome to portal...! have a nice day");
                }
                else
                {
                    Console.WriteLine("Invalid login name or password. Please provide correct credentials");
                }
                Console.Read();
            }
           
        }
       
    }
}
