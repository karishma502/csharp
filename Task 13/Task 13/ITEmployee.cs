using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
   sealed class ITEmployee:Employee
    {

        ///can inherti further this class
        ///

        public void CalculateBonus()
        {
            Console.WriteLine("Total bonus of the year of each emp is ....50000");
            Console.ReadLine();
        }
        
    }
}
