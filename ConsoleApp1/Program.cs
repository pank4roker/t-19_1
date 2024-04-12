using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("      Task1");
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            IMeth meth = derivedClass;
            meth.Method();
            //Task 2
            Console.WriteLine("      Task2");
            MyClass myClass = new MyClass(3);
            myClass.Info();
            //Task 3
            Console.WriteLine("      Task3");
            Task3 task3 = new Task3();
            task3.Method1();
            task3.Method2();
            task3.Method3();
            //Task4
            Console.WriteLine("      Task4");
            People people = new People();
            people.Talkloud();
            people.Think();
            people.Talkok();
            //Task5
            Console.WriteLine("      Task5");
            List<ISwitchable> switchables = new List<ISwitchable>();
            TVSet tVSet = new TVSet();
            PersonalComputer personalComputer = new PersonalComputer();
            switchables.Add(tVSet);
            switchables.Add(personalComputer);
            foreach (var elem in switchables)
            {
                
                if(elem is TVSet)
                {
                    Console.WriteLine("Televisor");
                    elem.On();
                    elem.Off();
                }
                else
                {
                    Console.WriteLine("PC");
                    elem.On();
                    elem.Off();
                }
                
            }
            //Task 6
            Console.ReadKey();
        }
    }
}
