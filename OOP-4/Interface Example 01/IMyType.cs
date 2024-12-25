using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface_Example_01
{
    internal interface IMyType
    {
        public int MyProperty { get; set; }

        public void MyFuntion();

        public void Print()
        {
            Console.WriteLine("Hello From Default Implmented Method");
        }
    }
}
