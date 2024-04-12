using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class People : ITalk, IThink
    {
        public void Talkloud()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }
        public void Think()
        {
            Console.WriteLine("Думает - A С# больше всего");
        }
        public void Talkok()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}
