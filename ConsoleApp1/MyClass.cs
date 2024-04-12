using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass : IPi, INumber, ISq, IRoot
    {
        public int X { get; set; }
        public MyClass() { }
        public MyClass(int x)
        {
            X = x;
        }
        public int Number()
        {
            return X;
        }

        public double Pi()
        {
            return Math.PI;
        }

        public double Root()
        {
           return Math.Pow(X,2);
        }

        public double Sq()
        {
           return Math.Sqrt(X);
        }
        public void Info()
        {
            Console.WriteLine($"{Number()}\n{Pi()}\n{Root()}\n{Sq()}");
        }
    }
}
