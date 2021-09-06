using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    class samplee
    {
        public static void IFutureMethod()
        {
            Console.WriteLine("IFutureMethod method");
        }
        public void ZensarMethod(string v)
        {
            first();
            Console.WriteLine("ZensarMethod method");
        }

        public void first()
        {

        }

        public void ZensarMethod(int i)
        {
            Console.WriteLine(i);
            ZensarMethod();
        }

        private void ZensarMethod()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            samplee obj = new samplee();
            obj.first();
            obj.ZensarMethod("Akkki");
            Console.Read();
        }
    }
}
