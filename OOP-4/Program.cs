using OOP_4.Interface_Example_01;

namespace Demo
{
    internal class Program
    {
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


        }
    }
}
