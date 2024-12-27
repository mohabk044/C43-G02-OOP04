using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Inteface_Example_03
{
    internal class Airplane : Vehicle, IMovable, IFlyable
    {
        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }
        void IMovable.Backward()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Forward()
        {
            Console.WriteLine("Fly forward on airrrrrrrrrr");
        }
        void IMovable.Forward()
        {
            Console.WriteLine("Move Forward on Ground");
        }
        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }
        void IMovable.Left()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

    }
}
