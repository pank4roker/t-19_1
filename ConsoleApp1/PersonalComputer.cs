using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PersonalComputer : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Включение");
        }

        public void On()
        {
            Console.WriteLine("Выключение");
        }
    }
}
