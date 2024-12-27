using OOP_4.Inteface_Example_03;
using OOP_4.Interface_Example_01;
using OOP_4.Interface_Example_02;

namespace Demo
{
    internal class Program
    {


        #region InterfaceEx02
        static void PrintTenNumbersFromSeries(ISeries series)
        {
            if (series is null)
                return;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{series.current} \t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }

        #endregion


        static void Main()
        {
            #region InterfaceEx01
            //IMyType MyType;
            MyType myType = new MyType();
            myType.MyFuntion();
            myType.MyProperty = 10;
            //myType.Print(); //Error
            IMyType referenceFromInterface = new MyType();
            referenceFromInterface.MyFuntion();
            referenceFromInterface.MyProperty = 20;
            referenceFromInterface.Print();
            #endregion

            #region InterfaceEx03
            IMovable movable = new Airplane();
            movable.Forward();
            IFlyable flyable = new Airplane();
            flyable.Forward();
            #endregion
        }
    }
}
