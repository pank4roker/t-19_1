using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Task1
    interface IMeth
    {
        void Method();
    }
    //Task 2
    interface IPi
    {
        double Pi();
    }
    interface INumber
    {
        int Number();
    }
    interface ISq
    {
        double Sq();
    }
    interface IRoot
    {
        double Root();
    }
    //Task 3
    interface IInterface1
    {
        void Method1();
    }
    interface IInterface2 : IInterface1
    {
        void Method2();
    }
    interface IInterface3 : IInterface2
    {
        void Method3();
    }
    //Task4
    interface ITalk
    {
        void Talkloud();
        void Talkok();
    }
    interface IThink
    {
        void Think();
    }
    //task 5
    interface ISwitchable
    {
        void On();
        void Off();
    }
}
