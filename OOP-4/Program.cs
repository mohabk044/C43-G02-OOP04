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

            #region InterfaceEx02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintTenNumbersFromSeries(seriesByTwo);
            //SeriesByThree seriesByThree = new SeriesByThree();
            //PrintTenNumbersFromSeries(seriesByThree);
            //SeriesByFour seriesByFour = new SeriesByFour();
            //PrintTenNumbersFromSeries(seriesByFour);
            #endregion

            #region InterfaceEx03
            IMovable movable = new Airplane();
            movable.Forward();
            IFlyable flyable = new Airplane();
            flyable.Forward();
            #endregion

            #region Video 5

            int[] Arr01 = [1, 2, 3];
            int[] Arr02 = [4, 5, 6];
            Console.WriteLine($"Arr01.GetHashCode() : {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02.GetHashCode() : {Arr02.GetHashCode()}");
            Arr02 = Arr01; // this object [1,2,3] has 2 references [Arr01,Arr02] , [4,5,6] became unreachable object.
            //Console.WriteLine("After Shallow Copy");
            Console.WriteLine("After Deep Copy");
            Arr02 = (int[])Arr01.Clone();
            Console.WriteLine($"Arr01.GetHashCode() : {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02.GetHashCode() : {Arr02.GetHashCode()}");
            Arr02[0] = 100;
            foreach (int number in Arr01)
                Console.WriteLine(number);
            Console.WriteLine("");
            #endregion

        }
    }
}
