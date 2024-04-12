using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task3 : IInterface3
    {
        public void Method1()
        {
            Console.WriteLine("Method1()");
        }

        public void Method2()
        {
            Console.WriteLine("Method2()");
        }

        public void Method3()
        {
            Console.WriteLine("Method3()");
        }
    }
}
