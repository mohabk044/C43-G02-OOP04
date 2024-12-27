using OOP_4.Built_In_Interfaces;
using OOP_4.Inteface_Example_03;
using OOP_4.Interface_Example_01;
using OOP_4.Interface_Example_02;
using OOP_4.Operators_Overloading;

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

            #region Video 6
            string[] Names01 = ["Amr", "Mona"];
            string[] Names02 = ["Ahmed", "Yassmin"];
            Console.WriteLine($"NAmes01.GetHashCode() : {Names01.GetHashCode()}");
            Console.WriteLine($"NAmes02.GetHashCode() : {Names02.GetHashCode()}");
            Names02 = (String[])Names01.Clone();
            Console.WriteLine("After Deep Copy*");
            Console.WriteLine($"NAmes01.GetHashCode() : {Names01.GetHashCode()}");
            Console.WriteLine($"NAmes02.GetHashCode() : {Names02.GetHashCode()}");
            #endregion

            #region Video 7
            Employee employee01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 8_000, Department = new Department() { Code = 1001, Title = "Sales" } };
            Employee employee02 = new Employee() { Id = 20, Name = "Omnia", Salary = 4_000, Department = new Department() { Code = 2002, Title = "HR" } };
            Console.WriteLine($"employee01.GetHashCode()==> {employee01.GetHashCode()}");
            Console.WriteLine($"employee02.GetHashCode()==> {employee02.GetHashCode()}");
            employee02 = (Employee)employee01.Clone();
            employee02 = new Employee(employee01);
            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"employee01.GetHashCode()==> {employee01.GetHashCode()}");
            Console.WriteLine($"employee02.GetHashCode()==> {employee02.GetHashCode()}");
            Console.WriteLine("*");
            Console.WriteLine($"Employee01==> {employee01}");
            Console.WriteLine($"Employee02==> {employee01}");
            #endregion

            #region Video 8
            Employee[] employees =
            {
                new Employee(){Id = 10, Name = "Ahmed" , Salary = 8_000},
                new Employee(){Id = 20, Name = "Omnia" , Salary = 2_000},
                new Employee(){Id = 30, Name = "Esraa" , Salary = 10_000},
                new Employee(){Id = 40, Name = "Omar" , Salary = 9_000},
            };

            Array.Sort(employees);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion

            #region Video 9
            Employee[] employees =
            {
                                new Employee(){Id = 40, Name = "Ahmed" , Salary = 8_000},
                new Employee(){Id = 10, Name = "Omnia" , Salary = 2_000},
                new Employee(){Id = 20, Name = "Mostafa" , Salary = 10_000},
                new Employee(){Id = 30, Name = "Omar" , Salary = 9_000},

            };


            Array.Sort(employees, new EmployeeComparer());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            int[] Numebrs = [9, 2, 5, 6, 7, 1, 3, 8];
            Array.Sort(Numebrs, new intComparer());
            foreach (int number in Numebrs)
                Console.WriteLine(number);
            #endregion

            #region Video 10
            Complex C1 = new Complex() { Real = 2, Imag = 4 };
            Complex C2 = new Complex() { Real = 3, Imag = 5 };
            Complex C3 = default;

            C3 = C1 + C2;

            Console.WriteLine($"C1: {C1}");
            Console.WriteLine($"C2: {C2}");
            Console.WriteLine($"C3: {C3}");
            #endregion

            #region Video 11
            Complex C11 = new Complex() { Real = 2, Imag = 4 };
            Complex C12 = new Complex() { Real = 3, Imag = 5 };
            Complex C13 = ++C11;
            Console.WriteLine(C13);
            #endregion
        }
    }
}
